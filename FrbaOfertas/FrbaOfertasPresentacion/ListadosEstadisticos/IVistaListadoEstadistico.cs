using FrbaOfertasPresentacion.bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertasPresentacion.ListadosEstadisticos
{
    public interface IVistaListadoEstadistico : IVistaBase
    {
        List<string> Semestres {  set; }

        List<string> Reportes {  set; }

        int Anio { get; set; }

        string ReporteSeleccionado { get; set; }

        string SemestreSeleccionado { get; set; }

        System.Data.DataTable Datos { get; set; }
    }
}
