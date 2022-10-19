using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeDiWork.Logica
{
    public class Desperfecto
    {
        public string Descripcion { get; set; }
        public decimal ManoDeObra { get; set; }
        public decimal Tiempo { get; set; }
        public Vehiculo Vehiculo { get; set; }
        public List<Repuesto> Repuestos { get; set; }

    }
}
