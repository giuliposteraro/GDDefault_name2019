﻿using Negocio.Base;
using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Repositorios
{
    public class RepositorioDeCompras: IPersistencia<Compra>
    {
        public RepositorioDeCompras(MaperDeCompras maper)
        {
            this.maper = maper;
        }

        /// <summary>
        /// obtiene la cantidad de veces que la oferta fue comprada.
        /// </summary>
        /// <param name="id_Oferta"></param>
        /// <returns></returns>
        public int ObtenerCantidadCompradas(int id_Oferta)
        {
            this.InicializarConexion();

            try
            {
                SqlCommand command = conn.CreateCommand();
                command.Connection = conn;
                SqlParameter param = new SqlParameter("@Id_Oferta", id_Oferta);
                command.Parameters.Add(param);

                var texto = @"SELECT count(*)
                            FROM [DEFAULT_NAME].[Compra] c 
                            where [Id_Oferta] = @Id_Oferta";

                command.CommandText = texto;

                int cantidad = Convert.ToInt32(command.ExecuteScalar());
                //inserto las funcionalidades asociadas al rol
                return cantidad;
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("se produjo un error al buscar la cantidad de compras para la oferta: {0}", ex.Message));
            }
            finally
            {
                this.CerrarConexion();
            }
        }


        /// <summary>
        /// devuelve true o false dependiendo de si encuentra otra oferta con el mismo codigo
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool ObtenerOfertasConElMismoCodigo(string Codigo)
        {
            this.InicializarConexion();

            try
            {
                SqlCommand command = conn.CreateCommand();
                command.Connection = conn;
                SqlParameter param = new SqlParameter("@Codigo_Of", Codigo);
                command.Parameters.Add(param);

                var texto = @"SELECT count(*)
                            FROM [DEFAULT_NAME].[Oferta] 
                            where [Codigo_Of] = @Codigo_Of";

                command.CommandText = texto;

                int cantidad = Convert.ToInt32(command.ExecuteScalar());
                
                return cantidad>0;
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("se produjo un error al buscar ofertas con el mismo código: {0}", ex.Message));
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public void Guardar(Compra compra)
        {
            this.InicializarConexion();
            SqlTransaction transaction;
            transaction = conn.BeginTransaction();

            try
            {

                //inserto la nueva compra

                SqlCommand command = conn.CreateCommand();
                command.Connection = conn;
                command.Transaction = transaction;
                SqlParameter param = new SqlParameter("@Id_Cliente", compra.Id_Cliente);
                command.Parameters.Add(param);
                param = new SqlParameter("@Id_Proveedor", compra.Id_Proveedor);
                command.Parameters.Add(param);
                param = new SqlParameter("@Id_Oferta", compra.Id_Oferta);
                command.Parameters.Add(param);
                param = new SqlParameter("@Fecha_Compra", compra.Fecha_Compra);
                command.Parameters.Add(param);
                param = new SqlParameter("@Codigo_Cupon", compra.Codigo_Cupon);
                command.Parameters.Add(param);
                param = new SqlParameter("@Estado_Cupon", compra.Estado_Cupon);
                command.Parameters.Add(param);
                param = new SqlParameter("@Cantidad", compra.Cantidad);
                command.Parameters.Add(param);
                param = new SqlParameter("Monto", compra.Monto);
                command.Parameters.Add(param);

                command.CommandText = @"INSERT INTO [DEFAULT_NAME].[Compra]
                                           ([Id_Cliente]
                                           ,[Id_Proveedor]
                                           ,[Id_Oferta]
                                           ,[Fecha_Compra]
                                           ,[Fecha_Entrega]
                                           ,[Codigo_Cupon]
                                           ,[Estado_Cupon]
                                           ,[Cantidad]
                                           ,[Monto])
                                     VALUES
                                           (@Id_Cliente
                                           ,@Id_Proveedor
                                           ,@Id_Oferta
                                           ,convert(datetime,@Fecha_Compra,121)
                                           ,null
                                           ,@Codigo_Cupon
                                           ,@Estado_Cupon
                                           ,@Cantidad
                                           ,@Monto)";

                command.ExecuteNonQuery();

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw new Exception(string.Format("se produjo un error al guardar las compras: {0}", ex.Message));
            }
            finally
            {
                this.CerrarConexion();
            }
        }
    }
}
