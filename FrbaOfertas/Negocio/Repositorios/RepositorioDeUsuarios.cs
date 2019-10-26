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
            return BuscarConFiltros(nombre).FirstOrDefault();
        }

        public List<Usuario> BuscarConFiltros(string Nombre)
        {
            try
            {
                List<Usuario> lista = new List<Usuario>();

                Dictionary<string, object[]> parametros = new Dictionary<string, object[]>();
                if (Nombre != string.Empty) parametros.Add("Usuario_Cuenta", new object[2] { Nombre, TipoDeComparador.eID.Texto });

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
    }
}
