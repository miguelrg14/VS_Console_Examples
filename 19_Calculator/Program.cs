using System;

namespace MiCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pido los valores
            int valor1;
            int valor2;

            /*
            Console.WriteLine("Dame 2 números: ");
            Console.WriteLine(" ");            
            Console.Write("1 : ");
            valor1 = Convert.ToInt32(Console.ReadLine());            
            Console.Write("2 : ");
            valor2 = Convert.ToInt32(Console.ReadLine());
            */

            // Pido la elección con esos valores
            int eleccion;

            Console.WriteLine(" ");
            Console.WriteLine("Decide que hacer");
            Console.WriteLine(" ");
            Console.WriteLine("1 - Cuadrado de 1 número");
            Console.WriteLine("2 - Potencia de 1 número");
            Console.WriteLine("3 - Sumar Nºs");
            Console.WriteLine("4 - Restar Nºs ");
            Console.WriteLine("5 - Multiplicar Nºs ");
            Console.WriteLine("6 - Dividir Nºs ");
            Console.WriteLine(" ");
            eleccion = Convert.ToInt32(Console.ReadLine());

            switch (eleccion)
            {
                // Cuadrado
                case 1:
                    {
                        Console.Write("Dame 1 número: ");
                        valor1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("El cuadrado del nº es: " + Cuadrado(valor1));
                        break;
                    }
                // Potencia
                case 2:
                    {
                        Console.Write("Dame 1 número: ");
                        valor1 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Dame la potencia que quieres hacer del Nº: ");
                        int potencia = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("La potencia del nº es: " + Potencia(valor1, potencia));
                        break;
                    }

                // Sumar
                case 3:
                    {
                        Console.Write("Dame 1 número: ");
                        valor1 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Dame otro número: ");
                        valor2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("El resultado es: " + (valor1 + valor2));

                        Console.WriteLine("El mayor de los 2 valores es: " + Math.Max(valor1, valor2));
                        Console.WriteLine("El menor de los 2 valores es: " + Math.Min(valor1, valor2));
                        Console.WriteLine("El absoluto de " + valor1 + " es: " + Math.Abs(valor1));
                        break;
                    }

                // Restar
                case 4:
                    {
                        Console.Write("Dame 1 número: ");
                        valor1 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Dame otro número: ");
                        valor2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("El resultado es: " + (valor1 - valor2));
                        break;
                    }

                // Multiplicar
                case 5:
                    {
                        Console.Write("Dame 1 número: ");
                        valor1 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Dame otro número: ");
                        valor2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("El resultado es: " + (valor1 * valor2));
                        break;
                    }

                // Dividir
                case 6:
                    {
                        Console.Write("Dame 1 número: ");
                        valor1 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Dame otro número: ");
                        valor2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("El resultado es: " + (valor1 / valor2));
                        break;
                    }

                // Por si el usuario teclea otro Nº q no sea 1 d los dl menú
                default:
                    {
                        Console.WriteLine("Vuelve a introducir la opcion");
                        break;
                    }
            }
        }

        static int Cuadrado(int num)
        {
            return num * num;
        }

        static float Potencia(int x, int y)
        {
            float res = (float)x;
            int aux = 1;
            if (y > 0)
            {
                while (aux < y)
                {
                    res = res * x;
                    aux++;
                }
            }
            else if (y < 0)
            {
                float aux2 = (float)x;
                while (aux < (y * (-1)))
                {
                    aux2 = aux2 * x;
                    aux++;
                }
                res = (1 / aux2);
            }
            else res = 1;

            return res;
        }


    }
}
