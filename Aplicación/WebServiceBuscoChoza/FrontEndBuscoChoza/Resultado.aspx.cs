using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontEndBuscoChoza
{
    public partial class Resultado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        public void Cargar_Resultado(List<String> resultado)
        {
            //lbl_codigo.Text = resultado[0];//dtt.Columns.Add("CÓDIGO");
            //lbl_tipoPublicacion.Text = resultado[1];//dtt.Columns.Add("TIPO");
            //string[] ubicacion = resultado[2].Split(',');
            //lbl_resultadoProvincia.Text = ubicacion[0];//dtt.Columns.Add("UBICACIÓN");
            //lbl_resultadoCanton.Text = ubicacion[1];//dtt.Columns.Add("MTS CONSTRUCCIÓN");
            //lbl_resultadoDistrito.Text = ubicacion[2];//dtt.Columns.Add("MTS TERRENO");
            //lbl_mtsConstruccion.Text = resultado[3];
            //lbl_mtsTerreno.Text = resultado[4];
            //lbl_balcon.Text = resultado[5];//dtt.Columns.Add("BALCÓN");
            //lbl_jardin.Text = resultado[6];//dtt.Columns.Add("JARDÍN");
            //lbl_piscina.Text = resultado[7];//dtt.Columns.Add("PISCINA");
            //lbl_precio.Text = resultado[8];//dtt.Columns.Add("PRECIO VENTA");
            //lbl_descripcion.Text = resultado[9];//dtt.Columns.Add("DESCRIPCION");
            String Valor = Request.QueryString["Valor"];
            string[] ubicacion = Valor.Split('&');
            lbl_codigo.Text = Valor;
        }
    }
}