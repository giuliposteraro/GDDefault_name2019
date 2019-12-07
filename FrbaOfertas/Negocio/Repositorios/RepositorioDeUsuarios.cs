using Negocio.Base;
using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Repositorios
{
    public class RepositorioDeUsuarios : IPersistencia<Usuario>
    {
        public RepositorioDeUsuarios(MaperDeUsuarios maper)
        {
            this.maper = maper;
        }

        public Usuario ObtenerPorNombre(string nombre)
        {
            return BuscarConFiltros(nombre, true).FirstOrDefault();
        }

        public List<Usuario> BuscarConFiltros(string Nombre, bool activo)
        {
            try
            {
                List<Usuario> lista = new List<Usuario>();

                Dictionary<string, object[]> parametros = new Dictionary<string, object[]>();
                if (Nombre != string.Empty) parametros.Add("Usuario_Cuenta", new object[2] { Nombre, TipoDeComparador.eID.Texto });
                parametros.Add("Estado_Cuenta", new object[2] { activo, TipoDeComparador.eID.TextoExacto });

                List<string> columnas = new List<string>(new string[] { "Id_Usuario", "Usuario_Cuenta", "Contra_Cuenta","Cant_Ingresos_Cuenta",   "Estado_Cuenta"  });

                lista = this.maper.mapearAEntidad(BuscarTodosPorFiltro(parametros, columnas));
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("se produjo un error al buscar los clientes: {0}", ex.Message));
            }
        }

        public void SumarUnError(int Id_Usuario)
        {
            try
            {
                List<SqlParameter> parametros = new List<SqlParameter>();

                SqlParameter param = new SqlParameter("@Id_Usuario", Id_Usuario);
                parametros.Add(param);

                this.EjecutarSP("DEFAULT_NAME.SP_Cuenta_Suma_Intento_Fallido", parametros);
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("se produjo un error al ejecutar procedimiento almacenado: {0}", ex.Message));
            }
        }

        public void LimpiarCantidadDeErrores(int Id_Usuario)
        {
            try
            {
                List<SqlParameter> parametros = new List<SqlParameter>();

                SqlParameter param = new SqlParameter("@Id_Usuario", Id_Usuario);
                parametros.Add(param);

                this.EjecutarSP("DEFAULT_NAME.SP_Cuenta_Limpia_Intentos_Fallidos", parametros);
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("se produjo un error al ejecutar procedimiento almacenado: {0}", ex.Message));
            }
        }

        public void GuardarContraseña(int Id_Usuario, string Contraseña)
        {
            try
            {
                List<Funcionalidad> lista = new List<Funcionalidad>();

                List<SqlParameter> parametros = new List<SqlParameter>();
                SqlParameter param = new SqlParameter("@Id_Usuario", Id_Usuario);
                parametros.Add(param);
                param = new SqlParameter("@Contra_Cuenta", Contraseña);
                parametros.Add(param);

                string statement = @"UPDATE [DEFAULT_NAME].[Cuenta]
                                    SET [Contra_Cuenta] =  @Contra_Cuenta
                                    WHERE Id_Usuario = @Id_Usuario";

                EjecutarStatement(statement, parametros);

            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("se produjo un error al ejecutar la actualización: {0}", ex.Message));
            }
        }



        public void ActualizarRoles(Usuario UsuarioEnEdicion)
        {
            this.InicializarConexion();
            SqlTransaction transaction;
            transaction = conn.BeginTransaction();

            try
            {
                //busco las funcionalidades de la base
                var maper = new MaperDeRoles();
                var repo = new RepositorioDeRoles(maper);
                List<int> _roles = (from f in repo.ObtenerPorIdUsuario(UsuarioEnEdicion.Id_Usuario) select f.Id_Rol).ToList();
                List<int> _RolesDelUser = (from f in UsuarioEnEdicion.RolDelUsuario select f.Id_Rol).ToList();
                SqlCommand command = conn.CreateCommand();
                command.Transaction = transaction;
                SqlParameter param;

                //actualizo los roles asociadas al usuario
                //elimino las que estan en la base y no en mi objeto
                List<int> RolEliminar = (from f in _roles where !_RolesDelUser.Contains(f) select f).ToList();
                if (RolEliminar.Any())
                {
                    command.Parameters.Clear();
                    param = new SqlParameter("@Id_Usuario", UsuarioEnEdicion.Id_Usuario);
                    command.Parameters.Add(param);
                    string cmd = @"DELETE FROM [DEFAULT_NAME].[Rol_Por_Cuenta]
                                    where [Id_Usuario] = @Id_Usuario and [Id_Rol] in (";

                    for (int i = 0; i < RolEliminar.Count(); i++)
                    {
                        string a = ",";
                        if (i == 0) a = "";
                        param = new SqlParameter(string.Format("@Id_Rol{0}", i), RolEliminar[i]);
                        command.Parameters.Add(param);
                        cmd = cmd + string.Format("{1}@Id_Rol{0}", i, a);
                    }
                    cmd = cmd + ")";
                    command.CommandText = cmd;
                    command.ExecuteNonQuery();
                }
                //inserto las que estan en mi objeto y no en la base
                List<int> RolAgregar = (from f in _RolesDelUser where !_roles.Contains(f) select f).ToList();
                if (RolAgregar.Any())
                {
                    command.Parameters.Clear();
                    StringBuilder comando = new StringBuilder();
                    comando.AppendLine(@"INSERT INTO [DEFAULT_NAME].[Rol_Por_Cuenta]
                                    ([Id_Usuario] ,[Id_Rol])
                                     VALUES");

                    for (int i = 0; i < RolAgregar.Count(); i++)
                    {
                        string a = ",";
                        if (i == 0) a = "";
                        param = new SqlParameter(string.Format("@Id_Usuario{0}", i), UsuarioEnEdicion.Id_Usuario);
                        command.Parameters.Add(param);
                        param = new SqlParameter(string.Format("@Id_Rol{0}", i), RolAgregar[i]);
                        command.Parameters.Add(param);
                        comando.AppendLine(string.Format("{1}(@Id_Usuario{0} , @Id_Rol{0})", i, a));
                    }
                    command.CommandText = comando.ToString();

                    command.ExecuteNonQuery();
                }
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw new Exception(string.Format("se produjo un error al actualizar los roles: {0}", ex.Message));
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public void Guardar(Usuario usuarioAGuardar, Cliente cliente = null, Proveedor proveedor = null)
        {
            this.InicializarConexion();
            SqlTransaction transaction;
            transaction = conn.BeginTransaction();

            try
            {

                //inserto el nuevo usuario

                SqlCommand command = conn.CreateCommand();
                command.Connection = conn;
                command.Transaction = transaction;
                SqlParameter param = new SqlParameter("@Usuario_Cuenta", usuarioAGuardar.Usuario_Cuenta);
                command.Parameters.Add(param);
                param = new SqlParameter("@Contra_Cuenta", Encriptador.ComputeSha256Hash(usuarioAGuardar.Contra_Cuenta));
                command.Parameters.Add(param);

                command.CommandText = @"INSERT INTO [DEFAULT_NAME].[Cuenta]
                                   ([Usuario_Cuenta],[Contra_Cuenta],[Cant_Ingresos_Cuenta],[Estado_Cuenta])
                                    VALUES (@Usuario_Cuenta,@Contra_Cuenta,0,1)
                                SELECT SCOPE_IDENTITY()";

                usuarioAGuardar.Id_Usuario = Convert.ToInt32(command.ExecuteScalar());
                
                
                //si hay roles, los asigno tambien aqui
                command.Parameters.Clear();
                StringBuilder comando = new StringBuilder();
                comando.AppendLine(@"INSERT INTO [DEFAULT_NAME].[Rol_Por_Cuenta]
                                   ([Id_Rol],[Id_Usuario])
                                    VALUES");

                for (int i = 0; i < usuarioAGuardar.RolDelUsuario.Count(); i++)
                {
                    string a = ",";
                    if (i == 0) a = "";
                    param = new SqlParameter(string.Format("@Id_Rol{0}", i), usuarioAGuardar.RolDelUsuario[i].Id_Rol);
                    command.Parameters.Add(param);
                    param = new SqlParameter(string.Format("@Id_Usuario{0}", i), usuarioAGuardar.Id_Usuario);
                    command.Parameters.Add(param);
                    comando.AppendLine(string.Format("{1}(@Id_Rol{0} , @Id_Usuario{0})", i, a));
                }
                command.CommandText = comando.ToString();

                command.ExecuteNonQuery();

                //si hay un cliente lo creo aqui


                //si hay un proveedor lo creo aqui

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw new Exception(string.Format("se produjo un error al insertar un usuario: {0}", ex.Message));
            }
            finally
            {
                this.CerrarConexion();
            }
        }
    }
}
