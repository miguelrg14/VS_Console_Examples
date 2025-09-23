// JuegoTorreDeBatalla
// Miguel Rodríguez Gallego
// 15/05/2021
// Menú principal

using System;

namespace TorreDeBatalla
{
    class Program
    {
        enum MenuPartida
        {
            // Pide un valor para empezar a jugar
            jugar_partida,       // 0
            // pide un valor para cargar la partida guardada
            cargar_partida,      // 1
            // salir del juego
            salir,               // 2            
        }
       
        static void Main(string[] args)
        {
            // Enseño la imagen ASCII al inicio del juego
            SplashScreen();

            int valor;
            int numEnemigos = 0;
            //Cola enemigos;
            MenuPartida opcion;
            TorreDeBatalla torreDeBatalla;

            while (true)
            {
                // Muestro el menú al usuario
                Console.WriteLine(" ");
                Console.WriteLine("¿Qué quieres hacer?");
                Console.WriteLine(" ");
                Console.WriteLine("0 - Jugar partida.");
                Console.WriteLine("1 - Cargar partida guardada.");
                Console.WriteLine("2 - Salir.");
                Console.WriteLine(" ");
                // Pido al usuario un valor para escoger una opción del menú
                try
                {
                    valor = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    valor = 9;                
                }

                opcion = (MenuPartida)valor;

                // Introduzco la opción del usuario en un switch con diferentes opciones
                switch (opcion)
                {
                    // Jugar al juego
                    case MenuPartida.jugar_partida:                        
                        // Pido el nº de enemigos y los creo                        
                        Console.WriteLine("Con cuantos enemigos quieres luchar (de 1 a 10): ");
                        numEnemigos = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(" ");

                        if (numEnemigos < 1 || numEnemigos > 10)
                        {
                            Console.WriteLine("Error. Solo se puede elegir entre 1 y 10 enemigos. Has elegido: " + numEnemigos);
                        } else
                        {
                            // Creo una partida
                            torreDeBatalla = new TorreDeBatalla(numEnemigos);
                            // Arranco la partida
                            torreDeBatalla.Jugar();
                        }
                        break;

                    // Cargar una partida anteriormente guardada
                    case MenuPartida.cargar_partida:
                        // Creo una partida a partir de los datos cargados
                        torreDeBatalla = new TorreDeBatalla();
                        // Cargo la partida guardada.
                        torreDeBatalla.CargarPartida();
                        // Arranco la partida
                        torreDeBatalla.Jugar();
                        break;

                    // Salir del juego
                    case MenuPartida.salir:
                        Environment.Exit(0);
                        break;

                    // Error si el usuario pulsa otra tecla del menú
                    default:
                        Console.WriteLine("Has pulsado una tecla errónea.");
                        break;
                }
            }
        }        

        // Icono ASCII para mostrar al inicio del juego
        public static void SplashScreen()
        {
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@                                @@@@@@@@@@@@@@@@@@@@@@@@");
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@      TORRE DE BATALLA          @@@@@@@@@@@@@@@@@@@@@@@@");
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@                                @@@@@@@@@@@@@@@@@@@@@@@@");
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            Console.WriteLine("@@@@@@@@@               @@@@@@@(                 @@@@@@@*              ,@@@@@@@@");
            Console.WriteLine("@@@@@@@@@    @@@@@@@@   @@@@@@@    @@@@@@@@@@&   &@@@@@@    @@@@@@@@   .@@@@@@@@");
            Console.WriteLine("@@@@@@@@@    @@@@@@@@              @@@@@@@@@@&              @@@@@@@@   .@@@@@@@@");
            Console.WriteLine("@@@@@@@@@    @@@@@@@@.            #@@@@@@@@@@@.            (@@@@@@@@    @@@@@@@@");
            Console.WriteLine("@@@@@@@@@    @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@    @@@@@@@@");
            Console.WriteLine("@@@@@@@@@                                                               @@@@@@@@");
            Console.WriteLine("@@@@@@@@@%                                                             @@@@@@@@@");
            Console.WriteLine("@@@@@@@@@@@@@     ,@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@      @@@@@@@@@@@@");
            Console.WriteLine("@@@@@@@@@@@@@@@@                                                 @@@@@@@@@@@@@@@");
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@                                          .@@@@@@@@@@@@@@@@@@");
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@    @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@   .@@@@@@@@@@@@@@@@@@");
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@    @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@   .@@@@@@@@@@@@@@@@@@");
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@    @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@   .@@@@@@@@@@@@@@@@@@");
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@    @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@   .@@@@@@@@@@@@@@@@@@");
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@    @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@   .@@@@@@@@@@@@@@@@@@");
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@    @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@   .@@@@@@@@@@@@@@@@@@");
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@    @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@   .@@@@@@@@@@@@@@@@@@");
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@    @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@   .@@@@@@@@@@@@@@@@@@");
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@    @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@   .@@@@@@@@@@@@@@@@@@");
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@    @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@   .@@@@@@@@@@@@@@@@@@");
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@    &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&   .@@@@@@@@@@@@@@@@@@");
            Console.WriteLine("@@@@@@@@@@@@@@@@@@                                             @@@@@@@@@@@@@@@@@");
            Console.WriteLine("@@@@@@@@@@@@@@@(    (@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@     @@@@@@@@@@@@@@@");
            Console.WriteLine("@@@@@@@@@@@@@     @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#    (@@@@@@@@@@@@");
            Console.WriteLine("@@@@@@@@@@@                                                          .@@@@@@@@@@");
            Console.WriteLine("@@@@@@@@@@*                                                           @@@@@@@@@@");
            Console.WriteLine("@@@@@@@@@@,   @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#   @@@@@@@@@@");
            Console.WriteLine("@@@@@@@@@@,   @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%   @@@@@@@@@@");
            Console.WriteLine("@@@@@/                                                                     @@@@@");
            Console.WriteLine("@@@@@,   @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@   &@@@@");
            Console.WriteLine("@@@@@,   @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@   &@@@@");
            Console.WriteLine("@@@@@(                                                                     @@@@@");
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
        }      
    }
}
