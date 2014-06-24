using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
//
//  @ Proyecto : 	Busco Choza
//  @ Archivo : 	Usuario.cs
//  @ Clase : 	Usuario
namespace BackEndBuscoChoza
{
    public class Usuario
    {
        private string nombre;// pasar a private
        private string password;
        private string correo;// pasar a private
        private int telefono;
        private string direccion;

        public Usuario() { }

        public Usuario(string _correo, string _password)
        {
            correo = _correo;
            password = _password;
        }

        public Usuario(string _nombre, string _correo, string _password, int _telefono, string _direccion) 
        {
            nombre = _nombre;
            correo = _correo;
            password = _password;
            telefono = _telefono;
            direccion = _direccion;


        }

        public string getNombre()
        {
            return nombre;
        }
        public string getPassword()
        {
            return password;
        }
        public string getCorreo()
        {
            return correo;
        }
        public int getTelefono()
        {
            return telefono;
        }
        public string getDireccion()
        {
            return direccion;
        }
        public void setNombre(string _nombre)
        {
            nombre = _nombre;
        }
        public void setPassword(string _password)
        {
            password = _password;
        }
        public void setCorreo(string _correo)
        {
            correo = _correo;
        }
        public void setTelefono(int _telefono)
        {
            telefono = _telefono;
        }
        public void setDireccion(string _direccion)
        {
            direccion = _direccion;
        }
        /* *
         * Metodo de Logueo de Usuarios
         * 
         * */
        public bool login()
        {
            //if (correo == "Bayron" && password == "1234")
            //{
            //    return true;
            //}
            //else
            /**************************************************************************************/
            //try
            //{ 
            //    string validacion = "1";
            //    string conect = "Server=tcp:aumy4ug2ib.database.windows.net,1433;Database=BD_BuscoChoza;User ID=AdminBuscoChoza@aumy4ug2ib;Password=BuscoChoza2014;Trusted_Connection=False;Encrypt=True;Connection Timeout=30";
            //    using (SqlConnection con = new SqlConnection(conect)) { 

            //    SqlCommand cmd = new SqlCommand("SP_LOGIN_USUARIO",con);
            //    cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //    //cmd.CommandText = "SP_LOGIN_USUARIO";

            //    SqlParameter p1 = new SqlParameter();
            //    p1.ParameterName = "@CORREO";
            //    p1.Value = correo;
            //    cmd.Parameters.Add(p1);

            //    SqlParameter p2 = new SqlParameter();
            //    p1.ParameterName = "@CONTRASENA";
            //    p1.Value = password;
            //    cmd.Parameters.Add(p2);

            //    SqlParameter p3 = new SqlParameter("@FUNCIONARETURN", DbType.Int32);
            //    p3.Direction = ParameterDirection.ReturnValue;
            //    cmd.Parameters.Add(p3);

            //    con.Open();
            //    cmd.ExecuteNonQuery();

            //    Console.Write("Antes     " + validacion);
            //    validacion = cmd.Parameters["@FUNCIONARETURN"].Value.ToString();
            //    Console.Write("Despues   " + validacion);
            //    con.Close();

            //    if (validacion == "0")
            //    {
            //        return true;
            //    }
            //    else
            //        return false;


            //    }
            //}catch (Exception)
            //{

            //    throw;
            //}
            /**************************************************************************************/
            Conexion Conexion = new Conexion();
            int funcionareturn;
            funcionareturn = Conexion.LoginBuscoChoza(correo, password);

            if (funcionareturn == 0)
            {
                return true;
            }
            else
                return false;
        }

        public bool registra() 
        {
            Conexion Conexion = new Conexion();
            int funcionareturn;


            funcionareturn = Conexion.RegistroBuscoChoza( nombre,  correo, password, telefono,direccion);

            if (funcionareturn == 0)
            {

                return true;

            }
            else
                return false;
        }
        public List<List<string>> buscarVentas(int _tipoPublicacion, int _tipoPropiedad, string _provincia, string _canton, string _distrito)
        {
            //Cambiarlo
            Conexion Conexion = new Conexion();
            return Conexion.BuscarPropiedad( _tipoPublicacion,  _tipoPropiedad,  _provincia,  _canton,  _distrito);

        }
        public void buscarAlquileres()
        {
        }
        public void actualizar()
        {
        }
        //public override bool ejecutarInsercion()
        //{
        //    return true;
        //}

        //public override bool ejecutarEliminacion()
        //{
        //    return true;
        //}
    }
}