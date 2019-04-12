using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio23
{
    class Euro
    {
        private double cantidad;
        static float cotizRespectoDolar;

        static Euro()
        {
            cotizRespectoDolar = 1.13f;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, float cotizacion)
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

        public static explicit operator Dolar(Euro p)
        {
            double result = p.cantidad * Euro.GetCotizacion();
            Dolar cantid = new Dolar(result);
            return cantid;
        }

        public static explicit operator Pesos(Euro e)
        {
            Dolar auxCantDolar = (Dolar)e;
            double result = auxCantDolar.GetCantidad() * Pesos.GetCotizacion();
            Pesos cantid = new Pesos(result);
            return cantid;
        }

        public static implicit operator Euro(double e)
        {
            double result = e * cotizRespectoDolar;
            Euro cantid = new Euro(result);
            return cantid;
        }
    }
}
