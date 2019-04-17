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
        private Queue<Cliente> clientes = new Queue<Cliente>();
        private string nombre;

        private Cliente Cliente
        {
            get
            {
                return clientes.Dequeue();
            }
            set
            {
                if(!clientes.Contains(value))
                clientes.Enqueue(value);
            }
        }
        private Negocio()
        {
            caja = new PuestoAtencion(Puesto.Caja1);
        }
    }
}
