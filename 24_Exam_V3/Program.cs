using System;
using System.IO;

namespace ExamenProgI
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("1 - Ejercicio 2");
                Console.WriteLine("2 - Ejercicio 3");
                Console.WriteLine("3 - Ejercicio 4");
                Console.WriteLine("4 - Ejercicio 5");
                Console.WriteLine("5 - Salir");
                Console.WriteLine("Selecciona un ejercicio");
                input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        Ejercicio2();
                        break;

                    case 2:
                        Ejercicio3();
                        break;

                    case 3:
                        Ejercicio4();
                        break;

                    case 4:
                        Ejercicio5();
                        break;

                    case 5:
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Error en la selección");
                        break;
                }
            }
        }

        static void Ejercicio2()
        {
            // Corregido en clase
        }

        static void Ejercicio3()
        {
            int input;
            int resultado;
            Console.WriteLine("Dame un número para calcular el factorial");
            input = Convert.ToInt32(Console.ReadLine());
            resultado = Factorial(input);
            Console.WriteLine("El factorial de " + input + " es " + resultado);
            //Console.WriteLine(Factorial(Convert.ToInt32(Console.ReadLine())));
        }

        static void Ejercicio4()
        {
            // Parte 1 (cargar)
            StreamReader ficheroLectura;
            string linea;

            // Si el fichero existe
            if (File.Exists("fichero.txt"))
            {
                // Abrir fichero
                ficheroLectura = File.OpenText("fichero.txt");
                do
                {
                    // Leer fichero
                    linea = ficheroLectura.ReadLine();
                    Console.WriteLine(linea);
                } while (linea != null);

                // Cerrar fichero
                ficheroLectura.Close();
            }

            // Parte 2 (guardar)
            StreamWriter ficheroEscritura;
            bool salir = false;
            string input;

            // Append fichero
            ficheroEscritura = File.AppendText("fichero.txt");

            while (salir == false)
            {
                // Escribir en fichero
                Console.WriteLine("Escribe algo para añadir al fichero");
                input = Console.ReadLine();

                if (input != "salir")
                {
                    ficheroEscritura.WriteLine(input);
                }
                else
                {
                    // Cerrar fichero
                    ficheroEscritura.Close();
                    salir = true;
                }
            }
        }

        static void Ejercicio5()
        {
            bool salir = false;
            int jugador = 1;
            int input;
            string[,] tablero;


            tablero = Initialize();

            while (!salir)
            {
                Mostrar(tablero);
                Console.WriteLine("Jugador " + jugador + ". Elije una columna");
                input = Convert.ToInt32(Console.ReadLine());
                if (PonerFicha(input - 1, jugador, ref tablero))
                {
                    salir = true;
                }
                SiguienteJugador(ref jugador);
            }
        }

        static void SiguienteJugador(ref int jugador)
        {
            if (jugador == 1)
            {
                jugador = 2;
            }
            else
            {
                jugador = 1;
            }
        }

        static bool PonerFicha(int columna, int jugador, ref string[,] tablero)
        {
            bool vacia = false;
            if (jugador == 1)
            {
                int aux = 4;
                while (!vacia && aux >= 0)
                {
                    if (EstaVacia(columna, aux, tablero))
                    {
                        vacia = true;
                        tablero[columna, aux] = "X";
                        if (CompruebaVictoria(columna, aux, jugador, tablero))
                        {
                            Console.WriteLine(jugador + " gana");
                            return true;
                        }
                        else
                        {
                            if (CompruebaVictoriaAdyacentes(columna, aux, jugador, tablero))
                            {
                                Console.WriteLine(jugador + " gana");
                                return true;
                            }
                        }
                    }
                    aux--;
                }
            }
            else
            {
                int aux = 4;
                while (!vacia && aux >= 0)
                {
                    if (EstaVacia(columna, aux, tablero))
                    {
                        vacia = true;
                        tablero[columna, aux] = "O";
                        if (CompruebaVictoria(columna, aux, jugador, tablero))
                        {
                            Console.WriteLine(jugador + " gana");
                            return true;
                        }
                        else
                        {
                            if (CompruebaVictoriaAdyacentes(columna, aux, jugador, tablero))
                            {
                                Console.WriteLine(jugador + " gana");
                                return true;
                            }
                        }
                    }
                    aux--;
                }
            }
            return false;
        }

        static bool CompruebaVictoriaAdyacentes(int columna, int fila, int jugador, string[,] tablero)
        {
            string comp;
            if (jugador == 1)
            {
                comp = "X";
            }
            else
            {
                comp = "O";
            }

            // Comprobación 1
            if (tablero[columna - 1, fila - 1] == comp)
            {
                if (CompruebaVictoria(columna - 1, fila - 1, jugador, tablero))
                {
                    return true;
                }
            }
            // Faltan 5 más

            return false;
        }
        static bool CompruebaVictoria(int columna, int fila, int jugador, string[,] tablero)
        {
            string comp;
            if (jugador == 1)
            {
                comp = "X";
            }
            else
            {
                comp = "O";
            }

            if (fila <= 2)
            {
                if (tablero[columna, fila - 1] == comp && tablero[columna, fila - 2] == comp)
                {
                    return true;
                }
            }

            if (columna == 0 && columna == 4)
            {
                return false;
            }

            if (tablero[columna - 1, fila - 1] == comp && tablero[columna + 1, fila + 1] == comp)
            {
                return true;
            }
            if (tablero[columna - 1, fila] == comp && tablero[columna + 1, fila] == comp)
            {
                return true;
            }
            if (tablero[columna - 1, fila + 1] == comp && tablero[columna + 1, fila - 1] == comp)
            {
                return true;
            }

            return false;
        }

        static bool EstaVacia(int columna, int fila, string[,] tablero)
        {
            if (tablero[columna, fila] == ".")
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        static string[,] Initialize()
        {
            string[,] tablero = new string[5, 5];
            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 5; x++)
                {
                    tablero[x, y] = ".";
                }
            }

            return tablero;
        }

        static void Mostrar(string[,] tablero)
        {
            Console.Clear();
            Console.WriteLine("\t1\t2\t3\t4\t5");
            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 5; x++)
                {
                    if (x != 4)
                    {
                        Console.Write("\t" + tablero[x, y]);
                    }
                    else
                    {
                        Console.WriteLine("\t" + tablero[x, y]);
                    }
                }
            }
            Console.WriteLine();
        }





        static int Factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            return n * Factorial(n - 1);
        }
    }
}
