using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ChallengeDiWork.Logica;
using ChallengeDiWork.Modelos;

namespace ChallengeDiWork.Persistencia
{
    public class ConsultasDeSalida : BD
    {
        public Repuesto MasUtilizado(string nombre)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnecctionString))
            {
                var query = "SELECT * FROM Repuesto WHERE Nombre = @nombre";
                using (SqlCommand sqlCommand = new SqlCommand(query,sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.Parameters.Add(new SqlParameter("nombre", SqlDbType.VarChar) { Value = nombre });
                }
            }
        }
    }
}
