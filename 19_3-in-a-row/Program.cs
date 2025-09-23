using System;

namespace TresEnRaya_Miguel_RodríguezGallego.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaro variables de contabilización de puntos y jugador activo en la partida
            int jugadorActivo = 1;
            int cont1 = 0;
            int cont2 = 0;

            // Hago un bucle para que sigan haciendose más partidas tras terminar una
            while(cont1 + cont2 < 10)
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
        static int ComprobarGanador(string jugador,string[] ter)
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
            if (ter[0]!=" " && ter[1] != " " && ter[2] != " " && ter[3] != " " && ter[4] != " " && ter[5] != " " && ter[6] != " " && ter[7] != " " && ter[8] != " ")
            {
                // Si nadie gana devuelvo el valor 3
                return 3;
            }
            return 0;
        }
    }
}
