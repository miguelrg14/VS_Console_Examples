using System;

namespace __ho_y_decimal__Incompleto_la_parte_del_decimal_
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            Console.WriteLine("Qué quieres hacer?");
            Console.WriteLine(" ");
            Console.WriteLine("1 - Añadir a una frase al final ', oh' ");
            Console.WriteLine("2 - Hacer un método que reciba un número flotante y retorne su valor entero enuna variable entera ");
            Console.WriteLine(" ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    {
                        string frase = " ";

                        Console.Write("Escribe una frase: ");
                        frase = Console.ReadLine();

                        Ho(ref frase);


                        Console.WriteLine(" ");
                        Console.WriteLine("La frase final es: " + frase);
                        break;
                    }

                case 2:
                    {
                        float num;
                        Console.Write("Escribe 1 Nº decimal: ");
                        num = Convert.ToInt32(Console.ReadLine());


                        Console.WriteLine("El Nº devuelto es: " + NumFloat(num));
                        Console.WriteLine("Además, el 1er Nº era deciaml o no?" + DecimalONo());

                        break;
                    }
            }


        }

        static string Ho(ref string frase)
        {
            return frase += ", ho";
        }

        static float NumFloat(float num)
        {
            float numEntero;

            return numEntero = num;
        }

        static bool DecimalONo()
        {
            int numSinDecimal;
            numSinDecimal = numEntero;

            if (num != numSinDecimal)
            {
                numEntero = num;
                return decimalONo = true;
            }

            else
            {
                return decimalONo = false;
            }
        }
    }
}
