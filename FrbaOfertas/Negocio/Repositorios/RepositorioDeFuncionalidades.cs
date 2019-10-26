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
    public class RepositorioDeFuncionalidades : IPersistencia<Funcionalidad>
    {
        public RepositorioDeFuncionalidades(MaperDeFuncionalidades maper)
        {
            this.maper = maper;
        }


        internal List<Funcionalidad> ObtenerPorIdRol(int Id_Rol)
        {
            try
            {
                List<Funcionalidad> lista = new List<Funcionalidad>();
                
                List<SqlParameter> parametros = new List<SqlParameter>();
                SqlParameter param = new SqlParameter("@Id_Rol", Id_Rol);
                parametros.Add(param);

                string consulta = @"select F.* from [DEFAULT_NAME].[Funcionalidad_Por_Rol] FPR  
                                    inner join [DEFAULT_NAME].[Funcionalidad] F on FPR.Id_Funcionalidad = F.Id_Funcionalidad
                                    where FPR.Id_Rol = @Id_Rol";

                lista = this.maper.mapearAEntidad(EjecutarConsulta(consulta ,parametros));
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("se produjo un error al buscar las Funcionalidades: {0}", ex.Message));
            }
        }

        internal Funcionalidad ObtenerUnoPorId(int Id_Funcionalidad)
        {
            return this.maper.mapearAEntidad(ObtenerPorID("Id_Funcionalidad", Id_Funcionalidad)).FirstOrDefault();
        }
    }
}
