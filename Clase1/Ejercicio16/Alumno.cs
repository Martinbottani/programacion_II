using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;

        public Alumno(string nombreAlumn, string apellidoAlumn, int legajoAlumn)
        {
            this.apellido = apellidoAlumn;
            this.nombre = nombreAlumn;
            this.legajo = legajoAlumn;

        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            nota1 = notaUno;
            nota2 = notaDos;
        }

        public void CalcularFinal()
        {
            Random auxNota = new Random();
            if(nota1 >= 4 && nota2 >= 4)
            {
                notaFinal = auxNota.Next(4,10);
            }
            else
            {
                notaFinal = -1;
            }
        }
        
        public string Mostrar()
        {
            string cadena = "";
            if(notaFinal != -1)
            {
                cadena = "\nAlumno: " + this.apellido + "\nNombre: " + this.nombre + "\nLegajo: " + this.legajo + "\nNota Final: " + notaFinal;
            }
            else
            {
                cadena = "\nAlumno: " + this.apellido + "\nNombre: " + this.nombre + "\nLegajo: " + this.legajo + "\nAlumno desaprobado";
            }
            return cadena;
        }
    }
}
