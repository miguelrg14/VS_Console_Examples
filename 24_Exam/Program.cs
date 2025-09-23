// Miguel Rodríguez Gallego

using System;
using System.IO;

namespace ExamenProgramacionI_MiguelRodríguezGallego
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();          
        }

        static void Menu()
        {
            // Declaro la elección del menú al jugador
            int eleccion;
            // Declaro una booleana para cuando el usuario quiera salir del menú
            bool salir = false;

            // Bucle menú Principal para que no salga mientras el usuario no escriba "5"
            while (salir != true)
            {
                // Muestro el menú por consola
                Console.WriteLine(" ");
                Console.WriteLine("Decide que ejercicio del examen ver");
                Console.WriteLine(" ");
                Console.WriteLine("1 - Cuadrovoid");
                Console.WriteLine("2 - Fibonacci");
                Console.WriteLine("3 - Guardar y cargar");
                Console.WriteLine("4 - Tres en raya");
                Console.WriteLine("5 - Salir");
                Console.WriteLine(" ");

                // Recojo el dato del menú por consola
                eleccion = Convert.ToInt32(Console.ReadLine());

                // Creo el menú mediante un switch que recoje la elección del usuario
                switch (eleccion)
                {
                    // 1 - Cuadrovoid
                    case 1:
                        {
                            // Llevo al programa al método cuadrovoid con el ejercicio hecho
                            Cuadrovoid();

                            Console.WriteLine(" ");
                            Console.WriteLine("Pulsa una tecla para volver al menú principal");
                            Console.ReadKey();
                            Console.WriteLine(" ");
                            Console.Clear();
                            break;
                        }
                    // 2 - Fibonacci
                    case 2:
                        {
                            Console.WriteLine("Dame un valor para hacerle Fibonacci");
                            int valor;
                            int rec;

                            for (valor = 1; valor <= 10; valor++)
                            {
                                rec = Fibonacci(valor);
                                Console.WriteLine(rec);
                            }
                            break;
                        }

                    // 3 - Guardar y cargar
                    case 3:
                        {
                            GuardarYCargar();
                            break;
                        }

                    // 4 - Tres en raya
                    case 4:
                        {
                            TresEnRaya();
                            break;
                        }

                    // 5 - Salir
                    case 5:
                        {
                            salir = true;
                            Console.WriteLine("Saliendo...");
                            break;
                        }

                    // "Default" ==> Para cuando el usuario escriba cualquier otra cosa que no sea un Nº entre 1 - 5 (fuera de los baremos del menú)
                    default:
                        {
                            Console.WriteLine("Valor incorrecto, vuelve a introducir otro valor del menú!");
                            Console.WriteLine(" ");
                            break;
                        }
                }
            }
        }

        // 1 - Cuadrovoid
        static void Cuadrovoid()
        {
            // Declaro las variables
            int x;
            int y;

            // Pido y recojo los valores por consola
            Console.WriteLine("Dime x (el ancho del cuadrado/rectángulo)");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ahora y (el alto del cuadrado/rectángulo)");
            y = Convert.ToInt32(Console.ReadLine());

            /* Bucle for para crear el cuadrovoid mediante los valores recojidos, 
             * creando variables internas en el bucle que se sumen cada vez que
               se coloque una "X" y por lo tanto sirvan como contador
            */
            for (int auxY = 0; auxY < y; auxY++)
            {
                for (int auxX = 0; auxX < x; auxX++)
                {
                    // Mediante las auxiliares hago que mientras ["auxY" == 0] o ["auxY" == y - 1] se escriba una X en el eje x e y
                    if (auxY == 0 || auxY == y - 1)
                    {
                        if (auxX == x - 1)
                        {
                            Console.WriteLine("X");
                        }
                        else
                        {
                            Console.Write("X");
                        }

                    }
                    // Sino...
                    else
                    {
                        // Para arreglar la columna de la izquierda hago que si el eje x = 0, se escriba una x
                        if (auxX == 0)
                        {
                            Console.Write("X");
                        }
                        // Para arreglar la columna de la derecha hago que si el eje x = x - 1 se escriba x
                        else if (auxX == x - 1)
                        {
                            Console.WriteLine("X");
                        }
                        // Establezco los espacios intermedios del cuadrado en el los lados verticales izquierdo y derecho
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
            }            
        }
        
        // 2 - Fibonacci
        public static int Fibonacci(int num)
        {
            if ((num == 0) || (num == -1))
            {
                return 1;
            }

            else
            {
                return Fibonacci(num - 1) + Fibonacci(num - 2);
            }
        }
        
        // 3 - Guardar y cargar
        static void GuardarYCargar()
        {
            // LEER ARCHIVO ANTES DE GUARDAR NADA
            // Parte para ver si ya hay algo guardado en el archivo o no
            // Declaro las variables para leer el fichero & leer las lineas de código a mostrar por pantalla
            StreamReader sr;
            string texto;

            // Para solucionar errores pongo este bucle que revisa si el fichero existe
            if (File.Exists("datos.txt"))
            {
                // Abro el fichero
                sr = File.OpenText("datos.txt");

                // Leo y escribo por pantalla las lineas de texto mientras no haya ninguna línea vacía
                do
                {
                    texto = sr.ReadLine();
                    Console.WriteLine(texto);
                } while (texto != null);

                // Cierro el fichero tras usarlo
                sr.Close();
            }

            // GUARDAR INFORMACIÓN
            StreamWriter sw;
            bool salir = false;
            string valorEntrada;

            // Uso un append para escribir al final del fichero y crear uno nuevo si no existe
            sw = File.AppendText("datos.txt");

            // En este bucle uso la booleana salir para que se repita hasta que el usuario escriba en el input "salir"
            while (salir == false)
            {
                // Leo por consola y escribo los datos en el fichero
                Console.WriteLine("Escribe algo para añadir al fichero");
                valorEntrada = Console.ReadLine();

                if (valorEntrada != "salir")
                {
                    // Escribo en el fichero mediante el streamreader, el valor de entrada y un "WriteLine"
                    sw.WriteLine(valorEntrada);
                }
                else
                {
                    // Cierro el fichero tras usarlo para evitar errores e igualo la booleana salir a "true" para terminar el bucle
                    sw.Close();
                    salir = true;
                }
            }
        }

        // 4 - Tres en raya
        static void TresEnRaya()
        {
            {
                // Declaro variables de contabilización de puntos y jugador activo en la partida
                int jugadorActivo = 1;
                int cont1 = 0;
                int cont2 = 0;

                // Hago un bucle para que sigan haciendose más partidas tras terminar una
                while (cont1 + cont2 < 10)
                {
                    // Declaro variables ter para establecer los huecos en los que poner las "X" y "O", establecer turnos y el ganador de cada ronda
                    string[] ter = new string[9];

                    int jugada;
                    int i;
                    int ganador = 0;

                    // Inicializo el array a espacios en las casillas vacias 
                    for (i = 0; i < 9; i++)
                    {
                        ter[i] = " ";
                    }


                    // Bucle while para crear el tablero de nuevo mientras no haya ganador
                    while (ganador == 0)
                    {

                        // Muestro por pantalla la situación de la partida
                        Console.WriteLine("-------");
                        Console.WriteLine("|" + ter[0] + "|" + ter[1] + "|" + ter[2] + "|");
                        Console.WriteLine("-------");
                        Console.WriteLine("|" + ter[3] + "|" + ter[4] + "|" + ter[5] + "|");
                        Console.WriteLine("-------");
                        Console.WriteLine("|" + ter[6] + "|" + ter[7] + "|" + ter[8] + "|");
                        Console.WriteLine("-------");

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
                                ganador = ComprobarGanador("X", ter);
                                // Al terminar turno paso al otro jugador
                                jugadorActivo = 2;
                            }
                            // Jugador 2
                            else
                            {
                                ter[i] = "O";
                                ganador = ComprobarGanador("O", ter);
                                // Al terminar turno paso al otro jugador
                                jugadorActivo = 1;
                            }
                        }
                        // Creo un else para repetir la jugada si algún jugador introduce su ficha en un espacio ocupado para que repita el turno junto a un mensaje por pantalla.
                        else
                        {
                            Console.WriteLine("Error, casilla ocupada! introduce otro valor");
                        }
                    }

                    // Si ganador = 3 la partida ha empatado porque se han cubierto todas las casillas sin ganador
                    if (ganador == 3)
                    {
                        Console.WriteLine("Habeis empatado, volved a jugar hasta que gane 1!");
                    }
                    else
                    {
                        // Expongo por pantalla quien ha ganado
                        Console.WriteLine(" ");
                        Console.WriteLine("Victoria!!!");
                        Console.WriteLine(" ");
                        Console.WriteLine("El ganador es el jugador: " + ganador);

                        Console.WriteLine(" ");
                        Console.WriteLine("Pulsa una tecla para volver al menú principal");
                        Console.ReadKey();
                        Console.WriteLine(" ");
                        Console.Clear();

                        Menu();
                    }                   
                    
                }                
            }
        }
        // Compruebo si algún jugador gana la ronda introduciendo todas las posibles soluciones
        static int ComprobarGanador(string jugador, string[] ter)
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
                // Si algun jugador gana devuelvo la respuesta de que ha ganado
                if (jugador == "X")
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
            if (ter[0] != " " && ter[1] != " " && ter[2] != " " && ter[3] != " " && ter[4] != " " && ter[5] != " " && ter[6] != " " && ter[7] != " " && ter[8] != " ")
            {
                // Si nadie gana devuelvo el valor 3
                return 3;
            }
            return 0;
        }
    }
}
