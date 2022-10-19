﻿using System.Data;
using System.Data.SqlClient;
using ChallengeDiWork.Logica;
using ChallengeDiWork.Modelos;

namespace ChallengeDiWork.Persistencia
{
    public class ConsultasDeSalida : BD
    {
        public Repuesto MasUtilizado(string nombre)
        {
            Repuesto repuesto = new Repuesto();
            using (SqlConnection sqlConnection = new SqlConnection(ConnecctionString))
            {
                var query = "FROM * Respuesto WHERE Nombre = @nombre";
                
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                sqlConnection.Open();
                if (nombre != null)
                {

                }
                DataSet resultado = new DataSet();
                sqlDataAdapter.Fill(resultado);

                sqlConnection.Close();
                return repuesto;
            }
        }
        public decimal Promedio()
        {
            return 0;
        }
        public decimal TotalAcumulado()
        {
            return 0;
        }
    }
}
