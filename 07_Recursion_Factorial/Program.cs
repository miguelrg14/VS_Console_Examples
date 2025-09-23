using System;

namespace Factorial_Recursivo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Escribe 1 Nº y hago su factorial: ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.Write("El factorial de " + num + " es:" + FactorialRecursivo(num));
            // int.Parse
        }

        static int FactorialRecursivo(int num)
        {
            if (num == 0)
            {
                return 1;
            }

            else
            {
                return num * FactorialRecursivo(num - 1);
            }
        }
    }
}
