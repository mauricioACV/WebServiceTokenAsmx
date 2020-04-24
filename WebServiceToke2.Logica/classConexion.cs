using System.Configuration;

namespace WebServiceToke2.Logica
{
    public class classConexion
    {
        public string getConexion()
        {
            return ConfigurationManager.ConnectionStrings["conexionDb"].ToString();
        }
    }
}
