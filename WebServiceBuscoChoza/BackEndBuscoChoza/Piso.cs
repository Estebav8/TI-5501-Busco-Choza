//
//  @ Proyecto : 	Busco Choza
//  @ Archivo : 	Piso.cs
//  @ Clase : 	Piso

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEndBuscoChoza
{
    public class Piso
    {
        private int numeroPiso;
        private Apartamento[] listaApartamentos;
        private Oficina[] listaOficinas;

        public int getNumeroPiso()
        {
            return numeroPiso;
        }
        public Apartamento[] getlistaApartamentos()
        {
            return listaApartamentos;
        }
        public Oficina[] getlistaOficinas()
        {
            return listaOficinas;
        }
        public void setNumeroPiso()
        {
        }
        public void setApartamento()
        {
        }
        public void setOficina()
        {
        }
    }
}