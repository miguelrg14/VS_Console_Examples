using System;

namespace _6._EJERCICIOS_APARTE_CLASE_MARTES
{
    class Program
    {
        static void Main(string[] args)
        {
            //EJERCICIOS APARTE CLASE MARTES

            // Horas minutos segundos
            /*Crear una aplicación de consola en C# que pida al usuario una cantidad de días,
              horas, minutos y segundos cualesquiera y los muestre de forma convencional
              (nunca más de 24 horas, 60 minutos o 60 segundos.
            */

            //Declaro las variables
            int x;
            int y;
            int z;
            int f;

            //Ajusto horas
            Console.WriteLine("Dame una cantidad de días");
            x = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Ahora horas");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dame minutos");
            z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ahora quiero segundos");
            f = Convert.ToInt32(Console.ReadLine());


            do
            {
                z = z + 1;
                f = f - 60;
            }
            while (f >= 60);

            do
            {
                y = y + 1;
                z = z - 60;
            }
            while (z >= 60);

            do
            {
                x = x + 1;
                y = y - 24;
            }
            while (y >= 24);

            Console.WriteLine("");
            Console.WriteLine("Resumen");
            Console.WriteLine("Días: " + x);
            Console.WriteLine("Horas: " + y);
            Console.WriteLine("Minutos: " + z);
            Console.WriteLine("Segundos: " + f);



            //Bisiesto

            /*Crear una aplicación de consola en C# que pida un año por teclado y devuelva si
              es año bisiesto o no.
            */


            //Declaro variables y hago la pregunta al usuario
            int añico;
            Console.WriteLine("Dame un año y te diré si es bisiesto :)");

            añico = Convert.ToInt32(Console.ReadLine());

            //Hago al ordenador diferenciar los años bisiestos

            if ((añico % 400 == 0) && (añico != 0))
            {
                Console.WriteLine("Es bisiesto");

            }

            else if ((añico % 100 == 0) && (añico != 0))
            {
                Console.WriteLine("No es bisiesto");
            }

            else if ((añico % 4 == 0) && (añico != 0))
            {
                Console.WriteLine("Es bisiesto");
            }


            /* Para el resto de resultados que no sean divisibles entre nada de lo anterior
             * hago un mensaje aparte */
            else
            {
                Console.WriteLine("No es bisiesto");
            }







            // Traductor

            /* Crear una aplicación de consola en C# que pida un número por teclado del 1 al
               10 y muestre su traducción al inglés.
               Si el usuario introduce 0 se cierra la aplicación.
               Si el usuario introduce cualquier número que no esté comprendido entre 0 y 10 se
               le vuelve a pedir un número.   */



            // Declaro las variables de los números para luego poder adherirles las traducciones

            int input;

            //Pido el número
            Console.WriteLine("Dame un número entre el 1 y el 10 y te lo traduzco mejor que google");

            input = Convert.ToInt32(Console.ReadLine());

            if (input >= 11)
            {
                do
                {
                    Console.WriteLine("Vuelve a decir un número, que a mi no me la cuelas :/");
                    input = Convert.ToInt32(Console.ReadLine());
                }
                while (input >= 11);
            }

            if (input == 0)
            {
                Console.WriteLine("Cerrando...");
            }

            else if (input == 1)
            {
                Console.WriteLine("One");
            }

            else if (input == 2)
            {
                Console.WriteLine("Two");
            }

            else if (input == 3)
            {
                Console.WriteLine("Three");
            }

            else if (input == 4)
            {
                Console.WriteLine("Four");
            }

            else if (input == 5)
            {
                Console.WriteLine("Five");
            }

            else if (input == 6)
            {
                Console.WriteLine("Six");
            }

            else if (input == 7)
            {
                Console.WriteLine("Seven");
            }

            else if (input == 8)
            {
                Console.WriteLine("Eight");
            }

            else if (input == 9)
            {
                Console.WriteLine("Nine");
            }

            else if (input == 10)
            {
                Console.WriteLine("Ten");
            }




            //Factorial

            /*Crear una aplicación de consola en C# que calcule el factorial (N!) de un número
              N.
              El factorial de un entero positivo n, el factorial de n se define como el producto de todos los
              números enteros positivos (es decir, los números naturales) desde 1 hasta n.
            */

            Console.WriteLine("Escribe un número");

            int x;
            int y = 1;
            int z = Convert.ToInt32(Console.ReadLine());

            for (x = z; x > 1; --x)
            {
                y *= x;
                Console.WriteLine(y);
            }





            //Adivina número

            /*Crear una aplicación de consola en C# que genere un número aleatorio entre 1 y
              100 y pida al usuario que lo adivine.
              Cada vez que el usuario escriba un número entre 1 y 100 la aplicación le dirá si el
              número es mayor o menor que el que ha pensado.
              Cuando el usuario acierte el número se le dará la enhorabuena y se le dirá
              cuántos intentos han sido necesarios para acertar. */

            Random rnd = new Random();

            int randNum = rnd.Next(100);
            int x;
            int intentos = 0;

            Console.WriteLine("Escribe un número, a ver si aciertas majo :)");

            do
            {
                intentos = intentos + 1;
                x = Convert.ToInt32(Console.ReadLine());

                if (x < randNum)
                {
                    Console.WriteLine(x + " es menor que el número");
                }

                if (x > randNum)
                {
                    Console.WriteLine(x + " es mayor que el número");
                }

            }
            while (x != randNum);

            Console.WriteLine("Acertaste, enhorabuena!");
            Console.WriteLine("Necesitaste " + intentos + " intentos");




            // CUADROVOID

            /*
             * Crear una aplicación de consola en C# que genere un cuadro como en la imagen
               con X filas e Y columnas.
            */


            // Variables de entrada
            int i;
            int j;

            Console.WriteLine("Dime x (el ancho del cuadrado/rectángulo)");
            i = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ahora y (el alto del cuadrado/rectángulo)");
            j = Convert.ToInt32(Console.ReadLine());


            for (int auxJ = 0; auxJ < j; auxJ++)
            {
                for (int auxI = 0; auxI < i; auxI++)
                {
                    if (auxJ == 0 || auxJ == j - 1)
                    {
                        if (auxI == i - 1)
                        {
                            Console.WriteLine("X");
                        }
                        else
                        {
                            Console.Write("X");
                        }

                    }
                    else
                    {
                        if (auxI == 0)
                        {
                            Console.Write("X");
                        }
                        else if (auxI == i - 1)
                        {
                            Console.WriteLine("X");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
            }
        }
    }
}
