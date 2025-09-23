using System;

namespace _5._Números_aleatorios
{
    class Program
    {
        static void Main(string[] args)
        {
            // EJERCICIOS - NÚMEROS ALEATORIOS

            /* APUNTICOS DE CLASE
            Random rnd = new Random();
            int x = rnd.Next(lo que necesites);

            //Generar aleatorio
            UserStringHandle input(int;
            input vs Rnd;
            si
                input == Rnd; //Texto ===> Fin
            else
            */

            Random rnd = new Random();

            int randNum = rnd.Next(100);
            int x;

            Console.WriteLine("Escribe un número, a ver si aciertas majo :)");

            do
            {
                x = Convert.ToInt32(Console.ReadLine());

                if (x < randNum)
                {
                    Console.WriteLine(x + " es menor que el numerixo");
                }

                if (x > randNum)
                {
                    Console.WriteLine(x + " es mayor que el numerixo");
                }

            }
            while (x != randNum);

            Console.WriteLine("Al fin acertaste puto inútil xd");

        }
    }
}
