using System;
// Miguel Rodrígurz Gallego
namespace Ejercicio_Pilas
{
    class Program
    {
        enum Menu
        {
            // Pide un valor para el nuevo nodo a añadir
            Insertar_elemento,      // 0
            // Pide un valor para el valor del nodo a eliminar
            Sacar_elemento,         // 1
            // Devuelve el mayor elemento de la pila
            Mayor_elemento,         // 2   
            // Devuelve la posición en la pila del mayor de los elementos
            Posición_mayor,         // 3
            // Intercambia el valor de la cima de la pila con el elemento mayor almacenado en la pila
            Prioridad_elemento,     // 4
            // Almacena los valores de la pila en un fichero txt
            Guardar_elemento,       // 5
            // Carga el contenido de la pila desde un fichero txt
            Cargar_elemento,        // 6
            // Devuelve verdadero si el valor pasado está presente en algún elemento de la pila
            Existe,                 // 7
            // Vacía el contenido de la pila elemento a elemento
            Vacia_pila,             // 8
            // Invierte el contenido de la pila
            Invertir,               // 9
            // Devuelve el número de elementos de la pila
            Tamanio_pila,           // 10
            // Salir
            Salir                  // 11
        }

        static void Main(string[] args)
        {
            int valor = 0;
            Menu opcion;

            // Creo la pila de números aleatorios
            Pila nuevaPila = new Pila();

            while (valor != 11)
            {
                // Muestro el menú al usuario
                Console.WriteLine(" ");
                Console.WriteLine("¿Qué quieres hacer?");
                Console.WriteLine(" ");
                Console.WriteLine("0 - Insertar elemento");
                Console.WriteLine("1 - Sacar elemento");
                Console.WriteLine("2 - Mayor elemento");
                Console.WriteLine("3 - Posición mayor");
                Console.WriteLine("4 - Prioridad elemento");
                Console.WriteLine("5 - Guardar elemento");
                Console.WriteLine("6 - Cargar elemento");
                Console.WriteLine("7 - Existe el anterior valor en la pila?");
                Console.WriteLine("8 - Vaciar Pila");
                Console.WriteLine("9 - Invertir Pila");
                Console.WriteLine("10 - Tamaño Pila");
                Console.WriteLine("11 - Salir");
                Console.WriteLine(" ");
                // Pido al usuario un valor para escoger una opción del menú
                valor = Convert.ToInt32(Console.ReadLine());

                opcion = (Menu)valor;

                // Introduzco la opción del usuario en un switch con diferentes opciones
                switch (opcion)
                {
                    case Menu.Insertar_elemento:
                        int nuevoValor;
                        Console.WriteLine("Teclea el valor a añadir: ");
                        nuevoValor = Convert.ToInt32(Console.ReadLine());
                        // Inserto en la nueva pila el nuevo valor del usuario
                        nuevaPila.Insertar(nuevoValor);
                        nuevaPila.Mostrar();
                        break;

                    case Menu.Sacar_elemento:
                        // Referencio al método de la clase "Pila" enviándole el valor que el usuario desea eliminar
                        nuevaPila = nuevaPila.EliminarValor();
                        nuevaPila.Mostrar();
                        break;

                    case Menu.Mayor_elemento:
                        Console.WriteLine("El mayor elemento de la pila es: " + nuevaPila.Mayor().ToString());
                        break;

                    case Menu.Posición_mayor:
                        Console.WriteLine("La posición del mayor elemento de la pila es: " + nuevaPila.PosicionMayor().ToString());
                        break;

                    case Menu.Prioridad_elemento:
                        if (nuevaPila.Intercambiar())
                        {
                            Console.WriteLine("Hemos intercambiado el valor de la cima de la pila con el elemento mayor almacenado en la pila");
                            nuevaPila.Mostrar();
                        }
                        else
                        {
                            Console.WriteLine("La lista está vacía");
                        }
                        break;

                    case Menu.Guardar_elemento:
                        if (nuevaPila.Guardar())
                        {
                            Console.WriteLine("Se ha guardado la pila correctamente");
                        }
                        else
                        {
                            Console.WriteLine("No se ha podido guardar la pila correctamente");
                        }
                        break;

                    case Menu.Cargar_elemento:
                        if (nuevaPila.Cargar())
                        {
                            Console.WriteLine("Se ha cargado la pila correctamente");
                        }
                        else
                        {
                            Console.WriteLine("No se ha podido cargar la pila correctamente");
                        }
                        break;

                    case Menu.Existe:
                        nuevoValor = 0;
                        Console.WriteLine("Teclea el valor a buscar: ");
                        nuevoValor = Convert.ToInt32(Console.ReadLine());
                        // Inserto en la nueva pila el nuevo valor del usuario
                        nuevaPila.Mostrar();
                        if (nuevaPila.Existe(nuevoValor))
                        {
                            Console.WriteLine("El valor buscado existe en la pila");
                        }
                        else
                        {
                            Console.WriteLine("El valor buscado no existe en la pila");
                        }
                        break;

                    case Menu.Vacia_pila:
                        nuevaPila = new Pila();
                        Console.WriteLine("Pila borrada");
                        break;

                    case Menu.Invertir:
                        nuevaPila.Mostrar();
                        if (nuevaPila.Invertir(ref nuevaPila))
                        {                           
                            Console.WriteLine("Se ha invertido la pila");
                            nuevaPila.Mostrar();
                        }
                        else
                        {
                            Console.WriteLine("No se puede invertir una pila vacía");
                        }
                        break;

                    case Menu.Tamanio_pila:
                        Console.WriteLine("El tamaño de la pila es: " + nuevaPila.Tamanio().ToString());
                        break;
                }
            }
        }
    }
}
