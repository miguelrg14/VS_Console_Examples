using System;
using System.IO;
namespace Prog
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaramos e inicializamos el fichero de lectura
            StreamReader ficheroDeLectura;
            ficheroDeLectura = File.OpenText("text.txt");

            // Declaramos e inicializamos nuestra estructura de datos estática
            int[] nums = new int[5];

            // Leemos los valores del fichero
            for (int aux = 0; aux < nums.Length; aux++)
            {
                nums[aux] = Convert.ToInt32(ficheroDeLectura.ReadLine());
            }
            ficheroDeLectura.Close();

            // Ordenamos el array
            BubbleSort(ref nums);

            // Declaramos e inicializamos el fichero de escritura
            StreamWriter ficheroDeEscritura;
            ficheroDeEscritura = File.AppendText("text.txt");

            // Escribimos en el fichero de salida
            ficheroDeEscritura.WriteLine();
            for (int aux = 0; aux < nums.Length; aux++)
            {
                ficheroDeEscritura.Write(nums[aux]);
                if(aux < nums.Length - 1)
                {
                    ficheroDeEscritura.Write(" / ");
                }
            }
            ficheroDeEscritura.Close();
        }

        /// <summary>
        /// Método que ordena los valores de un array de enteros de menor a mayor
        /// </summary>
        /// <param name="arrayToOrder"> Array para ser ordenado </param>
        static void BubbleSort(ref int[] arrayToOrder)
        {
            bool somethingChanged = true; // Variable de control del algoritmo de ordenación

            // Bucle principal, termina cuando todo esta ordenado
            while (somethingChanged)
            {
                somethingChanged = false;

                // Bucle de comparaciones (el -1 es para no salirnos del array)
                for (int aux = 0; aux < arrayToOrder.Length - 1; aux++)
                {
                    // Se cambian los valores de posición
                    if (arrayToOrder[aux] > arrayToOrder[aux + 1])
                    {
                        int first = arrayToOrder[aux];
                        arrayToOrder[aux] = arrayToOrder[aux + 1];
                        arrayToOrder[aux + 1] = first;

                        somethingChanged = true; // Se sigue ejecutando el algortimo
                    }
                }
            }
        }
    }
}