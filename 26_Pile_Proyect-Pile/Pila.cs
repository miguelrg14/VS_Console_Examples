using System;
// Miguel Rodríguez Gallego
namespace Proyecto_Nodo
{
    class Pila
    {
        class Nodo
        {
            public int dato;
            public Nodo siguiente;
        }
        private Nodo cabeza;

        public Pila()
        {
            cabeza = null;
        }

        // Insertar los nums en una lista enlazada ordenada
        public void Insertar(int v)
        {
            // Variables auxiliares
            Nodo nuevoNodo;
            Nodo anterior;

            // Creamos nuestro nuevo nodo
            nuevoNodo = new Nodo();
            // Meto el dato que me pasan en una variable
            nuevoNodo.dato = v;
            anterior = null;

            // Si la lista está vacía o queremos insertar en la cabecera. (Suponemos q la función "ListaVacía()" ya está implementada).
            if (ListaVacia() || cabeza.dato > v)
            {
                nuevoNodo.siguiente = cabeza;
                cabeza = nuevoNodo;
            }
            else
            {
                anterior = cabeza;
                // Buscamos el nodo d valor menor a v
                while (anterior.siguiente != null && anterior.siguiente.dato <= v)
                {
                    anterior = anterior.siguiente;
                }

                // Insertamos el nuevo nodo después del nodo anterior
                nuevoNodo.siguiente = anterior.siguiente;
                anterior.siguiente = nuevoNodo;
            }
        }

        /* Resumen método "EliminarValor": 
         * Hacer un nodo guia el cual cuando llegue a un número que no me interesa lo salte con la variable 
         * cabeza para eliminar (ya que en c#) los valores se eliminan automaticamente al saltarlos
         */
        public Pila EliminarValor(int v)
        {
            // Genero la pila "p" y creo una nueva memoria para ella
            Pila p = new Pila();
            Nodo indice;

            // Si la lista está vacía lo muestro por pantalla gracias al método "ListaVacia"
            if (ListaVacia())
            {
                Console.WriteLine("Lista vacía");
            }
            // Si la lista tiene datos permito al usuario eliminar el que quiera
            else
            {
                indice = cabeza;

                // Si el dato de la cabeza es igual al valor de la variable v 
                if (cabeza.dato == v)
                {
                    indice = indice.siguiente;
                    p.cabeza = indice;
                }
                else
                {
                    // Vamos avanzando por la lista hasta el último elemento
                    while (indice != null)
                    {
                        if (indice.dato != v)
                        {
                            p.Insertar(indice.dato);
                        }
                    
                        indice = indice.siguiente;
                    }            
                }                 
            }
            // Devuelvo la pila de datos
            return p;
        }
        // Método para comprobar si hay datos en la lista
        public bool ListaVacia()
        {
            if (cabeza == null)
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
            if (ListaVacia())
            {
                Console.WriteLine("Lista vacía");
            }
            // Creo un else para mostrar los datos si los hay
            else
            {
                // Creo la variable i para hacer de contador al lado de los nºs que muestre por pantalla a su izquierda
                int i = 1;
                indice = cabeza;
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
    }
}
