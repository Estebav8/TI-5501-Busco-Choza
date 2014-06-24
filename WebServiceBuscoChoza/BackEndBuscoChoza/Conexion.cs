using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
//
//  @ Proyecto : 	Busco Choza
//  @ Archivo : 	Conexion.cs
//  @ Clase : 	    Conexion

namespace BackEndBuscoChoza
{
    public class Conexion
    {
        private string conect = "Server=tcp:aumy4ug2ib.database.windows.net,1433;Database=BD_BuscoChoza;User ID=AdminBuscoChoza@aumy4ug2ib;Password=BuscoChoza2014;Trusted_Connection=False;Encrypt=True;Connection Timeout=30";
        private SqlConnection conexion;
        public void abrirConexion()
        {
            SqlConnection con = new SqlConnection(conect);
            con.Open();
        }

        public void cerrarConexion()
        {
            SqlConnection con = new SqlConnection(conect);
            con.Close();
        }
        //public abstract bool ejecutarInsercion();

        //public abstract bool ejecutarEliminacion();

        public int LoginBuscoChoza(string correo, string contrasena)
        {
            //asigna los datos
            try
            {
                using (SqlConnection connection = new SqlConnection(conect))
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        connection.Open();
                        command.Connection = connection;
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.CommandText = "SP_Login_Usuario";
                        command.CommandTimeout = 10;
                        command.Parameters.Add(new SqlParameter("@funcionareturn", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.ReturnValue, false, 0, 32, "ret", System.Data.DataRowVersion.Default, null));
                        command.Parameters.AddWithValue("@CORREO", correo);
                        command.Parameters.AddWithValue("@CONTRASENA", contrasena);
                        int rows = command.ExecuteNonQuery();
                        int j = (int)command.Parameters["@funcionareturn"].Value;
                        connection.Close();
                        return j;
                    }
                }
            }
            catch (SqlException)
            {
                return -1;
            }
        }
        public int RegistroBuscoChoza(string nombre, string correo, string contrasena, int telefono, string direccion)
        {
            //asigna los datos
            try
            {
                using (SqlConnection connection = new SqlConnection(conect))
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        connection.Open();
                        command.Connection = connection;
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.CommandText = "SP_INSERT_USUARIO";
                        command.CommandTimeout = 10;
                        command.Parameters.Add(new SqlParameter("@VALIDACION", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.ReturnValue, false, 0, 32, "ret", System.Data.DataRowVersion.Default, null));
                        command.Parameters.AddWithValue("@NOMBRE", nombre);
                        command.Parameters.AddWithValue("@CORREO", correo);
                        command.Parameters.AddWithValue("@CONTRASENA", contrasena);
                        command.Parameters.AddWithValue("@TELEFONO", telefono);
                        command.Parameters.AddWithValue("@DIRECCION", direccion);
                        int rows = command.ExecuteNonQuery();
                        int j = (int)command.Parameters["@VALIDACION"].Value;
                        connection.Close();
                        return j;
                    }
                }
            }
            catch (SqlException)
            {
                return -1;
            }
        }

        public List<Usuario> BuscarUsuarioBuscoChoza()
        {
            //asigna los datos
            
                List<Usuario> resultado = new List<Usuario>();
                using (SqlConnection connection = new SqlConnection(conect))
                {
                    using (SqlCommand command = new SqlCommand("Select * From USUARIO",connection))
                    {
                        connection.Open();
                        SqlDataReader lector_usuarios = command.ExecuteReader();
                        while(lector_usuarios.Read())
                        {
                            Usuario usuario_temp = new Usuario();
                            usuario_temp.setNombre(lector_usuarios[1].ToString());
                            usuario_temp.setCorreo(lector_usuarios[2].ToString());
                            usuario_temp.setPassword(lector_usuarios[3].ToString());
                            usuario_temp.setTelefono(Int32.Parse(lector_usuarios[4].ToString()));
                            usuario_temp.setDireccion(lector_usuarios[5].ToString());
                            resultado.Add(usuario_temp);
                        }
                        connection.Close();
                    }
                }
                return resultado.ToList();

        }
        /* *
         * Parametros:
         * *tipoPublicacion = 1:Vender, 2:Alquilar, 3:Ambas
         * *tipoPropiedad   = 0:Casa, 1:Apartamento, 2:Oficina
         * *provincia       = string
         * *canton          = string
         * *ditrito         = string
         * */
        public List<List<string>> BuscarPropiedad(int tipoPublicacion, int tipoPropiedad, string provincia, string canton, string distrito)
        {
            List<List<string>> resultado = new List<List<string>>();
            using (SqlConnection connection = new SqlConnection(conect))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandText = "SP_BUSCAR";
                    command.CommandTimeout = 10;
                    command.Parameters.AddWithValue("@TIPOPUBLICAR", tipoPublicacion);
                    command.Parameters.AddWithValue("@TIPOPROPIEDAD", tipoPropiedad);
                    command.Parameters.AddWithValue("@NOMBREPROVINCIA", provincia);
                    command.Parameters.AddWithValue("@NOMBRECANTON", canton);
                    command.Parameters.AddWithValue("@NOMBREDISTRITO", distrito);

                    SqlDataReader lector_resultado = command.ExecuteReader();
                    
                    while (lector_resultado.Read())
                    {
                        List<string> fila = new List<string>();
                        fila.Add(lector_resultado[0].ToString());//Codigo
                        fila.Add(lector_resultado[1].ToString());//Tipo propiedad
                        fila.Add(provincia+", "+canton+", "+distrito);//Ubicacion
                        fila.Add(lector_resultado[3].ToString());//Construccion
                        fila.Add(lector_resultado[4].ToString());//Terreno
                        if (lector_resultado[5].ToString().ToUpper() == "TRUE")
                        {
                            fila.Add("SI");//Balcon
                        }
                        else
                            fila.Add("NO");//Balcon
                        if (lector_resultado[6].ToString().ToUpper() == "TRUE")
                        {
                            fila.Add("SI");//Jardin
                        }
                        else
                            fila.Add("NO");//Jardin
                        if (lector_resultado[7].ToString().ToUpper() == "TRUE")
                        {
                            fila.Add("SI");//Piscina
                        }
                        else
                            fila.Add("NO");//Piscina
                        fila.Add(lector_resultado[8].ToString());//Precio
                        fila.Add(lector_resultado[2].ToString());//Descripcion
                        fila.Add(lector_resultado[11].ToString());//Nombre
                        fila.Add(lector_resultado[12].ToString());//Correo
                        fila.Add(lector_resultado[13].ToString());//Telefono
                        fila.Add(lector_resultado[9].ToString());//Latitud
                        fila.Add(lector_resultado[10].ToString());//Longitud
                        resultado.Add(fila);
                    }
                    connection.Close();
                }
            }
            return resultado.ToList();
            
        }
        /* Metodo para obtener provincias
         * */
        public DataTable Provincias()
        {
            try
            {
                DataTable resultado = new DataTable();
                using (SqlConnection connection = new SqlConnection(conect))
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        connection.Open();
                        command.Connection = connection;
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.CommandText = "SP_LLENARPROVINCIA";
                        command.CommandTimeout = 10;
                        SqlDataAdapter adaptador = new SqlDataAdapter(command);
                        adaptador.Fill(resultado);
                    }
                }
                return resultado;
            }
            catch (SqlException e)
            {
                DataTable resultado = new DataTable();
                return resultado;
            }
        }
        /*Metodo para obtener cantones
         * */
        public DataTable Cantones(string provincia)
        {
            try
            {
                DataTable resultado = new DataTable();
                using (SqlConnection connection = new SqlConnection(conect))
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        connection.Open();
                        command.Connection = connection;
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.CommandText = "SP_LLENARCANTON";
                        command.CommandTimeout = 10;
                        command.Parameters.AddWithValue("@PROVINCIA", provincia);
                        SqlDataAdapter adaptador = new SqlDataAdapter(command);
                        adaptador.Fill(resultado);
                    }
                }
                return resultado;
            }
            catch (SqlException e)
            {
                DataTable resultado = new DataTable();
                return resultado;
            }
        }
        /* Metodo para obtener cantones
         * */
        public DataTable Distritos( string provincia, string canton)
        {
            try
            {
                DataTable resultado = new DataTable();
                using (SqlConnection connection = new SqlConnection(conect))
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        connection.Open();
                        command.Connection = connection;
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.CommandText = "SP_LLENARDISTRITO";
                        command.CommandTimeout = 10;
                        command.Parameters.AddWithValue("@CANTON", canton);
                        command.Parameters.AddWithValue("@PROVINCIA", provincia);
                        SqlDataAdapter adaptador = new SqlDataAdapter(command);
                        adaptador.Fill(resultado);
                    }
                }
                return resultado;
            }
            catch (SqlException e)
            {
                DataTable resultado = new DataTable();
                return resultado;
            }
        }
    }
}