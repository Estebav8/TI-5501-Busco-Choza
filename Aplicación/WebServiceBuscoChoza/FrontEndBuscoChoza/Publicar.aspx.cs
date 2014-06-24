using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontEndBuscoChoza
{
    public partial class Publicar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            pnl_casas.Visible = false;
            pnl_apartamento_oficina.Visible = false;
            if (ddl_tipoPublicacion.SelectedIndex == 0)
            {
                lbl_precio.Text = "Precio de venta:"; 
            }
            if (ddl_tipoPublicacion.SelectedIndex == 1)
            {
                lbl_precio.Text = "Precio de alquiler por mes:";
            }
            if (ddl_tipoPropiedad.SelectedIndex == 0)
            {
                pnl_casas.Visible = true;
                pnl_apartamento_oficina.Visible = false;
            }
            if (ddl_tipoPropiedad.SelectedIndex == 1 )
            {
                pnl_casas.Visible = false;
                pnl_apartamento_oficina.Visible = true;
                lbl_apartamento_oficina.Text = "Número de apartamento";
            }
            if (ddl_tipoPropiedad.SelectedIndex == 2)
            {
                pnl_casas.Visible = false;
                pnl_apartamento_oficina.Visible = true;
                lbl_apartamento_oficina.Text = "Número de oficina";
            }
        }

        protected void btn_publicar_Click(object sender, EventArgs e)
        {
            
        }

        protected void ddl_tipoPublicacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ddl_canton_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}