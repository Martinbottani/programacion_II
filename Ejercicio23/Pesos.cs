using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio23
{
    class Pesos
    {
        private double cantidad;
        static float cotizRespectoDolar;

        static Pesos()
        {
            cotizRespectoDolar = 42.99f;
        }

        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, float cotizacion)
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

        public static explicit operator Dolar(Pesos d)
        {
            double result = d.cantidad / Pesos.GetCotizacion();
            Dolar cantid = new Dolar(result);
            return cantid;
        }

        public static explicit operator Euro(Pesos p)
        {
            Dolar auxCantDolar = (Dolar)p;
            double result = auxCantDolar.GetCantidad() / Euro.GetCotizacion();
            Euro cantid = new Euro(result);
            return cantid;
        }

        public static implicit operator Pesos(double p)
        {
            double result = p * cotizRespectoDolar;
            Pesos cantid = new Pesos(result);
            return cantid;
        }
    }
}
