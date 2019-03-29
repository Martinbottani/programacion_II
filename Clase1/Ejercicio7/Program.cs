using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 7";
            string numero;
            bool numeroEnt;
            string numero2;
            bool numeroEnt2;
            string numero3;
            bool numeroEnt3;
            int dia;
            int mes;
            int año;
            //int añoAct;
            int diasTotales = 0;
            Console.Write("Escriba el dia de su nacimiento: ");
            numero = Console.ReadLine();
            numeroEnt = int.TryParse(numero, out dia);
            Console.Write("Escriba el mes de su nacimiento: ");
            numero2 = Console.ReadLine();
            numeroEnt2 = int.TryParse(numero2, out mes);
            Console.Write("Escriba el año de su nacimiento: ");
            numero3 = Console.ReadLine();
            numeroEnt3 = int.TryParse(numero3, out año);
            DateTime primeraFecha = DateTime.Now;

            /*
            for (i = año; i <= añoAct; i++)
            {
                if (i % 4 == 0 || i % 400 == 0)
                {
                    diasTotales = diasTotales + 366;
                }
                else
                {
                    diasTotales = diasTotales + 365;
                }
            }
            */
            Console.WriteLine("\nLos dias vividos son {0}", diasTotales);
            Console.ReadKey();
        }
    }
}
