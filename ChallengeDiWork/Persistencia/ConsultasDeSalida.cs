using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;
using ChallengeDiWork.Logica;
using ChallengeDiWork.Modelo;

namespace ChallengeDiWork.Persistencia
{
    public class ConsultasDeSalida : BD
    {
        public bool MasUtilizado(Vehiculo marca, Repuesto repuestoId, Repuesto cantidad)
        {
            bool result = false;
            string query = "select top(1) RD.RepuestoId, SUM(D.Cantidad) as 'Cantidad', V.Marca from Vehiculo as V " +
                           "inner join Desperfecto as D on V.VehiculoID = D.VehiculoId " +
                           "inner join Repuesto_Desperfecto as RD on RD.DesperfectoID = D.DesperfectoId " +
                           "inner join Repuesto as R on R.RepuestoId = RD.RepuestoID " +
                           "group by RD.RepuestoId, V.Marca " +
                           "having V.Marca = @marca " +
                           "order by Cantidad desc ";
            using (SqlConnection conn = new SqlConnection(ConnecctionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {

                }

            }
            return result;
        }
    }
}