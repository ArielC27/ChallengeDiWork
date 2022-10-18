using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChallengeDiWork.Logica;

namespace ChallengeDiWork
{
    public abstract class Vehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Patente { get; set; }
        public List<Desperfecto> Desperfectos { get; set; }
        public decimal CostoTotal(decimal repuestos, decimal mO, int dia)
        {
            decimal total = 0;
            return total = repuestos + mO + (130 * dia) + total * 1.10m;
        }

    }
}
