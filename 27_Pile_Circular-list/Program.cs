using System;
// Miguel Rodríguez Gallego
namespace Lista_circular_Ejercicio_Leer_nombres
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable para el contador de términos
            int contador = 0;

            // Creo una nueva ranura de memoria para la pila nombres
            Pila nombres = new Pila();
            string nombre = " ";
            
            // Hago un bucle en el que mientras que el usuario no introduzca fin se ejecute el programa
            while (nombre != "FIN")
            {
                contador++;
                Console.WriteLine("Escribe un nombre: ");
                nombre = Console.ReadLine();
                // Bucle if para insertar los nombres en la pila
                if (nombre != "FIN")
                {
                    nombres.Insertar(nombre);
                }
            }
            // Expongo el Nº total de números
            Console.WriteLine(contador - 1);
            // Expongo los datos con los métodos ligados a la clase pila
            //nombres.CerrarLista();
            nombres.MostrarLista();
        }
    }
}
