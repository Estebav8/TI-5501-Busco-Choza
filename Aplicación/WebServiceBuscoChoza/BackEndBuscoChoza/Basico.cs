using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BackEndBuscoChoza;
//
//  @ Proyecto : 	Busco Choza
//  @ Archivo : 	Basico.cs
//  @ Clase : 	Basico
namespace BackEndBuscoChoza
{
    public class Basico : Usuario
    {
        public Venta[] listaVentas;
        public Alquiler[] listaAlquileres;
        public Venta[] listaVentasFavoritas;
        public Alquiler[] listaAlquileresFavoritos;

        Basico() { }

        public void publicar()
        {
        }
        public Venta[] consultarVentasFavoritos()
        {
            return listaVentasFavoritas;
        }
        public Venta[] consultarVentas()
        {
            return listaVentas;
        }
        public Alquiler[] consultarAlquileresFavoritos()
        {
            return listaAlquileresFavoritos;
        }
        public Alquiler[] consultarAlquileres()
        {
            return listaAlquileres;
        }
    }
}