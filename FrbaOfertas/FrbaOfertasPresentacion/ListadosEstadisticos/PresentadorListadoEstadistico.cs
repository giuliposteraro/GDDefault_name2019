using Negocio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertasPresentacion.ListadosEstadisticos
{
    public class PresentadorListadoEstadistico
    {
        private readonly IVistaListadoEstadistico _vista;

        public PresentadorListadoEstadistico(IVistaListadoEstadistico vista)
        {
            _vista = vista;

        }

        public void Posicionar()
        {
            List<string> listaReportes = new List<string>();
            listaReportes.Add("Proveedores con mayor descuento");
            listaReportes.Add("Proveedores con mayor facturacion");
            _vista.Reportes = listaReportes;

            List<string> listaSemestres = new List<string>();
            listaSemestres.Add("1° Semestre");
            listaSemestres.Add("2° Semestre");
            _vista.Semestres = listaSemestres;


        }

        public void generarReporte()
        {
             try
             {
                var maper = new MaperDeProveedores();
                var repo = new RepositorioDeProveedores(maper);

                DateTime fechaDesde;
                DateTime fechaHasta;
                if (_vista.SemestreSeleccionado == "1° Semestre")
                {
                    fechaDesde = new DateTime(_vista.Anio, 1, 1);
                    fechaHasta = new DateTime(_vista.Anio, 6, 30);
                }
                else
                {
                    fechaDesde = new DateTime(_vista.Anio, 7, 1);
                    fechaHasta = new DateTime(_vista.Anio, 12, 31);
                }

                if (_vista.ReporteSeleccionado == "Proveedores con mayor descuento")
                {
                    _vista.Datos = repo.ObtenerReporteDescuentos(fechaDesde,fechaHasta);

                }
                else if (_vista.ReporteSeleccionado == "Proveedores con mayor facturacion")
                {
                    _vista.Datos = repo.ObtenerReporteFacturacion(fechaDesde, fechaHasta);
                }
                else
                {
                    _vista.MostrarMensaje("El reporte seleccionado no es disponible");
                }

            }
            catch (Exception ex)
            {
                _vista.MostrarMensaje(string.Format("Se produjo una excepción al generar los reportes: {0}", ex.Message));
            }
        }
    }
}
