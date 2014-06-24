using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//
//  @ Proyecto : 	Busco Choza
//  @ Archivo : 	Administrador.cs
//  @ Clase : 	Administrador
namespace BackEndBuscoChoza
{
    public class Administrador:Usuario
    {
        protected Basico[] listaUsuariosBasicos;
        protected Administrador[] listaUsuariosAdministradores;
        protected Venta[] listaVentas;
        protected Alquiler[] listaAlquileres;

        Administrador() { }

        public void agregarBasico()
        {
        }
        public void agregarAdministrador()
        {
        }
        public void agregarVenta()
        {
        }
        public void agregarAlquiler()
        {
        }
        public void eliminarBasico()
        {
        }
        public void eliminarAdministrador()
        {
        }
        public void eliminarVenta()
        {
        }
        public void eliminarAlquiler()
        {
        }
    }
}