using System;

namespace OPERADORES_BÁSICOS_EJEMPLOS
{
    class Program
    {
        static void Main(string[] args)
        {
            //OPERADORES BÁSICOS EJEMPLOS

            int a = 10;
            int b = 20;
            int c = -15;
            // En principio solo habria que poner "result" (sin comillas) al principio pero esto se pone automáticamente

            IAsyncResult = a + b;
            // result vale 30

            IAsyncResult += 15;
            // 45

            IAsyncResult++;
            // 46

            IAsyncResult = a + b * c;
            // -290 (10+(20*-15))

            IAsyncResult = 5 % 3;
            // 2 (el resto de dividir 5 entre 3

            IAsyncResult = a + ++b;
            //result vale 31 y b 21(b se ha incrementado antes de la suma)

            IAsyncResult = a + b++;
            //result vale 31 y b 22(b se ha incrementado después de la suma)

            IAsyncResult *= 10;
            //result vale 310


            /*OPERADORES BÁSICOS - EJERCICIOS
             
            ● Definir 2 variables (int) y sumarlas
            ● Utilizar el ++ (postfijo) sobre una de ellas y ver qué valor devuelve
            ● Crear 2 variables de tipo string
               ○ string myVar1 = “Hello “;
               ○ string myVar2 = “World!”:
               ○ ¿Sumarlas?
            ● Dadas 4 variables: w=9, x=5, y=2, z=-3 (intentar averiguar el resultado final
              antes de escribir el código)
               ○ int result = (w+x*z) / ++y;
               ○ result += 8 * x;
               ○ result *= 2;
               ○ float result2 = result / 0.5f;
            */

            int l = 1;
            int j = 2;
            IAsyncResult = l + j;


            IAsyncResult = l++ + j;


            string myVar1 = "Hello";
            string myVar2 = "World";
            IAsyncResult = myVar1 + myVar2;


            int w = 9;
            int x = 5;
            int y = 2;
            int z = -3;
            int result = (w + x * z) / ++y;
            result += 8 * x;
            result *= 2;
            float result2 = result / 0.5f;
        }
    }
}
