using System;

namespace Ejs_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Declaro el array
            int[] valores;

            // Pido el número de valores que iran dentro del array al usuario
            Console.Write("Dime el Nº de valores que quieres: ");
            int numVal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            // Inicializo (le doy un valor) al array
            valores = new int[numVal];

            // int[valores] = { 15, 27, 19, 80 };

            // Rellenar array
            Console.WriteLine("Rellenemos el array");
            RellenarArray(ref valores);
            Console.WriteLine(" ");

            // Leer array
            Console.WriteLine("Y ahora leámoslo...");
            LeerArray(valores);
            Console.WriteLine(" ");

            // Leer el máximo de los nums del array
            Console.WriteLine("Ahora el máximo... ");
            Maximo(valores);
            Console.WriteLine(" ");

            // Leer el array de mayor a menor valor
            Console.WriteLine("Ahora de mayor a menor... ");
            MayorAMenor(valores);
            Console.WriteLine(" ");

            // Números aleatorios comprendidos entre 2 números
            Console.WriteLine("Ahora números aleatorios entre 2 valores...");
            Console.Write("Número de elementos del array: ");
            int[] arrayAleatorio = new int[Convert.ToInt32(Console.ReadLine())];
            Console.Write("Escribe el mínimo: ");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Escribe el máximo: ");
            int max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");
            Console.WriteLine("Números generados: ");
            LeerArray(ArrayAleatorio(ref arrayAleatorio, min, max));
            Console.WriteLine("La suma de todos los elementos de tu array random es " + SumaElementosArray(arrayAleatorio));
            Console.WriteLine(" ");

            // Array de números del 1 al 100
            Console.WriteLine("Ahora array de 100 elementos");
            Console.WriteLine("Pulsa intro");
            Console.ReadLine();

            int[] array100 = new int[100];
            array100 = NumerosConsecutivos(array100);
            LeerArray(array100);
            Console.WriteLine("La suma de todos los elementos de tu array es " + SumaElementosArray(array100));
            Console.WriteLine("La media de los elementos es: " + MediaArray(array100));
            Console.WriteLine(" ");
            

            // Array abecedario
            Console.WriteLine("Ahora el abecedario...");
            Console.WriteLine("Escribe números de entre 0 - 26 para escribir las letras correspondientes del abecedario");
            char[] arrayAbecedario = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'Ñ', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            MostrarArrayChar(arrayAbecedario);
            int decisionChar = 0;
            string stringChar = "";
            while (decisionChar != -1)
            {
                decisionChar = Convert.ToInt32(Console.ReadLine());
                if (decisionChar > -1 && decisionChar < 27)
                {
                    stringChar = stringChar + arrayAbecedario[decisionChar];
                }
                else if (decisionChar < -1 || decisionChar > 26)
                {
                    Console.WriteLine("Error, inserte otro número");
                }

                // Si escribes "-1"
                else if (decisionChar == -1)
                {
                    Console.Write("Tu cadena de caracteres es ");
                }

            }
            Console.WriteLine(stringChar);

            Console.WriteLine(" ");
            

            // Pasar elementos a otra array con el orden invertido
            Console.WriteLine("Ahora el array de 5 posiciones...");
            Console.WriteLine(" ");

            Console.WriteLine("Array: ");
            int[] array3 = { 1, 2, 3, 4, 5 };
            LeerArray(array3);
            int[] array4 = new int[array3.Length];
            Console.WriteLine(" ");

            Console.WriteLine("Array invertido: ");
            array4 = InvertirOrdenElementos(array3);
            LeerArray(array4);

            Console.WriteLine(" ");

            */

            // Comprobar si un número es capicua
            Console.Write("Dime un número y te digo si es capicúa: ");
            int x;
            int y;
            int num;
            num = Convert.ToInt32(Console.ReadLine());
            x = num;
            y = 0;
            Capicua(num, y, x);


            /*
            Console.Write("Dame 1 Nº y te digo si es capicúa: ");
            Console.Write(" ");
            int inputNum = Convert.ToInt32(Console.ReadLine());

            int numOrig = inputNum;
            int invertido = 0;

            while (inputNum > 0)
            {
                int digito = numOrig % 10;
                invertido = invertido * 10 + digito;
                numOrig /= 10;
            }

            Console.WriteLine("El Nº invertido es: " + invertido);
            if (numOrig == invertido)
            {
                Console.WriteLine("Es capicúa");
            }
            */
        }


        // Rellenar valores del array
        static int[] RellenarArray(ref int[] valores)
        {
            for (int i = 0; i < valores.Length; i++)
            {
                Console.Write("Dame el Nº " + i + " : ");
                valores[i] = Convert.ToInt32(Console.ReadLine());
            }

            return valores;
        }

        // Leer valores del array
        static int[] LeerArray(int[] valores)
        {
            for (int i = 0; i < valores.Length; i++)
            {
                Console.WriteLine("Valor " + i + " ==> " + valores[i]);
            }
            return valores;
        }

        static int[] Maximo(int[] valores)
        {
            /* Hago una comparación interna de los valores del array mediante la librería de métodos del array "Array" el método "Sort<>".
             * Después, dentro del sort abro la librería de métodos "Comparison" y mediante 2 variables y usando el método
             * "CompareTo" las comparo para que retorne una indicación de los correspondientes valores del array.
             * */
            Array.Sort<int>(valores, new Comparison<int>((i1, i2) => i2.CompareTo(i1)));
            Console.WriteLine("Máximo: " + valores[0]);

            return valores;
        }

        static int[] MayorAMenor(int[] valores)
        {
            Array.Sort<int>(valores, new Comparison<int>((i1, i2) => i2.CompareTo(i1)));

            for (int i = 0; i < valores.Length; i++)
            {
                Console.WriteLine("Valor " + i + " ==> " + valores[i]);
            }

            return valores;
        }

        static int[] ArrayAleatorio(ref int[] arrayAleatorio, int min, int max)
        {
            for (int i = 0; i < arrayAleatorio.Length; ++i)
            {
                Random rnd = new Random();
                arrayAleatorio[i] = rnd.Next(min, max + 1);
            }
            return arrayAleatorio;
        }

        static int SumaElementosArray(int[] arrayAleatorio)
        {
            int res = 0;
            for (int i = 0; i < arrayAleatorio.Length; ++i)
            {
                res = res + arrayAleatorio[i];
            }
            return res;
        }

        static int[] NumerosConsecutivos(int[] array100)
        {
            for (int i = 0; i < array100.Length; ++i)
            {
                array100[i] = i + 1;
            }
            return array100;
        }

        static int MediaArray(int[] array100)
        {
            int result = 0;
            int media;
            for (int i = 0; i < array100.Length; ++i)
            {
                result = result + array100[i];
            }
            media = result / array100.Length;
            return media;
        }

        static void MostrarArrayChar(char[] arrayAbecedario)
        {
            for (int i = 0; i <= arrayAbecedario.Length - 1; ++i)
            {
                Console.Write("Índice: " + i + " | Valor: ");
                Console.WriteLine(arrayAbecedario[i]);
            }
        }

        static int[] InvertirOrdenElementos(int[] x)
        {
            int[] arrayInvertido = new int[x.Length];
            for (int i = 0; i < x.Length; ++i)
            {
                arrayInvertido[i] = x[(x.Length - 1) - i];
            }
            return arrayInvertido;
        }

        static void Capicua(int num, int y, int x)
        {
            while (num > 0)
            {
                y = (y * 10) + (num % 10);
                num = num / 10;
            }
            if (x == y)
            {
                Console.WriteLine("Es capicúa");
            }
            else
            {
                Console.WriteLine("No es capicúa");
            }
        }

        /*
         *             int numOrig = x;
            int invertido = 0;

            while (x > 0)
            {
                int digito = numOrig % 10;
                invertido = invertido * 10 + digito;
                numOrig /= 10;
            }

            Console.WriteLine("El Nº invertido es: " + invertido);
            if(numOrig == invertido)
            {
                Console.WriteLine("Es capicúa");
            }
            return x;
        */

                /*
         *             string stringAux = Convert.ToString(x);
            bool esCapicua = false;
            int[] numberInt = new int[stringAux.Length];
            int[] numberCharInvert = new int[stringAux.Length];
            for (int i = 0; i <= stringAux.Length - 1; ++i)
            {
                numberInt[i] = Convert.ToChar(stringAux.Substring(i));
            }
            numberCharInvert = InvertirOrdenElementos(numberInt);
            if (numberInt == numberCharInvert)
            {
                esCapicua = true;
            }
            return esCapicua;
        */

        /*
         *             int numOrig = inputNum;
            int invertido = 0;

            while (inputNum > 0)
            {
                int digito = numOrig % 10;
                invertido = invertido * 10 + digito;
                numOrig /= 10;
            }

            Console.WriteLine("El Nº invertido es: " + invertido);
            if(numOrig == invertido)
            {
                Console.WriteLine("Es capicúa");
            }
            return inputNum;
        */
    }
}
