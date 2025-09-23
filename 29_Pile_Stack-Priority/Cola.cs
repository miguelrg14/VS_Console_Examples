using System;
// Miguel Rodríguez Gallego
namespace ColaPrioridad
{
    class Cola
    {
        // Atributos
        private Nodo primero;
        private Nodo ultimo;
        public string prioridad;

        // Constructor
        public Cola(string prior)
        {
            primero = null;
            ultimo = null;
            prioridad = prior;
        }

        // Insertar los nums en una lista enlazada
        public void Insertar(int v)
        {
            // Variables auxiliares
            Nodo nuevoNodo;            

            // Creamos nuestro nuevo nodo
            nuevoNodo = new Nodo();
            // Meto el dato que me pasan en una variable
            nuevoNodo.dato = v;

            // Si la lista está vacía se iguala "primero" y "ultimo" al nuevo nodo
            if (Vacia())
            {
                nuevoNodo.siguiente = primero;
                primero = nuevoNodo;
                ultimo = nuevoNodo;
            }
            // Sino añadimos el "nuevoNodo" al final de la cola
            else
            {
                ultimo.siguiente = nuevoNodo;
                ultimo = nuevoNodo;                
            }
        }

        /* Resumen método "Leer": 
         * Hacer un nodo guia el cual cuando llegue a un número que no me interesa lo salte con la variable 
         * cabeza para eliminar (ya que en c#) los valores se eliminan automaticamente al saltarlos
         */
        public Nodo Leer()
        {
            // Creo un nuevo nodo para almacenar el primero
            Nodo n = new Nodo();
            n = primero;

            // Si la lista está vacía lo muestro por pantalla
            if (Vacia())
            {
                Console.WriteLine("Lista vacía");               
            }
            // Si la lista solo tiene un elemento, lo elimino poniendo el "primero" y "ultimo" nodos como nulos
            else if (primero == ultimo)
            {
                primero = null;
                ultimo = null;               
            }
            // Si la lista tiene datos elimino el primero
            else
            {
                primero = primero.siguiente;
            }
            // Devuelvo el primer nodo de la cola
            return n;
        }

        // Método para comprobar si hay datos en la lista
        public bool Vacia()
        {
            if (primero == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Muestro por pantalla todos los datos
        public void Mostrar()
        {
            // Creo el nodo "indice"
            Nodo indice;
            // Abro un "if" para mostrar mediante el método "ListaVacia" un msg d lista vacía si no hay datos/se borraron todos
            if (Vacia())
            {
                Console.WriteLine("Lista vacía");
            }
            // Creo un else para mostrar los datos si los hay
            else
            {
                // Creo la variable i para hacer de contador al lado de los nºs que muestre por pantalla a su izquierda
                int i = 1;
                indice = primero;
                Console.WriteLine("Prioridad: " + " - " + this.prioridad);
                Console.WriteLine("Dato: " + i + " - " + indice.dato);

                // Vamos avanzando por la lista hasta el último elemento
                while (indice.siguiente != null)
                {
                    i++;
                    indice = indice.siguiente;
                    Console.WriteLine("Dato: " + i + " - " + indice.dato);
                }
            }
        }
        public int Tamanio()
        {
            // Creo el nodo "indice"
            Nodo indice;
            // Si la lista está vacía devuelvo 0
            if (Vacia())
            {
               return 0;
            }
            // En el otro caso, calculo el tamaño de la cola
            else
            {
                // Creo la variable i para hacer de contador
                int i = 1;
                // Situo el índice en el 1er nodo
                indice = primero;

                // Vamos avanzando por la cola hasta el último nodo
                while (indice.siguiente != null)
                {
                    i++;
                    indice = indice.siguiente;
                }
                // Devuelvo el tamaño de la cola
                return i;
            }
        }

        public int Mayor()
        {
            // Creo el nodo "indice"
            Nodo indice;
            // Si la cola está vacía devuelvo 0
            if (Vacia())
            {
                return 0;
            }
            // En el otro caso, busco el mayor valor de la cola
            else
            {
                // Situo el índice en el 1er nodo
                indice = primero;
                // Creo la variable i para guardar el mayor valor de la cola
                int i = indice.dato;

                // Vamos avanzando por la lista hasta el último elemento
                while (indice.siguiente != null)
                {                    
                    indice = indice.siguiente;

                    // Si el valor del nodo es mayor que el que tenemos almacenado lo guardamos en "i"
                    if (indice.dato > i)
                    {
                        i = indice.dato;
                    }
                }
                // Devolvemos el mayor valor encontrado
                return i;
            }
        }
    }
}
