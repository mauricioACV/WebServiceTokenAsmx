using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebServiceToke2.Logica;
using System.Data;
using System.Web.Services.Protocols;

    [WebService]
    public class wsClientes
{
        public classSeguridad soapheader;

        [WebMethod]
        [SoapHeader("soapheader", Direction = SoapHeaderDirection.InOut)]
        public string autenticaUsuario()
        {
            try
            {
                if (soapheader == null) return "-1";
                if (!soapheader.blCredencialValida(soapheader.stToken)) return "-1";

                string stToken = Guid.NewGuid().ToString();

                HttpRuntime.Cache.Add(stToken, soapheader.stToken, null, System.Web.Caching.Cache.NoAbsoluteExpiration,
                    TimeSpan.FromMinutes(30), System.Web.Caching.CacheItemPriority.NotRemovable, null);

                return stToken;
            }
            catch (Exception)
            {

                throw;
            }

        }

        [WebMethod]
        [SoapHeader("soapheader", Direction = SoapHeaderDirection.InOut)]
        public DataSet dsConsultaClientes(int IdPais)
        {

            try
            {
                if (soapheader == null) throw new Exception("Requiere Validación");
                if (!soapheader.blCredencialValida(soapheader)) throw new Exception("Requiere Validación");

                DataSet dsConsulta = null;

                WebServiceToke2.Logica.Clases.classClientes objClassClientes = new WebServiceToke2.Logica.Clases.classClientes();
                dsConsulta = objClassClientes.dsConsultaClientes(IdPais);

                return dsConsulta;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
