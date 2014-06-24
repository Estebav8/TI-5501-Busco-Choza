using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace BackEndBuscoChoza
{
    public class ConexionSQL
    {
        private string cadenaConexionSQL;
        private ConexionSQL _ConexionSQL;
        private SqlConnection _SqlConnection;


        private ConexionSQL()
        {
            cadenaConexionSQL = "Server=tcp:aumy4ug2ib.database.windows.net,1433;Database=BD_BuscoChoza;User ID=AdminBuscoChoza@aumy4ug2ib;Password=BuscoChoza2014;Trusted_Connection=False;Encrypt=True;Connection Timeout=30";
            SqlConnection _SqlConnection = new SqlConnection();
            _SqlConnection.ConnectionString = cadenaConexionSQL;
        }

        public ConexionSQL getConexion()
        {
            if (_ConexionSQL == null)
            {
                _ConexionSQL = new ConexionSQL();
            }
            return _ConexionSQL;
        }

        //public void Prueba()
        //{
        //    System.Data.SqlClient.SqlCommand _SqlCommand = new System.Data.SqlClient.SqlCommand("Select * From Provincia", this.getConexion()._SqlConnection);

        //    System.Data.SqlClient.SqlDataAdapter _SqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter();
        //    _SqlDataAdapter.SelectCommand = _SqlCommand;

        //    DataTable _DataTable = new DataTable();
        //    _DataTable.Locale = System.Globalization.CultureInfo.InvariantCulture;

        //    _SqlDataAdapter.Fill(_DataTable);
        //    //GridView1.DataSource = _DataTable;
        //   // GridView1.DataBind();
        //}
    }
}