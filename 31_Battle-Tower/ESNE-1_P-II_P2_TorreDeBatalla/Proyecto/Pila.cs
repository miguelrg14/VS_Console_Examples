// JuegoTorreDeBatalla
// Miguel Rodríguez Gallego
// 15/05/2021
// Pila ordenada para la recogida de puntuaciones de los usuarios tras ganar la partida

using System;

namespace TorreDeBatalla
{
    class Pila
    {
        // Declaro la clase Nodo con sus respectivos atributos para trabajar con ella en la Pila
        class Nodo
        {
            public Puntuacion puntuacion;
            public Nodo siguiente;
        }
        private Nodo cabeza;

        // Constructor
        public Pila()
        {
            cabeza = null;
        }

        // Insertar los nums en una lista enlazada ordenada
        public void Insertar(Puntuacion puntos)
        {
            // Variables auxiliares
            Nodo nuevoNodo;
            Nodo anterior;

            // Creamos nuestro nuevo nodo
            nuevoNodo = new Nodo();
            // Meto el dato que me pasan en una variable
            nuevoNodo.puntuacion = puntos;
            anterior = null;

            // Si la lista está vacía o queremos insertar en la cabecera. (Suponemos q la función "ListaVacía()" ya está implementada).
            if (ListaVacia() || cabeza.puntuacion.Puntos <= puntos.Puntos)
            {
                nuevoNodo.siguiente = cabeza;
                cabeza = nuevoNodo;
            }
            else
            {
                anterior = cabeza;
                // Buscamos el nodo d valor menor a v
                while (anterior.siguiente != null && anterior.siguiente.puntuacion.Puntos >= puntos.Puntos)
                {
                    anterior = anterior.siguiente;
                }

                // Insertamos el nuevo nodo después del nodo anterior
                nuevoNodo.siguiente = anterior.siguiente;
                anterior.siguiente = nuevoNodo;
            }
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
                // Muestro por pantalla la fecha y puntuación del primer jugador que se encuentra en la Pila ordenada
                Console.WriteLine(indice.puntuacion.Fecha + " - " + indice.puntuacion.Puntos + " puntos.");

                // Vamos avanzando por la lista hasta el último elemento
                while (indice.siguiente != null)
                {
                    i++;
                    indice = indice.siguiente;
                    // Muestro por pantalla la fecha y puntuación del resto de jugadores que se encuentran en la Pila ordenada
                    Console.WriteLine(indice.puntuacion.Fecha + " - " + indice.puntuacion.Puntos + " puntos.");
                }
            }
        }
    }
}
