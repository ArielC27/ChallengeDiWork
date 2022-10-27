using System.Data;
using System.Data.SqlClient;
using System.Xml.Schema;
using ChallengeDiWork.Logica;
using ChallengeDiWork.Modelo;

namespace ChallengeDiWork.Persistencia
{
    public class ConsultasDeSalida : BD
    {
        public Repuesto MasUtilizado(string marca, int repuestoId, int cantidad)
        {
            Repuesto maxRepuesto = new Repuesto();
            using (SqlConnection conn = new SqlConnection(ConnecctionString))
            {
                //--- Query para que muestre el maximo respuesto que se utilizo en las reparaciones realizadas ---//

                string query = "SELECT TOP(1) RD.RepuestoId, SUM(D.Cantidad) AS 'Cantidad', V.Marca FROM Vehiculo as V " +
                    "INNER JOIN Desperfecto AS D ON V.VehiculoID = D.VehiculoId " +
                    "INNER JOIN Repuesto_Desperfecto AS RD on RD.DesperfectoID = D.DesperfectoId " +
                    "INNER JOIN Repuesto AS R on R.RepuestoId = RD.RepuestoID " +
                    "GROUP BY RD.RepuestoId, V.Marca " +
                    "HAVING V.Marca = @marca " +
                    "ORDER BY Cantidad DESC ";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {

                }

            }
            return maxRepuesto;
        }
    }
}