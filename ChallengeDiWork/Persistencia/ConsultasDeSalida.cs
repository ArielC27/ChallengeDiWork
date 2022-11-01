using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Persistencia
{
    public abstract class ConsultasDeSalida : BD
    {
        public bool MasUtilizado(Vehiculo vehiculo, Repuesto repuesto, Desperfecto desperfecto)
        {
            bool result = false;
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                string query = "select top(1) RD.RepuestoId, SUM(D.Cantidad) as 'Cantidad', V.Marca from Vehiculo as V " +
                               "inner join Desperfecto as D on V.VehiculoID = D.VehiculoId " +
                               "inner join Repuesto_Desperfecto as RD on RD.DesperfectoID = D.DesperfectoId " +
                               "inner join Repuesto as R on R.RepuestoId = RD.RepuestoID " +
                               "group by RD.RepuestoId, V.Marca " +
                               "having V.Marca = @marca " +
                               "order by Cantidad desc ";

                SqlParameter marca = new SqlParameter("Marca", SqlDbType.VarChar) { Value = vehiculo.Marca };
                SqlParameter repuestoID = new SqlParameter("RepuestoId", SqlDbType.Int) { Value = repuesto.RepuestoId };
                SqlParameter cantidad = new SqlParameter("Cantidad", SqlDbType.Int) { Value = desperfecto.Cantidad };

                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.Add(marca);
                    sqlCommand.Parameters.Add(repuestoID);
                    sqlCommand.Parameters.Add(cantidad);

                    int numberOfRows = sqlCommand.ExecuteNonQuery();

                    if (numberOfRows > 0)
                    {
                        result = true;
                    }
                }
                sqlConnection.Close();
            }
            return result;
        }
    }
}
