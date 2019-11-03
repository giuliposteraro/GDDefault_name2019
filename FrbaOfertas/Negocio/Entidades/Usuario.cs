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
    public class Usuario : EntidadBase
    {
        public int Cant_Ingresos_Cuenta { get;  set; }
        public string Contra_Cuenta { get; set; }
        public EstadosUsuario Estado_Cuenta { get; set; }
        public int Id_Usuario { get; set; }
        public string Usuario_Cuenta { get; set; }
        
        public override int ID
        {
            get
            {
                return Id_Usuario;
            }
        }

        #region roles
        private List<Rol> _roles;

        public List<Rol> RolDelUsuario
        {
            get
            {
                if (_roles == null)
                    RecargarRoles();
                return _roles;
            }
        }

        //agrega una rol si no esta en la lista
        public void AgregarRol(Rol func)
        {
            if (_roles == null) _roles = new List<Rol>();

            if (!_roles.Contains(func)) _roles.Add(func);
        }

        //elimina el rol si esta en la lista
        public void EliminarRol(Rol func)
        {
            if (_roles == null) return;

            if (_roles.Contains(func)) _roles.Remove(func);
        }

        //limpia el listado de roles
        public void LimpiarRoles()
        {
            _roles = null;
        }
        #endregion

        /// <summary>
        /// llena los roles con lo que existe en base de datos.
        /// </summary>
        public void RecargarRoles()
        {
            var maper = new MaperDeRoles();
            var repo = new RepositorioDeRoles(maper);
            _roles = repo.ObtenerPorIdUsuario(this.Id_Usuario);
        }
    }

    public enum EstadosUsuario
    {
        desactivo = 0,
        activo = 1
    }
}
