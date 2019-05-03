﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entitades;

namespace Bottani.Martin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MOTOS");
            Vehiculo m1 = new Moto("ASD123", 75, 4);
            Console.WriteLine(m1.ConsultarDatos());
            Moto m2 = new Moto("ASDaa123", 175);
            Console.WriteLine(m2.ConsultarDatos());
            Moto m3 = new Moto("QWE312", 175, 4, 35);
            Console.WriteLine(m3.ConsultarDatos());
            Console.WriteLine("PICKUPS");
            PickUp p1 = new PickUp("TYR753", "78", 51);
            Console.WriteLine(p1.ConsultarDatos());
            PickUp p2 = new PickUp("TYR753", "Model A");
            Console.WriteLine(p2.ConsultarDatos());
            Console.WriteLine("AUTOMOVILES");
            Automovil a1 = new Automovil("POI952", ConsoleColor.Red);
            Console.WriteLine(a1.ConsultarDatos());
            Automovil a2 = new Automovil("MNB651", ConsoleColor.DarkCyan, 23);
            Console.WriteLine(a2.ConsultarDatos());
            Console.ReadKey();
        }
    }
}