using System;
using System.IO;

// Miguel Rodríguez Gallego

namespace ExamenFinal_Programación1_MiguelRodríguezGallego
{
    class Program
    {

        // El ejercicio 1 es el main
        static void Main(string[] args)
        {
            //Esto simplemente es un menú para escoger el apartado a ejecutar anclando todos los métodos a un case
            int apartado;
            Console.WriteLine("Escoge que apartado de la práctica quieres ver: ");
            Console.WriteLine("1. Ejercicio 2");
            Console.WriteLine("2. Ejercicio 3");
            Console.WriteLine("3. Ejercicio 4");
            Console.WriteLine("4. Ejercicio 5");
            Console.WriteLine("5. Salir");
            // Leo la entrada del usuario para saber a que parte del menú quiere acceder
            apartado = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");

            // Creo un bucle para que el usuario solo pueda usar números del 1-5, y si no, le vuelve a pedir el dato para que no pueda salir de ninguna otra manera que no sea el menú
            while((apartado >= 6))
            {
                Console.WriteLine("Entrada no valida, escoge uno de los números del apartado");
                apartado = Convert.ToInt32(Console.ReadLine());
            }

            // Creo un switch para ligar los distintos ejercicios al menú de escoger
            switch (apartado)
            {
                case 1:
                    ejercicio2();
                    break;
                case 2:
                    ejercicio3();
                    break;
                case 3:
                    ejercicio4();
                    break;
                case 4:
                    ejercicio5();
                    break;
                case 5:
                    Console.WriteLine("Saliendo...");
                    break;
            }






            // Ejercicio Cuadrovoid
            static void ejercicio2()
            {
                // Variables de entrada
                int i;
                int j;

                // Recojo el ancho de la figura y lo ligo a la variable i
                Console.WriteLine("Dime x (el ancho del cuadrado/rectángulo)");
                i = Convert.ToInt32(Console.ReadLine());

                // Recojo el alto de la figura y la ligo a la variable j
                Console.WriteLine("Ahora y (el alto del cuadrado/rectángulo)");
                j = Convert.ToInt32(Console.ReadLine());


                // Creo un bucle for en el que establezco la variable de nº entero "auxj" y hago que mientras sea menor a "j" se sume en 1. (Recordar que j es el alto)
                for (int auxJ = 0; auxJ < j; auxJ++)
                {
                    // Hago lo mismo que en el anterior bucle pero con "I", el ancho.
                    for (int auxI = 0; auxI < i; auxI++)
                    {
                        // Hago que mientras "auxJ" sea igual a 0 o sea igual a "j - 1" se den dos opciones
                        if (auxJ == 0 || auxJ == j - 1)
                        {
                            // Aquí, cuando la auxiliar vale lo mismo que "i-1" se escribe en una linea X, haciendo pasar al programa a otra linea y por lo tanto dejando hueco en medio
                            if (auxI == i - 1)
                            {
                                Console.WriteLine("X");
                            }
                            // Aquí, si no se da el caso anterior se escribe una "X" sin más, permitiendo escribir a la consola otra en la misma fila si el programa lo requiere para no dejar espacio entremedias
                            else
                            {
                                Console.Write("X");
                            }

                        }
                        // Aquí, si no se da el caso de que el auxiliar de "J" es 0, se busca que se den otros casos de escritura de código
                        else
                        {
                            // Aquí, si el auxiliar del ancho es igual al ancho se escriben tantas X como requiera el programa
                            if (auxI == 0)
                            {
                                Console.Write("X");
                            }
                            // Escribo en una linea una "X" si el auxiliar del ancho, "I", es igual a "i-1"
                            else if (auxI == i - 1)
                            {
                                Console.WriteLine("X");
                            }
                            // Aquí establezco los posibles espacios entremedias para que no queden todas las "X" juntas sin espacio si no se da ninguno de los anteriores casos
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                    }
                }
            }







            // Ejercicio Factorial
            static void ejercicio3()
            {
                // Pido al usuario un número
                Console.WriteLine("Escribe un número");

                // Establezco las variables necesarias para el bucle del factorial y recojo la variable z del usuario para usarla en el bucle for
                int x;
                int y = 1;
                int z = Convert.ToInt32(Console.ReadLine());

                // Establezco un bucle for en el que se producen diversas operaciones con las que se obtiene el factorial del número escrito en pantalla
                for (x = z; x > 1; --x)
                {
                    y *= x;
                    Console.WriteLine(y);
                }
            }










            // Ejercicio Guardar y cargar datos de un usuario en un fichero
            static void ejercicio4()
            {
                // Declaro variables
                int a = 0;
                string i;
                string dato;

                // Creo el fichero
                StreamWriter sw = File.CreateText("textoUsuario.txt");

                //Recojo los datos introducidos por el usuario
                dato = Console.ReadLine();

                // Creo un bucle para que si el documento ya existe muestre por pantalla los datos que tiene dentro
                if("textoUsuario.txt" =! null)
                {
                    StreamReader sr = File.OpenText("textoUsuario.txt");
                    Console.WriteLine("El documento ya existe, y en el está escrito esto: " + sr);
                    File.AppendText(dato);
                }

                sw = Console.ReadLine();

            }








            // Ejercicio 5 - Conecta 3
            static void ejercicio5()
            {
                // Declaro variables de contabilización de puntos y jugador activo en la partida
                int jugadorActivo = 1;
                int cont1 = 0;
                int cont2 = 0;

                // Hago un bucle para que sigan haciendose más partidas tras terminar una
                while (cont1 + cont2 < 10)
                {
                    // Declaro variables ter para establecer los huecos en los que poner las "X" y "O", establecer turnos y el ganador de cada ronda
                    string[] ter = new string[27];

                    int jugada;
                    int i;
                    int ganador = 0;

                    // Inicializo el array a espacios en las casillas vacias 
                    for (i = 0; i < 27; i++)
                    {
                        ter[i] = " ";
                    }

                    // Bucle while para crear el tablero de nuevo mientras no haya ganador
                    while (ganador == 0)
                    {
                        // Muestro por pantalla la situación de la partida
                        Console.WriteLine("-----------");
                        Console.WriteLine("|" + ter[0] + "|" + ter[1] + "|" + ter[2] + "|" + ter[3] + "|" + ter[4] + "|");
                        Console.WriteLine("-----------");
                        Console.WriteLine("|" + ter[6] + "|" + ter[7] + "|" + ter[8] + "|" + ter[9] + "|" + ter[10] + "|");
                        Console.WriteLine("-----------");
                        Console.WriteLine("|" + ter[12] + "|" + ter[13] + "|" + ter[14] + "|" + ter[15] + "|" + ter[16] + "|");
                        Console.WriteLine("-----------");
                        Console.WriteLine("|" + ter[17] + "|" + ter[18] + "|" + ter[19] + "|" + ter[20] + "|" + ter[21] + "|");
                        Console.WriteLine("-----------");
                        Console.WriteLine("|" + ter[22] + "|" + ter[23] + "|" + ter[24] + "|" + ter[25] + "|" + ter[26] + "|");
                        Console.WriteLine("-----------");

                        Console.WriteLine(" ");
                        // Pido donde colocar su marca al jugador
                        Console.WriteLine("Jugador " + jugadorActivo + ": Del 1 al 9, ¿qué casilla desea cubrir?");
                        jugada = Convert.ToInt32(Console.ReadLine());

                        // Reduzco en 1 la entrada del usuario para asignar el indice del array correctamente(el hueco del tablero en el que quiero colocarlo, ya que va de 0-8)
                        i = jugada - 1;

                        // Si la casilla solicitada está vacía permito al usuario que la rellene
                        if (ter[i] == " ")
                        {
                            // Jugador 1
                            if (jugadorActivo == 1)
                            {
                                ter[i] = "X";
                                ganador = comprobarGanador("X", ter);
                                // Al terminar turno paso al otro jugador
                                jugadorActivo = 2;
                            }
                            // Jugador 2
                            else
                            {
                                ter[i] = "O";
                                ganador = comprobarGanador("O", ter);
                                // Al terminar turno paso al otro jugador
                                jugadorActivo = 1;
                            }
                        }
                        // Creo un else para repetir la jugada si algún jugador introduce su ficha en un espacio ocupado para que repita el turno junto a un mensaje por pantalla.
                        else
                        {
                            Console.WriteLine("Error! esa casilla ya está ocupada, introduce otro valor en otra casilla libre");
                        }
                    }

                    // Si ganador = 3 la partida ha empatado porque se han cubierto todas las casillas sin ganador
                    if (ganador == 3)
                    {
                        Console.WriteLine("Habeis empatado");
                    }
                    else
                    {
                        // Expongo por pantalla quien ha ganado
                        Console.WriteLine("El ganador es el jugador: " + ganador);

                        // Si la variable "jugadorActivo" es igual a 1 se suma una ronda ganada a su marcador, si no, en el else se contabiliza al jugador 2
                        if (ganador == 1)
                        {
                            cont1++;
                        }
                        else
                        {
                            cont2++;
                        }
                    }
                    // Escribo por pantalla el nº de rondas que ha ganado cada uno
                    Console.WriteLine("El jugador 1 lleva " + cont1 + " victorias");
                    Console.WriteLine("El jugador 2 lleva " + cont2 + " victorias");
                }
            }

            // Creo un método para comprobar si algun jugador gana la ronda introduciendo todas las posibles soluciones
            static int comprobarGanador(string jugador, string[] ter)
            {
                if ((ter[0] == jugador && ter[1] == jugador && ter[2] == jugador) ||
                    (ter[3] == jugador && ter[4] == jugador && ter[5] == jugador) ||
                    (ter[6] == jugador && ter[7] == jugador && ter[8] == jugador) ||
                    (ter[0] == jugador && ter[3] == jugador && ter[6] == jugador) ||
                    (ter[1] == jugador && ter[4] == jugador && ter[7] == jugador) ||
                    (ter[2] == jugador && ter[5] == jugador && ter[8] == jugador) ||
                    (ter[0] == jugador && ter[4] == jugador && ter[8] == jugador) ||
                    (ter[2] == jugador && ter[4] == jugador && ter[6] == jugador))
                {
                    // Si algun jugador introduce los números con los que se gana, devuelvo la respuesta de que ha ganado
                    if (jugador == "X")
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
                if (ter[0] != " " && ter[1] != " " && ter[2] != " " && ter[3] != " " && ter[4] != " " && ter[5] != " " && ter[6] != " " && ter[7] != " " && ter[8] != " " && 
                    ter[9] != " " && ter[10] != " " && ter[11] != " " && ter[12] != " " && ter[13] != " " && ter[14] != " " && ter[15] != " " && ter[16] != " " && ter[17] != " " &&
                    ter[18] != " " && ter[19] != " " && ter[20] != " " && ter[21] != " " && ter[22] != " " && ter[23] != " " && ter[24] != " " && ter[25] != " " && ter[26] != " ")
                {
                    // Si nadie gana devuelvo el valor 3
                    return 3;
                }
                return 0;
            }
        }
    }
}
