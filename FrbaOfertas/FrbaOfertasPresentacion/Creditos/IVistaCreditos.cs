using FrbaOfertasPresentacion.bases;
using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertasPresentacion.Creditos
{
    public interface IVistaCreditos : IVistaBase
    {

        List<Credito> Creditos { get; set; }
    }
}
