using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio33
{
    public enum Puesto
    {
        Caja1,
        Caja2
    }
    public class PuestoAtencion
    {
        private static int numeroActual;
        private Puesto puesto;
        
        public int NumeroActual
        {
            get
            {
                return ++numeroActual;
            }
        }

        public bool AtenderCliente(Cliente cli)
        {
            bool retorno = false;
            if(retorno == false)
            {
                System.Threading.Thread.Sleep(300);
                retorno = true;
            }
            return retorno;
        }

        private PuestoAtencion()
        {
            numeroActual = 0;
        }
        
        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }
    }
}
