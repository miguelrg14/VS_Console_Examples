using System;

namespace Ejercicio_barcos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] p1Board = InitilizeBoard();

            CreateShip1(1, ref p1Board);
            CreateShip2(2, ref p1Board);
            CreateShip3(3, ref p1Board);

            ShowBoard(p1Board);


        }

        // Método que crea un nuevo barco de un tamaño especifico con el input del usuario
        static void CreateShip(int size, ref string[,] board)
        {
            // Switch de claridad para usuario
            switch(size)
            {
                case 1:
                    Console.WriteLine("Creando barco de una casilla");
                    break;
                case 2:
                    Console.WriteLine("Creando barco de una casilla");
                    break;
                case 3:
                    Console.WriteLine("Creando barco de una casilla");
                    break;
                default:
                    // Error de compilación no debería suceder nunca
                    Console.WriteLine("Error llamando el método CreateShip (revisar el size)");
                    break;

            }
            if(size !=1)
            {
                int nx = 0;
                int ny = 0;
                // Gestión de la primera casilla
                while (!salir)
                {
                    Console.WriteLine("Introduce una casilla para el nuevo barco");
                    Console.WriteLine("X entre 1 y 5: ");
                    nx = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Y entre 1 y 5: ");
                    ny = Convert.ToInt32(Console.ReadLine());

                    if (board[x - 1, y - 1] == "X")
                    {
                        Console.WriteLine("Casilla no válida para el nuevo barco");
                    }
                    else if(Math.Abs(x - nX) == 1 && y == nY) //Adyacente horizontal
                    {
                        board[nx - 1, nY - 1] = "X";
                    }
                    else if (Math.Abs(x - ny) == 1 && y == nx) //Adyacente horizontal
                    {
                        if(count >= 2 && !isHorizontal)
                        {
                            board[nx - 1, nY - 1] = "X";
                            count++;
                            x = nx;
                            y = ny;
                            isHorizontal = true;
                            salir = true;
                        }
                        board[nx - 1, nY - 1] = "X";
                    }
                    else
                    {
                        Console.WriteLine("Casilla no adyacente");
                    }
                }
            }
            

            board

            int nx;
            int ny;
            Console.WriteLine("Introduce una casilla para el nuevo barco");
            Console.WriteLine("X entre 1 y 5: ");
            nx = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y entre 1 y 5: ");
            ny = Convert.ToInt32(Console.ReadLine());

            if (board[x - 1, y - 1] == "X")
            {

            }

            //Cuando el tamaño es 2 o más
            if (size!= 1)
            {
                int nx;
                int ny;
                Console.WriteLine("Introduce una segunda casilla para el nuevo barco");
                Console.WriteLine("X: ");
                nx = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Y: ");
                ny = Convert.ToInt32(Console.ReadLine());

                // Gestión de la 2ª y 3ª casillas
            }

        }

        static string[,] InitilizeBoard()
        {
            string[,] result = new string[5, 5];

            for(int x = 0; x < result.Length; x++)
            {
                for (int y = 0; y < 5; y++)
                {
                    result[x, y] = "0";
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
                        Console.Write("")
                    }
                    Console.WriteLine(board[x, y]);
                    else
                    {
                        Console.Write("\")
                    }
                }
            }
        }
    }
}
