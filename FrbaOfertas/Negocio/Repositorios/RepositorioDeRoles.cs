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
    }
}
