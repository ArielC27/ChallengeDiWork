﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeDiWork.Logica
{
    public class Repuesto
    {
        public string Nombre { get; set; }
        public decimal Precio{ get; set; }
        public List<Desperfecto> Desperfectos { get; set; }
    }
}