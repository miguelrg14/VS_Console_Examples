using System;

namespace _4._Control_de_flujo__Boole_y_operadores_lógicos_expresiones_condicionales_if__else_y_else_if__
{
    class Program
    {
        static void Main(string[] args)
        {

            // CLASE 4    (BORRADOR)

            //COntrol de Flujjo - LÓGICA DE BOOLE y Operadores Lógicos (orden de prioridad para averiguar si el resultado final es verdadero o falso)

            //EJERCICIOS BOOLE
            // APARTADO 1

            bool result01 = (2 > 5 || 4 == 4 && 6 <= 7);
            Console.WriteLine(result01);


            //APARTADO 2

            bool result02;
            int num;

            Console.WriteLine("escribe un número cualquiera");
            num = Convert.ToInt32(Console.ReadLine());

            result02 = num == 10;
            Console.WriteLine(num == 10);


            //Apartado 3

            bool result3;
            int num3;

            Console.WriteLine("escribe un número cualquiera");
            num3 = Convert.ToInt32(Console.ReadLine());

            result3 = num3 != 5;
            Console.WriteLine(num3 != 5);


            //2ª manera de hacer el Apartado 3

            bool result4;
            int num4;

            Console.WriteLine("escribe un número cualquiera");
            num4 = Convert.ToInt32(Console.ReadLine());

            result4 = !(num4 == 5);
            Console.WriteLine(!(num4 == 5));

            /* 3ª manera

            result = num == 5;
            Console.WriteLine(!result4);

            */



            //EXPRESIONES CONDICIONALES - Ejercicios

            /*      if(expresion) ==> expresión puede ser True/False y si pongo "false" entre paréntesis se ejecutará el código si la operación anterior da "false"
             *
             *      if(expresion)
             *      {
             *      num23==24
             *      }
             *      
             *      else if(expresion)
             *      {
             *      
             *      }
             */

            int num6;

            Console.WriteLine("introduce un número");
            num6 = Convert.ToInt32(Console.ReadLine());

            if (num6 > 10)
            {
                Console.WriteLine("es mayor que 10");
            }


            //Ejercicios "if"

            int x;
            int y;
            int z;

            Console.WriteLine("introduce un número");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ahora otro");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("te prometo que es el último");
            z = Convert.ToInt32(Console.ReadLine());

            if ((x > 50) && (y > 50) && (z > 50))
            {
                Console.WriteLine("buena Tula Bro!");
            }

            // Tmb se puede hacer con la expresión "o" denominada en programación "||" así: else if((x > 50) && (y > 50) || (x > 50) && (z > 50) || (z > 50) && (y > 50))


            else if ((x > 50) && (y > 50))
            {
                Console.WriteLine("2 son demasiado grandes");
            }

            else if ((x > 50) && (z > 50))
            {
                Console.WriteLine("2 son demasiado grandes");
            }

            else if ((z > 50) && (y > 50))
            {
                Console.WriteLine("2 son demasiado grandes");
            }


            else if ((x > 50))
            {
                Console.WriteLine("1 está tocho");
            }

            else if ((y > 50))
            {
                Console.WriteLine("1 está tocho");
            }

            else if ((z > 50))
            {
                Console.WriteLine("1 está tocho");
            }


            // Con el else solo no debo justificar nada, cuenta como la última opción del programa por si acaso no funciona ninguna de las anteriores.

            else
            {
                Console.WriteLine("son todos demasiado bajos");
            }


            //CLASE 5 (BORRADOR)


            // Control de flujo - SWITCH    

            /* EXPLICACIÓN

            int myint = 3;
            switch (myint)
            {
                case 0:

                    Console.WriteLine("user has typed 0");
                    break;

                case 1
                :

                    Console.WriteLine("user has typed 1");
                    break;

                case 2:

                    Console.WriteLine("user has typed 2");
                    break;


            }

            */


            // EJERCICIO

            int P;

            Console.WriteLine("introduce un número");
            P = Convert.ToInt32(Console.ReadLine());


            switch (P)
            {
                case 0:

                    Console.WriteLine("user has typed 0");
                    break;

                case 1
    :

                    Console.WriteLine("user has typed 1");
                    break;

                case 2:

                    Console.WriteLine("user has typed 2");
                    break;

                case 3:

                    Console.WriteLine("te has pasao colega");
                    break;


            }


            // Control de Flujo - OPERADOR TERNARIO


            int myage = 19;
            Console.WriteLine(myage >= 19);




            // Control de Flujo - BUCLE "Do While"


            int u = 0;
            do
            {
                Console.WriteLine("Continuamos el bucle");
                Console.WriteLine("Terminamos el bucle");
                u++;
                /* el u++ aumenta el valor del "int u = 0" y le va sumando 1 a la vez que se repite el mensaje con cada suma,
                y así hasta que llega al valor 3 donde pararía el bucle. Si no se pone el u++ el bucle sería infinito
                */
            }
            while (u <= 3);



            //EJEMPLO - BUCLE WHILE

            //Pedir un número al usuario y asegurarse de que es un número correcto

            int number1 = 0;
            while (number1 >= 0)
            {
                Console.WriteLine("Dame un número. Introduce uno negativo para terminar");
                number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("El número introducido es:" + number1);
            }


            //Pedir un número al usuario y asegurarse de que es un número correcto

            int number2 = -1;
            bool correctNumber = false;

            do
            {
                string line = Console.ReadLine();
                correctNumber = Int32.TryParse(line, out number2);
            }
            while (!correctNumber);
            //este código no funciona



            // EJERCICIOS - Control de flujo

            // Control de flujo - Bucle "For"

            // For (rar comprobación, expresión comparación, ejecución final)

            /*Realizar un programa que muestre este menú:
             
                 Presiona 1 para empezar a jugar.
                 Presiona 2 para ver las opciones.
                 Presiona 3 para ver los créditos.
                 Presiona 4 para salir.

              Si el jugador presiona otra tecla diferente, el menú deberá decirle “Entrada inválida” y volverá a pintar el mensaje.
             
              Si el jugador pulsa una tecla del 1 al 3, el ordenador deberá mostrar el mensaje:

                 1)Vamos a empezar la partida
                 2) Cargando opciones
                 3) Cargando créditos
                 Después volver a mostrar el menú

              Si el jugador pulsa el 4
                 El ordenador dirá “Bye bye”
                 El programa se acabará
            */



            // 1




            int input;

            do
            {
                Console.WriteLine("Presiona 1 para empezar a jugar");
                Console.WriteLine("Presiona 2 para ver las opciones");
                Console.WriteLine("Presiona 3 para ver los créditos");
                Console.WriteLine("Presiona 4 para salir");

                input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 0:
                        Console.WriteLine("Entrada inválida");
                        break;

                    case 1:
                        Console.WriteLine("Vamos a empezar la partida");
                        break;

                    case 2:
                        Console.WriteLine("Cargando opciones");
                        break;

                    case 3:
                        Console.WriteLine("Cargando Créditos");
                        break;

                    case 4:
                        Console.WriteLine("Saliendo");
                        break;
                }

            }
            while (input != 4);


            /*
             * 
             * Esta es mi otra manera de hacer el ejercicio anterior. El único problema de esta manera es que 
             * el enunciado no se repite y por lo tanto solo sería correcta la forma en la que lo hizo el
             * profesor con "switch".
             * 
            Console.WriteLine("Presiona 1 para empezar a jugar");
            Console.WriteLine("Presiona 2 para ver las opciones");
            Console.WriteLine("Presiona 3 para ver los créditos");
            Console.WriteLine("Presiona 4 para salir");

            int r;
            r = Convert.ToInt32(Console.ReadLine());

            if (r <= 0)
            {
                Console.WriteLine("Entrada inválida");
            }

            else if (r == 1)
            {
                Console.WriteLine("Vamos a empezar la partida");
            }

            else if (r == 2)
            {
                Console.WriteLine("Cargando opciones");
            }

            else if (r == 3)
            {
                Console.WriteLine("Cargando Créditos");
            }


            else if (r == 4)
            {
                Console.WriteLine("Bye Bye");
                //Aquí falta el comando para que se acabe el comando

            }

            else if (r >= 5)
            {
                Console.WriteLine("Entrada inválida");
            }

            */



            //Formas de hacerlo:

            /*
            for (int aux = 1; aux <= 20; aux++) ;
            */

            /*
             Console.WriteLine(input + " por " + " aux " + " est "
            */



            /*
                Control de flujo - EJERCICIOS

                Pedirle al usuario un número y mostrar su tabla de multiplicar hasta el 20

                Pedirle al usuario un número y una cadena de texto
                    Repetir dicho texto tantas veces como el número que haya escrito el usuario
            */



            //Pedirle al usuario un número y mostrar su tabla de multiplicar hasta el 20

            int inputNum7;
            int multi;

            //Recogemos el input de usuario
            Console.WriteLine("introduzca un número");
            inputNum7 = Convert.ToInt32(Console.ReadLine());

            /*necesito una variable diferente que se vaya sumando una unidad cada vez que se ejecuta el for
             * hasta que llegue a 20.
             */

            for (int x = 1; x <= 20; x++)
            {

                multi = inputNum7 * x;
                Console.WriteLine(multi);

            }




            /*
                Pedirle al usuario un número y una cadena de texto
                    Repetir dicho texto tantas veces como el número que haya escrito el usuario
            */

            // Variables de entrada del usuario
            int inputNum;
            string inputTxt;

            //Recogemos el input de usuario
            Console.WriteLine("introduzca un número");
            inputNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca un texto");
            inputTxt = Console.ReadLine();

            do
            {
                Console.WriteLine(inputTxt);
                inputNum--;


            }
            while (inputNum >= 0);


            //Si pongo "Console.Clear();" después se borrarán todas las cadenas de texto que se repitan en pantalla.

            //Escribe el texto introducido "inputNum" veces

        }
    }
}
