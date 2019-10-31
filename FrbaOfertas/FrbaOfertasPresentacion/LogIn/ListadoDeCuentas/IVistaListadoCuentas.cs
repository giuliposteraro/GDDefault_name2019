using FrbaOfertasPresentacion.bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio.Entidades;

namespace FrbaOfertasPresentacion.LogIn.ListadoDeCuentas
{
    public interface IVistaListadoCuentas : IVistaBase
    {
        string Usuario_Nombre { get; set; }
        bool Activo { get; set; }
        List<Usuario> Usuarios { get; set; }

        void ReloadView();
    }
}
