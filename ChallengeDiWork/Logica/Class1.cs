using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Metodos
    {
        public decimal Presupuesto(decimal repuestos, decimal mO, int dias)
        {
            decimal total = 0;
            decimal recargo = 0;
            decimal subtotal = 0;
            subtotal = repuestos + mO + (130 * dias);
            recargo = subtotal * 1.10m;
            return total = subtotal + recargo;
        }
    }
}
