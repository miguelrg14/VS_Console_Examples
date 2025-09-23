using System;
using System.Security.Cryptography.X509Certificates;

namespace BasicCode03
{
    class Program
    {
        static float MyFloat()
        {
            return 4.82f;
        }
        static string MyString()
        {
            return "Hola Mundo!";
        }
        static bool MyBool()
        {
            return true;
        }
        static int MyRandomInt()
        {
            Random myRandom = new Random();
            return myRandom.Next();
        }
        static int Cuadrado(int x)
        {
            return (x * x);
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
        static void MenuCalculadora()
        {
            Console.WriteLine("¿Qué quieres hacer? 1.- Sumar  2.- Restar  3.- Multiplicar 4.- Dividir  5. Potencia  6.- Volver a introducir valores  0.- Salir");
        }
        static float Suma(float x, float y)
        {
            return x + y;
        }
        static float Resta(float x, float y)
        {
            return x - y;
        }
        static float Multiplicacion(float x, float y)
        {
            return x * y;
        }
        static float Division(float x, float y)
        {
            return x / y;
        }
        static void Calculadora()
        {
            // Calculadora
            int opcion = 1;
            bool opcion2 = false;
            float valor1 = 1;
            float valor2 = 1;
            while (opcion != 0)
            {
                do
                {
                    if (opcion2 == false)
                    {
                        Console.WriteLine("Escribe el primer valor");
                        valor1 = Convert.ToSingle(Console.ReadLine());
                    }
                    Console.WriteLine("Escribe el segundo valor");
                    valor2 = Convert.ToSingle(Console.ReadLine());
                    MenuCalculadora();
                    float result = 1;
                    do
                    {
                        opcion = Convert.ToInt32(Console.ReadLine());
                        switch (opcion)
                        {
                            case 1:
                                result = Suma(valor1, valor2);
                                break;
                            case 2:
                                result = Resta(valor1, valor2);
                                break;
                            case 3:
                                result = Multiplicacion(valor1, valor2);
                                break;
                            case 4:
                                result = Division(valor1, valor2);
                                break;
                            case 5:
                                result = Potencia(Convert.ToInt32(valor1), Convert.ToInt32(valor2));
                                break;
                            case 6:
                                result = Suma(valor1, valor2);
                                break;
                            default:
                                Console.WriteLine("Vuelve a introducir la opcion");
                                break;
                        }
                    }
                    while (opcion > 7 && opcion < 0);
                    Console.WriteLine("¿Quieres guardar el resultado? (True or False)");
                    opcion2 = Convert.ToBoolean(Console.ReadLine());
                    if (opcion2 == true)
                    {
                        valor1 = result;
                    }


                }
                while (opcion != 6);
            }
        static void Main(string[] args)
            {
                /*
                // Devolver variables
                Console.WriteLine(MyFloat());
                Console.WriteLine(MyString());
                Console.WriteLine(MyBool());
                Console.WriteLine(MyRandomInt());

                // Cuadrado
                Console.WriteLine("Introduzca un número para calcular su cuadrado");
                Console.WriteLine(Cuadrado(Convert.ToInt32(Console.ReadLine())));

                // Potencia
                Console.WriteLine("Introduzca la base de la potencia");
                int basePotencia = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduzca el exponente de la potencia");
                int exponentePotencia = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Potencia(basePotencia,exponentePotencia));
                */
                Calculadora();
            }
        }
    }
}
