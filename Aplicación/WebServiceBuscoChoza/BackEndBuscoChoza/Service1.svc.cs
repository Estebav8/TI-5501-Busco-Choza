using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using BackEndBuscoChoza;

namespace BackEndBuscoChoza
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {

    //    public List<Lugares> GetDataUsingDataContract()
    //    {
    //        BackEndBuscoChoza.Service1 Contexto;

    //        using (Contexto = new BackEndBuscoChoza.Service1())
    //        {
    //            List<Lugares> Provincias = new List<Lugares>();
    //            foreach(var p in Contexto)
    //            {
    //                Lugares ldata = new Lugares();
    //                ldata.NumeroProvicia = 

                
    //            }
    //            return Provincias;

    //        //}
    //        return new List<Lugares>();
    //    }
        public string Hola(string Parametro) 
        {
            return Parametro + "Si sirvio";
            //logica.hola
        }
        public bool Loguear(string _correo,string _password)
        {
            Usuario u1 = new Usuario(_correo, _password);
            return u1.login();
        }
        public bool Registrar(string _nombre, string _correo, string _password, int _telefono, string _direccion)
        {
            Usuario u1 = new Usuario( _nombre,  _correo,  _password,  _telefono,  _direccion);
            return u1.registra();
        }
        public List<Busqueda> Buscar()
        {
            List<Busqueda> resultado = new List<Busqueda>();

            return resultado;
        }
        public List<Usuario> BuscarUsuarios()
        {
            List<Usuario> t = new List<Usuario>();
            Usuario u1 = new Usuario();
            return t;//u1.buscarVentas();
        }

        public List<List<string>> BuscarVenta(int _tipoPublicacion, int _tipoPropiedad, string _provincia, string _canton, string _distrito)
        {
            Usuario u1 = new Usuario();
            return u1.buscarVentas(_tipoPublicacion, _tipoPropiedad, _provincia, _canton, _distrito);
        }

        public DataTable Provincias()
        {
            Conexion conexion = new Conexion();
            return conexion.Provincias();
        }

        public DataTable Cantones(string _provincia)
        {
            Conexion conexion = new Conexion();
            return conexion.Cantones( _provincia);
        }

        public DataTable Distritos(string _provincia, string _cantones)
        {
            Conexion conexion = new Conexion();
            return conexion.Distritos( _provincia,  _cantones);
        }

    }

}
