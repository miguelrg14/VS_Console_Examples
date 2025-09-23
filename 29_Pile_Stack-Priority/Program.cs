using System;
// Miguel Rodrígurz Gallego
namespace ColaPrioridad
{
    class Program
    {
        enum Menu
        {
            // Pide un valor para el nuevo nodo a añadir
            Añadir_valor,       // 0
            // pide un valor para el valor del nodo a eliminar
            Leer_valor,         // 1
            // Mostrar los elementos de la lista por pantalla
            Mostrar_lista,      // 2
            // Tamaño total
            Tamanio_total,      // 3
            // Tamaño por prioridad
            Tamanio_prioridad,  // 4
            // Mayor total
            Mayor_total,        // 5
            // Mayor por prioridad
            Mayor_prioridad,    // 6
            // Vacia            
            Cola_Vacia,              // 7
            // Salir
            Salir               // 8
        }

        static void Main(string[] args)
        {
            int valor = 0;
            Menu opcion;

            // Creo 3 colas con distinta prioridad
            Cola pAlta = new Cola("Alta");
            Cola pMedia = new Cola("Media");
            Cola pBaja = new Cola("Baja");

            // Relleno las colas con nºs aleatorios
            for (int i = 0; i < 100; i++)
            {
                pAlta.Insertar(NumAleatorio());
                pMedia.Insertar(NumAleatorio());
                pBaja.Insertar(NumAleatorio());
            }

            // Hago el menú
            while (valor != 8)
            {               
                // Muestro el menú al usuario
                Console.WriteLine("¿Qué quieres hacer?");
                Console.WriteLine(" ");
                Console.WriteLine("0 - Añadir 1 valor al nuevo nodo");
                Console.WriteLine("1 - Eliminar un valor");
                Console.WriteLine("2 - Mostrar lista");
                Console.WriteLine("3 - Tamaño del total");
                Console.WriteLine("4 - Tamaño por prioridad");
                Console.WriteLine("5 - Mayor nº del total");
                Console.WriteLine("6 - Mayor por prioridad");
                Console.WriteLine("7 - Ver si la lista está vacía");
                Console.WriteLine("8 - Salir");
                // Pido al usuario un valor para escoger una opción del menú
                valor = Convert.ToInt32(Console.ReadLine());

                // Recojo la opción del usuario
                opcion = (Menu)valor;
                string prior;

                // Introduzco la opción del usuario en un switch con diferentes opciones
                switch (opcion)
                {
                    // Caso para añadir 1 nuevo valor
                    case Menu.Añadir_valor:
                        int nuevoValor;
                        Console.WriteLine("Teclea el valor a añadir: ");
                        nuevoValor = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("A que cola quieres añadir?(Alta, Media o Baja)");
                        prior = Console.ReadLine();
                        // Inserto en la cola el valor añadido por el usuario en función d la prioridad indicada
                        if (prior.Equals("Alta"))
                        {
                            pAlta.Insertar(nuevoValor);
                        }
                        else if (prior.Equals("Media"))
                        {
                            pMedia.Insertar(nuevoValor);
                        }
                        else if (prior.Equals("Baja"))
                        {
                            pBaja.Insertar(nuevoValor);
                        }
                        // Si se equivoca el usuario de prioridad devuelvo error
                        else
                        {
                            Console.WriteLine("Prioridad " + prior + " Incorrecta");
                            break;
                        }
                        Console.WriteLine("El nuevo valor introducido es: " + nuevoValor);
                        break;
                        
                        // Caso para leer valores
                    case Menu.Leer_valor:
                        Console.WriteLine("De que cola quieres Leer?(Alta, Media o Baja)");
                        prior = Console.ReadLine();

                        // Variable auxiliar 
                        Nodo n = new Nodo();

                        // Leo en función de la prioridad escogida por el usuario
                        if (prior.Equals("Alta"))
                        {
                            n = pAlta.Leer();
                        }
                        else if (prior.Equals("Media"))
                        {
                            n = pMedia.Leer();
                        }
                        else if (prior.Equals("Baja"))
                        {
                            n = pBaja.Leer();
                        }
                        // Si se introduce un valor incorrecto devuelvo error
                        else
                        {
                            Console.WriteLine("Prioridad " + prior + " Incorrecta");
                            break;
                        }
                        Console.WriteLine("Valor leído = " + n.dato);
                        break;

                        // Muestro la lista
                    case Menu.Mostrar_lista:
                        Console.WriteLine("Que cola quieres Mostrar?(Alta, Media o Baja)");
                        prior = Console.ReadLine();

                        // Muestro en función de la prioridad elegida por el usuario
                        if (prior.Equals("Alta"))
                        {
                            pAlta.Mostrar();
                        }
                        else if (prior.Equals("Media"))
                        {
                            pMedia.Mostrar();
                        }
                        else if (prior.Equals("Baja"))
                        {
                            pBaja.Mostrar();
                        }
                        // Si se introduce un valor incorrecto devuelvo error
                        else
                        {
                            Console.WriteLine("Prioridad " + prior + " Incorrecta");
                            break;
                        }
                        break;

                        // Enseño el tamaño total de la lista
                    case Menu.Tamanio_total:                        
                        Console.WriteLine("El tamaño total de la cola es:  " + Tamanio(pAlta, pMedia, pBaja));
                        break;

                        // Enseño el tamaño por prioridad según la que escoja el usuario
                    case Menu.Tamanio_prioridad:
                        int tamanio = 0;
                        Console.WriteLine("De que cola quieres saber el tamaño?(Alta, Media o Baja)");
                        prior = Console.ReadLine();

                        // Muestro el tamaño de la prioridad elegida por el usuario
                        if (prior.Equals("Alta"))
                        {
                            tamanio = pAlta.Tamanio();
                        }
                        else if (prior.Equals("Media"))
                        {
                            tamanio = pMedia.Tamanio();
                        }
                        else if (prior.Equals("Baja"))
                        {
                            tamanio = pBaja.Tamanio();
                        }
                        // Si se introduce un valor incorrecto devuelvo error
                        else
                        {
                            Console.WriteLine("Prioridad " + prior + " Incorrecta");
                            break;
                        }
                        Console.WriteLine("El tamaño de la prioridad " + prior + " es " + tamanio);
                        break;

                        // Muestro por pantalla el mayor nº del total
                    case Menu.Mayor_total:
                        Console.WriteLine("El mayor valor de la cola es:  " + Mayor(pAlta, pMedia, pBaja));
                        break;

                        // Muestro por pantalla el mayor nº de la prioridad elegida por el usuario
                    case Menu.Mayor_prioridad:
                        int mayor = 0;
                        Console.WriteLine("De que cola quieres saber cual es el mayor valor?(Alta, Media o Baja)");
                        prior = Console.ReadLine();

                        // Muestro el mayor nº segun la prioridad escogida
                        if (prior.Equals("Alta"))
                        {
                            mayor = pAlta.Mayor();
                        }
                        else if (prior.Equals("Media"))
                        {
                            mayor = pMedia.Mayor();
                        }
                        else if (prior.Equals("Baja"))
                        {
                            mayor = pBaja.Mayor();
                        }
                        // Si se introduce un valor incorrecto devuelvo error
                        else
                        {
                            Console.WriteLine("Prioridad " + prior + " Incorrecta");
                            break;
                        }
                        Console.WriteLine("El mayor valor con prioridad " + prior + " es " + mayor);
                        break;

                        // Vacío la cola y muestro un mensaje que lo corrobora por pantalla
                    case Menu.Cola_Vacia:
                        if (Vacia(pAlta, pMedia, pBaja))
                        {
                            Console.WriteLine("La cola está vacía");
                        }
                        else
                        {
                            Console.WriteLine("La cola NO está vacía");
                        }
                        break;
                }
            }
        }

        // Creo los números aleatorios
        private static int NumAleatorio()
        {
            Random rnd = new Random();

            int randNum = rnd.Next();

            return randNum;
        }

        // Este método obtiene el tamaño total de las 3 colas sumando el tamaño de cada una d ellas
        private static int Tamanio(Cola pAlta, Cola pMedia, Cola pBaja)
        {
            return pAlta.Tamanio() + pMedia.Tamanio() + pBaja.Tamanio();
        }

        // Este método obtiene el mayor valor de las 3 colas
        private static int Mayor(Cola pAlta, Cola pMedia, Cola pBaja)
        {             
            // Comprueba si el mayor valor de la cola de prioridad alta es mayor q el d las otras 2 colas
            if (pAlta.Mayor() > pMedia.Mayor() && pAlta.Mayor() > pBaja.Mayor())
            {
                return pAlta.Mayor();
            }
            // Comprueba si el mayor valor d la cola d prioridad media es mayor q el d la cola de prioridad baja
            else if (pMedia.Mayor() > pBaja.Mayor())
            {
                return pMedia.Mayor();
            }
            // Si no se cumple ninguno de los casos anteriores, el mayor valor es el d la cola d prioridad baja
            else
            {
                return pBaja.Mayor();
            }
        }
        // Comprueba si la lista está vacía
        private static bool Vacia(Cola pAlta, Cola pMedia, Cola pBaja)
        {
            if (pAlta.Vacia() && pMedia.Vacia() && pBaja.Vacia())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
