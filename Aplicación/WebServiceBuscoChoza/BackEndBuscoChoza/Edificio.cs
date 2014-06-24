//
//  @ Proyecto : 	Busco Choza
//  @ Archivo : 	Edificio.cs
//  @ Clase : 	Edificio

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEndBuscoChoza
{
    public class Edificio:Instalacion
    {
        private string nombre;
        private Piso[] listaPisos;

        public string getNombre()
        {
            return nombre;
        }
        public Piso[] getListaPisos()
        {
            return listaPisos;
        }
        public void setNombre()
        {
        }
        public void setPiso()
        {
        }
    }
}