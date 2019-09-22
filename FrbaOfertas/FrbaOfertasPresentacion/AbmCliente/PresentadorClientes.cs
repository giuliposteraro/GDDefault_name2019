﻿using Negocio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertasPresentacion.AbmCliente
{
    public class PresentadorClientes
    {
        private readonly IVistaClientes _vista;

        public PresentadorClientes(IVistaClientes vista)
        {
            _vista = vista;
            
        }
        public void IniciarVista()
        {
          

        }
        public void ActualizarVista()
        {

        }

        public void Buscar()
        {
            //buscador 
            var maper = new MaperDeClientes();
            var repo = new RepositorioDeClientes(maper);

            _vista.Clientes = repo.Buscar();
            
        }

        public void BuscarConFiltros()
        {
            var maper = new MaperDeClientes();
            var repo = new RepositorioDeClientes(maper);

            _vista.Clientes = repo.BuscarConFiltros(_vista.Nombre, _vista.Apellido);
        }

    }

        
}
