using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralHerencia
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public Centralita()
        {
            listaDeLlamadas = new List<Llamada>();
        }
        
        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        public float GananciasPorLocal
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Local);
            }
        }

        public float GananciasPorProvincial
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Provincial);
            }
        }

        public float GananciasPorTotal
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return listaDeLlamadas;
            }
        }

        private float CalcularGanancia(TipoLlamada tipo)
        {
            float sumaLocal = 0;
            float sumaProvincial = 0;
            float retorno = 0;
            foreach (Llamada llamada in listaDeLlamadas)
            {
                if (llamada is Provincial)
                {
                    Provincial provincial = (Provincial)llamada;
                    sumaProvincial += provincial.CostoLlamada;
                }
                else if (llamada is Local)
                {
                    Local local = (Local)llamada;
                    sumaLocal += local.CostoLlamada;
                }
            }
            switch(tipo)
            {
                case TipoLlamada.Local:
                    retorno = sumaLocal;
                    break;
                case TipoLlamada.Provincial:
                    retorno = sumaProvincial;
                    break;
                case TipoLlamada.Todas:
                    retorno = sumaLocal + sumaProvincial;
                    break;
            }

            return retorno;
        }

        protected string Mostrar()
        {
            StringBuilder mostrar = new StringBuilder();
            foreach (Llamada llamada in Llamadas)
            {
                mostrar.AppendLine(llamada.ToString());
            }
            mostrar.AppendFormat("\nRazon Social: {0}\nGanancia por todas las llamadas: {1}\n", razonSocial, GananciasPorTotal);
            mostrar.AppendFormat("\nGanancia por local: {0}\nGanancia por Provincial: {1}\n", GananciasPorLocal, GananciasPorProvincial);
            return mostrar.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public void OrdenarLlamadas()
        {
            this.Llamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            listaDeLlamadas.Add(nuevaLlamada);
        }

        public static bool operator ==(Centralita c, Llamada llamada)
        {
            bool retorno = false;
            foreach(Llamada l in c.listaDeLlamadas)
            {
                if(l == llamada)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Centralita c, Llamada llamada)
        {
            return !(c == llamada);
        }

        public static Centralita operator +(Centralita c, Llamada nuevaLlamada)
        {
            if (c != nuevaLlamada)
            {
                c.AgregarLlamada(nuevaLlamada);
            }

            return c;
        }
    }
}
