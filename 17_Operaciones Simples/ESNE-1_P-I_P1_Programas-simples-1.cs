using System;

namespace Miguel_Rodríguez_Gallego
{
    class Program
    {
        static void Main(string[] args)
        {
            //Esto simplemente es un menú para escoger el apartado a ejecutar anclando todos los métodos a un case
            int apartado;
            Console.WriteLine("Escoge que apartado de la práctica quieres ver poniendo un nº entre 1-4");
            apartado = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");
            switch (apartado)
            {
                case 1:
                    apartado1();
                    break;
                case 2:
                    apartado2();
                    break;
                case 3:
                    apartado3();
                    break;
                case 4:
                    apartado4();
                    break;
            }
        }

        static void apartado1()
        {
            // Declaro las variables para el valor actual que pido, el anterior y la diferencia final.

            int valAct = 0;
            int valAnt = 0;
            int dif = 0;

            //Pido al usuario una cadena de números

            Console.WriteLine("Introduce una serie de números y escribe uno negativo para pararla cuando quieras");

            // Hago un bucle en el que pido números hasta que el usuario me de uno negativo. 

            do
            {
                /* Igualo los números para que la variable "ValAnt" vaya haciendo de memoria para los 
                 * posibles casos siguientes de la cadena.
                 */
                valAnt = valAct;


                //Leo el número que introduce el usuario
                valAct = Convert.ToInt32(Console.ReadLine());


                /*Pongo dos "ifs" para ver si el último valor cogido por el usuario es mayor que el anterior,
                 * con lo cual si no lo es, el programa me da la diferencia máxima.
                 */
                if (valAct > valAnt)
                {
                    // Aquí recojo la mayor diferencia entre números con la variable nueva: "Dif".
                    if (valAct - valAnt > dif)
                    {
                        dif = valAct - valAnt;
                    }
                }

                /*Este "else if" sirve para que cuando el usuario introduzca dos valores iguales, se 
                 * termine la cadena dando error
                 */
                else if (valAnt == valAct)
                {
                    Console.WriteLine("Serie no válida! Escribiste un número igual que el anterior y rompiste la cadena");
                    break;
                }

                /*Este "else" sirve para que cuando el usuario introduzca un valor menor al anterior se 
                 * termine la cadena dando error
                 */
                else
                {
                    Console.WriteLine("Serie no válida! Escribiste un número menor que el anterior y rompiste la cadena");
                    break;
                }

            } while (valAct >= 0);

            // Cuando se termina el bucle se escribe la mayor diferencia de números de la cadena.
            Console.WriteLine("La mayor diferencia entre números es: " + dif);
            Console.ReadKey();
        }


        static void apartado2()
        {
            /*Declaro Variables (pongo como string a "valRecog" para que también acepte como
             * posible error una letra y no solo un número. Si declaro solo los números y pongo
             * una letra el programa se bloquearía)
             */
            string valRecog;
            int cont = 1;


            //Abro un bucle "do while" para que el programa se pare al coger 3 recompensas
            do
            {
                //Pregunto por el número y lo recojo
                Console.WriteLine("Escoge una puerta (1-5). Intento #" + cont);
                valRecog = Console.ReadLine();

                //Abro las diversas salidas del 1-5 en un switch
                switch (valRecog)
                {
                    case "1":
                        Console.WriteLine("Te ha tocado un Mercedes");
                        break;

                    case "2":
                        Console.WriteLine("Te ha tocado el nuevo Call of Duty");
                        break;

                    case "3":
                        Console.WriteLine("Te ha tocado la PlayStation 5");
                        break;

                    case "4":
                        Console.WriteLine("Te ha tocado un PC Gaming");
                        break;

                    case "5":
                        Console.WriteLine("Te ha tocado un viaje a Miami");
                        break;

                }

                /*Creo un if para que se me contabilice que el número es de 1-5 y así lograr hacer
                 * al programa llevar la cuenta del número de recompensas recogidas
                 */
                if (valRecog == "1" | valRecog == "2" | valRecog == "3" | valRecog == "4" | valRecog == "5")
                {
                    cont += 1;
                }
                //Preparo un else por si lo que introdujo el usuario no es valido para que no contabilice y muestre un mensaje de error
                else
                {
                    Console.WriteLine("Entrada no valida, vuelve a escribir un número entre 1-5.");
                }

            } while (cont < 4);
        }

        static void apartado3()
        {
            /* declaro en float las variables que recogen los datos de género y edad porque más
             * adelante las voy a tener que dividir para obtener porcentajes con decimales.
             * Además, recojo la variable valRecog en string porque así podré hacer un switch
             * más fácil de cadenas de texto.
             */
            float o = 0;
            float a = 0;
            float h = 0;
            float m = 0;
            string valRecog;
            float total = 0;

            //Pido una secuencia de números al usuario
            Console.WriteLine("Introduzca secuencia (O/A/H/M):");

            /*Hago un bucle "do while(valRecog == "o" | valRecog == "a" | valRecog == "h" | valRecog == "m")"
             * para que si el valor recogido dentro de este no es ninguna de esas letras se termine el bucle y me
             * de la estadística final.
             */
            do
            {
                /* Recojo los caracteres con "Console.ReadLine".
                 * El ".ToLower()" pasa todos los caracteres leídos en el "ReadLine" a mayúscula.
                 */
                valRecog = Console.ReadLine().ToLower();

                switch (valRecog)
                {
                    /*En cada case pongo la variable correspondiente y ++ para que se acumule la 
                     * cantidad total para la estadística final
                     */
                    case "o":
                        o++;
                        break;

                    case "a":
                        a++;
                        break;

                    case "h":
                        h++;
                        break;

                    case "m":
                        m++;
                        break;
                }
            } while (valRecog == "o" | valRecog == "a" | valRecog == "h" | valRecog == "m");

            //Sumo todo para dar el total final
            total = o + a + h + m;
            Console.WriteLine("Total individuos: " + total);

            //Últimas operaciones para mostrar los resultados finales de la estadística
            Console.WriteLine("Niños: " + o + " (" + (o / total) * 100 + "%)");
            Console.WriteLine("Niñas: " + a + " (" + (a / total) * 100 + "%)");
            Console.WriteLine("Hombres adultos: " + h + " (" + (h / total) * 100 + "%)");
            Console.WriteLine("Mujeres adultas: " + m + " (" + (m / total) * 100 + "%)");
        }

        static void apartado4()
        {
            /*Declaro las variables ("numComp" para el número completo que recojo al principio; 
             * "primerNum" para la primera cifra y "segundoNum" para la segunda)
             */
            int numComp;
            int primerNum;
            int segundoNum;

            //Pido un número de 2 cifras al usuario
            Console.WriteLine("Dime un número de 2 cifras");

            //Convierto el string recogido del usuario a int para poder operar con el
            numComp = Convert.ToInt32(Console.ReadLine());

            //Abro un if para limitar los valores que me de el usuario a números entre 10 y 99
            if (numComp >= 10 | numComp < 100)
            {
                //Opero el nº entre 10 para obtener el primer entero y guardarlo para después
                primerNum = numComp / 10;

                //Cojo el resto de la operación(que viene a ser la 2ª cifra) para moverlo luego de sitio
                segundoNum = numComp % 10;

                //Abro otro if para dar error si el usuario mete un valor de más/menos de 2 cifras 
                if (numComp < 10 | numComp >= 100)
                {
                    Console.WriteLine("Error. Ese número tiene más de 2 cifras. Vuelve a intentarlo");
                }

                //Meto un else por si el valor final es válido para que este se muestre por pantalla
                else
                {
                    Console.WriteLine("El número invertido es " + segundoNum + primerNum);
                }

            }
        }
    }
}
