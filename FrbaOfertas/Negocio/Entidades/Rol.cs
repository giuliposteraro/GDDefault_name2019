using Negocio.Base;
using Negocio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Entidades
{
    [Serializable]
    public class Rol : EntidadBase
    {

        public int Id_Rol { get; set; }
	    public string Nombre_rol{get; set;}
        public bool Estado_rol { get; set; }

        public override int ID
        {
            get
            {
                return Id_Rol;
            }
        }

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
            _funcionalidades = new List<Funcionalidad>();
        }


        public string Funcionalidades
        {
            get
            {
                string fun = "";
                foreach (Funcionalidad f in FuncionalidadesDelRol)
                {
                    fun = fun + ", " + f.Detalle_func;
                }
                if (fun.Length > 0)
                    return fun.Substring(2);

                return fun;
            }
        }

        public string EstadoComoString
        {
            get
            {
                if (Estado_rol)
                    return "Habilitado";
                else
                    return "Deshabilitado";
            }
        }

        public override bool Equals(object obj)
        {
            //Verifico que sea del mismo tipo
            if (obj.GetType() != this.GetType()) return false;

            //Valido que el objeto no sea null
            if (ReferenceEquals(null, obj)) return false;

            //Verifico si el objeto actual es igual al que recibo por parámetro
            if (this.Id_Rol != ((Rol)obj).Id_Rol) return false;

            return true;
        }

    }
}
