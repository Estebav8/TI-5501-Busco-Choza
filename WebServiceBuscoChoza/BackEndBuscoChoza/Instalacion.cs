//
//  @ Proyecto : 	Busco Choza
//  @ Archivo : 	Instalacion.cs
//  @ Clase : 	Instalacion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEndBuscoChoza
{
    public class Instalacion
    {
        private float latitud;
        private float longitud;
        private string descripcion;
        private int mtsConstruccion;
        private int mtsTerreno;
        private int bannos;
        private int habitaciones;
        private bool estacionamiento;
        public float getLatitud()
        {
            return latitud;
        }
        public float getLongitud()
        {
            return longitud;
        }
        public string getDescripcion()
        {
            return descripcion;
        }
        public int getMtsConstruccion()
        {
            return mtsConstruccion;
        }
        public int getMtsTerreno()
        {
            return mtsTerreno;
        }
        public int getBannos()
        {
            return bannos;
        }
        public int getHabitaciones()
        {
            return habitaciones;
        }
        public bool getEstacionamiento()
        {
            return estacionamiento;
        }
        public void setLatitud()
        {
        }
        public void setLongitud()
        {
        }
        public void setDescripcion()
        {
        }
        public void setMtsConstruccion()
        {
        }
        public void setMtsTerreno()
        {
        }
        public void serBannos()
        {
        }
        public void setHabitaciones()
        {
        }
        public void setEstacionaiento()
        {
        }
    }
}