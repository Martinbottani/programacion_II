using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio33
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        public Cliente Cliente
        {
            get
            {
                return clientes.Dequeue();
            }
            set
            {
                
                clientes.Enqueue(value);
            }
        }
        public int ClientePendientes
        {
            get
            {
                return clientes.Count();
            }
        }
        private Negocio()
        {
            caja = new PuestoAtencion(Puesto.Caja1);
            clientes = new Queue<Cliente>();
        }

        public Negocio(string nombre)
        {
            this.nombre = nombre;
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            bool retorno = false;
            if(!(n == c))
            {
                n.clientes.Enqueue(c);
                retorno = true;
            }
            return retorno;
        }

        public static bool operator -(Negocio n, Cliente c)
        {
            bool retorno = false;
            if ((n == c))
            {
                n.clientes.Dequeue();
                retorno = true;
            }
            return retorno;
        }

        public static bool operator ==(Negocio n, Cliente c)
        {
            bool retorno = false;
            foreach(Cliente auxCliente in n.clientes)
            {
                if(auxCliente == c)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public static bool operator ~(Negocio n)
        {
            bool retorno = false;
            if(n.caja.AtenderCliente(n.Cliente))
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
