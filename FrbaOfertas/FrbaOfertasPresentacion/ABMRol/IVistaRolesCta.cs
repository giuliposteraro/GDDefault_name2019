using FrbaOfertasPresentacion.bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertasPresentacion.ABMRol
{
    public interface IVistaRolesCta : IVistaBase
    {
        List<Negocio.Entidades.Rol> RolesSelccionados { get; set; }
        List<Negocio.Entidades.Rol> RolesPosibles { get; set; }
        string Nombre { get; set; }

    }
}
