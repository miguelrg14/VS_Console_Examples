using System;
using System.IO;
//Miguel Rodríguez Gallego
namespace Ejercicio_Bubble_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implementar una aplicación de consola que pida 5 números y los ordene de menor a mayor con bubble sort.

            // Pido los nº al usuario
            Console.WriteLine("Escribe 5 números y yo te los ordeno de menor a mayor");

            // Creo un fichero
            StreamWriter fichero;
            fichero = File.CreateText("ordenar5números");

            // Creo un array(Recordar que los arrays empiezan en 0)
            int[] array = new int[5];

            // Fichero.WriteLine(array[0] + " / " + array[1] + " / " + array[2] + " / " + array[3] + " / " + array[4] + " / ");
            // Creo un bucle para recoger 5 números
            for (int aux = 0; aux < array.Length; aux++)
            {
                Console.WriteLine("Escribe 1 número");
                array[aux] = Convert.ToInt32(Console.ReadLine());

                // Escribo en una linea del fichero cada número
                fichero.WriteLine(array[aux]);
            }
            fichero.Close();

            // A sabiendas de que los arrays son objetos y por lo tanto se pasan por defecto por referencia, igualmente lo coloco para dejar el ejercicio más visible.
            BubbleSort(ref array);

            // Muestro por pantalla los números del array
            Console.WriteLine(array[0] + " / " + array[1] + " / " + array[2] + " / " + array[3] + " / " + array[4] + " / ");
        }

        // Implementar una aplicación de consola que pida 5 números y los ordene de menor a mayor con bubble sort.
        static void BubbleSort(ref int[] arrayToSort)
        {
            // Creo una variable booleana para que mientras el bucle sea falso y no llegue hasta la parte final donde se le da el valor "true" no finalice
            bool changed = true;

            while (changed)
            {
                changed = false;
                // Declaro la variable de la auxiliar y hago que mientras sea menor al arrayToSort se le vaya restando 1 a este
                for (int aux = 0; aux < arrayToSort.Length - 1; aux++)
                {
                    // Con otro bucle hago que el arrayToSort coja los números del array del aux y mientras sea igual a su propio valor se sume una unidad a si mismo
                    if (arrayToSort[aux] > arrayToSort[aux + 1])
                    {
                        int aux2 = arrayToSort[aux];
                        arrayToSort[aux] = arrayToSort[aux + 1];
                        arrayToSort[aux + 1] = aux2;
                        // Cierro el ciclo del while estableciendo que changed sea igual a true
                        changed = true;
                    }
                }
            }
            // Devuelvo el dato final
            return;
        }
    }
}
