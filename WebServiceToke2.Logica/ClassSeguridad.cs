using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Services.Protocols;

namespace WebServiceToke2.Logica
{
    public class classSeguridad : SoapHeader
    {
        public string stToken { get; set; }
        public string autenticaToken { get; set; }

        public bool blCredencialValida(string token)
        {
            try
            {
                if (token == DateTime.Now.ToString("yyyyMMdd")) return true;
                else return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool blCredencialValida(classSeguridad soapHeader)
        {
            try
            {
                if (soapHeader == null) return false;
                if (!string.IsNullOrEmpty(soapHeader.autenticaToken))
                    return (HttpRuntime.Cache[soapHeader.autenticaToken] != null);

                return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
