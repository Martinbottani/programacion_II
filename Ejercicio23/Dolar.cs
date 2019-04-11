using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio23
{
    class Dolar
    {
        private double cantidad;
        private static float cotizRespectoDolar;
        
        static Dolar()
        {
            cotizRespectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, float cotizacion)
        {
            this.cantidad = cantidad;
            cotizRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static float GetCotizacion()
        {
            return cotizRespectoDolar;
        }

        public static explicit operator Euro(Dolar d)
        {
            double result = d.cantidad / Euro.GetCotizacion();
            Euro cantid = new Euro(result);
            return cantid;
        }

        public static explicit operator Pesos(Dolar d)
        {
            double result = d.cantidad * Pesos.GetCotizacion();
            Pesos cantid = new Pesos(result);
            return cantid;
        }

        public static implicit operator Dolar(double d)
        {
            double result = d * cotizRespectoDolar;
            Dolar cantid = new Dolar(result);
            return cantid;
        }
    }
}
