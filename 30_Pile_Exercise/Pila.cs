using System;
using System.IO;
// Miguel Rodríguez Gallego
namespace Ejercicio_Pilas
{
    class Pila
    {
        // Declaro el nodo
        class Nodo
        {
            public int dato;
            public Nodo siguiente;
        }
        private Nodo cabeza;

        // Constructor
        public Pila()
        {
            cabeza = null;
        }

        // Insertar los nums en una lista enlazada 
        public void Insertar(int v)
        {
            // Variables auxiliares
            Nodo nuevoNodo = new Nodo(); ;
            Nodo indice;

            // Meto el dato que me pasan en el "nuevoNodo"
            nuevoNodo.dato = v;

            // Si la lista está vacía insertamos el "nuevoNodo" en la "cabeza"
            if (ListaVacia())
            {
                nuevoNodo.siguiente = cabeza;
                cabeza = nuevoNodo;
            }
            // En el caso contrario lo añadimos al final
            else
            {
                indice = cabeza;

                // Vamos avanzando por la lista hasta el último elemento
                while (indice.siguiente != null)
                {                
                    indice = indice.siguiente;
                }

                indice.siguiente = nuevoNodo;
            }
        }

        /* Resumen método "EliminarValor": 
         * Este método construye una nueva pila. 
         * Utiliza un índice para ir copiando los valores d la pila original n la nueva pila.
         * Cuando se encuentra con el valor q pretendemos eliminar, simplemente no lo copia a la nueva pila.
         * Una vez terminada d construir la nueva pila la devolvemos.
         */
        public Pila EliminarValor()
        {
            // Creo una nueva pila "p"
            Nodo indice;
            Pila p = new Pila();

            // Si la lista está vacía lo muestro por pantalla gracias al método "ListaVacia"
            if (ListaVacia())
            {
                Console.WriteLine("Lista vacía");
            }
            // Si la lista tiene datos permito al usuario eliminar el que quiera
            else
            {
                // Situo el índice n la cabeza d la pila
                indice = cabeza;

                // Vamos avanzando por la lista hasta el último elemento
                while (indice != null)
                {
                    if (indice.siguiente != null)
                    {
                        p.Insertar(indice.dato);               
                        indice = indice.siguiente;
                    }
                    else
                    {
                        indice = null;
                    }
                }                              
            }
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
                indice = cabeza;
                string estadoPila = indice.dato.ToString();

                // Vamos avanzando por la lista hasta el último elemento
                while (indice.siguiente != null)
                {                  
                    indice = indice.siguiente;                  
                    estadoPila += " -> " + indice.dato.ToString();
                }
                Console.WriteLine("Estado de la pila: " + estadoPila);
            }
        }

        public int Mayor()
        {
            // Creo el nodo "indice"
            Nodo indice;
            int mayor = 0;
            // Si la lista está vacía devuelvo 0
            if (ListaVacia())
            {
                return 0;
            }
            // En el otro caso, busco el mayor valor de la cola
            else
            {
                // Situo el índice n la cabeza d la pila
                indice = cabeza;
                // Hago q el mayor sea igual al 1er valor d la pila
                mayor = indice.dato;

                // Vamos avanzando por la lista hasta el último elemento
                while (indice.siguiente != null)
                {
                    // Si el valor dl índice es mayor q el q tenemos almacenado lo guardamos
                    if (indice.dato > mayor)
                    {
                        mayor = indice.dato;
                    }
                    indice = indice.siguiente;                   
                }
                if (indice.dato > mayor)
                {
                    mayor = indice.dato;
                }
                // Devolvemos el mayor valor encontrado
                return mayor;
            }
        }

        // Devuelve la posición en la pila del mayor de los elementos
        public int PosicionMayor()
        {
            // Creo el nodo "indice"
            Nodo indice;
            // Recojo el mayor valor d la pila mediante el método "mayor()"
            int mayor = Mayor();
            int i = 1;

            // Si la lista está vacía devuelvo 0
            if (ListaVacia())
            {
                return 0;
            }
            // Sino, calculo la posición q ocupa el mayor valor d la pila
            else
            {
                // Situo el índice en la cabeza
                indice = cabeza;

                // Vamos avanzando por la lista hasta el último elemento
                while (indice.siguiente != null)
                {
                    // Si el valor dl índice es = al mayor valor d la pila devuelvo la posición q ocupa
                    if (indice.dato == mayor)
                    {
                        return i;
                    }
                    indice = indice.siguiente;
                    i++;
                }
                // Si ha llegado hasta aquí, el mayor valor d la pila es el último
                return i;
            }
        }
        // Intercambia el valor de la cima de la pila con el elemento mayor almacenado en la pila
        public bool Intercambiar()
        {
            // Declaro variables
            Nodo indice;
            Nodo indiceAnterior = new Nodo();
            int mayor = Mayor();
            int posicion = PosicionMayor();
            int cima = 0;
            int posicionCima = 0;

            // Si la lista está vacía quiere decir q no podemos hacer el intercambio, por lo q devuelvo "false"
            if (ListaVacia())
            {
                return false;
            }
            // Creo un else para realizar el intercambio
            else
            {
                // Situo el índice en la cabeza
                indice = cabeza;

                // Comprobamos cual es la posición dl último nodo
                while (indice.siguiente != null)
                {                    
                    indice = indice.siguiente;
                    posicionCima++;
                }

                cima = indice.dato;

                // Situo el índice en la cabeza
                indice = cabeza;
                // Guardo el valor dl "indice" n "indiceAnterior"
                indiceAnterior = indice;

                // Vamos avanzando por la lista hasta el último elemento
                for (int i = 0; i < posicionCima; i++)
                {      
                    // Si el contador = posición dl mayor nodo -1, intercambiamos el valor mayor por la cima en el siguiente
                    if (i == posicion - 1)
                    {
                        indice.siguiente.dato = cima;
                    }
                    // Si el contador = posición dl mayor nodo, intercambiamos el valor mayor por la cima
                    if (i == posicion)
                    {
                        indice.dato = cima;
                    }
                    // Si el contador = posición d la cima -1, intercambiamos el valor d la cima por el mayor en el siguiente
                    if (i == posicionCima - 1)
                    {
                        indice.siguiente.dato = mayor;
                    }
                    // Si el contador = posición d la cima, intercambiamos el valor d la cima por el mayor
                    if (i == posicionCima)
                    {
                        indice.dato = mayor;
                    }
                    indice = indiceAnterior.siguiente;
                    indiceAnterior = indiceAnterior.siguiente;
                }
                // Si todo ha terminado bn devolvemos true
                return true;
            }
        }

        // Devuelvo el tamaño d la pila
        public int Tamanio()
        {
            // Creo el nodo "indice"
            Nodo indice;
            // Si la lista está vacía devuelvo 0
            if (ListaVacia())
            {
                return 0;
            }
            // En el otro caso, calculo el tamaño de la cola
            else
            {
                // Creo la variable i para hacer de contador
                int i = 1;
                // Situo el índice en el 1er nodo
                indice = cabeza;

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

        public bool Existe(int v)
        {
            // Creo el nodo "indice"
            Nodo indice;
            // Si la lista está vacía devuelvo false
            if (ListaVacia())
            {
                return false;
            }
            else
            {
                // Situo el índice n la cabeza
                indice = cabeza;

                // Vamos avanzando por la lista hasta el último elemento
                while (indice.siguiente != null)
                {
                    // Si encontramos el valor buscado devolvemos true
                    if (indice.dato == v)
                    {
                        return true;
                    }
                    indice = indice.siguiente;
                }
                // Si encontramos el valor buscado devolvemos true
                if (indice.dato == v)
                {
                    return true;
                }
                // Si hemos llegado hasta aquí es q no hemos encontrado el valor buscado, con lo cual devolvemos false
                return false;
            }
        }

        // Almacena los valores de la pila en un fichero txt
        public bool Guardar()
        {
            // Paso la ruta del fichero al lector de texto "StreamReader"
            StreamWriter sw = File.CreateText("pila.txt");

            // Creo el nodo "indice"
            Nodo indice;
            // Si la lista está vacía no guardo nada y devuelvo false
            if (ListaVacia())
            {
                return false;
            }
            // Caso contrario recorro la pila y guardo los valores encontrados en el fichero
            else
            {
                // Situo el índice n la cabeza
                indice = cabeza;

                // Vamos avanzando por la lista hasta el último elemento
                while (indice.siguiente != null)
                {
                    // Escribo el valor d la pila n el fichero
                    sw.WriteLine(indice.dato); 
                    indice = indice.siguiente;
                }
                sw.WriteLine(indice.dato);
            }
            //Cierro el fichero
            sw.Close();

            return true;
        }

        // Carga el contenido de la pila desde un fichero txt
        public bool Cargar()
        {
            // Creo el nodo índice
            Nodo indice;

            // Igualo el índice a la cabeza
            indice = cabeza;

            // Si la lista no está vacía la recorremos para situarnos al final d ella y poder cargar los nodos dl fichero a continuación
            if (!ListaVacia())
            {
                // Vamos avanzando por la lista hasta el último elemento
                while (indice.siguiente != null)
                {
                    indice = indice.siguiente;
                }
            }
            string linea;

            //Paso la ruta del fichero al lector de texto "StreamReader"
            StreamReader sr = File.OpenText("pila.txt");
            //Leo la primera linea de fichero para comprobar que hay texto
            linea = sr.ReadLine();
            //Continuo leyendo hasta que terminen los datos del fichero
            while (linea != null)
            {               
                Insertar(Convert.ToInt32(linea));
                
                linea = sr.ReadLine();
            }
            //Cierro el fichero
            sr.Close();

            return true;
        }

        // Invierte el contenido d la pila recibida como parámetro por referencia
        public bool Invertir(ref Pila pila)
        {
            // Creo el nodo "indice"
            Nodo indice;
            // Si está vacío devuelvo false 
            if (ListaVacia())
            {
                return false;
            }
            // Creo un array d trabajo con el tamaño d la pila
            int[] a = new int[Tamanio()];
            int i = 0;
            
            // Situo el índice n la cabeza
            indice = cabeza;

            // Vamos avanzando por la lista hasta el último elemento y guardamos los valores n el array d trabajo
            while (indice.siguiente != null)
            {
                a[i] = indice.dato;
                indice = indice.siguiente;
                i++;
            }
            a[i] = indice.dato;

            // Creo una nueva pila
            Pila p = new Pila();            

            // Leemos el array d atrás hacia delante y vamos insertando en la nueva pila
            for (int j = Tamanio() - 1; j >= 0; j--)
            {
                p.Insertar(a[j]);
            }

            // Igualo la pila actual a la pila d trabajo
            pila = p;

            return true;
            
        }
    }
}
