using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontEndBuscoChoza
{
    public partial class Buscar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BackEndBuscoChoza.IService1 client = new BackEndBuscoChoza.Service1();
                foreach (DataRow i in client.Provincias().Rows)
                {
                    ddl_provincia.Items.Add(i.ItemArray[0].ToString());

                }
            }
        }
        protected void btn_buscar_Click(object sender, EventArgs e)
        {
            BackEndBuscoChoza.IService1 client = new BackEndBuscoChoza.Service1();

            //System.Data.SqlClient.SqlConnection _SqlConnection = new System.Data.SqlClient.SqlConnection();
            //_SqlConnection.ConnectionString = "Server=tcp:aumy4ug2ib.database.windows.net,1433;Database=BD_BuscoChoza;User ID=AdminBuscoChoza@aumy4ug2ib;Password=BuscoChoza2014;Trusted_Connection=False;Encrypt=True;Connection Timeout=30";

            //System.Data.SqlClient.SqlCommand _SqlCommand = new System.Data.SqlClient.SqlCommand("Select * From USUARIO", _SqlConnection);

            //System.Data.SqlClient.SqlDataAdapter _SqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter();
            //_SqlDataAdapter.SelectCommand = _SqlCommand;

            //DataTable _DataTable = new DataTable();
            //_DataTable.Locale = System.Globalization.CultureInfo.InvariantCulture;

            //_SqlDataAdapter.Fill(_DataTable);
            int _tipoPublicacion = ddl_tipoPublicacion.SelectedIndex + 1;
            int _tipoPropiedad = ddl_tipoPropiedad.SelectedIndex;
            string _provincia = ddl_provincia.Text;
            string _canton = ddl_canton.Text;
            string _distrito = ddl_distrito.Text;

            lbl_resultadoBusqueda.Text = "Resultado de la busqueda";

            DataTable dtt = new DataTable();

            dtt.Columns.Add("CÓDIGO");
            dtt.Columns.Add("TIPO");
            dtt.Columns.Add("UBICACIÓN");
            dtt.Columns.Add("MTS CONSTRUCCIÓN");
            dtt.Columns.Add("MTS TERRENO");
            dtt.Columns.Add("BALCÓN");
            dtt.Columns.Add("JARDÍN");
            dtt.Columns.Add("PISCINA");
            dtt.Columns.Add("PRECIO VENTA");
            dtt.Columns.Add("DESCRIPCION");

            List<List<string>> busqueda = client.BuscarVenta(_tipoPublicacion, _tipoPropiedad, _provincia, _canton, _distrito).ToList();

            for (int i = 0; i < busqueda.Count; i++)
            {
                object[] filas = new object[10];

                for (int j = 0; j < 10; j++)
                {
                    filas[j] = busqueda[i].ToList()[j];
                }
                //filas[0] = client.BuscarUsuarios().ToList()[i].getNombre();
                //filas[1] = client.BuscarUsuarios().ToList()[i].getCorreo();
                //filas[2] = client.BuscarUsuarios().ToList()[i].getPassword();
                //filas[3] = client.BuscarUsuarios().ToList()[i].getTelefono();
                //filas[4] = client.BuscarUsuarios().ToList()[i].getDireccion();
                
                dtt.Rows.Add(filas);
            }

            //dtg_resultadoBusqueda.Columns.Add();

            dtg_resultadoBusqueda.DataSource = dtt;// client.BuscarUsuarios().ToList();
            dtg_resultadoBusqueda.DataBind();
            //dtg_resultadoBusqueda.Columns.Add("h");
            
            //dtg_resultadoBusqueda.Columns[0].Visible = false;
            //dtg_resultadoBusqueda.Columns[dtg_resultadoBusqueda.Columns["Tres"].inde].Visible = false;
        }
        protected void dtg_resultadoBusqueda_onSelectedIndexChanged(Object sender, EventArgs e)
        {
            GridViewRow row = dtg_resultadoBusqueda.SelectedRow;
            
            List<string> datos = new List<string>();
            String Valor = "";
            for (int i = 0; i < 9; i++)
            {
                datos.Add(row.Cells[i].Text);
                Valor += row.Cells[i].Text+"&";
            }

            Response.Redirect("Resultado.aspx?Valor="+Valor);

            //if (row.Cells[0].Text == "0202")
            //{
            //    Response.Write("<script>alert('Soy Pollo')</script>");
            //}
            //if (row.Cells[0].Text == "123456789")
            //{
            //    Response.Write("<script>alert('Soy Martin')</script>");
            //}
        }

        protected void ddl_provincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            BackEndBuscoChoza.IService1 client = new BackEndBuscoChoza.Service1();
            ddl_canton.Items.Clear();
            foreach (DataRow j in client.Cantones(ddl_provincia.SelectedValue.ToString()).Rows)
            {
                ddl_canton.Items.Add(j.ItemArray[0].ToString());
            }
        }

        protected void ddl_canton_SelectedIndexChanged(object sender, EventArgs e)
        {
            BackEndBuscoChoza.IService1 client = new BackEndBuscoChoza.Service1();
            ddl_distrito.Items.Clear();
            foreach (DataRow k in client.Distritos(ddl_provincia.SelectedValue.ToString(), ddl_canton.SelectedValue.ToString()).Rows)
            {
                ddl_distrito.Items.Add(k.ItemArray[0].ToString());
            }
        }

        
    }

    public static class ConversorDataTable
    {
        public static DataTable ToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                table.Columns.Add(prop.Name, prop.PropertyType);
            }
            object[] values = new object[props.Count];
            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }
                table.Rows.Add(values);
            }
            return table;
        }
    }

    public class StringValue
    {
        public StringValue(string s)
        {
            _value = s;
        }
        public string Value { get { return _value; } set { _value = value; } }
        string _value;
    }


}