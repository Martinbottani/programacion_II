using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5_CAMPUS
{
    class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;

        private Estante(int capacidad)
        {
            productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        public Producto[] GetProductos()
        {
            return productos;
        }

        public string MostrarEstante(Estante e)
        {
            string cadena;
            int i;
            string codigoDeBarras;
            cadena = "La ubicacion del estante es: " + e.ubicacionEstante;
            for (i = 0; i < productos.Length; i++)
            {
                codigoDeBarras = (string)productos[i];
                cadena = cadena + Producto.MostrarProducto(productos[i]);
            }
            return cadena;
        }

        public static bool operator ==(Estante e, Producto p)
        {
            bool retorno = false;
            int i;
            string marcaProducto;
            marcaProducto = p.GetMarca();
            for (i = 0; i < e.productos.Length; i++)
            {
                if (e.productos[i].GetMarca() == marcaProducto)
                {
                    retorno = true;
                }       
            }
            return retorno;
        }

        public static bool operator != (Estante e, Producto p)
        {
            bool retorno = false;
            int i;
            string marcaProducto;
            marcaProducto = p.GetMarca();
            for (i = 0; i < e.productos.Length; i++)
            {
                if (e.productos[i].GetMarca() != marcaProducto)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        
        public static bool operator + (Estante e, Producto p)
        {
            bool retorno = false;
            int i;
            if(e != p)
            {
                retorno = true;
                for (i = 0; i < e.productos.Length; i++)
                {                  
                    if (Object.ReferenceEquals(e.productos[i], null))
                    {
                        e.productos[i] = p;
                    }
                    break;
                }
            }
            return retorno;
        }

        public static bool operator - (Estante e, Producto p)
        {
            bool retorno = false;
            int i;
            if (e == p)
            {
                retorno = true;
                for (i = 0; i < e.productos.Length; i++)
                {
                    if (Object.ReferenceEquals(e.productos[i], p))
                    {
                        e.productos[i] = null;
                    }
                    break;
                }
            }
            return retorno;
        }
    }
}
