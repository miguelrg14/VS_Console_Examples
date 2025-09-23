using System;
// Miguel Rodríguez Gallego
namespace Proyecto_Nodo
{
    class ListaDoblementeEnlazada
    {
        class Nodo
        {
            public int dato;
            public Nodo siguiente;
            public Nodo anterior;

            public Nodo (int v)
            {
                dato = v;
                siguiente = null;
                anterior = null;
            }
        }

        private Nodo nodoDeAcceso;

        public ListaDoblementeEnlazada()
        {
            nodoDeAcceso = null;
        }

        // Insertar los nums en una lista enlazada ordenada
        public void Añadir(int v)
        {
            // Variables auxiliares
            Nodo nuevoNodo;
            Nodo anterior;
            Nodo siguiente;

            // Creamos nuestro nuevo nodo
            nuevoNodo = new Nodo(v);

            if (ListaVacia())
            {
                // Si la lista está vacia el nuevo nodo será el nodo de Acceso y sus referencias serán null
                nodoDeAcceso = nuevoNodo;
                nuevoNodo.siguiente = null;
                nuevoNodo.anterior = null;
            }
            else
            {
                // Insertao un nodo en una lista no ordenada tras el nodo de acceso
                // Pasos: 
                // Nuestro nodo siguiente tiene que ser el que era antes el del nodo de acceso, para tomar su puesto
                nuevoNodo.siguiente = nodoDeAcceso.siguiente;
                // Hacemos que el nodo de acceso nos apunte a nosotros como siguiente
                nodoDeAcceso.siguiente = nuevoNodo;
                // Apuntamos de vuelta al nodo de acceso
                nuevoNodo.anterior = nodoDeAcceso;
                // Hacemos que el siguiente a nosotros nos apunte como anteriores si el siguiente no es null, ya que eso implicaria que es el final de la lista
                if (nuevoNodo.siguiente != null)
                {
                    nuevoNodo.siguiente.anterior = nuevoNodo;
                }
            }

        }

        /* Resumen método "EliminarValor": 
         * Hacer un nodo guia el cual cuando llegue a un número que no me interesa lo salte con la variable 
         * cabeza para eliminar (ya que en c#) los valores se eliminan automaticamente al saltarlos
         */
        public ListaDoblementeEnlazada Eliminar(int v)
        {
            // Genero la pila "p" y creo una nueva memoria para ella
            ListaDoblementeEnlazada p = new ListaDoblementeEnlazada();
            Nodo indice;

            // Si la lista está vacía lo muestro por pantalla gracias al método "ListaVacia"
            if (ListaVacia())
            {
                Console.WriteLine("Lista vacía");
            }
            // Si la lista tiene datos permito al usuario eliminar el que quiera
            else
            {
                indice = nodoDeAcceso;

                // Si el dato de la cabeza es igual al valor de la variable v 
                if (nodoDeAcceso.dato == v)
                {
                    indice = indice.siguiente;
                    p.nodoDeAcceso = indice;
                    p.nodoDeAcceso.anterior = null;
                }
                else
                {
                    // Vamos avanzando por la lista hasta el último elemento
                    while (indice != null)
                    {
                        if (indice.dato != v)
                        {
                            p.Añadir(indice.dato);
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
            if (nodoDeAcceso == null)
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
                indice = nodoDeAcceso;
                Console.WriteLine("Dato: " + i + indice.dato);

                // Vamos avanzando por la lista hasta el último elemento
                while (indice.siguiente != null)
                {
                    i++;
                    indice = indice.siguiente;
                    Console.WriteLine("Dato: " + i + indice.dato);
                }
            }
        }
    }
}
