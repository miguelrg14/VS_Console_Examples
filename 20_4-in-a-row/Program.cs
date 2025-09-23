using System;

namespace _4EnRayaExamen
{
    class Program
    {
        static void Main(string[] args)
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
    }
}
