using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitades
{
    public class PickUp : Vehiculo
    {
        private string modelo;
        private static int valorHora;

        static PickUp()
        {
            valorHora = 70;
        }

        public PickUp(string patente, string modelo) : base(patente)
        {
            this.modelo = modelo;
        }
        
        public PickUp(string patente, string modelo, int valorHora) : this(patente, modelo)
        {
            PickUp.valorHora = valorHora;
        }

        public override bool Equals(object obj)
        {
            return obj is PickUp;
        }

        public override string ConsultarDatos()
        {
            StringBuilder mostrar = new StringBuilder();
            mostrar.AppendLine(ImprimirTicket());
            mostrar.AppendFormat("\nModelo: {0}\nValor hora: {1}", modelo, valorHora);
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
