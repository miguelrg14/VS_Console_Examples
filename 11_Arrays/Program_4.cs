using System;

namespace BasicCode05
{
    class Program
    {
        static void Main(string[] args)
        {
            // Factorial
            Console.WriteLine("Hola Mundo");
            int numFac = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Factorial(numFac));
            Numerar(numFac);

            // Introducir y mostrar array
            int[] array1 = new int[10];
            NewArray(array1);
            MostrarArray(array1);

            // Número más alto de tu array
            Console.Write("El número más alto de tu array es ");
            Console.WriteLine(Maximo(array1));

            // Ordenar array de mayor a menor
            int[] array2 = new int[5];
            NewArray(array2);
            OrdenarMayorMenor(array2);
            Console.WriteLine("Esta es tu array ordenada de mayor a menor:");
            MostrarArray(array2);

            // Array de números aleatorios y suma de ellos
            Console.WriteLine("Escribe el número de elementos que quieres que tenga tu array");
            int[] arrayRandom1 = new int[Convert.ToInt32(Console.ReadLine())];
            Console.WriteLine("Escribe el número mínimo y el número máximo entre los que quieres que se comprendan los valores que obtienen los elementos de tu array");
            Console.WriteLine("Número mínimo");
            int numMin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Número máximo");
            int numMax = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tu array random es:");
            MostrarArray(ArrayRandom(arrayRandom1, numMin, numMax));
            Console.WriteLine("La suma de todos los elementos de tu array random es " + SumaElementosArray(arrayRandom1));

            Console.ReadLine();

            // Array con números del 1 al 100, suma y media
            int[] array1a100 = new int[100];
            array1a100 = ArrayNumerosConsecutivos(array1a100);
            MostrarArray(array1a100);
            Console.WriteLine("La suma de todos los elementos de tu array es " + SumaElementosArray(array1a100));
            Console.WriteLine("La media de los elementos es: " + MediaElementosArray(array1a100));

            // Array abecedario
            char[] arrayAbecedario = { 'A','B','C','D','E','F','G','H','I','J','K','L','M','N','Ñ','O','P','Q','R','S','T','U','V','W','X','Y','Z'};
            MostrarArrayChar(arrayAbecedario);
            int decisionChar = 0;
            string stringChar = "";
            while(decisionChar != -1)
            {
                decisionChar = Convert.ToInt32(Console.ReadLine());
                if (decisionChar > -1 && decisionChar < 27)
                {
                    stringChar = stringChar + arrayAbecedario[decisionChar];
                }
                else if(decisionChar < -1 || decisionChar > 26)
                {
                    Console.WriteLine("Error, inserte otro número");
                }
                else
                {
                    Console.Write("Tu cadena de caracteres es ");
                }
                    
            }
            Console.WriteLine(stringChar);

            // Pasar elementos a otra array con el orden invertido
            Console.WriteLine("La array es:");
            int[] array3 = { 1, 2, 3, 4, 5 };
            MostrarArray(array3);
            int[] array4 = new int[array3.Length];
            Console.WriteLine("La array invertida es:");
            array4 = InvertirOrdenElementos(array3);
            MostrarArray(array4);

            // Comprobar si un número es capicua
            int inputNum = Convert.ToInt32(Console.ReadLine());
            if(EsCapicua(inputNum))
            {
                Console.WriteLine("El número es capicua");
            }
            else
            {
                Console.WriteLine("El número NO es capicua");
            }

        }
        static int Factorial (int x)
        {
            if (x ==1)
            {
                return 1;
            }
            return x * Factorial(x - 1);
        }
        static void Numerar (int x)
        {
            if (x >= 1)
            {
                Console.WriteLine(x);
                Numerar(x - 1);
            }
            else
                Console.WriteLine(x);
        }
        static void NewArray (int[] x)
        {
            for (int i = 0; i <= x.Length - 1; ++i)
            {
                Console.WriteLine("Escribe el valor en el índice " + i + ":");
                x[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        static void MostrarArray(int[] x)
        {
            for(int i = 0; i <= x.Length - 1; ++i)
            {
                Console.Write("Index: " + i + " Value: ");
                Console.WriteLine(x[i]);
            }
        }
        static int Maximo(int[] x)
        {
            int primero;
            int segundo;
            bool haCambiado = true;
            while(haCambiado == true)
            {
                haCambiado = false;

                for(int aux = 0; aux < x.Length - 1; aux++)
                {
                    primero = x[aux];
                    segundo = x[aux + 1];

                    if(primero < segundo)
                    {
                        x[aux] = segundo;
                        x[aux + 1] = primero;
                        haCambiado = true;
                    }
                }
            }
            return x[0];
        }
        static int[] OrdenarMayorMenor(int[] x)
        {
            int primero;
            int segundo;
            bool haCambiado = true;
            while (haCambiado == true)
            {
                haCambiado = false;

                for (int aux = 0; aux < x.Length - 1; aux++)
                {
                    primero = x[aux];
                    segundo = x[aux + 1];

                    if (primero < segundo)
                    {
                        x[aux] = segundo;
                        x[aux + 1] = primero;
                        haCambiado = true;
                    }
                }
            }
            return x;
        }
        static int[] ArrayRandom(int[] x, int numMin, int numMax)
        {
            for (int i = 0; i <= x.Length - 1; ++i)
            {
                Random rnd = new Random();
                x[i] = rnd.Next(numMin,numMax + 1);
            }
            return x;
        }
        static int SumaElementosArray(int[] x)
        {
            int res = 0;
            for (int i = 0; i <= x.Length - 1; ++i)
            {
                res = res + x[i];
            }
            return res;
        }
        static int[] ArrayNumerosConsecutivos(int[] x)
        {
            for (int i = 0; i <= x.Length - 1; ++i)
            {
                x[i] = i + 1;
            }
            return x;
        }
        static int MediaElementosArray(int[] x)
        {
            int res = 0;
            int media;
            for (int i = 0; i <= x.Length - 1; ++i)
            {
                res = res + x[i];
            }
            media = res / x.Length;
            return media;
        }
        static void MostrarArrayChar(char[] x)
        {
            for (int i = 0; i <= x.Length - 1; ++i)
            {
                Console.Write("Index: " + i + " Value: ");
                Console.WriteLine(x[i]);
            }
        }
        static int[] InvertirOrdenElementos(int[] x)
        {
            int[] arrayInvertida = new int[x.Length];
            for (int i = 0; i <= x.Length - 1; ++i)
            {
                arrayInvertida[i] = x[(x.Length -1) - i];
            }
            return arrayInvertida;
        }
        static char[] InvertirOrdenElementosChar(char[] x)
        {
            char[] arrayInvertida = new char[x.Length];
            for (int i = 0; i <= x.Length - 1; ++i)
            {
                arrayInvertida[i] = x[(x.Length - 1) - i];
            }
            return arrayInvertida;
        }
        static bool EsCapicua(int x)
        {
            string stringAux = Convert.ToString(x);
            bool esCapicua = false;
            char[] numberChar = new char[stringAux.Length];
            char[] numberCharInvert = new char[stringAux.Length];
            for (int i = 0; i <= stringAux.Length - 1; ++i)
            {
                numberChar[i] = Convert.ToChar(stringAux.Substring(i));
            }
            numberCharInvert = InvertirOrdenElementosChar(numberChar);
            if(numberChar == numberCharInvert)
            {
                esCapicua = true;
            }
            return esCapicua;
        }
    }
}
