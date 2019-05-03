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

        public Automovil(string patente, ConsoleColor color, int valorHora) : this(patente, color)
        {
            Automovil.valorHora = valorHora;
        }

        public override bool Equals(object obj)
        {          
            return obj is Automovil;
        }

        public override string ConsultarDatos()
        {
            StringBuilder mostrar = new StringBuilder();
            mostrar.AppendLine(ImprimirTicket());
            mostrar.AppendFormat("\nColor: {0}\nValor de la hora: {1}\n", color, valorHora);
            return mostrar.ToString();
        }

        public override string ImprimirTicket()
        {
            StringBuilder mostrar = new StringBuilder();
            int valorDeEstadia = base.ingreso.Hour * valorHora;
            mostrar.AppendLine(base.ImprimirTicket());
            mostrar.AppendFormat("\nCosto de estadia: {0}", valorDeEstadia);
            return mostrar.ToString();
        }


    }
}
