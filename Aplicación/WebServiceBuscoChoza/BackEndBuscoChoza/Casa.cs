//
//  @ Proyecto : 	Busco Choza
//  @ Archivo : 	Casa.cs
//  @ Clase : 	Casa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEndBuscoChoza
{
    public class Casa:Instalacion
    {
        private bool piscina;
        private bool balcon;
        private bool jardin;
        public bool getPiscina()
        {
            return piscina;
        }
        public bool getBalcon()
        {
            return balcon;
        }
        public bool getJardin()
        {
            return jardin;
        }
        public void setPiscinas()
        {
        }
        public void setBalcon()
        {
        }
        public void setJardin()
        {
        }
    }
}