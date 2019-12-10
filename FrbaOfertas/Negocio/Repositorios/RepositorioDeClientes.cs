using Negocio.Base;
using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Repositorios
{
    public class RepositorioDeClientes : IPersistencia<Cliente>
    {
        public RepositorioDeClientes(MaperDeClientes maper)
        {
            this.maper = maper;
        }


        /// <summary>
        /// busca todos los clientes existentes en el sistema,.
        /// </summary>
        /// <returns></returns>
        public List<Cliente> Buscar()
        {
            try
            {
                List<Cliente> lista = new List<Cliente>();
                lista = this.maper.mapearAEntidad(BuscarTodos());
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("se produjo un error al buscar los clientes: {0}", ex.Message));
            }
        }


        /// <summary>
        /// busca multiples clientes por los filtros seleccionados
        /// </summary>
        /// <param name="Nombre">busca concidencias aproximadas</param>
        /// <param name="Apellido">busca concidencias aproximadas</param>
        /// <param name="idUsuario">filtro exacto</param>
        /// <returns></returns>
        public List<Cliente> BuscarConFiltros(string Nombre = null, string Apellido = null, int DNI = 0, string email ="", int idUsuario = 0)
        {
            try
            {
                List<Cliente> lista = new List<Cliente>();

                Dictionary<string, object[]> parametros = new Dictionary<string, object[]>();
                if (Nombre != string.Empty) parametros.Add("Nombre_Clie", new object[2] { Nombre, TipoDeComparador.eID.Texto });
                if (Apellido != string.Empty) parametros.Add("Apellido_Clie", new object[2] { Apellido, TipoDeComparador.eID.Texto });
                if (DNI != 0) parametros.Add("DNI_Clie", new object[2] { DNI, TipoDeComparador.eID.TextoExacto });
                if (email != string.Empty) parametros.Add("Mail_Clie", new object[2] { email, TipoDeComparador.eID.Texto });
                if (idUsuario != 0) parametros.Add("Id_Cuenta", new object[2] { idUsuario, TipoDeComparador.eID.TextoExacto });

                lista = this.maper.mapearAEntidad(BuscarTodosPorFiltro(parametros));
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("se produjo un error al buscar los clientes: {0}", ex.Message));
            }
        }

        /// <summary>
        /// devuelve uno por id
        /// </summary>
        /// <param name="Id_Cliente">id del cliente que queremos buscar</param>
        /// <returns></returns>
        internal Cliente ObtenerUnoPorId(int Id_Cliente)
        {
            try
            {
                return this.maper.mapearAEntidad(ObtenerPorID("Id_Cliente", Id_Cliente)).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("se produjo un error al buscar el cliente: {0}", ex.Message));
            }
        }


        /// <summary>
        /// busca un cliente por su IdCuenta (idusuario)
        /// </summary>
        /// <param name="idUsuario"> id cuenta del cliente a encontrar</param>
        /// <returns></returns>
        public Cliente ObtenerDelUsuario(int idUsuario)
        {
            try
            {
                //busco por el filtro y me quedo con el primero o un nulo si la lista devuelta esta vacia.
                return this.BuscarConFiltros(idUsuario: idUsuario).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("se produjo un error al buscar el cliente: {0}", ex.Message));
            }
        }


        public void Modificar(Cliente cliente)
        {
            this.InicializarConexion();
            SqlTransaction transaction;
            transaction = conn.BeginTransaction();

            try
            {   
                    List<SqlParameter> parametros = new List<SqlParameter>();

                    SqlParameter parametro = new SqlParameter("@Id_Cliente", cliente.Id_Cliente);
                    parametros.Add(parametro);
                    if (cliente.Id_Cuenta != 0)
                    {
                        parametro = new SqlParameter("@Id_Cuenta", cliente.Id_Cuenta);
                        parametros.Add(parametro);
                    }
                    parametro = new SqlParameter("@Nombre_Clie", cliente.Nombre_Clie);
                    parametros.Add(parametro);
                    parametro = new SqlParameter("@Apellido_Clie", cliente.Apellido_Clie);
                    parametros.Add(parametro);
                    parametro = new SqlParameter("@DNI_Clie", cliente.DNI_Clie);
                    parametros.Add(parametro);
                    parametro = new SqlParameter("@Mail_Clie", cliente.Mail_Clie);
                    parametros.Add(parametro);
                    parametro = new SqlParameter("@Tel_Clie", cliente.Tel_Clie);
                    parametros.Add(parametro);
                    parametro = new SqlParameter("@Fecha_Nac_Clie", cliente.Fecha_Nac_Clie);
                    parametros.Add(parametro);
                    parametro = new SqlParameter("@Monto_Total_cred_Clie", cliente.Monto_Total_cred_Clie);
                    parametros.Add(parametro);
                    parametro = new SqlParameter("@Habilitado", cliente.Habilitado);
                    parametros.Add(parametro);
                    parametro = new SqlParameter("@Id_Direccion", cliente.Direccion.Id_Direccion);
                    parametros.Add(parametro);
                    parametro = new SqlParameter("@Numero_Dir", cliente.Direccion.Numero_Dir);
                    parametros.Add(parametro);
                    parametro = new SqlParameter("@Piso_Dir", cliente.Direccion.Piso_Dir);
                    parametros.Add(parametro);
                    parametro = new SqlParameter("@Depto_Dir", cliente.Direccion.Depto_Dir);
                    parametros.Add(parametro);
                    parametro = new SqlParameter("@Localidad_Dir", cliente.Direccion.Localidad_Dir);
                    parametros.Add(parametro);
                    parametro = new SqlParameter("@Ciudad_Dir", cliente.Direccion.Ciudad_Dir);
                    parametros.Add(parametro);
                    parametro = new SqlParameter("@Calle_Dir", cliente.Direccion.Calle_Dir);
                    parametros.Add(parametro);
                    parametro = new SqlParameter("@Codigo_Postal_Dir", cliente.Direccion.Codigo_Postal_Dir);
                    parametros.Add(parametro);

                    string sp = "DEFAULT_NAME.SP_modificar_cliente_con_domicilio";

                    SqlCommand cmd = new SqlCommand(sp, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Transaction = transaction;

                    foreach (SqlParameter par in parametros)
                    {
                        cmd.Parameters.Add(par);
                    }

                    int resultado = cmd.ExecuteNonQuery();
                    if (resultado == 0)
                        throw new Exception("error al ejecutar el sp de insercion de usuarios");
               
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

        public void Agregar(Cliente cliente)
        {
            this.InicializarConexion();
            SqlTransaction transaction;
            transaction = conn.BeginTransaction();

            try
            {
                List<SqlParameter> parametros = new List<SqlParameter>();

                SqlParameter parametro = new SqlParameter("@FechaSistema", DateTime.Parse(ConfigurationManager.AppSettings["FechaDelDia"]));
                parametros.Add(parametro);
                parametro = new SqlParameter("@Id_Cuenta", null);
                parametros.Add(parametro);
                parametro = new SqlParameter("@Nombre_Clie", cliente.Nombre_Clie);
                parametros.Add(parametro);
                parametro = new SqlParameter("@Apellido_Clie", cliente.Apellido_Clie);
                parametros.Add(parametro);
                parametro = new SqlParameter("@DNI_Clie", cliente.DNI_Clie);
                parametros.Add(parametro);
                parametro = new SqlParameter("@Mail_Clie", cliente.Mail_Clie);
                parametros.Add(parametro);
                parametro = new SqlParameter("@Tel_Clie", cliente.Tel_Clie);
                parametros.Add(parametro);
                parametro = new SqlParameter("@Fecha_Nac_Clie", cliente.Fecha_Nac_Clie);
                parametros.Add(parametro);
                parametro = new SqlParameter("@Monto_Total_cred_Clie", cliente.Monto_Total_cred_Clie);
                parametros.Add(parametro);
                parametro = new SqlParameter("@Numero_Dir", cliente.Direccion.Numero_Dir);
                parametros.Add(parametro);
                parametro = new SqlParameter("@Piso_Dir", cliente.Direccion.Piso_Dir);
                parametros.Add(parametro);
                parametro = new SqlParameter("@Depto_Dir", cliente.Direccion.Depto_Dir);
                parametros.Add(parametro);
                parametro = new SqlParameter("@Localidad_Dir", cliente.Direccion.Localidad_Dir);
                parametros.Add(parametro);
                parametro = new SqlParameter("@Ciudad_Dir", cliente.Direccion.Ciudad_Dir);
                parametros.Add(parametro);
                parametro = new SqlParameter("@Calle_Dir", cliente.Direccion.Calle_Dir);
                parametros.Add(parametro);
                parametro = new SqlParameter("@Codigo_Postal_Dir", cliente.Direccion.Codigo_Postal_Dir);
                parametros.Add(parametro);

                string sp = "DEFAULT_NAME.SP_insertar_cliente_con_domicilio";

                SqlCommand cmd = new SqlCommand(sp, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Transaction = transaction;

                foreach (SqlParameter par in parametros)
                {
                    cmd.Parameters.Add(par);
                }

                int resultado = cmd.ExecuteNonQuery();
                if (resultado == 0)
                    throw new Exception("error al ejecutar el sp de insercion de clientes");

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw new Exception(string.Format("se produjo un error al insertar un cliente: {0}", ex.Message));
            }
            finally
            {
                this.CerrarConexion();
            }
        }
    }
}
