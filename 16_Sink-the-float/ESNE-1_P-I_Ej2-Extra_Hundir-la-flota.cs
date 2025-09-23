using System;

namespace BarcosIntento01
{
    class HundirLaFlota
    {
        static void Main(string[] args)
        {
            int contadorbarcos = 3;
            int contadorcambio = 0; 
            int jugador = 1; 
            int elecciontamanno = 0; 
            string[,] tablero1 = InicializarTablero1();
            string[,] tablero2 = InicializarTablero2();
            string[,] tableroAgua1 = InicializarTableroAgua1();
            string[,] tableroAgua2 = InicializarTableroAgua2();
            bool victoria = false;

            do
            {
                switch(elecciontamanno)
                {
                    case 0:
                        if(jugador == 1)
                        {
                            EnseñarTablero(tablero1);
                            Console.WriteLine();
                            CrearBarco(1, ref jugador, ref tablero1);
                            elecciontamanno++;
                            contadorbarcos--;
                            contadorcambio++; 
                        }
                        else if(jugador == 2)
                        {
                            EnseñarTablero(tablero2);
                            Console.WriteLine();
                            CrearBarco(1, ref jugador, ref tablero2);
                            elecciontamanno++;
                            contadorbarcos--;
                        }
                        break;

                    case 1:
                        if (jugador == 1)
                        {
                            EnseñarTablero(tablero1);
                            Console.WriteLine();
                            CrearBarco(2, ref jugador, ref tablero1);
                            elecciontamanno++;
                            contadorbarcos--;
                            contadorcambio++; 
                        }
                        else if (jugador == 2)
                        {
                            EnseñarTablero(tablero2);
                            Console.WriteLine();
                            CrearBarco(2, ref jugador, ref tablero2);
                            elecciontamanno++;
                            contadorbarcos--;
                        }
                        break;

                    case 2:
                        if (jugador == 1)
                        {
                            EnseñarTablero(tablero1);
                            Console.WriteLine();
                            CrearBarco(3, ref jugador, ref tablero1);
                            contadorcambio++;
                            elecciontamanno++;
                            contadorbarcos--;
                        }
                        else if (jugador == 2)
                        {
                            EnseñarTablero(tablero2);
                            Console.WriteLine();
                            CrearBarco(3, ref jugador, ref tablero2);
                            elecciontamanno++;
                            contadorbarcos--;
                        }
                        break;

                    default:
                        Console.WriteLine("Introduzca un valor válido por favor");
                        break; 

                }

                Console.Clear();
                
                if(contadorcambio == 3)
                {
                    EnseñarTablero(tablero1);
                    Console.WriteLine("\t        Tablero 1");
                    jugador++;
                    contadorbarcos = 3;
                    contadorcambio = 0; 
                    elecciontamanno = 0;
                    Console.ReadKey(); 
                    Console.Clear(); 
                }

            }
            while (contadorbarcos > 0);

            EnseñarTablero(tablero2);
            Console.WriteLine("\t        Tablero 2");
            Console.ReadKey();
            Console.Clear(); 

            do
            {
                PedirCasillas(ref victoria, ref tablero1, ref tablero2, ref tableroAgua1, ref tableroAgua2);
            }
            while (victoria == false); 



        }

        static void CrearBarco (int size,ref int jugador, ref string [,] tablero)
        {

            switch(size)
            {
                case 1:

                    Console.WriteLine("Turno del jugador: " + jugador);
                    Console.WriteLine("Barco de 1 casilla");
                    break;

                case 2:

                    Console.WriteLine("Turno del jugador: " + jugador);
                    Console.WriteLine("Barco de 2 casillas");
                    break;

                case 3:

                    Console.WriteLine("Turno del jugador: " + jugador);
                    Console.WriteLine("Barco de 3 casillas");
                    break;
                default:
                    Console.WriteLine("Error en el switch de la creación de barcos, comprobar el tamaño");
                    break; 
            }

            int x = 0;
            int y = 0;
            bool salir = false; 

            while (salir == false)
            {
                Console.WriteLine("Introduzca la columna del barco ( Entre 1 y 5 ): ");
                Console.Write("Columna: ");
                x = Convert.ToInt32(Console.ReadLine()); 

                while (x > 5)
                {
                    Console.WriteLine("Por favor introduzca un valor válido para la columna. Entre 1 y 5: ");
                    Console.Write("Columna: ");
                    x = Convert.ToInt32(Console.ReadLine());

                }

                Console.WriteLine("Introduzca la fila del barco ( Entre 1 y 5 ): ");
                Console.Write("Fila: ");
                y = Convert.ToInt32(Console.ReadLine());

                while (y > 5)
                {
                    Console.WriteLine("Por favor introduzca un valor válido para la fila. Entre 1 y 5: ");
                    Console.Write("Fila: ");
                    y = Convert.ToInt32(Console.ReadLine());

                }

                if (tablero[x-1,y-1] == "X")
                {
                    Console.WriteLine("Casilla ya ocupada"); 
                }
                else
                {
                    salir = true; 
                }
            }

            tablero[x - 1, y - 1] = "X";

            //Si el tamaño es mayor que 1 casilla

            if (size != 1)
            {
                int contador = 1;
                bool isHorizontal = true;
                int nX = 0;
                int nY = 0;

                while(contador != size)
                {
                    salir = false;

                    if (size > 1)
                    {
                        Console.Clear();
                        EnseñarTablero(tablero);
                    }

                    while (salir == false)
                    {
                        Console.WriteLine("Introduzca la nueva columna del barco ( Entre 1 y 5 ): ");
                        Console.Write("X: ");
                        nX = Convert.ToInt32(Console.ReadLine());

                        while (nX > 5)
                        {
                            Console.WriteLine("Por favor introduzca un valor válido para la columna. Entre 1 y 5: ");
                            Console.Write("X: ");
                            nX = Convert.ToInt32(Console.ReadLine());

                        }

                        Console.WriteLine("Introduzca la nueva fila del barco ( Entre 1 y 5 ): ");
                        Console.Write("Y: ");
                        nY = Convert.ToInt32(Console.ReadLine());

                        while (nY > 5)
                        {
                            Console.WriteLine("Por favor introduzca un valor válido para la fila. Entre 1 y 5: ");
                            Console.Write("Y: ");
                            nY = Convert.ToInt32(Console.ReadLine());

                        }

                        if (tablero[nX - 1, nY - 1] == "X")
                        {
                            Console.WriteLine("Casilla ya ocupada");
                        }

                        
                        //Comprobación de casillas adyacente horizontalmente
                        else if ( Math.Abs (x - nX) == 1 && y == nY)
                        {
                            if (contador >= 2 && !isHorizontal )
                            {
                                Console.WriteLine("La casilla no está adyacente en fila");
                            }
                            else
                            {
                                //Crear la casilla del barco 
                                tablero[nX - 1, nY - 1] = "X";
                                contador++;
                                x = nX;
                                y = nY;
                                isHorizontal = true;
                                salir = true;
                            }

                        }
                        //Comprobación de casilla adyacente verticalmente
                        else if (Math.Abs(y - nY) == 1 && x == nX) 
                        {
                            if (contador >= 2 && isHorizontal)
                            {
                                Console.WriteLine("La casilla no está adyacente en columna");
                            }
                            else
                            {
                                //Crear la casilla del barco 
                                tablero[nX - 1, nY - 1] = "X";
                                contador++;
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

        static void PedirCasillas (ref bool victoria, ref string [,] tableroVerdad1, ref string[,] tableroVerdad2, ref string[,] tableroDisparos1, ref string[,] tableroDisparos2)
        {
            int jugador = 1;
            int impacto1 = 0;
            int impacto2 = 0; 
            int columna;
            int fila;

            do
            {
                //Primero mostrar al jugador que le toque el tablero de disparos correspondiente
                if(jugador == 1)
                {
                    Console.WriteLine("\t Tablero del jugador 2"); 
                    EnseñarTablero(tableroDisparos2);
                }
                else if (jugador == 2)
                {
                    Console.WriteLine("\t Tablero del jugador 1");
                    EnseñarTablero(tableroDisparos1);
                }

                //Necesitamos pedir casillas al jugador que le toque para ver donde quiere disparar

                // Columna 

                Console.WriteLine(" - Turno del jugador: " + jugador);
                Console.WriteLine("Introduzca la columna donde quiere disparar el proyectil (Entre 1 y 5)");
                Console.Write("Columna: ");
                columna = Convert.ToInt32(Console.ReadLine());

                while (columna > 5)
                {
                    Console.WriteLine("Introduzca una columna válida donde quiere disparar el proyectil (ENTRE 1 Y 5)");
                    Console.Write("Columna: ");
                    columna = Convert.ToInt32(Console.ReadLine());
                }

                //Fila

                Console.WriteLine("Introduzca la fila donde quiere disparar el proyectil (Entre 1 y 5)");
                Console.Write("Columna: ");
                fila = Convert.ToInt32(Console.ReadLine());

                while (fila > 5)
                {
                    Console.WriteLine("Introduzca una fila válida donde quiere disparar el proyectil (ENTRE 1 Y 5)");
                    Console.Write("Columna: ");
                    fila = Convert.ToInt32(Console.ReadLine());
                }

                Console.Clear();

                    if (jugador == 1)
                    {
                        if (tableroVerdad2[columna - 1, fila - 1] == "X")
                        {
                            tableroDisparos2[columna - 1, fila - 1] = "I";
                            Console.WriteLine("!Impacto!");
                            impacto2++;

                            if (impacto2 == 6)
                            {
                                Console.WriteLine("!Ha ganado el jugador 1!");
                                victoria = true;
                            }
                        }
                        else if (tableroVerdad2[columna - 1, fila - 1] != "X")
                        {
                            tableroDisparos2[columna - 1, fila - 1] = "A";
                            Console.WriteLine("Agua");
                        }

                        EnseñarTablero(tableroDisparos2);
                        Console.ReadKey();
                        Console.Clear();
                        jugador++;

                    }
                    else if (jugador == 2)
                    {

                        if (tableroVerdad1[columna - 1, fila - 1] == "X")
                        {
                            tableroDisparos1[columna - 1, fila - 1] = "I";
                            Console.WriteLine("!Impacto!");
                            impacto1++;

                            if (impacto1 == 6)
                            {
                                Console.WriteLine("!Ha ganado el jugador 2!");
                                victoria = true;
                            }
                        }
                        else if (tableroVerdad1[columna - 1, fila - 1] != "X")
                        {
                            tableroDisparos1[columna - 1, fila - 1] = "A";
                            Console.WriteLine("Agua");
                        }

                        EnseñarTablero(tableroDisparos1);
                        Console.ReadKey();
                        Console.Clear();
                        jugador--;
                    }

            }
            while (victoria == false);

            Console.ReadKey();  

            //Una vez dispara hay que comprobar si la casilla a la que le ha dado en el tablero de verdad es una "X" o no
            //Si es una "X" (es decir barco) en el tablero Disparos habrá que poner una "I" (Impacto), sino "A" (Agua) 
            //Si es un Impacto hay que hacer un contador para que cada vez que le de a una X se le sume 1 al contador, cuando el contador llegue a 6
            // siginificará que no quedan más barcos, entonces habrá ganado el jugador correspondiente. 2 Contadores, uno para cada jugador. 
            //Si no hay condición de victoria que se pase turno y le toque al siguiente jugador.  
            //No hace falta condición de empate a menos que queramos que haya un máximo de proyectiles, cosa que no porq es más trabajo. 
        }

        static string [,] InicializarTablero1()
        {
            string[,] tableroInicial = new string[5, 5];

            for (int x = 0; x < 5; x++)
            {
                for (int y = 0; y<5; y++)
                {
                    tableroInicial[x, y] = " "; 
                }
            }

            return tableroInicial; 
        }

        static string[,] InicializarTablero2()
        {
            string[,] tableroInicial = new string[5, 5];

            for (int x = 0; x < 5; x++)
            {
                for (int y = 0; y < 5; y++)
                {
                    tableroInicial[x, y] = " ";
                }
            }

            return tableroInicial;
        }

        static string[,] InicializarTableroAgua1()
        {
            string[,] tableroAgua = new string[5, 5];

            for (int x = 0; x < 5; x++)
            {
                for (int y = 0; y < 5; y++)
                {
                    tableroAgua[x, y] = "?";
                }
            }

            return tableroAgua;
        }

        static string[,] InicializarTableroAgua2()
        {
            string[,] tableroAgua = new string[5, 5];

            for (int x = 0; x < 5; x++)
            {
                for (int y = 0; y < 5; y++)
                {
                    tableroAgua[x, y] = "?";
                }
            }

            return tableroAgua;
        }

        static void EnseñarTablero(string [,] tablero)
        {
            Console.Write("\t");

            Console.WriteLine("    1   2   3   4   5 ");

            Console.Write("\t");

            Console.WriteLine("  ---------------------");
            for (int y = 0; y<5;y++)
            {
                Console.Write("\t");
                Console.Write(y + 1);

                for (int x = 0; x < 5; x++)
                {
                    Console.Write(" | ");

                    if (x == 4)
                    {
                       
                        Console.Write(tablero[x, y]);
                        Console.WriteLine(" | ");
                    }
                    else
                    {
                        Console.Write(tablero[x, y] + ""); 
                    }
                }

                Console.Write("\t");
                Console.WriteLine("  ---------------------");
            }

        }
    }

}
