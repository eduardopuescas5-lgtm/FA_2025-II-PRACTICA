﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA1_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejer1();
            Console.ReadKey();

            ejer2 ();
            Console.ReadKey();
        }

        static void ejer1()
        {
            string nombre, carrera; //Declaramos variables

            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese su nombre de carrera: ");
            carrera = Console.ReadLine();

            Console.WriteLine($"\n{nombre}, bienvenido a FA de {carrera}");


        }
        static void ejer2()
        {
            Console.Write("Ingrese numero x: ");
            int x = int.Parse( Console.ReadLine() );

            Console.Write("Ingrese numero y: ");
            int y = Convert.ToInt32( Console.ReadLine());

            double resu = (double)x / (double)y;

            Console.WriteLine("Suma: "+(x+y));
            Console.WriteLine("Resta: " + (x + y));
            Console.WriteLine("Multiplicacion: " + (x + y));
            Console.WriteLine("Divison: " + (x + y));




        }
         static void ejer3()
        {

        }
        static void ejer4()
        {

        }
        static void ejer5()
        {

        }
        static void ejer6()
        {

        }
    }
}
