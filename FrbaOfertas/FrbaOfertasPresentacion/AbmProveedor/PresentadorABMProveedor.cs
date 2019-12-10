using Negocio.Entidades;
using Negocio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertasPresentacion.AbmProveedor
{
    public class PresentadorABMProveedor
    {
        private readonly IVistaABMProveedor _vista;

        public PresentadorABMProveedor(IVistaABMProveedor vista)
        {
            _vista = vista;
            
        }

        public void Posicionar(bases.ModosDeEjecucion modosDeEjecucion, Negocio.Entidades.Proveedor proveedor)
        {
            modo = modosDeEjecucion;
            ProveedorAGuardar = proveedor;

            if (modo == bases.ModosDeEjecucion.Baja)
            {
                _vista.BloquearPantalla();
                _vista.Texto = "Baja de Proveedores";
                _vista.BotonNombre = "Eliminar";
            }
            else if (modo == bases.ModosDeEjecucion.Alta)
            {
                _vista.Texto = "ALta de Proveedores";
                _vista.BotonNombre = "Crear";
            }
            else
            {
                _vista.Texto = "Modificación de Proveedores";
                _vista.BotonNombre = "Modificar";
            }

            if (ProveedorAGuardar != null)
            {
                _vista.RazonSocial = ProveedorAGuardar.Razon_Social_Prov;
                _vista.Mail_Proveedor = ProveedorAGuardar.Mail_Proveedor;
                _vista.Telefono_Prov = ProveedorAGuardar.Telefono_Prov;
                _vista.Cuit_Prov = ProveedorAGuardar.Cuit_Prov;
                _vista.Rubro_Prov = ProveedorAGuardar.Rubro_Prov;
                _vista.Nom_Contacto_Prov = ProveedorAGuardar.Nom_Contacto_Prov;
                _vista.Numero_Dir = ProveedorAGuardar.Direccion.Numero_Dir;
                _vista.Piso_Dir = ProveedorAGuardar.Direccion.Piso_Dir;
                _vista.Depto_Dir = ProveedorAGuardar.Direccion.Depto_Dir;
                _vista.Localidad_Dir = ProveedorAGuardar.Direccion.Localidad_Dir;
                _vista.Ciudad_Dir = ProveedorAGuardar.Direccion.Ciudad_Dir;
                _vista.Calle_Dir = ProveedorAGuardar.Direccion.Calle_Dir;
                _vista.Codigo_Postal_Dir = ProveedorAGuardar.Direccion.Codigo_Postal_Dir;
            }
            else
            {
                ProveedorAGuardar = new Proveedor();
                Domicilio dir = new Domicilio();
                ProveedorAGuardar.Direccion = dir;
            }
        }

        public bases.ModosDeEjecucion modo { get; set; }

        public Negocio.Entidades.Proveedor ProveedorAGuardar { get; set; }


        public bool Guardar()
        {
            if (!this.ValidarGuardar())
                return false;

            try
            {
                ObtenerProveedorDesdeVista();
                //mando a guardar            
                var maper = new MaperDeProveedores();
                var repo = new RepositorioDeProveedores(maper);

                if (modo == bases.ModosDeEjecucion.Baja)
                {
                    ProveedorAGuardar.Habilitado = false;
                    List<string> propertiesAActualizar = new List<string> { ("Habilitado") };
                    repo.ActualizarEntidad(ProveedorAGuardar, propertiesAActualizar, "Id_Proveedor");
                }
                else if (modo == bases.ModosDeEjecucion.Modificacion)
                {
                    repo.Modificar(ProveedorAGuardar);
                }
                else
                {
                    repo.Agregar(ProveedorAGuardar);
                }

                _vista.MostrarMensaje(string.Format("{0} realizada con éxito.", modo));
                return true;
            }
            catch (Exception ex)
            {
                _vista.MostrarMensaje(string.Format("Se produjo una excepción al realizar la operación sobre el cliente: {0}", ex.Message));
                return false;
            }
        }

        private void ObtenerProveedorDesdeVista()
        {
            
            ProveedorAGuardar.Razon_Social_Prov = _vista.RazonSocial;
            ProveedorAGuardar.Mail_Proveedor = _vista.Mail_Proveedor;
            ProveedorAGuardar.Telefono_Prov = _vista.Telefono_Prov;
            ProveedorAGuardar.Cuit_Prov = _vista.Cuit_Prov;
            ProveedorAGuardar.Rubro_Prov = _vista.Rubro_Prov;
            ProveedorAGuardar.Nom_Contacto_Prov = _vista.Nom_Contacto_Prov;

            ProveedorAGuardar.Direccion.Tipo_Objeto = 2;
            ProveedorAGuardar.Direccion.Numero_Dir = _vista.Numero_Dir;
            ProveedorAGuardar.Direccion.Piso_Dir = _vista.Piso_Dir;
            ProveedorAGuardar.Direccion.Depto_Dir = _vista.Depto_Dir;
            ProveedorAGuardar.Direccion.Localidad_Dir = _vista.Localidad_Dir;
            ProveedorAGuardar.Direccion.Ciudad_Dir = _vista.Ciudad_Dir;
            ProveedorAGuardar.Direccion.Calle_Dir = _vista.Calle_Dir;
            ProveedorAGuardar.Direccion.Codigo_Postal_Dir = _vista.Codigo_Postal_Dir;
        }

        public bool ValidarGuardar()
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                //valido unicidad de razon social y cuit
                var maper = new MaperDeProveedores();
                var repo = new RepositorioDeProveedores(maper);

                if (modo == bases.ModosDeEjecucion.Modificacion && !ProveedorAGuardar.Habilitado)
                    sb.AppendLine("No se puede editar un proveedor inhabilitado");


                if (_vista.RazonSocial == "")
                    sb.AppendLine("Debe ingresar la Razon social del proveedor");
                else
                {
                    List<Proveedor> prov = repo.BuscarConFiltros(_vista.RazonSocial, 0);
                    if (prov.Where(x => x.Id_Proveedor != ProveedorAGuardar.Id_Proveedor).Any())
                        sb.AppendLine("Ya existe un proveedor con la misma razon social");
                }


                if (_vista.Rubro_Prov == "")
                    sb.AppendLine("Debe ingresar un Rubro para el proveedor");
                if (_vista.Cuit_Prov == "")
                    sb.AppendLine("Debe ingresar un CUIT para el proveedor");
                else
                {
                    List<Proveedor> prov = repo.BuscarConFiltros(null, null, _vista.Cuit_Prov,null);
                    if (prov.Where(x => x.Id_Proveedor != ProveedorAGuardar.Id_Proveedor).Any())
                        sb.AppendLine("Ya existe un proveedor con el mismo CUIT");
                }
                if (_vista.Telefono_Prov == "")
                    sb.AppendLine("Debe ingresar un teléfono para el proveedor");
                if (_vista.Calle_Dir == "")
                    sb.AppendLine("Debe ingresar una calle para el proveedor");
                if (sb.Length > 0)
                {
                    _vista.MostrarMensaje(sb.ToString());
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                _vista.MostrarMensaje(string.Format("Se produjo una excepción al validar el nuevo usuario: {0}", ex.Message));
                return false;
            }
        }
    }
}
