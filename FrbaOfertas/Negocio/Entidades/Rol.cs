using Negocio.Base;
using Negocio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Entidades
{
    public class Rol : EntidadBase
    {

        public int Id_Rol { get; set; }
	    public string Nombre_rol{get; set;}
	    public bool Estado_rol{get; set;}

        private List<Funcionalidad> _funcionalidades;

        public List<Funcionalidad> FuncionalidadesDelRol
        {
            get
            {
                if (_funcionalidades == null)
                {
                    var maper = new MaperDeFuncionalidades();
                    var repo = new RepositorioDeFuncionalidades(maper);
                    _funcionalidades = repo.ObtenerPorIdRol(this.Id_Rol);
                }
                return _funcionalidades;
            }
        }

        //agrega una funcionalidad si 
        public void AgregarFuncionalidad(Funcionalidad func)
        {
            if (_funcionalidades == null) _funcionalidades = new List<Funcionalidad>();

            if (!_funcionalidades.Contains(func)) _funcionalidades.Add(func);
        }

        public void EliminarFuncionalidad(Funcionalidad func)
        {
            if (_funcionalidades == null) return;

            if (_funcionalidades.Contains(func)) _funcionalidades.Remove(func);
        }

        //limpia el listado de funcionalidades
        public void LimpiarFuncionalidades()
        {
            _funcionalidades = null;
        }
    }
}
