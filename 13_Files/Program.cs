using System;
using System.IO;

namespace MiEjFicheros
{
    class Program
    {
        /*
         *             StreamWriter fichero;
            fichero = File.AppendText("prueba.txt");

            StreamReader ficheroDeLectura;
            ficheroDeLectura = File.OpenText("prueba.txt");


            fichero.WriteLine("Este es un fichero de prueba");
            string linea = ficheroDeLectura.ReadLine();

            fichero.Close();
        */

        static void Main(string[] args)
        {
            Menu();
            string decisionStr = Console.ReadLine();
            if (decisionStr == "1")
            {
                StreamWriter miFichero;
                miFichero = File.CreateText("miFichero.txt");
                bool salir = false;
                string input;
                string texto;
                Console.WriteLine("Escribe \"salir\" para salir");
                do
                {
                    input = Console.ReadLine();
                    if (input == "salir")
                    {
                        salir = true;
                    }
                    else
                    {
                        miFichero.WriteLine(input);
                    }
                }
                while (salir == false);
                miFichero.Close();
            }
            else if (decisionStr == "2")
            {
                StreamReader miFichero;
                miFichero = File.OpenText("miFichero.txt");
                miFichero = File.AppendText("miFichero.txt");
                bool salir = false;
                string input;
                string texto;
                Console.WriteLine("Escribe \"salir\" para salir");
                do
                {
                    input = Console.ReadLine();
                    if (input == "salir")
                    {
                        salir = true;
                    }
                    else
                    {
                        miFichero.WriteLine(input);
                    }
                }
                while (salir == false);
                miFichero.Close();
            }
        }

        static void Menu()
        {
            Console.WriteLine("¿Qué quieres hacer?");
            Console.WriteLine("Crear un nuevo proyecto (1)");
            Console.WriteLine("Continuar con el anterior proyecto (2)");
        }
        static bool EsNumerico(string myString, int valorNumerico)
        {
            if (int.TryParse(myString, out valorNumerico) == true)
                return true;
            else
                return false;
        }
    }
}
