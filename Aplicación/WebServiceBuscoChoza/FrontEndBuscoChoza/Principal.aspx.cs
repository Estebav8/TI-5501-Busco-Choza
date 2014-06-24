using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BackEndBuscoChoza;
using System.Text.RegularExpressions;

namespace FrontEndBuscoChoza
{
    public partial class Principal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            BackEndBuscoChoza.IService1 client = new BackEndBuscoChoza.Service1();
            lbl_inicioSesion.Text = client.Hola("Hola..");

        }
        protected void btn_iniciarSesion_Click(object sender, EventArgs e)
        {
            //Servicio de Logueo
            //Server.Transfer();
            BackEndBuscoChoza.IService1 client = new BackEndBuscoChoza.Service1();
            string c = txt_correoInicio.Text;
            string p = txt_passwordInicio.Text;
            if (esCorreo(txt_correoInicio.Text))
            {
                if (client.Loguear(c, p))
                {
                    Response.Redirect("Perfil.aspx");
                }
                else
                    Response.Write("<script>alert('Por favor verifique su cuenta y contraseña')</script>");
            }
            else
                Response.Write("<script>alert('Ingrese un correo válidio')</script>");
           
            
        }
        protected void btn_registrarse_Click(object sender, EventArgs e)
        {
            string nombre = txt_nombreRegistro.Text;
            string correo = txt_correoRegistro.Text;
            string password = txt_passwordRegistro.Text;
            int telefono;
            string direccion = txt_direccion.Text;
            if (nombre.Length<=20)
            {
                if (esCorreo(correo))
                {
                    if (password.Length>=4)
                    {
                        if (int.TryParse(txt_telefono.Text, out telefono )==true)
                        {
                            if (txt_direccion.Text.Length>=10)
                            {
                                BackEndBuscoChoza.IService1 client = new BackEndBuscoChoza.Service1();
                                if (client.Registrar(nombre, correo, password, telefono, direccion)==true)
                                {
                                    Response.Write("Su cuenta ha sido registrada.");
                                    Response.Redirect("Perfil.aspx");
                                }
                                else
                                    Response.Write("<script>alert('Su cuenta no se ha podido registrar. Intente de nuevo.')</script>");
                            }
                            else
                                Response.Write("<script>alert('Por favor ingrese una dirección válida. \nAl menos debe contener 10 caracteres')</script>");
                        }
                        else
                            Response.Write("<script>alert('Por favor ingrese un número telefónico al que le puedan contactar.')</script>");
                    }
                    else
                        Response.Write("<script>alert('Por favor ingrese una contraseña de al menos 4 caracteres.')</script>");
                }
                else
                    Response.Write("<script>alert('Por favor ingrese un correo válido para poder ser contactado.')</script>");
            }
            else
                Response.Write("<script>alert('Por favor ingrese su nombre completo.')</script>");
        }

        private Boolean esCorreo(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}