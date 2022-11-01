using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Logica
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

        //--- Calculo del subtotal, que es el presupuesto inicial antes de aplicar los recargos y descuentos respectivos.
        public void PresupuestoInicial()
        {
            Subtotal = ((Repuesto.Precio * Desperfecto.Cantidad) + Desperfecto.ManoDeObra + (130 * Desperfecto.Tiempo)) * 1.10m;
        }

        //--- Calculo del presupuesto Total y final, segun el metodo de pago que elija el cliente, se aplican los descuentos y recargos establecidos.
        public decimal Total()
        {
            switch (MetodoDePago)
            {
                case "TD": //Tarjeta de debito
                    return TotalFacturado = Subtotal * 1.10m; //Recargo del 10% por pago con Tarjeta de debito

                case "TC": //Tarjeta de credito
                    return TotalFacturado = Subtotal * 1.10m; //Recargo del 10 % por pago con Tarjeta de credito

                default:
                    return TotalFacturado = Subtotal - (Subtotal * 1.10m); //Descuento del 10% por pago en efectivo
            }
        }

        //--- Calculo del promedio de todos los presupuestos cargados.
        public decimal Promedio()
        {
            int n = 1;
            decimal promedio = 0m;
            List<Factura> Presupuestos = new List<Factura>();
            foreach (Factura factura in Presupuestos)
            {
                TotalFacturado = TotalFacturado + (factura.TotalFacturado);
                promedio = TotalFacturado / n;
            }
            return promedio;
        }

        //--- Calculo de la suma total de todos los presupuestos cargados, tanto para motos y autos.
        public decimal Suma()
        {
            decimal sumaTotal = 0m;
            List<Factura> Presupuestos = new List<Factura>();
            foreach (Factura presupuesto in Presupuestos)
            {
                sumaTotal += presupuesto.TotalFacturado;
            }
            return sumaTotal;
        }
    }
}
