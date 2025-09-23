using System;

namespace ProgramaTestingFicheros
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] p1Board = InitilizeBoard();

            CreateShip(1, ref p1Board);
            CreateShip(2, ref p1Board);
            CreateShip(3, ref p1Board);

            ShowBoard(p1Board);
        }

        // Método que crea un nuevo barco de un tamaño específico con el input del usuario
        static void CreateShip(int size, ref string[,] board)
        {
            // Switch de claridad para user
            switch(size)
            {
                case 1:
                    Console.WriteLine("Creando barco de una casilla");
                    break;
                case 2:
                    Console.WriteLine("Creando barco de dos casillas");
                    break;
                case 3:
                    Console.WriteLine("Creando barco de tres casillas");
                    break;
                default:
                    // Error de compilación no debería suceder nunca
                    Console.WriteLine("Error llamando el método CreateShip (revisar el size)");
                    break;
            }
            int x = 0;
            int y = 0;
            bool salir = false;
            // Gestión de la primera casilla
            while (!salir)
            {
                Console.WriteLine("Introduce una casilla para el nuevo barco");
                Console.WriteLine("X entre 1 y 5: ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Y entre 1 y 5: ");
                y = Convert.ToInt32(Console.ReadLine());
                
                if (board[x - 1, y - 1] == "X")
                {
                    Console.WriteLine("Casilla ya ocupada");
                }
                else
                {
                    salir = true;
                }
            }
            board[x-1, y-1] = "X";

            // Cuando el tamaño es 2 o más
            if(size != 1)
            {
                int count = 1;
                bool isHorizontal = true;
                int nX = 0;
                int nY = 0;
                // Gestión de la 2a y 3a casillas
                while (count != size)
                {
                    salir = false;
                    while (!salir)
                    {
                        Console.WriteLine("Introduce una segunda casilla para el nuevo barco");
                        Console.WriteLine("X entre 1 y 5: ");
                        nX = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Y entre 1 y 5: ");
                        nY = Convert.ToInt32(Console.ReadLine());

                        if (board[nX - 1, nY - 1] == "X")
                        {
                            Console.WriteLine("Casilla ya ocupada");
                        }
                        else if(Math.Abs(x - nX) == 1 && y == nY) // Adyacente horizontal
                        {
                            if(count >= 2 && !isHorizontal)
                            {
                                Console.WriteLine("Casilla no adyacente en línea");
                            }
                            else
                            {
                                // Creamos casilla de barco
                                board[nX - 1, nY - 1] = "X";
                                count++;
                                x = nX;
                                y = nY;
                                isHorizontal = true;
                                salir = true;
                            }
                        }
                        else if (Math.Abs(y - nY) == 1 && x == nX) // Adyacente vertical
                        {
                            if (count >= 2 && isHorizontal)
                            {
                                Console.WriteLine("Casilla no adyacente en línea");
                            }
                            else
                            {
                                // Creamos casilla de barco
                                board[nX - 1, nY - 1] = "X";
                                count++;
                                x = nX;
                                y = nY;
                                isHorizontal = false;
                                salir = true;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Casilla no adyacente");
                        }
                    }
                }
            }
        }

        static string[,] InitilizeBoard()
        {
            string[,] result = new string[5, 5];

            for(int x = 0; x < 5; x++)
            {
                for (int y = 0; y < 5; y++)
                {
                    result[x, y] = "O";
                }
            }

            return result;
        }

        static void ShowBoard(string[,] board)
        {
            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 5; x++)
                {
                    if(x == 4)
                    {
                        Console.WriteLine(board[x, y]);
                    }
                    else
                    {
                        Console.Write(board[x, y] + " ");
                    }
                }
            }
        }
    }
}
