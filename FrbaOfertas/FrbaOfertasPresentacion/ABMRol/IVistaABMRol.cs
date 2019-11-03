using FrbaOfertasPresentacion.bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertasPresentacion.ABMRol
{
    public interface IVistaABMRol : IVistaBase
    {
        string NombrePagina { get; set; }

        string NombreBoton { get; set; }

        List<Negocio.Entidades.Funcionalidad> FuncionalidadesPosibles { get; set; }

        void BloquearParaELiminar();

        string Nombre { get; set; }

        List<Negocio.Entidades.Funcionalidad> FuncionalidadesSeleccionadas { get; set; }

        
    }
}
