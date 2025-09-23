using System;

namespace Ejs_Strings_mios__FALTA_por_corregir_el_4_
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena;
            Console.WriteLine("Escribe una cadena de texto: ");
            cadena = Console.ReadLine();
            Console.WriteLine(" ");

            // 1
            foreach (char c in cadena)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine(" ");

            // 2
            int tamanio = cadena.Length;
            Console.WriteLine("Tamaño = " + tamanio);
            Console.WriteLine(" ");

            // 3 
            Console.WriteLine("Introduce un Nº a invertir");
            string cadenaAInvertir = Console.ReadLine();

            string invertido = Invertir(cadenaAInvertir);

            Console.WriteLine("La cadena invertida es: " + invertido);
            Console.ReadLine();

            /*
            // Variable de tipo cadena de caracteres
            string x = "";

            //Imprime en pantalla información al usuario
            Console.Write("Escribe la frase: ");

            //Lee datos digitados por el usuario
            x = Console.ReadLine();

            //Arreglo de tipo cadena formado por un método split
            //El método split separa la cadena dependiendo el carácter que se use, en este caso el ESPACIO será lo que separará cada una de las palabras
            string[] palabras = x.Split(' ');

            //Ciclo que recorre nuestro arreglo de palabras
            for (int y = palabras.GetLength(0) - 1; y >= 0; y--)  
            {
                //Imprime en pantalla las palabras
                Console.Write(palabras[y] + " "); 
            }
            //Hace pausa
            Console.ReadKey(); 
            */

            // 4
            Console.WriteLine(cadena.Replace("juego", "videojuego"));

            Console.WriteLine(" ");

            // 5
            string cifrado = "";
            for (int aux = 0; aux < cadena.Length; aux++)
            {
                if (cadena[aux] == ' ')
                {
                    cifrado += ' ';
                }
                else
                {
                    int ascii = Convert.ToInt32(cadena[aux]);
                    ascii++;
                    cifrado += (char)ascii;
                }
                Console.Write(cifrado);
            }
        }

        static string Invertir(string cadenaAInvertir)
        {
            string invertido = "";
            for(int i = cadenaAInvertir.Length-1; i>=0; i--)
            {
                invertido += cadenaAInvertir[i];
            }

            return invertido;
        }
    }
}
