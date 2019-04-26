using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador : Persona
    {
        private float altura;
        private float peso;
        private Posicion posicion;

        public float Altura
        {
            get
            {
                return altura;
            }
        }

        public float Peso
        {
            get
            {
                return peso;
            }
        }

        public Posicion Posicion
        {
            get
            {
                return posicion;
            }
        }

        public Jugador(string nombre, string apellido, int edad, int dni, float peso, float altura, Posicion posicion) : base(nombre, apellido, edad, dni)
        {
            this.peso = peso;
            this.altura = altura;
            this.posicion = posicion;
        }

        public override string Mostrar()
        {
            StringBuilder mostrar = new StringBuilder();
            mostrar.AppendFormat("*JUGADOR*\n\n{0}", base.Mostrar(), "\nPeso: {1}\nAltura: {2}\nPosicion: {3}", peso, altura, Posicion);
            return mostrar.ToString();
        }

        public bool ValidarEstadoFisico()
        {
            bool retorno = false;
            float IMC = Peso / (Altura * Altura);
            if (IMC > 18.5f && IMC <= 25)
            {
                retorno = true;
            }
            return retorno;
        }

        public override bool ValidarAptitud()
        {
            bool retorno = false;
            if (Edad < 40 && ValidarEstadoFisico() == true)
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
