using System;

namespace BarcosEnGuerra
{
    class Program
    {
        static void Main(string[] args)
        {
            // Al introducir los valores las columnas y las filas están invertidas
            
            
            char[,] MatrizBaseJ1 = new char[5, 5] { { 'X', 'X', 'X', 'X', 'X' }, { 'X', 'X', 'X', 'X', 'X' }, { 'X', 'X', 'X', 'X', 'X' }, { 'X', 'X', 'X', 'X', 'X' }, { 'X', 'X', 'X', 'X', 'X' } };
            char[,] MatrizBaseJ2 = new char[5, 5] { { 'X', 'X', 'X', 'X', 'X' }, { 'X', 'X', 'X', 'X', 'X' }, { 'X', 'X', 'X', 'X', 'X' }, { 'X', 'X', 'X', 'X', 'X' }, { 'X', 'X', 'X', 'X', 'X' } };

            char[,] campoJ1 = new char[5, 5] { { 'O', 'O', 'O', 'O', 'O' }, { 'O', 'O', 'O', 'O', 'O' }, { 'O', 'O', 'O', 'O', 'O' }, { 'O', 'O', 'O', 'O', 'O' }, { 'O', 'O', 'O', 'O', 'O' } };
            char[,] campoJ2 = new char[5, 5] { { 'O', 'O', 'O', 'O', 'O' }, { 'O', 'O', 'O', 'O', 'O' }, { 'O', 'O', 'O', 'O', 'O' }, { 'O', 'O', 'O', 'O', 'O' }, { 'O', 'O', 'O', 'O', 'O' } };

            int turno = 1;
            bool finalPartida = false;

            // Pedir Barcos J1

            if(turno == 1)
            {
                // Elegir Barco 1
                
                ElegirBarco1(MatrizBaseJ1);

                // Elegir Barco 2

                ElegirBarco2(MatrizBaseJ1);

                // Elegir Barco 3

                ElegirBarco3(MatrizBaseJ1);

                Console.WriteLine("Pulsa cualquier tecla para terminar tu turno");
                Console.ReadKey();

                turno = 2;
            }

            // Pedir barcos J2

            if (turno == 2)
            {
                // Elegir Barco 1

                ElegirBarco1(MatrizBaseJ2);

                // Elegir Barco 2

                ElegirBarco2(MatrizBaseJ2);

                // Elegir Barco 3

                ElegirBarco3(MatrizBaseJ2);

                Console.WriteLine("Pulsa cualquier tecla para terminar tu turno");
                Console.ReadKey();
                turno = 1;
            }
            Console.WriteLine("");

            // Flujo de la partida

            int tocadosJ1 = 0;
            int tocadosJ2 = 0;
            while (finalPartida == false)
            {
                if (turno == 1)
                {
                    
                    int fila;
                    string filastr;
                    int columna;
                    string columnastr;
                    Console.WriteLine("Turno del jugador " + turno);
                    Console.WriteLine("Pulsa cualquier tecla para empezar tu turno");
                    Console.ReadKey();
                    Console.WriteLine("");
                    MostrarMatrizConCoordenadas(campoJ1);
                    Console.Write("Elige la columna (numero del 0 al 4)");
                    filastr = Console.ReadLine();
                    if (int.TryParse(filastr, out fila) == true)
                    {
                        if (fila > -1 && fila < 5)
                        {
                            Console.Write("Elige la fila (numero del 0 al 4)");
                            columnastr = Console.ReadLine();
                            if (int.TryParse(columnastr, out columna) == true)
                            {
                                if (columna > -1 && columna < 5)
                                {
                                    if (campoJ1[fila, columna] == 'O')
                                    {
                                        if (MatrizBaseJ2[fila, columna] == 'B')
                                        {
                                            Console.WriteLine("Le has dado!");
                                            campoJ1[fila, columna] = 'X';
                                            tocadosJ1 = tocadosJ1 + 1;

                                            MostrarMatriz(campoJ1);
                                            Console.WriteLine("Pulsa cualquier tecla para continuar");
                                            Console.ReadKey();
                                            Console.WriteLine("");
                                            Console.Clear();
                                            /*Console.WriteLine("Pulsa cualquier tecla para terminar tu turno");
                                            Console.ReadKey();
                                            Console.Clear();
                                            turno = 2;*/
                                        }
                                        else
                                        {
                                            Console.WriteLine("No le has dado");
                                            campoJ1[fila, columna] = 'A';

                                            MostrarMatriz(campoJ1);
                                            Console.WriteLine("Pulsa cualquier tecla para terminar tu turno");
                                            Console.ReadKey();
                                            Console.Clear();
                                            turno = 2;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Esas coordenadas ya las has puesto");
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Entrada no válida");
                            }

                        }
                    }
                    else
                    {
                        Console.WriteLine("Entrada no válida");
                    }
                    if(tocadosJ1 >= 6 || tocadosJ2 >= 6)
                    {
                        finalPartida = true;
                    }
                }
                if (turno == 2)
                {

                    int fila2;
                    string fila2str;
                    int columna2;
                    string columna2str;
                    Console.WriteLine("Turno del jugador " + turno);
                    Console.WriteLine("Pulsa cualquier tecla para empezar tu turno");
                    Console.ReadKey();
                    Console.WriteLine("");
                    MostrarMatrizConCoordenadas(campoJ2);
                    Console.Write("Elige la columna (numero del 0 al 4)");
                    fila2str = Console.ReadLine();
                    if (int.TryParse(fila2str, out fila2) == true)
                    {
                        if (fila2 > -1 && fila2 < 5)
                        {
                            Console.Write("Elige la fila (numero del 0 al 4)");
                            columna2str = Console.ReadLine();
                            if (int.TryParse(columna2str, out columna2) == true)
                            {
                                if (columna2 > -1 && columna2 < 5)
                                {
                                    if(campoJ2[fila2,columna2] == 'O')
                                    {
                                        if (MatrizBaseJ1[fila2, columna2] == 'B')
                                        {
                                            Console.WriteLine("Le has dado!");
                                            campoJ2[fila2, columna2] = 'X';
                                            tocadosJ2 = tocadosJ2 + 1;

                                            MostrarMatriz(campoJ2);
                                            Console.WriteLine("Pulsa cualquier tecla para continuar");
                                            Console.ReadKey();
                                            Console.WriteLine("");
                                            Console.Clear();
                                            /*Console.WriteLine("Pulsa cualquier tecla para terminar tu turno");
                                            Console.ReadKey();
                                            Console.Clear();
                                            turno = 1;*/
                                        }
                                        else
                                        {
                                            Console.WriteLine("No le has dado");
                                            campoJ2[fila2, columna2] = 'A';

                                            MostrarMatriz(campoJ2);
                                            Console.WriteLine("Pulsa cualquier tecla para terminar tu turno");
                                            Console.ReadKey();
                                            Console.Clear();
                                            turno = 1;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Esas coordenadas ya las has puesto");
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Entrada no válida");
                            }

                        }
                    }
                    else
                    {
                        Console.WriteLine("Entrada no válida");
                    }

                    if (tocadosJ1 >= 6 || tocadosJ2 >= 6)
                    {
                        finalPartida = true;
                    }
                }


            }

            if (tocadosJ1 >= 6)
            {
                Console.WriteLine("Ha ganado el J1!");
            }
            else
            {
                Console.WriteLine("Ha ganado el J2!");
            }
            Console.ReadKey();
            

        }
        static void MostrarMatriz(char[,] matriz)
        {
            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 5; x++)
                {
                    Console.Write(Convert.ToString(matriz[x, y]) + " ");
                }
                Console.WriteLine("");
            }
        }
        static void MostrarMatrizConCoordenadas(char[,] matriz)
        {
            Console.WriteLine("  0 1 2 3 4");
            for (int y = 0; y < 5; y++)
            {
                Console.Write(y + " ");
                for (int x = 0; x < 5; x++)
                {
                    Console.Write(Convert.ToString(matriz[x, y]) + " ");
                }
                Console.WriteLine("");
            }
        }
        static void ElegirBarco1(char[,] matriz)
        {
            bool barco1J1 = false;
            int x = 0;
            int y = 0;
            int xB = x;
            int yB = y;
            matriz[x, y] = 'B';
            string input;
            do
            {
                do
                {
                    Console.WriteLine("Coloca tu barco de 1 (mueve con WASD y confirma con E)");
                    MostrarMatriz(matriz);
                    input = Console.ReadLine();
                    if (input == "w")
                    {
                        if (y > 0)
                        {
                            yB = y;
                            xB = x;
                            y = y - 1;
                            matriz[xB, yB] = 'X';
                        }
                    }
                    else if (input == "a")
                    {
                        if (x > 0)
                        {
                            xB = x;
                            yB = y;
                            x = x - 1;
                            matriz[xB, yB] = 'X';
                        }
                    }
                    else if (input == "s")
                    {
                        if (y < 4)
                        {
                            yB = y;
                            xB = x;
                            y = y + 1;
                            matriz[xB, yB] = 'X';
                        }
                    }
                    else if (input == "d")
                    {
                        if (x < 4)
                        {
                            xB = x;
                            yB = y;
                            x = x + 1;
                            matriz[xB, yB] = 'X';
                        }
                    }
                    else if (input == "e")
                    {
                        barco1J1 = true;
                    }
                    matriz[x, y] = 'B';


                    Console.Clear();
                }
                while (input != "w" && input != "a" && input != "s" && input != "d" && input != "e");
            }
            while (barco1J1 == false);
        }
        static void ElegirBarco2(char[,] MatrizBaseJ1)
        {
            bool barco2J1 = false;
            bool rotacion = false;
            int x = 1;
            int y = 0;
            int x2 = x - 1;
            int y2 = 0;
            int xB = x;
            int yB = y;
            int xB2 = x2;
            int yB2 = y2;
            if (MatrizBaseJ1[0, 0] != 'B' && MatrizBaseJ1[1, 0] != 'B')
            {
                MatrizBaseJ1[x, y] = 'B';
                MatrizBaseJ1[x2, y2] = 'B';
            }
            else
            {
                y = y + 1;
                y2 = y2 + 1;
                MatrizBaseJ1[x, y] = 'B';
                MatrizBaseJ1[x2, y2] = 'B';
            }

            string input;
            do
            {
                do
                {
                    Console.WriteLine("Coloca tu barco de 2 (mueve con WASD, rota con r y confirma con E)");
                    MostrarMatriz(MatrizBaseJ1);
                    input = Console.ReadLine();
                    if (input == "w")
                    {
                        if (y > 0 && y2 > 0)
                        {

                            if (rotacion == false && MatrizBaseJ1[x, y - 1] != 'B' && MatrizBaseJ1[x - 1, y - 1] != 'B')
                            {
                                yB = y;
                                xB = x;
                                y = y - 1;

                                yB2 = y2;
                                xB2 = x2;
                                y2 = y;
                                x2 = x - 1;

                                MatrizBaseJ1[xB, yB] = 'X';
                                MatrizBaseJ1[xB2, yB2] = 'X';
                            }
                            else if (rotacion == true && MatrizBaseJ1[x, y - 1] != 'B')
                            {
                                yB = y;
                                xB = x;
                                y = y - 1;

                                yB2 = y2;
                                xB2 = x2;
                                y2 = y + 1;
                                x2 = x;

                                MatrizBaseJ1[xB, yB] = 'X';
                                MatrizBaseJ1[xB2, yB2] = 'X';
                            }

                        }
                    }
                    else if (input == "a")
                    {
                        if (x > 0 && x2 > 0)
                        {
                            if (rotacion == false && MatrizBaseJ1[x - 2, y] != 'B')
                            {
                                yB = y;
                                xB = x;
                                x = x - 1;

                                yB2 = y2;
                                xB2 = x2;
                                y2 = y;
                                x2 = x - 1;

                                MatrizBaseJ1[xB, yB] = 'X';
                                MatrizBaseJ1[xB2, yB2] = 'X';
                            }
                            else if (rotacion == true && MatrizBaseJ1[x - 1, y] != 'B' && MatrizBaseJ1[x - 1, y + 1] != 'B')
                            {
                                yB = y;
                                xB = x;
                                x = x - 1;

                                yB2 = y2;
                                xB2 = x2;
                                y2 = y + 1;
                                x2 = x;

                                MatrizBaseJ1[xB, yB] = 'X';
                                MatrizBaseJ1[xB2, yB2] = 'X';
                            }
                        }
                    }
                    else if (input == "s")
                    {
                        if (y < 4 && y2 < 4)
                        {
                            if (rotacion == false && MatrizBaseJ1[x, y + 1] != 'B' && MatrizBaseJ1[x - 1, y + 1] != 'B')
                            {
                                yB = y;
                                xB = x;
                                y = y + 1;

                                yB2 = y2;
                                xB2 = x2;
                                y2 = y;
                                x2 = x - 1;

                                MatrizBaseJ1[xB, yB] = 'X';
                                MatrizBaseJ1[xB2, yB2] = 'X';
                            }
                            else if (rotacion == true && MatrizBaseJ1[x, y + 2] != 'B')
                            {
                                yB = y;
                                xB = x;
                                y = y + 1;

                                yB2 = y2;
                                xB2 = x2;
                                y2 = y + 1;
                                x2 = x;

                                MatrizBaseJ1[xB, yB] = 'X';
                                MatrizBaseJ1[xB2, yB2] = 'X';
                            }
                        }
                    }
                    else if (input == "d")
                    {
                        if (x < 4 && x2 < 4)
                        {
                            if (rotacion == false && MatrizBaseJ1[x + 1, y] != 'B')
                            {
                                yB = y;
                                xB = x;
                                x = x + 1;

                                yB2 = y2;
                                xB2 = x2;
                                y2 = y;
                                x2 = x - 1;

                                MatrizBaseJ1[xB, yB] = 'X';
                                MatrizBaseJ1[xB2, yB2] = 'X';
                            }
                            else if (rotacion == true && MatrizBaseJ1[x + 1, y] != 'B' && MatrizBaseJ1[x + 1, y + 1] != 'B')
                            {
                                yB = y;
                                xB = x;
                                x = x + 1;

                                yB2 = y2;
                                xB2 = x2;
                                y2 = y + 1;
                                x2 = x;

                                MatrizBaseJ1[xB, yB] = 'X';
                                MatrizBaseJ1[xB2, yB2] = 'X';
                            }
                        }
                    }
                    else if (input == "r")
                    {
                        if (rotacion == false)
                        {
                            if (y < 4 && MatrizBaseJ1[x, y + 1] != 'B')
                            {
                                yB2 = y2;
                                xB2 = x2;
                                x2 = x2 + 1;
                                y2 = y2 + 1;
                                MatrizBaseJ1[xB2, yB2] = 'X';
                                rotacion = true;
                            }
                        }
                        else
                        {
                            if (x > 0 && MatrizBaseJ1[x - 1, y] != 'B')
                            {
                                yB2 = y2;
                                xB2 = x2;
                                x2 = x2 - 1;
                                y2 = y2 - 1;
                                MatrizBaseJ1[xB2, yB2] = 'X';
                                rotacion = false;
                            }
                        }
                    }
                    else if (input == "e")
                    {
                        barco2J1 = true;
                    }
                    MatrizBaseJ1[x, y] = 'B';
                    MatrizBaseJ1[x2, y2] = 'B';


                    Console.Clear();
                }
                while (input != "w" && input != "a" && input != "s" && input != "d" && input != "e");
            }
            while (barco2J1 == false);
        }

        static void ElegirBarco3(char[,] MatrizBaseJ1)
        {
            bool barco2J1 = false;
            bool rotacion = false;
            int x = 2;
            int y = 0;
            int x2 = 1;
            int y2 = 0;
            int x3 = 0;
            int y3 = 0;
            int xB = x;
            int yB = y;
            int xB2 = x2;
            int yB2 = y2;
            int xB3 = x3;
            int yB3 = y3;
            if (MatrizBaseJ1[0, 0] != 'B' && MatrizBaseJ1[1, 0] != 'B' && MatrizBaseJ1[2, 0] != 'B')
            {
                MatrizBaseJ1[x, y] = 'B';
                MatrizBaseJ1[x2, y2] = 'B';
                MatrizBaseJ1[x3, y3] = 'B';
            }
            else if(MatrizBaseJ1[0, 1] != 'B' && MatrizBaseJ1[1, 1] != 'B' && MatrizBaseJ1[2, 1] != 'B')
            {
                y = y + 1;
                y2 = y2 + 1;
                y3 = y3 + 1;
                MatrizBaseJ1[x, y] = 'B';
                MatrizBaseJ1[x2, y2] = 'B';
                MatrizBaseJ1[x3, y3] = 'B';
            }
            else if (MatrizBaseJ1[0, 2] != 'B' && MatrizBaseJ1[1, 2] != 'B' && MatrizBaseJ1[2, 2] != 'B')
            {
                y = y + 2;
                y2 = y2 + 2;
                y3 = y3 + 2;
                MatrizBaseJ1[x, y] = 'B';
                MatrizBaseJ1[x2, y2] = 'B';
                MatrizBaseJ1[x3, y3] = 'B';
            }
            else
            {
                y = y + 3;
                y2 = y2 + 3;
                y3 = y3 + 3;
                MatrizBaseJ1[x, y] = 'B';
                MatrizBaseJ1[x2, y2] = 'B';
                MatrizBaseJ1[x3, y3] = 'B';
            }

            string input;
            do
            {
                do
                {
                    Console.WriteLine("Coloca tu barco de 3 (mueve con WASD, rota con r y confirma con E, puedes mover dos espacios de una vez si pulsas dos veces una tecla)");
                    MostrarMatriz(MatrizBaseJ1);
                    input = Console.ReadLine();
                    if (input == "w")
                    {
                        if (y > 0 && y2 > 0 && y3 > 0)
                        {

                            if (rotacion == false && MatrizBaseJ1[x, y - 1] != 'B' && MatrizBaseJ1[x - 1, y - 1] != 'B' && MatrizBaseJ1[x - 2, y - 1] != 'B')
                            {
                                yB = y;
                                xB = x;
                                y = y - 1;

                                yB2 = y2;
                                xB2 = x2;
                                y2 = y;
                                x2 = x - 1;

                                yB3 = y3;
                                xB3 = x3;
                                y3 = y2;
                                x3 = x2 - 1;

                                MatrizBaseJ1[xB, yB] = 'X';
                                MatrizBaseJ1[xB2, yB2] = 'X';
                                MatrizBaseJ1[xB3, yB3] = 'X';
                            }
                            else if (rotacion == true && MatrizBaseJ1[x, y - 1] != 'B')
                            {
                                yB = y;
                                xB = x;
                                y = y - 1;

                                yB2 = y2;
                                xB2 = x2;
                                y2 = y + 1;
                                x2 = x;

                                yB3 = y3;
                                xB3 = x3;
                                y3 = y2 + 1;
                                x3 = x2;

                                MatrizBaseJ1[xB, yB] = 'X';
                                MatrizBaseJ1[xB2, yB2] = 'X';
                                MatrizBaseJ1[xB3, yB3] = 'X';
                            }

                        }
                    }
                    else if (input == "ww") // doble salto w
                    {
                        if (y > 1 && y2 > 1 && y3 > 1)
                        {

                            if (rotacion == false && MatrizBaseJ1[x, y - 2] != 'B' && MatrizBaseJ1[x - 1, y - 2] != 'B' && MatrizBaseJ1[x - 2, y - 2] != 'B')
                            {
                                yB = y;
                                xB = x;
                                y = y - 2;

                                yB2 = y2;
                                xB2 = x2;
                                y2 = y;
                                x2 = x - 1;

                                yB3 = y3;
                                xB3 = x3;
                                y3 = y2;
                                x3 = x2 - 1;

                                MatrizBaseJ1[xB, yB] = 'X';
                                MatrizBaseJ1[xB2, yB2] = 'X';
                                MatrizBaseJ1[xB3, yB3] = 'X';
                            }
                            else if (rotacion == true && MatrizBaseJ1[x, y - 1] != 'B' && MatrizBaseJ1[x, y - 2] != 'B')
                            {
                                yB = y;
                                xB = x;
                                y = y - 1;

                                yB2 = y2;
                                xB2 = x2;
                                y2 = y + 1;
                                x2 = x;

                                yB3 = y3;
                                xB3 = x3;
                                y3 = y2 + 1;
                                x3 = x2;

                                MatrizBaseJ1[xB, yB] = 'X';
                                MatrizBaseJ1[xB2, yB2] = 'X';
                                MatrizBaseJ1[xB3, yB3] = 'X';

                                yB = y;
                                xB = x;
                                y = y - 1;

                                yB2 = y2;
                                xB2 = x2;
                                y2 = y + 1;
                                x2 = x;

                                yB3 = y3;
                                xB3 = x3;
                                y3 = y2 + 1;
                                x3 = x2;

                                MatrizBaseJ1[xB, yB] = 'X';
                                MatrizBaseJ1[xB2, yB2] = 'X';
                                MatrizBaseJ1[xB3, yB3] = 'X';
                            }

                        }
                    }
                    else if (input == "aa")   // Doble salto a
                    {
                        if (x > 1 && x2 > 1 && x3 > 1)
                        {
                            if (rotacion == false && MatrizBaseJ1[x - 3, y] != 'B' && MatrizBaseJ1[x - 4, y] != 'B')
                            {
                                yB = y;
                                xB = x;
                                x = x - 1;

                                yB2 = y2;
                                xB2 = x2;
                                y2 = y;
                                x2 = x - 1;

                                yB3 = y3;
                                xB3 = x3;
                                y3 = y2;
                                x3 = x2 - 1;

                                MatrizBaseJ1[xB, yB] = 'X';
                                MatrizBaseJ1[xB2, yB2] = 'X';
                                MatrizBaseJ1[xB3, yB3] = 'X';

                                yB = y;
                                xB = x;
                                x = x - 1;

                                yB2 = y2;
                                xB2 = x2;
                                y2 = y;
                                x2 = x - 1;

                                yB3 = y3;
                                xB3 = x3;
                                y3 = y2;
                                x3 = x2 - 1;

                                MatrizBaseJ1[xB, yB] = 'X';
                                MatrizBaseJ1[xB2, yB2] = 'X';
                                MatrizBaseJ1[xB3, yB3] = 'X';
                            }
                            else if (rotacion == true && MatrizBaseJ1[x - 1, y] != 'B' && MatrizBaseJ1[x - 1, y + 1] != 'B' && MatrizBaseJ1[x - 1, y + 2] != 'B')
                            {
                                yB = y;
                                xB = x;
                                x = x - 2;

                                yB2 = y2;
                                xB2 = x2;
                                y2 = y + 1;
                                x2 = x;

                                yB3 = y3;
                                xB3 = x3;
                                y3 = y2 + 1;
                                x3 = x2;

                                MatrizBaseJ1[xB, yB] = 'X';
                                MatrizBaseJ1[xB2, yB2] = 'X';
                                MatrizBaseJ1[xB3, yB3] = 'X';
                            }
                        }
                    }
                    else if (input == "a")
                    {
                        if (x > 0 && x2 > 0 && x3 > 0)
                        {
                            if (rotacion == false && MatrizBaseJ1[x - 3, y] != 'B')
                            {
                                yB = y;
                                xB = x;
                                x = x - 1;

                                yB2 = y2;
                                xB2 = x2;
                                y2 = y;
                                x2 = x - 1;

                                yB3 = y3;
                                xB3 = x3;
                                y3 = y2;
                                x3 = x2 - 1;

                                MatrizBaseJ1[xB, yB] = 'X';
                                MatrizBaseJ1[xB2, yB2] = 'X';
                                MatrizBaseJ1[xB3, yB3] = 'X';
                            }
                            else if (rotacion == true && MatrizBaseJ1[x - 1, y] != 'B' && MatrizBaseJ1[x - 1, y + 1] != 'B' && MatrizBaseJ1[x - 1, y + 2] != 'B')
                            {
                                yB = y;
                                xB = x;
                                x = x - 1;

                                yB2 = y2;
                                xB2 = x2;
                                y2 = y + 1;
                                x2 = x;

                                yB3 = y3;
                                xB3 = x3;
                                y3 = y2 + 1;
                                x3 = x2;

                                MatrizBaseJ1[xB, yB] = 'X';
                                MatrizBaseJ1[xB2, yB2] = 'X';
                                MatrizBaseJ1[xB3, yB3] = 'X';
                            }
                        }
                    }
                    else if (input == "s")
                    {
                        if (y < 4 && y2 < 4 && y3 < 4)
                        {
                            if (rotacion == false && MatrizBaseJ1[x, y + 1] != 'B' && MatrizBaseJ1[x - 1, y + 1] != 'B' && MatrizBaseJ1[x - 2, y + 1] != 'B')
                            {
                                yB = y;
                                xB = x;
                                y = y + 1;

                                yB2 = y2;
                                xB2 = x2;
                                y2 = y;
                                x2 = x - 1;

                                yB3 = y3;
                                xB3 = x3;
                                y3 = y2;
                                x3 = x2 - 1;

                                MatrizBaseJ1[xB, yB] = 'X';
                                MatrizBaseJ1[xB2, yB2] = 'X';
                                MatrizBaseJ1[xB3, yB3] = 'X';
                            }
                            else if (rotacion == true && MatrizBaseJ1[x, y + 3] != 'B')
                            {
                                yB = y;
                                xB = x;
                                y = y + 1;

                                yB2 = y2;
                                xB2 = x2;
                                y2 = y + 1;
                                x2 = x;

                                yB3 = y3;
                                xB3 = x3;
                                y3 = y2 + 1;
                                x3 = x2;

                                MatrizBaseJ1[xB, yB] = 'X';
                                MatrizBaseJ1[xB2, yB2] = 'X';
                                MatrizBaseJ1[xB3, yB3] = 'X';
                            }
                        }
                    }
                    else if (input == "ss")   // Doble salto s
                    {
                        if (y < 3 && y2 < 3 && y3 < 3)
                        {
                            if (rotacion == false && MatrizBaseJ1[x, y + 2] != 'B' && MatrizBaseJ1[x - 1, y + 2] != 'B' && MatrizBaseJ1[x - 2, y + 2] != 'B')
                            {
                                yB = y;
                                xB = x;
                                y = y + 2;

                                yB2 = y2;
                                xB2 = x2;
                                y2 = y;
                                x2 = x - 1;

                                yB3 = y3;
                                xB3 = x3;
                                y3 = y2;
                                x3 = x2 - 1;

                                MatrizBaseJ1[xB, yB] = 'X';
                                MatrizBaseJ1[xB2, yB2] = 'X';
                                MatrizBaseJ1[xB3, yB3] = 'X';
                            }
                            else if (rotacion == true && MatrizBaseJ1[x, y + 3] != 'B')
                            {
                                yB = y;
                                xB = x;
                                y = y + 1;

                                yB2 = y2;
                                xB2 = x2;
                                y2 = y + 1;
                                x2 = x;

                                yB3 = y3;
                                xB3 = x3;
                                y3 = y2 + 1;
                                x3 = x2;

                                MatrizBaseJ1[xB, yB] = 'X';
                                MatrizBaseJ1[xB2, yB2] = 'X';
                                MatrizBaseJ1[xB3, yB3] = 'X';

                                yB = y;
                                xB = x;
                                y = y + 1;

                                yB2 = y2;
                                xB2 = x2;
                                y2 = y + 1;
                                x2 = x;

                                yB3 = y3;
                                xB3 = x3;
                                y3 = y2 + 1;
                                x3 = x2;

                                MatrizBaseJ1[xB, yB] = 'X';
                                MatrizBaseJ1[xB2, yB2] = 'X';
                                MatrizBaseJ1[xB3, yB3] = 'X';
                            }
                        }
                    }
                    else if (input == "d")
                    {
                        if (x < 4 && x2 < 4 && x3 < 4)
                        {
                            if (rotacion == false && MatrizBaseJ1[x + 1, y] != 'B')
                            {
                                yB = y;
                                xB = x;
                                x = x + 1;

                                yB2 = y2;
                                xB2 = x2;
                                y2 = y;
                                x2 = x - 1;

                                yB3 = y3;
                                xB3 = x3;
                                y3 = y2;
                                x3 = x2 - 1;

                                MatrizBaseJ1[xB, yB] = 'X';
                                MatrizBaseJ1[xB2, yB2] = 'X';
                                MatrizBaseJ1[xB3, yB3] = 'X';
                            }
                            else if (rotacion == true && MatrizBaseJ1[x + 1, y] != 'B' && MatrizBaseJ1[x + 1, y + 1] != 'B' && MatrizBaseJ1[x + 1, y + 2] != 'B')
                            {
                                yB = y;
                                xB = x;
                                x = x + 1;

                                yB2 = y2;
                                xB2 = x2;
                                y2 = y + 1;
                                x2 = x;

                                yB3 = y3;
                                xB3 = x3;
                                y3 = y2 + 1;
                                x3 = x2;

                                MatrizBaseJ1[xB, yB] = 'X';
                                MatrizBaseJ1[xB2, yB2] = 'X';
                                MatrizBaseJ1[xB3, yB3] = 'X';
                            }
                        }
                    }
                    else if (input == "dd")     // Doble salto d
                    {
                        if (x < 3 && x2 < 3 && x3 < 3)
                        {
                            if (rotacion == false && MatrizBaseJ1[x + 1, y] != 'B')
                            {
                                yB = y;
                                xB = x;
                                x = x + 1;

                                yB2 = y2;
                                xB2 = x2;
                                y2 = y;
                                x2 = x - 1;

                                yB3 = y3;
                                xB3 = x3;
                                y3 = y2;
                                x3 = x2 - 1;

                                MatrizBaseJ1[xB, yB] = 'X';
                                MatrizBaseJ1[xB2, yB2] = 'X';
                                MatrizBaseJ1[xB3, yB3] = 'X';

                                yB = y;
                                xB = x;
                                x = x + 1;

                                yB2 = y2;
                                xB2 = x2;
                                y2 = y;
                                x2 = x - 1;

                                yB3 = y3;
                                xB3 = x3;
                                y3 = y2;
                                x3 = x2 - 1;

                                MatrizBaseJ1[xB, yB] = 'X';
                                MatrizBaseJ1[xB2, yB2] = 'X';
                                MatrizBaseJ1[xB3, yB3] = 'X';
                            }
                            else if (rotacion == true && MatrizBaseJ1[x + 1, y] != 'B' && MatrizBaseJ1[x + 1, y + 1] != 'B' && MatrizBaseJ1[x + 1, y + 2] != 'B')
                            {
                                yB = y;
                                xB = x;
                                x = x + 2;

                                yB2 = y2;
                                xB2 = x2;
                                y2 = y + 1;
                                x2 = x;

                                yB3 = y3;
                                xB3 = x3;
                                y3 = y2 + 1;
                                x3 = x2;

                                MatrizBaseJ1[xB, yB] = 'X';
                                MatrizBaseJ1[xB2, yB2] = 'X';
                                MatrizBaseJ1[xB3, yB3] = 'X';
                            }
                        }
                    }
                    else if (input == "r")
                    {
                        if (rotacion == false)
                        {
                            if (y < 3 && MatrizBaseJ1[x, y + 1] != 'B' && MatrizBaseJ1[x, y + 2] != 'B')
                            {
                                yB2 = y2;
                                xB2 = x2;
                                yB3 = y3;
                                xB3 = x3;
                                x2 = x2 + 1;
                                y2 = y2 + 1;
                                x3 = x3 + 2;
                                y3 = y3 + 2;
                                MatrizBaseJ1[xB2, yB2] = 'X';
                                MatrizBaseJ1[xB3, yB3] = 'X';
                                rotacion = true;
                            }
                        }
                        else
                        {
                            if (x > 1 && MatrizBaseJ1[x - 1, y] != 'B' && MatrizBaseJ1[x - 2, y] != 'B')
                            {
                                yB2 = y2;
                                xB2 = x2;
                                yB3 = y3;
                                xB3 = x3;
                                x2 = x2 - 1;
                                y2 = y2 - 1;
                                x3 = x3 - 2;
                                y3 = y3 - 2;
                                MatrizBaseJ1[xB2, yB2] = 'X';
                                MatrizBaseJ1[xB3, yB3] = 'X';
                                rotacion = false;
                            }
                        }
                    }
                    else if (input == "e")
                    {
                        barco2J1 = true;
                    }
                    MatrizBaseJ1[x, y] = 'B';
                    MatrizBaseJ1[x2, y2] = 'B';
                    MatrizBaseJ1[x3, y3] = 'B';


                    Console.Clear();
                }
                while (input != "w" && input != "a" && input != "s" && input != "d" && input != "e");
            }
            while (barco2J1 == false);
        }
    }
}
