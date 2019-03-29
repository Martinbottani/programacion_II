using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 16";

            string texto1;
            string texto2;
            string texto3;
            string texto4;

            Alumno alumn1 = new Alumno("Martin", "Bottani", 0123456);
            Alumno alumn2 = new Alumno("Lucas", "Valdiviezo", 0123456);
            Alumno alumn3 = new Alumno("Lucas", "Fernandez Uchiha", 0123457);
            Alumno alumn4 = new Alumno("Carlitos", "Carlonchas", 0123458);

            alumn1.Estudiar(10, 10);
            alumn2.Estudiar(10, 10);
            alumn3.Estudiar(10, 10);
            alumn4.Estudiar(1, 2);

            alumn1.CalcularFinal();
            Thread.Sleep(100);
            alumn2.CalcularFinal();
            Thread.Sleep(100);
            alumn3.CalcularFinal();
            Thread.Sleep(100);
            alumn4.CalcularFinal();

            texto1 = alumn1.Mostrar();
            texto2 = alumn2.Mostrar();
            texto3 = alumn3.Mostrar();
            texto4 = alumn4.Mostrar();

            Console.WriteLine("{0}", texto1);
            Console.WriteLine("{0}", texto2);
            Console.WriteLine("{0}", texto3);
            Console.WriteLine("{0}", texto4);
            Console.ReadKey();
        }
    }
}
