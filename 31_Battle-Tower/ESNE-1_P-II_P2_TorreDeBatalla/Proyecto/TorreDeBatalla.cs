// JuegoTorreDeBatalla
// Miguel Rodríguez Gallego
// 15/05/2021
// Donde se desarrollan las funcionalidades básicas de la partida

using System;
using System.IO;

namespace TorreDeBatalla
{
    class TorreDeBatalla
    {
        // Clases que voy a utilizar
        Jugador jugador;
        Cola enemigos;
        Enemigo enemigoActual;
        Puntuacion puntos;
        Pila puntuacionesMasAltas;

        enum MenuJugar
        {
            // atacar a un enemigo
            atacar,                 // 0
            // lanzar un proyectil mágico
            proyectil_magico,       // 1
            // analizar estadísticas del enemigo actual
            analizar,               // 2    
            // no atacar a cambio de recuperar energía
            descansar,              // 3    
            // guardar la partida actual
            guardar_partida,        // 4    
            // salir del juego
            salir,                  // 5
        }

        // Constructor por defecto
        public TorreDeBatalla()
        {
            jugador = new Jugador();
            enemigos = new Cola();
            puntos = new Puntuacion();
            puntuacionesMasAltas = new Pila();
        }

        // Constructor para una partida nueva
        public TorreDeBatalla(int numEnemigos)
        {
            jugador = new Jugador(numEnemigos);
            enemigos = new Cola();
            this.GenerarEnemigos(numEnemigos);
            puntos = new Puntuacion();
            puntuacionesMasAltas = new Pila();
        }

        // Generador de enemigos segun el Nº de enemigos escogido 
        public void GenerarEnemigos(int numEnemigos)
        {
            for (int i = 0; i < numEnemigos; i++)
            {
                Enemigo enemigo = new Enemigo();
                enemigos.Insertar(enemigo);
            }
        }

        // Menu de opciones durante la partida frente a un enemigo
        public void Jugar()
        {
            int valor;
            MenuJugar opcion;
            enemigoActual = enemigos.Leer().enemigo;

            Console.WriteLine("Te vas a enfrentar a " + enemigoActual.Nombre);

            while (true)
            {
                // Muestro el menú al usuario
                Console.WriteLine(" ");
                Console.WriteLine("¿Qué quieres hacer?");
                Console.WriteLine(" ");
                Console.WriteLine("0 - Atacar.");
                Console.WriteLine("1 - Lanzar un proyectil mágico.");
                Console.WriteLine("2 - Analizar enemigo.");
                Console.WriteLine("3 - Descansar y recuperar energía.");
                Console.WriteLine("4 - Guardar la partida actual.");
                Console.WriteLine("5 - Salir del juego.");
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
               
                opcion = (MenuJugar)valor;

                // Introduzco la opción del usuario en un switch con diferentes opciones
                switch (opcion)
                {
                    // Ataque físico
                    case MenuJugar.atacar:
                        Ataque();
                        ContraAtaque();
                        RegeneraEnergia();
                        break;

                    // Ataque mágico
                    case MenuJugar.proyectil_magico:
                        ProyectilMagico();
                        ContraAtaque();
                        RegeneraEnergia();
                        break;
                       
                    // Analizar al rival
					case MenuJugar.analizar:
                        Console.WriteLine(" ");
                        Console.WriteLine("Jugador: " + " fuerza = " + this.jugador.Fuerza + " | poder magico = " + 
                            this.jugador.Poder_magico + " | defensa = " + this.jugador.Defensa + " | energia = " + this.jugador.Energia +
                            " | barrera magica = " + this.jugador.Barrera_magica + " | vida = " + this.jugador.Vida);

                        Console.WriteLine(" ");

                        Console.WriteLine(enemigoActual.Nombre + ": fuerza = " + enemigoActual.Fuerza + " | poder magico = " + 
                            enemigoActual.Poder_magico + " | defensa = " + enemigoActual.Defensa + " | energia = " + enemigoActual.Energia +
                            " | barrera magica = " + enemigoActual.Barrera_magica + " | vida = " + enemigoActual.Vida);

                        //enemigos.Mostrar();
                        break;

                    // Descansar para recuperar energia 
                    case MenuJugar.descansar:
                        RegeneraEnergia();
                        ContraAtaque();
                        break;

                    // Guardar la partida
                    case MenuJugar.guardar_partida:
                        GuardarPartida();
                        break;

                    // Salir de la partida
                    case MenuJugar.salir:
                        Environment.Exit(0);
                        break;

                    // Por si el usuario introduce un valor que no sea uno de los anteriores del menú
                    default:
                        Console.WriteLine("Has pulsado una tecla errónea.");
                        break;
                }

                if (jugador.Vida <= 0)
                {
                    SplashScreen2();
                    Console.WriteLine(" ");
                    Console.WriteLine("Has perdido la partida. Pulse una tecla para salir.");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                if (enemigoActual.Vida <= 0)
                {
                    if (enemigos.Vacia())
                    {
                        puntos.Puntos += 500;                       
                        CargarPuntuaciones();
                        puntuacionesMasAltas.Insertar(puntos);
                        puntuacionesMasAltas.Mostrar();
                        GuardarPuntuaciones();
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine("Has ganado la partida. Conseguiste derrotar a todos los enemigos. Pulse una tecla para salir.");
                        Console.ReadLine();
                        Environment.Exit(0);
                    } else
                    {
                        puntos.Puntos += 50;
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine("Has derrotado a " + enemigoActual.Nombre + ". Ahora a por el siguiente...");
                        enemigoActual = enemigos.Leer().enemigo;
                    }
                }
            }
        }

        // Ataque físico del jugador
        public void Ataque()
        {
            if (jugador.Energia > 0)
            {
                if (jugador.Fuerza > enemigoActual.Defensa)
                {
                    enemigoActual.Vida -= jugador.Fuerza;
                }
                jugador.Energia -= jugador.Fuerza;
                puntos.Puntos += jugador.Fuerza;
                if (jugador.Energia < 0)
                {
                    jugador.Energia = 0;
                }               
            } else
            {
                Console.WriteLine("Ataque fallido. No tienes energía.");
            }            
        }

        // Ataque Proyectil Mágico del jugador
        public void ProyectilMagico()
        {
            if (jugador.Energia > 0)
            {
                if (jugador.Poder_magico > enemigoActual.Barrera_magica)
                {
                    enemigoActual.Vida -= jugador.Poder_magico;
                }
                jugador.Energia -= jugador.Poder_magico;
                puntos.Puntos += jugador.Poder_magico;
                if (jugador.Energia < 0)
                {
                    jugador.Energia = 0;
                }
            }
            else
            {
                Console.WriteLine("Ataque fallido. No tienes energía.");
            }
        }
        // Regenerar Energia del jugador
        public void RegeneraEnergia()
        {
            jugador.Energia += Utilidades.NumAleatorio(1,2);
        }
        // Contraataque del enemigo tras el ataque del jugador
        public void ContraAtaque()
        {
            // El contraataque necesita un nº aleatorio entre 1 y 4 para decidir la opción a ejecutar.
            int decision = Utilidades.NumAleatorio(1, 3);
          
            // Se realiza la acción en función de la decision obtenida.
            switch (decision)
            {
                case 1:
                    AtaqueEnemigo();
                    RegeneraEnergiaEnemigo();
                    Console.WriteLine(" ");
                    Console.WriteLine("Decision ataque enemigo : ataque");
                    break;

                case 2:
                    ProyectilMagicoEnemigo();
                    RegeneraEnergiaEnemigo();
                    Console.WriteLine(" ");
                    Console.WriteLine("Decision ataque enemigo : proyectil mágico"); 
                    break;

                case 3:
                    RegeneraEnergiaEnemigo();
                    Console.WriteLine(" ");
                    Console.WriteLine("Decision ataque enemigo : descansar");
                    break;
            }            
        }

        // Ataque del enemigo
        public void AtaqueEnemigo()
        {
            if (enemigoActual.Energia > 0)
            {
                if (enemigoActual.Fuerza > jugador.Defensa)
                {
                    jugador.Vida -= enemigoActual.Fuerza;
                }
                enemigoActual.Energia -= enemigoActual.Fuerza;
                if (enemigoActual.Energia < 0)
                {
                    enemigoActual.Energia = 0;
                }
            }            
        }

        // Ataque Mágico del Enemigo
        public void ProyectilMagicoEnemigo()
        {
            if (enemigoActual.Energia > 0)
            {
                if (enemigoActual.Poder_magico > jugador.Barrera_magica)
                {
                    jugador.Vida -= enemigoActual.Poder_magico;
                }
                enemigoActual.Energia -= enemigoActual.Poder_magico;
                if (enemigoActual.Energia < 0)
                {
                    enemigoActual.Energia = 0;
                }
            }           
        }

        // Regenerar Energia del Enemigo
        public void RegeneraEnergiaEnemigo()
        {
            enemigoActual.Energia += Utilidades.NumAleatorio(1, 2);
        }

        // Guardar progreso de la Partida
        public void GuardarPartida()
        {
            // Paso la ruta del fichero al lector de texto "StreamReader"
            StreamWriter sw = File.CreateText("partida.txt");

            sw.WriteLine(jugador.Vida);
            sw.WriteLine(jugador.Fuerza);
            sw.WriteLine(jugador.Defensa);
            sw.WriteLine(jugador.Poder_magico);
            sw.WriteLine(jugador.Barrera_magica);
            sw.WriteLine(jugador.Energia);

            sw.WriteLine(enemigoActual.Nombre);
            sw.WriteLine(enemigoActual.Vida);
            sw.WriteLine(enemigoActual.Fuerza);
            sw.WriteLine(enemigoActual.Defensa);
            sw.WriteLine(enemigoActual.Poder_magico);
            sw.WriteLine(enemigoActual.Barrera_magica);
            sw.WriteLine(enemigoActual.Energia);

            // Paso los enemigos de la cola a un array.
            Enemigo[] enemigosArray = enemigos.ColaToArray();

            // Se recorre el array de enemigos asignando cada enemigo a la variable "c"
            foreach (Enemigo en in enemigosArray)
            {               
                sw.WriteLine(en.Nombre);
                sw.WriteLine(en.Vida);
                sw.WriteLine(en.Fuerza);
                sw.WriteLine(en.Defensa);
                sw.WriteLine(en.Poder_magico);
                sw.WriteLine(en.Barrera_magica);
                sw.WriteLine(en.Energia);
            }

            //Cierro el fichero
            sw.Close();
        }

        // Cargar progreso de la partida Guardada
        public void CargarPartida()
        {                      
            // Declaro variables
            string linea;

            //Paso la ruta del fichero al lector de texto "StreamReader"
            StreamReader sr = File.OpenText("partida.txt");
            //Leo la primera linea de fichero para comprobar que hay texto
            linea = sr.ReadLine();
            jugador.Vida = Convert.ToInt32(linea);
            linea = sr.ReadLine();
            jugador.Fuerza = Convert.ToInt32(linea);
            linea = sr.ReadLine();
            jugador.Defensa = Convert.ToInt32(linea);
            linea = sr.ReadLine();
            jugador.Poder_magico = Convert.ToInt32(linea);
            linea = sr.ReadLine();
            jugador.Barrera_magica = Convert.ToInt32(linea);
            linea = sr.ReadLine();
            jugador.Energia = Convert.ToInt32(linea);
            linea = sr.ReadLine();

            //Continuo leyendo hasta que terminen los datos del fichero
            while (linea != null)
            {
                Enemigo enemigo = new Enemigo();

                // Traslado el valor que recojo con la variable "linea" al enemigo
                enemigo.Nombre = linea;
                linea = sr.ReadLine();
                enemigo.Vida = Convert.ToInt32(linea);
                linea = sr.ReadLine();
                enemigo.Fuerza = Convert.ToInt32(linea);
                linea = sr.ReadLine();
                enemigo.Defensa = Convert.ToInt32(linea);
                linea = sr.ReadLine();
                enemigo.Poder_magico = Convert.ToInt32(linea);
                linea = sr.ReadLine();
                enemigo.Barrera_magica = Convert.ToInt32(linea);
                linea = sr.ReadLine();
                enemigo.Energia = Convert.ToInt32(linea);
                linea = sr.ReadLine();

                // Una vez leído un enemigo lo añado a la cola
                enemigos.Insertar(enemigo);
            }
            //Cierro el fichero
            sr.Close();

        }

        // Guardar progreso de la Partida
        public void GuardarPuntuaciones()
        {
            // Paso la ruta del fichero al lector de texto "StreamReader"
            StreamWriter sw = File.AppendText("puntuaciones.txt");

            sw.WriteLine(puntos.Fecha);
            sw.WriteLine(puntos.Puntos);

            //Cierro el fichero
            sw.Close();
        }

        // Cargar progreso de la partida Guardada
        public void CargarPuntuaciones()
        {
            // Declaro variables
            string linea;

            try
            {
                //Paso la ruta del fichero al lector de texto "StreamReader"
                StreamReader sr = File.OpenText("puntuaciones.txt");
                //Leo la primera linea de fichero para comprobar que hay texto
                linea = sr.ReadLine();

                //Continuo leyendo hasta que terminen los datos del fichero
                while (linea != null)
                {
                    Puntuacion p = new Puntuacion();

                    // Traslado el valor que recojo con la variable "linea" al enemigo
                    p.Fecha = Convert.ToDateTime(linea);
                    linea = sr.ReadLine();
                    p.Puntos = Convert.ToInt32(linea);
                    linea = sr.ReadLine();

                    // Una vez leído un enemigo lo añado a la cola
                    puntuacionesMasAltas.Insertar(p);
                }
                //Cierro el fichero
                sr.Close();
            }
            catch (FileNotFoundException)
            {                
            }
        }

        // Mensaje ASCII para cuando el jugador pierda
        public static void SplashScreen2()
        {
            Console.WriteLine(" ");
            Console.WriteLine("#####      #    #     # #######    ####### #     # ####### ######  ");
            Console.WriteLine("#     #   # #   ##   ## #          #     # #     # #       #     # ");
            Console.WriteLine("#        #   #  # # # # #          #     # #     # #       #     # ");
            Console.WriteLine("#  #### #     # #  #  # #####      #     # #     # #####   ######  ");
            Console.WriteLine("#     # ####### #     # #          #     #  #   #  #       #   #   ");
            Console.WriteLine("#     # #     # #     # #          #     #   # #   #       #    #  ");
            Console.WriteLine("#####   #     # #     # #######    #######    #    ####### #     # ");
        }
    }
}
