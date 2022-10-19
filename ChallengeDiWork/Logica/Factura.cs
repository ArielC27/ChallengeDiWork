using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ChallengeDiWork;
using ChallengeDiWork.Modelo;

namespace ChallengeDiWork.Logica
{
    public class Factura
    {
        public Vehiculo Vehiculo { get; set; }
        public Desperfecto Desperfecto { get; set; }
        public Repuesto Repuesto { get; set; }
        public string MetodoDePago { get; set; }
        public decimal Subtotal { get; set; }
        public decimal TotalFacturado { get; set; }

        public Factura(Vehiculo vehiculo, Desperfecto desperfecto, Repuesto repuesto)
        {
            Vehiculo = vehiculo;
            Desperfecto = desperfecto;
            Repuesto = repuesto;
        }
        public decimal PresupuestoInicial()
        {
            return Subtotal = ((Repuesto.Precio * Repuesto.Cantidad) + Desperfecto.ManoDeObra + (130 * Desperfecto.Tiempo)) * 1.10m;
        }
        public decimal Total()
        {
            switch (MetodoDePago)
            {
                case "TD":
                    return TotalFacturado = Subtotal * 1.10m; //Recargo del 10% por pago con Tarjeta de debito
                    break;
                case "TC":
                    return TotalFacturado = Subtotal * 1.10m; //Recargo del 10 % por pago con Tarjeta de credito
                    break;
                default: return TotalFacturado = Subtotal - (Subtotal * 1.10m); //Descuento del 10% por pago en efectivo
            }
        }
    }
}
