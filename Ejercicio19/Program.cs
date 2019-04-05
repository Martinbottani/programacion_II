using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador suma = new Sumador();
            Sumador suma2 = new Sumador();
            long num;
            num = suma.Sumar(15, 10);
            Console.WriteLine(num);
            Console.WriteLine(suma.SumarLetras("a", "b"));
            Console.WriteLine((int)suma);
            Console.WriteLine((suma | suma2));
            Console.WriteLine((int)suma2);
            Console.ReadKey();            
        }
    }
}
