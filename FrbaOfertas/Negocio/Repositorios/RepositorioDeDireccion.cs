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
    public class RepositorioDeDireccion: IPersistencia<Domicilio>
    {
        public RepositorioDeDireccion(MaperDeDireccion maper)
        {
            this.maper = maper;
        }

        public Domicilio ObtenerPorIDYTTipo(int Id_Objeto, int Tipo_Objeto)
        {
            try
            {
                List<Domicilio> lista = new List<Domicilio>();

                List<SqlParameter> parametros = new List<SqlParameter>();
                SqlParameter param = new SqlParameter("@Id_Objeto", Id_Objeto);
                parametros.Add(param);
                param = new SqlParameter("@Tipo_Objeto", Tipo_Objeto);
                parametros.Add(param);

                string consulta = @"SELECT [Id_Direccion]
                                  ,[Id_Objeto]
                                  ,[Tipo_Objeto]
                                  ,[Numero_Dir]
                                  ,[Piso_Dir]
                                  ,[Depto_Dir]
                                  ,[Localidad_Dir]
                                  ,[Ciudad_Dir]
                                  ,[Calle_Dir]
                                  ,[Codigo_Postal_Dir]
                              FROM [DEFAULT_NAME].[Direccion]
                                where Id_Objeto = @Id_Objeto and Tipo_Objeto = @Tipo_Objeto";

                
                
                lista = this.maper.mapearAEntidad(EjecutarConsulta(consulta, parametros));
                return lista.FirstOrDefault();

            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("se produjo un error al buscar las facturas: {0}", ex.Message));
            }
        }
    }
}
