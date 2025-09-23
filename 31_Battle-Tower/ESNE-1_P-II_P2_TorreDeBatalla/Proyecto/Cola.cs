// JuegoTorreDeBatalla
// Miguel Rodríguez Gallego
// 15/05/2021
// Uso una cola para la creación de los enemigos

using System;

namespace TorreDeBatalla
{
    class Cola
    {
        // Atributos
        private Nodo primero;
        private Nodo ultimo;
        
        // Constructor
        public Cola()
        {
            primero = null;
            ultimo = null;
        }

        // Insertar los nums en una lista enlazada
        public void Insertar(Enemigo enemigo)
        {
            // Variables auxiliares
            Nodo nuevoNodo;            

            // Creamos nuestro nuevo nodo
            nuevoNodo = new Nodo();
            // Meto el dato que me pasan en una variable
            nuevoNodo.enemigo = enemigo;

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
                // Creo la variable i, la cual ira subiendo segun el enemigo que toque
                int i = 1;
                indice = primero;            
                // Escribo por pantalla los enemigos que tocaron y sus estadísticas
                Console.WriteLine("Enemigo: " + i + " - " + indice.enemigo.Nombre + " fuerza "+ indice.enemigo.Fuerza + 
                    " poder magico " + indice.enemigo.Poder_magico + " defensa " + indice.enemigo.Defensa + " energia " + indice.enemigo.Energia);

                // Con un bucle escribo por pantalla los enemigos que van después del 1º hasta que no quede ninguno
                while (indice.siguiente != null)
                {
                    i++;
                    indice = indice.siguiente;
                    Console.WriteLine("Enemigo: " + i + " - " + indice.enemigo.Nombre + " fuerza " + indice.enemigo.Fuerza +
                    " poder magico " + indice.enemigo.Poder_magico + " defensa " + indice.enemigo.Defensa + " energia " + indice.enemigo.Energia);

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

        // Este método pasa todos los enemigos de la cola a un array y lo devuelve.
        public Enemigo[] ColaToArray()
        {
            // Creo el nodo "indice" y un array en el que guardar los enemigos
            Nodo indice;
            Enemigo[] enemigos = new Enemigo[this.Tamanio()];

            // Si la lista está vacía devuelvo 0
            if (!Vacia())
            {               
                // Creo la variable i para hacer de contador
                int i = 0;
                // Situo el índice en el 1er nodo
                indice = primero;

                // Vamos avanzando por la cola hasta el último nodo
                while (indice != null)
                {
                    enemigos[i] = indice.enemigo;
                    i++;
                    indice = indice.siguiente;
                }                
            }
            return enemigos;
        }
    }
}
