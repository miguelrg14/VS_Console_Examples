using System;

namespace _7._Ejercicios_métodos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicios métodos
            int inputNum;

            /// 1 ; Cuadrado
            int resultado;

            Console.WriteLine("Dame un número");
            inputNum = Convert.ToInt32(Console.ReadLine());

            resultado = Cuadrado(inputNum);
            // Los parentesis definen las variables

            Console.WriteLine(resultado);

            /// 2; Potencias
            int potencia;

            Console.WriteLine("Dame un número x");
            inputNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame un número y");
            potencia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(inputNum + " elevado a " + potencia + " = " + elevado(inputNum, potencia));
        }

        // Método que calcula el cuadrado de un número "num"
        static int Cuadrado(int num)
        {
            return num * num;
        }

        static int elevado(int x, int y)
        {
            int res = 0;

            for (int aux = 0; aux < y; aux++)   // 0, 1 y 2
            {
                res *= x; // res = res * x;
            }

            return res;
        }
    }
}
