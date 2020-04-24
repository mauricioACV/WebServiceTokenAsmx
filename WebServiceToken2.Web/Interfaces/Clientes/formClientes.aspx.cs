using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebServiceToken2.Web.Interfaces.Clientes
{
    public partial class formClientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet dbConsulta = null;

                wsServicio.wsClientesSoapClient obClientesSoap = new wsServicio.wsClientesSoapClient();
                obClientesSoap.ClientCredentials.UserName.UserName = "Mauricio";
                obClientesSoap.ClientCredentials.UserName.Password = "Mauricio$";

                wsServicio.classSeguridad obSeguridad = new wsServicio.classSeguridad()
                {
                   stToken = DateTime.Now.ToString("yyyyMMdd")
                };

                //obSeguridad.stToken = DateTime.Now.ToString("yyyyMMdd");

                string stToken = obClientesSoap.autenticaUsuario(ref obSeguridad);

                if (stToken.Equals("-1")) { throw new Exception("Requiere validación"); }

                obSeguridad.autenticaToken = stToken;
                             

                dbConsulta = obClientesSoap.dsConsultaClientes(ref obSeguridad, int.Parse(txtIdentificaion.Text));

                if (dbConsulta.Tables[0].Rows.Count > 0)
                {
                    gvwDatos.DataSource = dbConsulta;
                }
                else
                {
                    gvwDatos.DataSource = null;
                }

                gvwDatos.DataBind();
            }
            catch (Exception ex)
            {

                Response.Write("<Script Languaje='JavaScript'>parent.alert('"+ex.Message+"');</Script>");
            }
        }
    }
}