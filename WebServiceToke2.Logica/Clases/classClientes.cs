using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace WebServiceToke2.Logica.Clases
{
    public class classClientes
    {
        string stConexion;
        SqlConnection sqlConnection = null;
        SqlCommand sqlCommand = null;
        SqlDataAdapter sqlDataAdapter = null;

        public classClientes()
        {
            classConexion objClassConexion = new classConexion();
            stConexion = objClassConexion.getConexion();
        }

        public DataSet dsConsultaClientes(int Idpais)
        {
            try
            {
                DataSet dsConsulta = new DataSet();

                //var Idpais = 1;

                var query = @"Select * from Personas where IdPais='"+ Idpais+ "'";

                using (sqlConnection = new SqlConnection(stConexion))
                {
                    using (sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        sqlConnection.Open();
                        sqlCommand.ExecuteNonQuery();
                        sqlDataAdapter = new SqlDataAdapter(sqlCommand);                        
                        sqlDataAdapter.Fill(dsConsulta);
                        return dsConsulta;
                    }
                }                               
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
