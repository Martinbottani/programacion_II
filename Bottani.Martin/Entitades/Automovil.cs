using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitades
{
    public class Automovil : Vehiculo
    {
        private ConsoleColor color;
        private static int valorHora;

        static Automovil()
        {
            valorHora = 50;
        }
        
        public Automovil(string patente, ConsoleColor color) : base(patente)
        {
            this.color = color;
        }

        public Automovil(string patente, ConsoleColor color, int valorHora) : base(patente)
        {
            this.color = color;
            Automovil.valorHora = valorHora;
        }

        public override bool Equals(object obj)
        {          
            return obj is Automovil;
        }

        public override string ConsultarDatos()
        {
            StringBuilder mostrar = new StringBuilder();
            mostrar.AppendFormat("\n{0}\nColor: {1}\nValor de la hora: {2}\n", base.ImprimirTicket(), color, valorHora);
            return mostrar.ToString();
        }

    }
}
