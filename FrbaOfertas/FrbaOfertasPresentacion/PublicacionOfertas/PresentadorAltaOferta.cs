using FrbaOfertasPresentacion.bases;
using Negocio.Base;
using Negocio.Entidades;
using Negocio.Repositorios;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertasPresentacion.CompraOfertas
{
    public class PresentadorAltaOferta
    {
         private readonly IVistaAltaOferta _vista;

         public PresentadorAltaOferta(IVistaAltaOferta vista)
        {
            _vista = vista;

        }


         public void PosicionarAlta(Proveedor proveedor)
         {
            try
            {
                modo = ModosDeEjecucion.Alta;
                _vista.Titulo = "Alta Oferta";
                this.cargarComboProveedores();
                this.BloquearProveedor();
                _vista.codigo = GenerarCodigo();
                _vista.proveedorSeleccionado = proveedor;
            }
            catch (Exception ex)
            {
                _vista.MostrarMensaje(string.Format("Se produjo una excepción al posicionar para alta: {0}", ex.Message));
            }
         }

         private void BloquearProveedor()
         {
             var maper = new MaperDeProveedores();
             var repo = new RepositorioDeProveedores(maper);
             Usuario Usuario = Global.SessionUsuario;
             Proveedor _proveedor = repo.ObtenerDelUsuario(Usuario.Id_Usuario);
             _vista.HabilitarCombo(_proveedor == null);
         }

         private void cargarComboProveedores()
         {
             var maper = new MaperDeProveedores();
             var repo = new RepositorioDeProveedores(maper);
             //busco todos los proveedores para completar el combo
             List<Proveedor> proveedores = repo.Buscar();
             _vista.proveedores = proveedores.OrderBy(x => x.ToString()).ToList();
             
         }

         public void PosicionarModificar(Negocio.Entidades.Oferta oferta)
         {
             try
             {
                 modo = ModosDeEjecucion.Modificacion;
                 _vista.Titulo = string.Format("Modificación Oferta: {0} ", oferta.Codigo_Of);
                 cargarComboProveedores();
                 this.BloquearProveedor();

                 _vista.proveedorSeleccionado = oferta.Proveedor;
                 _vista.codigo = oferta.Codigo_Of;
                 _vista.fechaPublicacion = oferta.Fecha_Publi_Of;
                 _vista.fechaVencimiento = oferta.Fecha_Venc_Of;
                 _vista.descripcion = oferta.Descripcion_Of;
                 _vista.precioOferta = oferta.Precio_Oferta;
                 _vista.precioLista = oferta.Precio_Lista;
                 _vista.cantidadDisponible = oferta.Cant_Disp_Oferta;
                 _vista.cantidadMaxima = oferta.Maximo_Por_Compra;

                 OfertaEnEdicion = oferta.Clone<Oferta>();
             }
             catch (Exception ex)
             {
                 _vista.MostrarMensaje(string.Format("Se produjo una excepción al posicionar para modificación: {0}", ex.Message));
             }
         }

         public void PosicionarBaja(Negocio.Entidades.Oferta oferta)
         {
             try
             {
                 modo = ModosDeEjecucion.Baja;
                 _vista.Titulo = string.Format("Baja Oferta: {0} ", oferta.Codigo_Of);
                 cargarComboProveedores();

                 _vista.proveedorSeleccionado = oferta.Proveedor;
                 _vista.codigo = oferta.Codigo_Of;
                 _vista.fechaPublicacion = oferta.Fecha_Publi_Of;
                 _vista.fechaVencimiento = oferta.Fecha_Venc_Of;
                 _vista.descripcion = oferta.Descripcion_Of;
                 _vista.precioOferta = oferta.Precio_Oferta;
                 _vista.precioLista = oferta.Precio_Lista;
                 _vista.cantidadDisponible = oferta.Cant_Disp_Oferta;
                 _vista.cantidadMaxima = oferta.Maximo_Por_Compra;

                 OfertaEnEdicion = oferta.Clone<Oferta>();

                 _vista.BloquearDatos();
             }
             catch (Exception ex)
             {
                 _vista.MostrarMensaje(string.Format("Se produjo una excepción al posicionar para eliminar: {0}", ex.Message));
             }
         }

         public bool ValidarGuardar()
         {
             if (modo == ModosDeEjecucion.Baja)
                 return ValidarEliminar("eliminarse");

             //solo modificar
             if (modo == ModosDeEjecucion.Modificacion)
                 if (!ValidarEliminar("modificarse")) return false;
             //solo agregar
             if (modo == ModosDeEjecucion.Alta)
                 if (!validarCodigoYaExistente()) return false;

             //validaciones comunes del modificar y alta
             StringBuilder sb = new StringBuilder();

             //valido que haya una descripción
             if (_vista.descripcion.EsNuloOVacio())
                 sb.AppendLine("-Debe ingresar una descripción");
             //valido que las fechas existan y que la de vencimiento sea mayor a la de publicación
             if (_vista.fechaPublicacion == null)
                 sb.AppendLine("-Debe ingresar una fecha de publicación");
             if (_vista.fechaVencimiento == null)
                 sb.AppendLine("-Debe ingresar una fecha de vencimiento");
             if (_vista.fechaPublicacion > _vista.fechaVencimiento)
                 sb.AppendLine("-La fecha de publicación debe ser anterior a la fecha de vencimiento");
             //las fechas deben ser mayores a la fecha seteada en el sistema
             DateTime FechaDelDia = DateTime.Parse(ConfigurationManager.AppSettings["FechaDelDia"]);

             if (_vista.fechaPublicacion <= FechaDelDia)
                 sb.AppendLine("-La fecha de publicación no puede ser anterior a la fecha del sistema");
             if (_vista.fechaVencimiento <= FechaDelDia)
                 sb.AppendLine("-La fecha de vencimiento no puede ser anterior a la fecha del sistema");
             
             //valido los precios
             if (_vista.precioOferta == 0)
                 sb.AppendLine("-Debe ingresar un precio de oferta");
             if (_vista.precioLista == 0)
                 sb.AppendLine("-Debe ingresar un precio de lista");

             //valido cantidades
             if (_vista.cantidadDisponible == 0)
                 sb.AppendLine("-Debe ingresar una cantidad disponible para la oferta");
             if (_vista.cantidadMaxima == 0)
                 sb.AppendLine("-Debe ingresar una cantidad máxima de compra por cliente");
             if (_vista.cantidadMaxima > _vista.cantidadDisponible)
                 sb.AppendLine("-La cantidad máxima de compra por cliente no puede superar a la cantidad disponible");
             //valido proveedor
             if (_vista.proveedorSeleccionado == null)
                 sb.AppendLine("-Debe seleccionar un proveedor");

             if (sb.Length > 0)
             {
                 _vista.MostrarMensaje(sb.ToString());
                 return false;
             }

             return true;
         }

         private bool validarCodigoYaExistente()
         {
             var maper = new MaperDeCompras();
             var repo = new RepositorioDeCompras(maper);
             bool existeCodigo = repo.ObtenerOfertasConElMismoCodigo(_vista.codigo);
             if (existeCodigo)
                 _vista.MostrarMensaje("El código para la oferta ya fue utilizado en otra oferta");

             return !existeCodigo;
         }

         private bool ValidarEliminar(string mensaje)
         {
             //valido que la oferta no haya sido comprada, si fue comprada no puede ser eliminada
            var maper = new MaperDeCompras();
            var repo = new RepositorioDeCompras(maper);
            int CantidadComprada = repo.ObtenerCantidadCompradas(OfertaEnEdicion.Id_Oferta);

            if (CantidadComprada > 0)
            {
                _vista.MostrarMensaje(string.Format("La oferta no puede {0} ya que fue utilizada en una compra",mensaje));
                return false;
            }

             return true;
         }

         public bool Guardar()
         {
             switch (modo)
             {
                 case ModosDeEjecucion.Alta:
                     return this.GuardarNuevo();
                 case ModosDeEjecucion.Modificacion:
                     return this.ActualizarItem();
                 case ModosDeEjecucion.Baja:
                     return this.EliminarItem();
                 default:
                     return false;
             }
         }

         private bool EliminarItem()
         {
             try
             {
                 
                 if (!_vista.MensajePregunta("La oferta se eliminará, y ya no estará disponible en el sistema."))
                     return false;

                 var maper = new MaperDeOfertas();
                 var repo = new RepositorioDeOfertas(maper);

                 repo.EliminarEntidad(OfertaEnEdicion, "Id_Oferta");

                 _vista.MostrarMensaje("La oferta se elimino con éxito");
                 return true;
             }
             catch (Exception ex)
             {
                 _vista.MostrarMensaje(ex.Message);
                 return false;
             }
             
         }

         private bool ActualizarItem()
         {
             this.ObtenerDesdeVista();
             if (!this.ValidarGuardar())
                 return false;

             try
             {
                 //mando a guardar            
                 var maper = new MaperDeOfertas();
                 var repo = new RepositorioDeOfertas(maper);
             
          
                 List<string> propertiesAActualizar = new List<string> { ("Id_Proveedor"), ("Descripcion_Of"), ("Fecha_Publi_Of"), ("Fecha_Venc_Of"), ("Precio_Oferta"), ("Precio_Lista"), ("Cant_Disp_Oferta"),("Maximo_Por_Compra"), ("Codigo_Of") };
                 repo.ActualizarEntidad(OfertaEnEdicion, propertiesAActualizar, "Id_Oferta");

                 _vista.MostrarMensaje("Oferta actualizada con exito");
                 return true;
             }
             catch (Exception ex)
             {
                 _vista.MostrarMensaje(string.Format("Se produjo una excepción al actualizar la oferta: {0}", ex.Message));
                 return false;
             }
         }

         private void ObtenerDesdeVista()
         {
            OfertaEnEdicion.Id_Proveedor = _vista.proveedorSeleccionado.Id_Proveedor;
            OfertaEnEdicion.Descripcion_Of = _vista.descripcion;
            OfertaEnEdicion.Fecha_Publi_Of= _vista.fechaPublicacion;
            OfertaEnEdicion.Fecha_Venc_Of = _vista.fechaVencimiento;
            OfertaEnEdicion.Precio_Oferta= _vista.precioOferta;
            OfertaEnEdicion.Precio_Lista= _vista.precioLista;
            OfertaEnEdicion.Cant_Disp_Oferta= _vista.cantidadDisponible;
            OfertaEnEdicion.Maximo_Por_Compra= _vista.cantidadMaxima;
            OfertaEnEdicion.Codigo_Of= _vista. codigo;
         }

         private bool GuardarNuevo()
         {
             OfertaEnEdicion = new Oferta();

             this.ObtenerDesdeVista();
             if (!this.ValidarGuardar())
                 return false;

             try
             {
                 //mando a guardar            
                 var maper = new MaperDeOfertas();
                 var repo = new RepositorioDeOfertas(maper);

                 repo.Guardar(OfertaEnEdicion);

                 _vista.MostrarMensaje("Oferta creada con exito");
                 return true;
             }
             catch (Exception ex)
             {
                 _vista.MostrarMensaje(string.Format("Se produjo una excepción al crear la nueva oferta: {0}", ex.Message));
                 return false;
             }
         }

         public Oferta OfertaEnEdicion { get; set; }

         public ModosDeEjecucion modo { get; set; }

         private string GenerarCodigo()
         {
             int longitud = 10;
             string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
             StringBuilder res = new StringBuilder();
             Random rnd = new Random();
             while (0 < longitud--)
             {
                 res.Append(caracteres[rnd.Next(caracteres.Length)]);
             }
             return res.ToString();
         }
    }
}
