using System;
// Miguel Rodrígurz Gallego
namespace Proyecto_Nodo
{
    class Program
    {
        enum Menu
        {
            // Pide un valor para el nuevo nodo a añadir
            Añadir_valor,       // 0
            // pide un valor para el valor del nodo a eliminar
            Eliminar_valor,     // 1
            // Mostrar los elementos de la lista por pantalla
            Mostrar_lista,      // 2
            // Borrar la lista
            Borrar_lista,       // 3
        }

        static void Main(string[] args)
        {
            int valor = 0;
            Menu opcion;

            // Creo la pila de números aleatorios
            ListaDoblementeEnlazada nuevaPila = new ListaDoblementeEnlazada();

            for (int i = 0; i < 100; i++)
            {
                nuevaPila.Añadir(NumAleatorio());
            }

            while (valor != 3)
            {               
                // Muestro el menú al usuario
                Console.WriteLine("¿Qué quieres hacer?");
                Console.WriteLine(" ");
                Console.WriteLine("0 - Añadir 1 valor al nuevo nodo");
                Console.WriteLine("1 - Eliminar un valor");
                Console.WriteLine("2 - Mostrar lista");
                Console.WriteLine("3 - Borrar lista");
                // Pido al usuario un valor para escoger una opción del menú
                valor = Convert.ToInt32(Console.ReadLine());

                opcion = (Menu)valor;

                // Introduzco la opción del usuario en un switch con diferentes opciones
                switch (opcion)
                {
                    case Menu.Añadir_valor:
                        int nuevoValor;
                        Console.WriteLine("Teclea el valor a añadir: ");
                        nuevoValor = Convert.ToInt32(Console.ReadLine());
                        // Inserto en la nueva pila el nuevo valor del usuario
                        nuevaPila.Añadir(nuevoValor);
                        Console.WriteLine("El nuevo valor introducido es: " + nuevoValor);
                        break;

                    case Menu.Eliminar_valor:
                        int valorABorrar;
                        // Pido y recojo el valor a borrar por el usuario
                        Console.WriteLine("Teclea el valor a eliminar: ");
                        valorABorrar = Convert.ToInt32(Console.ReadLine());
                        // Referencio al método de la clase "Pila" enviándole el valor que el usuario desea eliminar
                        nuevaPila = nuevaPila.Eliminar(valorABorrar);
                        break;

                    case Menu.Mostrar_lista:
                        // Muestro la lista con el método Mostrar que se encuentra en la clase "Pila"
                        nuevaPila.Mostrar();
                        break;

                    // Borro la lista creando un nuevo registro de memoria para la nueva pila
                    case Menu.Borrar_lista:
                        nuevaPila = new ListaDoblementeEnlazada();
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
    }
}
