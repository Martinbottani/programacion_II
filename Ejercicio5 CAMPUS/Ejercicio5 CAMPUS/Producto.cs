using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5_CAMPUS
{
    class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string marca, string codigo, float precio)
        {
            this.marca = marca;
            this.codigoDeBarra = codigo;
            this.precio = precio;
        }

        public string GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        public static string MostrarProducto(Producto p)
        {
            string cadena;
            cadena = "El producto es: " + p.marca + "\nSu codigo de barras es: " + p.codigoDeBarra + "\nEl precio es: " + p.precio + "\n";
            return cadena;
        }

        public static explicit operator string (Producto p)
        {
            return p.codigoDeBarra;
        }

        public static bool operator != (Producto p1, Producto p2)
        {
            if (p1.marca != p2.marca || p1.codigoDeBarra != p2.codigoDeBarra)
            {
                return true;
            }
            else
            {
                return false;
            }
            //return !(p1 == p2);
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            if(p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Producto p, string cadena)
        {
            if (p.marca != cadena || p.codigoDeBarra != cadena)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Producto p, string cadena)
        {
            if (p.marca == cadena && p.codigoDeBarra == cadena)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
