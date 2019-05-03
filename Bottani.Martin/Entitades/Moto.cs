using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitades
{
    public class Moto : Vehiculo
    {
        private int cilindrada;
        private static short ruedas;
        private static int valorHora;

        static Moto()
        {
            valorHora = 30;
            ruedas = 2;
        }
        
        public Moto(string patente, int cilindrada) : base(patente)
        {
            this.cilindrada = cilindrada;
        }

        public Moto(string patente, int cilindrada, short ruedas) : this(patente, cilindrada)
        {
            Moto.ruedas = ruedas;
        }
        
        public Moto(string patente, int cilindrada, short ruedas, int valorHora) : this(patente, cilindrada, ruedas)
        {
            Moto.valorHora = valorHora;
        }

        public override bool Equals(object obj)
        {
            return obj is Moto;
        }

        public override string ConsultarDatos()
        {
            StringBuilder mostrar = new StringBuilder();
            mostrar.AppendLine(ImprimirTicket());
            mostrar.AppendFormat("\nCilindrada: {0}\nRuedas: {1}\nValor de la hora: {2}\n", cilindrada, ruedas, valorHora);
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
