using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio33
{
    public class Cliente
    {
        private string nombre;
        private int numero;

        private string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        private int Numero
        {
            get
            {
                return numero;
            }
        }

        public Cliente(int numero)
        {
            this.numero = numero;
        }

        public Cliente(int numero, string nombre) : this(numero)
        {
            Nombre = nombre;
        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            bool retorno = true;
            if(c1.Numero != c2.Numero)
            {
                retorno = false;
            }
            return retorno;
        }

        public static bool operator ==(Cliente c1, Cliente c2)
        {
            bool retorno = !(c1 != c2);
            return retorno;
        }
    }
}
