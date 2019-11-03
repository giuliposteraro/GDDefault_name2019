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
    public class RepositorioDeRoles: IPersistencia<Rol>
    {
        public RepositorioDeRoles(MaperDeRoles maper)
        {
            this.maper = maper;
        }


        internal List<Rol> ObtenerPorIdUsuario(int Id_Usuario)
        {
            try
            {
                List<Rol> lista = new List<Rol>();
                
                List<SqlParameter> parametros = new List<SqlParameter>();
                SqlParameter param = new SqlParameter("@Id_Usuario", Id_Usuario);
                parametros.Add(param);

                string consulta = @"select R.* from [DEFAULT_NAME].[Rol_Por_Cuenta] RPC
                                inner join [DEFAULT_NAME].[Rol] R on RPC.Id_Rol = R.Id_Rol
                                where RPC.Id_Usuario = @Id_Usuario";

                lista = this.maper.mapearAEntidad(EjecutarConsulta(consulta ,parametros));
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("se produjo un error al buscar las Funcionalidades: {0}", ex.Message));
            }
        }

        public List<Rol> BuscarConFiltros(string Nombre)
        {
            try
            {
                List<Rol> lista = new List<Rol>();

                Dictionary<string, object[]> parametros = new Dictionary<string, object[]>();
                if (Nombre != string.Empty) parametros.Add("Nombre_Rol", new object[2] { Nombre, TipoDeComparador.eID.Texto });

                lista = this.maper.mapearAEntidad(BuscarTodosPorFiltro(parametros));
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("se produjo un error al buscar los roles: {0}", ex.Message));
            }
        }

        public void Guardar(Rol RolEnEdicion)
        {
            this.InicializarConexion();
            SqlTransaction transaction;
            transaction = conn.BeginTransaction();

            try
            {

                //inserto el nuevo rol

                SqlCommand command = conn.CreateCommand();
                command.Connection = conn;
                command.Transaction = transaction;
                SqlParameter param = new SqlParameter("@Estado_rol", RolEnEdicion.Estado_rol);
                command.Parameters.Add(param);
                param = new SqlParameter("@Nombre_rol", RolEnEdicion.Nombre_rol);
                command.Parameters.Add(param);

                command.CommandText = @"INSERT INTO [DEFAULT_NAME].[Rol]
                                ([Nombre_rol],[Estado_rol])
                                VALUES (@Nombre_rol,@Estado_rol)
                                SELECT SCOPE_IDENTITY()";
                
                RolEnEdicion.Id_Rol = Convert.ToInt32(command.ExecuteScalar());
                //inserto las funcionalidades asociadas al rol


                command.Parameters.Clear();
                StringBuilder comando = new StringBuilder();
                comando.AppendLine( @"INSERT INTO [DEFAULT_NAME].[Funcionalidad_Por_Rol]
                                    ([Id_Rol],[Id_Funcionalidad])
                                     VALUES");

                for(int i=0; i<RolEnEdicion.FuncionalidadesDelRol.Count(); i++)
                {
                    string a = ",";
                    if (i == 0) a = "";
                    param = new SqlParameter(string.Format("@Id_Rol{0}",i), RolEnEdicion.Id_Rol);
                    command.Parameters.Add(param);
                    param = new SqlParameter(string.Format("@Id_Funcionalidad{0}",i), RolEnEdicion.FuncionalidadesDelRol[i].Id_Funcionalidad);
                    command.Parameters.Add(param);
                    comando.AppendLine(string.Format("{1}(@Id_Rol{0} , @Id_Funcionalidad{0})", i, a));
                }
                command.CommandText = comando.ToString();

                command.ExecuteNonQuery();

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw new Exception(string.Format("se produjo un error al buscar las Funcionalidades: {0}", ex.Message));
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public void Actualizar(Rol RolEnEdicion)
        {
            this.InicializarConexion();
            SqlTransaction transaction;
            transaction = conn.BeginTransaction();

            try
            {
                //busco las funcionalidades de la base
                var maper = new MaperDeFuncionalidades();
                var repo = new RepositorioDeFuncionalidades(maper);
                List<int> _funcionalidades = (from f in repo.ObtenerPorIdRol(RolEnEdicion.Id_Rol) select f.Id_Funcionalidad).ToList();
                List<int> _funcDelRol = (from f in RolEnEdicion.FuncionalidadesDelRol select f.Id_Funcionalidad).ToList();
                    
                //actualizo el rol
                SqlCommand command = conn.CreateCommand();
                command.Connection = conn;
                command.Transaction = transaction;
                
                SqlParameter param = new SqlParameter("@Estado_rol", RolEnEdicion.Estado_rol);
                command.Parameters.Add(param);
                param = new SqlParameter("@Nombre_rol", RolEnEdicion.Nombre_rol);
                command.Parameters.Add(param);
                param = new SqlParameter("@Id_Rol", RolEnEdicion.Id_Rol);
                command.Parameters.Add(param);

                command.CommandText = @"update [DEFAULT_NAME].[Rol]
                                set [Nombre_rol] = @Nombre_rol,[Estado_rol] = @Estado_rol
                                where Id_Rol = @Id_Rol";

                command.ExecuteNonQuery();

                //actualizo las funcionalidades asociadas al rol
                //elimino las que estan en la base y no en mi objeto
                List<int> funcEliminar = (from f in _funcionalidades where !_funcDelRol.Contains(f) select f).ToList();
                if (funcEliminar.Any())
                {
                    command.Parameters.Clear();
                    param = new SqlParameter("@Id_Rol", RolEnEdicion.Id_Rol);
                    command.Parameters.Add(param);
                    string cmd = @"DELETE FROM [DEFAULT_NAME].[Funcionalidad_Por_Rol]
                                    where [Id_Rol] = @Id_Rol and [Id_Funcionalidad] in (";

                    for (int i = 0; i < funcEliminar.Count(); i++)
                    {
                        string a = ",";
                        if (i == 0) a = "";
                        param = new SqlParameter(string.Format("@Id_Funcionalidad{0}", i), funcEliminar[i]);
                        command.Parameters.Add(param);
                        cmd = cmd + string.Format("{1}@Id_Funcionalidad{0}", i, a);
                    }
                    cmd = cmd + ")";
                    command.CommandText = cmd;
                    command.ExecuteNonQuery();
                }
                //inserto las que estan en mi objeto y no en la base
                List<int> funcAgregar = (from f in _funcDelRol where !_funcionalidades.Contains(f) select f).ToList();
                if (funcAgregar.Any())
                {
                    command.Parameters.Clear();
                    StringBuilder comando = new StringBuilder();
                    comando.AppendLine(@"INSERT INTO [DEFAULT_NAME].[Funcionalidad_Por_Rol]
                                    ([Id_Rol],[Id_Funcionalidad])
                                     VALUES");

                    for (int i = 0; i < funcAgregar.Count(); i++)
                    {
                        string a = ",";
                        if (i == 0) a = "";
                        param = new SqlParameter(string.Format("@Id_Rol{0}", i), RolEnEdicion.Id_Rol);
                        command.Parameters.Add(param);
                        param = new SqlParameter(string.Format("@Id_Funcionalidad{0}", i), funcAgregar[i]);
                        command.Parameters.Add(param);
                        comando.AppendLine(string.Format("{1}(@Id_Rol{0} , @Id_Funcionalidad{0})", i, a));
                    }
                    command.CommandText = comando.ToString();

                    command.ExecuteNonQuery();
                }
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw new Exception(string.Format("se produjo un error al buscar las Funcionalidades: {0}", ex.Message));
            }
            finally
            {
                this.CerrarConexion();
            }
        }
    }
}
