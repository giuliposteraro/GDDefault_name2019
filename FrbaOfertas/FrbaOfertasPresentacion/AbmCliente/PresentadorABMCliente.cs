using Negocio.Entidades;
using Negocio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertasPresentacion.AbmCliente
{
    public class PresentadorABMCliente
    {
        private readonly IVistaABMCliente _vista;

        public PresentadorABMCliente(IVistaABMCliente vista)
        {
            _vista = vista;
            
        }

        public void Posicionar(bases.ModosDeEjecucion modosDeEjecucion, Negocio.Entidades.Cliente cliente)
        {
            modo = modosDeEjecucion;
            clienteAGuardar = cliente;

            if (modo == bases.ModosDeEjecucion.Baja)
            {
                _vista.BloquearPantalla();
                _vista.Texto = "Baja de clientes";
            }
            else if (modo == bases.ModosDeEjecucion.Modificacion)
                _vista.Texto = "Modificación de clientes";
            else
                _vista.Texto = "Alta de clientes";

            if (cliente != null)
            {
                _vista.NombreCliente = cliente.Nombre_Clie;
                _vista.ApellidoCliente = cliente.Apellido_Clie;
                _vista.DNICliente = cliente.DNI_Clie;
                _vista.MailCliente = cliente.Mail_Clie;
                _vista.TelCliente = cliente.Tel_Clie;
                _vista.FechaCliente = cliente.Fecha_Nac_Clie;
                _vista.Numero_Dir = cliente.Direccion.Numero_Dir;
                _vista.Piso_Dir = cliente.Direccion.Piso_Dir;
                _vista.Depto_Dir = cliente.Direccion.Depto_Dir;
                _vista.Localidad_Dir = cliente.Direccion.Localidad_Dir;
                _vista.Ciudad_Dir = cliente.Direccion.Ciudad_Dir;
                _vista.Calle_Dir = cliente.Direccion.Calle_Dir;
                _vista.Codigo_Postal_Dir = cliente.Direccion.Codigo_Postal_Dir;
            }

            if (clienteAGuardar == null)
            {
                clienteAGuardar = new Cliente();
                Domicilio dir = new Domicilio();
                clienteAGuardar.Direccion = dir;
            }
        }

        private bases.ModosDeEjecucion modo { get; set; }

        public bool ValidarGuardar()
        {
            try
            {
                var maper = new MaperDeClientes();
                var repo = new RepositorioDeClientes(maper);

                StringBuilder sb = new StringBuilder();

                if (modo == bases.ModosDeEjecucion.Modificacion && !clienteAGuardar.Habilitado)
                    sb.AppendLine("No se puede editar un cliente inhabilitado");


                if (_vista.NombreCliente == "")
                    sb.AppendLine("Debe ingresar un Nombre para el Cliente");
                if (_vista.ApellidoCliente == "")
                    sb.AppendLine("Debe ingresar un apellido para el Cliente");
                if (_vista.DNICliente == 0)
                    sb.AppendLine("Debe ingresar un DNI para el Cliente");
                else
                {
                    List<Cliente> clie = repo.BuscarConFiltros(null, null,_vista.DNICliente,null, 0);
                    if (clie.Where(x => x.Id_Cliente != clienteAGuardar.Id_Cliente).Any())
                        sb.AppendLine("Ya existe un cliente con el mismo DNI");
                }
                if (_vista.FechaCliente == null)
                    sb.AppendLine("Debe ingresar la fecha de nacimiento del Cliente");
                if (_vista.TelCliente == "")
                    sb.AppendLine("Debe ingresar un teléfono para el Cliente");
                if (_vista.Calle_Dir == "")
                    sb.AppendLine("Debe ingresar una calle para el Cliente");
                if (sb.Length > 0)
                {
                    _vista.MostrarMensaje(sb.ToString());
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                _vista.MostrarMensaje(string.Format("Se produjo una excepción al validar el nuevo cliente: {0}", ex.Message));
                return false;
            }
        }

        public bool Guardar()
        {
            if (!this.ValidarGuardar())
                return false;

            try
            {
                ObtenerClienteDesdeVista();
                //mando a guardar            
                var maper = new MaperDeClientes();
                var repo = new RepositorioDeClientes(maper);

                if (modo == bases.ModosDeEjecucion.Baja)
                {
                    clienteAGuardar.Habilitado = false;
                    List<string> propertiesAActualizar = new List<string> { ("Habilitado") };
                    repo.ActualizarEntidad(clienteAGuardar, propertiesAActualizar, "Id_Cliente");
                }
                else if (modo == bases.ModosDeEjecucion.Modificacion)
                {
                    repo.Modificar(clienteAGuardar);
                }
                else
                    repo.Agregar(clienteAGuardar);

                _vista.MostrarMensaje(string.Format("{0} realizada con éxito.",modo));
                return true;
            }
            catch (Exception ex)
            {
                _vista.MostrarMensaje(string.Format("Se produjo una excepción al realizar la operación sobre el cliente: {0}", ex.Message));
                return false;
            }
        }

        private Cliente clienteAGuardar;
        private void ObtenerClienteDesdeVista()
        {
            clienteAGuardar.Nombre_Clie = _vista.NombreCliente;
            clienteAGuardar.Apellido_Clie = _vista.ApellidoCliente;
            clienteAGuardar.DNI_Clie = _vista.DNICliente;
            clienteAGuardar.Mail_Clie = _vista.MailCliente;
            clienteAGuardar.Tel_Clie = _vista.TelCliente;
            clienteAGuardar.Fecha_Nac_Clie = _vista.FechaCliente;
            clienteAGuardar.Direccion.Tipo_Objeto = 1;
            clienteAGuardar.Direccion.Numero_Dir = _vista.Numero_Dir;
            clienteAGuardar.Direccion.Piso_Dir = _vista.Piso_Dir;
            clienteAGuardar.Direccion.Depto_Dir = _vista.Depto_Dir;
            clienteAGuardar.Direccion.Localidad_Dir = _vista.Localidad_Dir;
            clienteAGuardar.Direccion.Ciudad_Dir = _vista.Ciudad_Dir;
            clienteAGuardar.Direccion.Calle_Dir = _vista.Calle_Dir;
            clienteAGuardar.Direccion.Codigo_Postal_Dir = _vista.Codigo_Postal_Dir;
        }
    }
}
