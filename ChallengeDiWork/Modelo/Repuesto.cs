using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeDiWork.Modelo
{
    public class Repuesto
    {
        public string Nombre { get; set; }
        public decimal Precio{ get; set; }
        public int Cantidad { get; set; }
        public List<Desperfecto> Desperfectos { get; set; }
    }
}
