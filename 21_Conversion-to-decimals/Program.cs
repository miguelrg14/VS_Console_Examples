using System;

namespace ConvertirADecimales
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            Console.WriteLine("Hola, introduce tu nombre");
            nombre = Console.ReadLine();

            int edad;
            Console.WriteLine("Ahora introduce tu edad");
            edad = Convert.ToInt32(Console.ReadLine());

            double nota1;
            Console.WriteLine("Ahora la nota de 1 examen");
            nota1 = (float)Convert.ToDecimal(Console.ReadLine());


            double nota2;
            Console.WriteLine("Ahora la nota de otro examen");
            nota2 = (float)Convert.ToDecimal(Console.ReadLine());

            /*
            string nombreAmigo;
            Console.WriteLine("Ahora el nombre de 1 amigo");
            nombreAmigo = Console.ReadLine();

            int edadAmigo;
            Console.WriteLine("Ahora la edad de tu amigo");
            edadAmigo = Convert.ToInt32(Console.ReadLine());
            */

            // Media notas
            double media;
            media = (nota1 + nota2) / 2;


            Console.WriteLine("Nombre: " + nombre + " | Edad: " + edad);
            Console.WriteLine("Nota1: " + nota1 + " | Nota2: " + nota2);
            Console.WriteLine(" ");
            Console.WriteLine("Media de las notas: " + media);

            /*
            Console.WriteLine(" ");
            Console.WriteLine("Nombre: " + nombreAmigo + " | Edad: " + edadAmigo);
            */
        }
    }
}
