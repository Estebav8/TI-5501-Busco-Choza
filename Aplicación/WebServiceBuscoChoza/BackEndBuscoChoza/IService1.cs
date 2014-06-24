using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace BackEndBuscoChoza
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1 
    {

        [OperationContract]
        string Hola(string Parametro);
        //List<Lugares> GetDataUsingDataContract();

        // TODO: agregue aquí sus operaciones de servicio
        [OperationContract]
        bool Loguear(string _correo, string _password);

        [OperationContract]
        bool Registrar(string _nombre, string _correo, string _password, int _telefono, string _direccion);

        [OperationContract]
        List<Busqueda> Buscar();

        [OperationContract]
        List<Usuario> BuscarUsuarios();

        [OperationContract]
        List<List<string>> BuscarVenta(int _tipoPublicacion, int _tipoPropiedad, string _provincia, string _canton, string _distrito);

        [OperationContract]
        DataTable Provincias();

        [OperationContract]
        DataTable Cantones(string _provincia);

        [OperationContract]
        DataTable Distritos(string _provincia, string _cantones);

    }


    //Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class Busqueda
    {
        [DataMember]
        public int ID_USUARIO;
        [DataMember]
        public string NOMBRE;
        [DataMember]
        public string CORREO;
        [DataMember]
        public string CONTRASENA;
        [DataMember]
        public int TELEFONO;
        [DataMember]
        public string DIRECCION;
        //[DataMember]
        //public string NombreProvicia;
        
    }
}
