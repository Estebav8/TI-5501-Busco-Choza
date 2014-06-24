using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//
//  @ Proyecto : 	Busco Choza
//  @ Archivo : 	Publicacion.cs
//  @ Clase : 	Publicacion
namespace BackEndBuscoChoza
{
    public abstract class Publicacion
    {
        private string fechaPublicacion;
        private bool estado;

        public bool getEstado()
        {
            return true;
        }
        public string getFechaPublicacion()
        {
            return "";
        }
        public void setEstado()
        {
        }
        public void setFechaPublicacion()
        {
        }
        public void agregarUsuario()
        {
        }
        public void notificarUsuarios()
        {
        }
    }
}