using System;

namespace Lista_circular_Ejercicio_Leer_nombres
{
    class Pila
    {
        class Nodo
        {
            public string dato;
            public Nodo siguiente;
        }

        private Nodo cabeza;

        public Pila()
        {
            cabeza = null;
        }

        public bool ListaVacia()
        {
            return cabeza == null;
        }

        public void Insertar(string v)
        {
            Nodo nuevoNodo = new Nodo();
            nuevoNodo.dato = v;

            if (ListaVacia())
            {
                // Primer nodo apunta a sí mismo
                nuevoNodo.siguiente = nuevoNodo;
                cabeza = nuevoNodo;
            }
            else
            {
                // Insertar al final (antes de volver a la cabeza)
                Nodo actual = cabeza;
                while (actual.siguiente != cabeza)
                {
                    actual = actual.siguiente;
                }

                actual.siguiente = nuevoNodo;
                nuevoNodo.siguiente = cabeza;
            }
        }

        public void MostrarLista()
        {
            if (ListaVacia())
            {
                Console.WriteLine("Lista vacía");
                return;
            }

            Console.WriteLine("Cabeza: " + cabeza.dato);  // Mostrar cabeza

            Nodo indice = cabeza;
            int i = 1;
            do
            {
                Console.WriteLine("Dato: " + i + " - " + indice.dato);
                indice = indice.siguiente;
                i++;
            }
            while (indice != cabeza);
        }
    }
}
