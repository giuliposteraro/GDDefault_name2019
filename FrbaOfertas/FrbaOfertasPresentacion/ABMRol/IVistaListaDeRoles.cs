using FrbaOfertasPresentacion.bases;
using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertasPresentacion.ABMRol
{
    public interface IVistaListaDeRoles : IVistaBase
    {
        List<Rol> Roles {get; set;}
        string Nombre { get; set; }
    }
}
