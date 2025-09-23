using System;

namespace Recursividad2_MostrarCadenaDeNºsHasta0
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Escribe 1 Nº y hago su cadena hasta 0: ");
            num = Convert.ToInt32(Console.ReadLine());

            CadenaNumeros(num);
            // int.Parse
        }

        static int CadenaNumeros(int num)
        {
            if (num == -1)
            {
                return 0;
            }

            else
            {
                Console.Write(num + ", ");
                return CadenaNumeros(num - 1);
            }
        }
    }
}
