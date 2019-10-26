using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Gestores
{
    public class GestorDeValidacionDePermisos
    {

        public bool TienePermisoPara(Funcionalidad func)
        {
            //si alguno de las funcionalidades de alguno de los roles del usuario es la funcionalidad que quiero validar devuelvo true
            return (from rol in Negocio.Base.Global.SessionUsuario.RolDelUsuario
                    from fun in rol.FuncionalidadesDelRol
                    where func.Id_Funcionalidad == fun.Id_Funcionalidad
                    select fun).Any();
            
        }
    }
}
