using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio26   
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numeros = new List<double>();
            Random r = new Random();
            int i;
            int j;
            for(i = 0; i < 20; i++)
            {
                double numero = r.Next(-50, 50);
                if(numero != 0)
                {
                    numeros.Add(numero);
                    System.Threading.Thread.Sleep(100);
                }
            }
            Console.WriteLine("Lista completa");
            foreach (double numero in numeros)
            {
                Console.WriteLine(numero);
            }

            numeros.Sort(Program.OrdenarDescendente);
            Console.WriteLine("Lista de positivos de forma descendiente");
            foreach (double numero in numeros)
            {
                if(numero > 0)
                {                 
                    Console.WriteLine(numero);
                }
            }

            numeros.Sort(Program.OrdenarAscendente);
            Console.WriteLine("Lista de negativos de forma ascendiente");
            foreach (double numero in numeros)
            {
                if (numero < 0)
                {
                    Console.WriteLine(numero);
                }
            }
            Console.ReadKey();
        }

        private static int OrdenarDescendente(double s1, double s2)
        {
            return -s1.CompareTo(s2);
        }

        private static int OrdenarAscendente(double s1, double s2)
        {
            return s1.CompareTo(s2);
        }
    }
}
