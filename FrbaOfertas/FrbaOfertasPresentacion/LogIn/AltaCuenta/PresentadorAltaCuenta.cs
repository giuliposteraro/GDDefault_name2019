using Negocio.Entidades;
using Negocio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertasPresentacion.LogIn.AltaCuenta
{
    public class PresentadorAltaCuenta 
    {
        private readonly IVistaAltaCuenta _vista;
        private ModoAltaCuenta _modoPosicionar { get; set; }

        public PresentadorAltaCuenta(IVistaAltaCuenta vista)
        {
            _vista = vista;

        }

        public void Posicionar(ModoAltaCuenta modo)
        {

            var maper = new MaperDeRoles();
            var repo = new RepositorioDeRoles(maper);

            _vista.Roles = repo.BuscarConFiltros("",true);

            _modoPosicionar = modo;

            List<string> listaTipo = new List<string>();
            listaTipo.Add("Clientes");
            listaTipo.Add("Proveedores");
            _vista.Tipos = listaTipo;

            if (_modoPosicionar == ModoAltaCuenta.DesdeListado)
            {
                _vista.TextoPantalla("Alta de usuarios administrativos");
                _vista.PantallaAdministrativo();
            }
        }



        public void IniciarVista()
        {
            
        }


        /// <summary>
        /// validaciones para guardar
        /// </summary>
        /// <returns></returns>
        public bool ValidarGuardar()
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                if (_vista.Contrasenia != _vista.Contrasenia2)
                    sb.AppendLine("las contraseñas deben ser iguales");

                if (_vista.Contrasenia == null || _vista.Contrasenia2 == null)
                    sb.AppendLine("la contraseña y su repetición no deben ser nulas");

                //valido usuario existente
                if (_vista.Nombre == "")
                    sb.AppendLine("Debe ingresar un nombre de usuario");
                else
                {
                    var maper = new MaperDeUsuarios();
                    var repo = new RepositorioDeUsuarios(maper);
                    Usuario usuario = repo.ObtenerPorNombre(_vista.Nombre);
                    if (usuario != null)
                        sb.AppendLine("El nombre de usuario ya fue utilizado anteriormente");
                }
                //validaciones propias de cliente y proveedor
                if (this._modoPosicionar == ModoAltaCuenta.DesdeLogIn)
                {
                    if (_vista.TipoSeleccionado == "Clientes")
                    {
                        if(_vista.NombreCliente == "")
                            sb.AppendLine("Debe ingresar un Nombre para el Cliente");
                        if (_vista.ApellidoCliente == "")
                            sb.AppendLine("Debe ingresar un apellido para el Cliente");
                        if (_vista.DNICliente == 0)
                            sb.AppendLine("Debe ingresar un DNI para el Cliente");
                        if (_vista.FechaCliente == null)
                            sb.AppendLine("Debe ingresar la fecha de nacimiento del Cliente");
                        if (_vista.TelCliente == "")
                            sb.AppendLine("Debe ingresar un teléfono para el Cliente");
                        if (_vista.Calle_Dir == "")
                            sb.AppendLine("Debe ingresar una calle para el Cliente");
                        
                    }
                    else
                    {
                        if (_vista.RazonSocial == "")
                            sb.AppendLine("Debe ingresar la Razon social del proveedor");
                        if (_vista.Rubro_Prov == "")
                            sb.AppendLine("Debe ingresar un Rubro para el proveedor");
                        if (_vista.Cuit_Prov == "")
                            sb.AppendLine("Debe ingresar un CUIT para el proveedor");
                        if (_vista.Nom_Contacto_Prov == "")
                            sb.AppendLine("Debe ingresar un contacto para el proveedor");
                        if (_vista.Telefono_Prov == "")
                            sb.AppendLine("Debe ingresar un teléfono para el proveedor");
                        if (_vista.Calle_Dir == "")
                            sb.AppendLine("Debe ingresar una calle para el proveedor");
                    }
                }


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

        /// <summary>
        /// guardado
        /// </summary>
        /// <returns></returns>
        public bool Guardar()
        {
            if (!this.ValidarGuardar())
                return false;

            try
            {
                ObtenerUsuarioDesdeVista();
                //mando a guardar            
                var maper = new MaperDeUsuarios();
                var repo = new RepositorioDeUsuarios(maper);

                repo.Guardar(usuarioAGuardar, clienteAGuardar, proveedorAGuardar);

                _vista.MostrarMensaje("Cuenta creada con éxito.");
                return true;
            }
            catch (Exception ex)
            {
                _vista.MostrarMensaje(string.Format("Se produjo una excepción al crear el nuevo usuario: {0}", ex.Message));
                return false;
            }
        }

        private Usuario usuarioAGuardar;
        private Cliente clienteAGuardar;
        private Proveedor proveedorAGuardar;

        private void ObtenerUsuarioDesdeVista()
        {
            usuarioAGuardar = new Usuario();
            usuarioAGuardar.Usuario_Cuenta = _vista.Nombre;
            usuarioAGuardar.Contra_Cuenta = _vista.Contrasenia;
            usuarioAGuardar.Estado_Cuenta = EstadosUsuario.activo;
            usuarioAGuardar.Cant_Ingresos_Cuenta = 0;
            foreach (Rol r in _vista.RolesSeleccionados)
                usuarioAGuardar.AgregarRol(r);

            //obtengo clientes y proveedores para modificar
            if (this._modoPosicionar == ModoAltaCuenta.DesdeLogIn)
            {
                if (_vista.TipoSeleccionado == "Clientes")
                {
                    proveedorAGuardar = null;
                    clienteAGuardar = new Cliente();
                    clienteAGuardar.Nombre_Clie = _vista.NombreCliente;
                    clienteAGuardar.Apellido_Clie = _vista.ApellidoCliente;
                    clienteAGuardar.DNI_Clie = _vista.DNICliente;
                    clienteAGuardar.Mail_Clie = _vista.MailCliente;
                    clienteAGuardar.Tel_Clie = _vista.TelCliente;
                    clienteAGuardar.Fecha_Nac_Clie = _vista.FechaCliente;
                    Domicilio dir = new Domicilio();
                    dir.Tipo_Objeto = 1;
                    dir.Numero_Dir = _vista.Numero_Dir;
                    dir.Piso_Dir = _vista.Piso_Dir;
                    dir.Depto_Dir = _vista.Depto_Dir;
                    dir.Localidad_Dir = _vista.Localidad_Dir;
                    dir.Ciudad_Dir = _vista.Ciudad_Dir;
                    dir.Calle_Dir = _vista.Calle_Dir;
                    dir.Codigo_Postal_Dir = _vista.Codigo_Postal_Dir;
                    clienteAGuardar.Direccion = dir;
                    
                }
                else
                {
                    clienteAGuardar = null;
                    proveedorAGuardar = new Proveedor();
                    proveedorAGuardar.Razon_Social_Prov = _vista.RazonSocial;
                    proveedorAGuardar.Mail_Proveedor = _vista.Mail_Proveedor;
                    proveedorAGuardar.Telefono_Prov  = _vista.Telefono_Prov;
                    proveedorAGuardar.Cuit_Prov  = _vista.Cuit_Prov;
                    proveedorAGuardar.Rubro_Prov  = _vista.Rubro_Prov;
                    proveedorAGuardar.Nom_Contacto_Prov  = _vista.Nom_Contacto_Prov;
                    Domicilio dir = new Domicilio();
                    dir.Tipo_Objeto = 2;
                    dir.Numero_Dir = _vista.Numero_Dir;
                    dir.Piso_Dir = _vista.Piso_Dir;
                    dir.Depto_Dir = _vista.Depto_Dir;
                    dir.Localidad_Dir = _vista.Localidad_Dir;
                    dir.Ciudad_Dir = _vista.Ciudad_Dir;
                    dir.Calle_Dir = _vista.Calle_Dir;
                    dir.Codigo_Postal_Dir = _vista.Codigo_Postal_Dir;
                    proveedorAGuardar.Direccion = dir;
                }
            }
        }

        public void CambioTipo()
        {
            if (this._modoPosicionar != ModoAltaCuenta.DesdeListado)
                _vista.MostrarPantallaAdicionalClienteOProveedor(_vista.TipoSeleccionado == "Clientes");

        }
    }
}
