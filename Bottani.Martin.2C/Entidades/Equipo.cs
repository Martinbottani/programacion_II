using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        private const int cantidadMaximaJugadores = 6;
        private DirectorTecnico directorTecnico;
        private List<Jugador> jugadores;
        private string nombre;

        public DirectorTecnico DirectorTecnico
        {
            set
            {
                directorTecnico = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
        }

        private Equipo()
        {
            jugadores = new List<Jugador>();
        }

        public Equipo(string nombre)
        {
            this.nombre = nombre;
        }

        public static explicit operator string(Equipo e)
        {
            StringBuilder mostrar = new StringBuilder();
            mostrar.AppendFormat("Nombre de Equipo: {0}\nCantidad maxima de jugadores: {1}\n", e.Nombre, cantidadMaximaJugadores);
            if (e.directorTecnico != null)
            {
                mostrar.AppendFormat("{0}\n {1}", e.directorTecnico.Mostrar());
            }
            else if(!e.directorTecnico.ValidarAptitud())
            {
                mostrar.AppendLine("Sin DT asignado");
            }
            foreach(Jugador jugador in e.jugadores)
            {
                    mostrar.AppendFormat("{0}", jugador.Mostrar());           
            }
            return mostrar.ToString();
        }

        public static bool operator ==(Equipo e, Jugador j)
        {
            bool retorno = false;
            foreach(Jugador jugador in e.jugadores)
            {
                if(jugador == j)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e == j);
        }

        public static Equipo operator +(Equipo e, Jugador j)
        {
            if(e.jugadores.Count < 6 && e != j && j.ValidarAptitud())
            {
                e.jugadores.Add(j);
            }
            return e;
        }
    }
}
