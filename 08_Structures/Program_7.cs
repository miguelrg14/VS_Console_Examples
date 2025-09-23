using System;

namespace Estructuras01
{
    class Program
    {
        struct contacto
        {
            public string nombre;
            public string apellido;
            public int numero;
        }
        static void Main(string[] args)
        {
            int decision2;
            contacto contactoAgenda;
            contactoAgenda.nombre = "Vacio";
            contactoAgenda.apellido = "Vacio";
            contactoAgenda.numero = 0;
            do
            {
                MenuAgenda();
                decision2 = Convert.ToInt32(Console.ReadLine());
                switch (decision2)
                {
                    case 1:
                        contactoAgenda = AlmacenarContacto();
                        break;
                    case 2:
                        VerContacto(contactoAgenda);
                        break;
                    case 3:
                        BorrarContacto(ref contactoAgenda);
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("No es una opción válida");
                        break;
                }
            }
            while (decision2 != 4);
        }
        static contacto AlmacenarContacto()
        {
            contacto nuevoContacto;

            Console.WriteLine("Introduzca un nombre para el nuevo contacto");
            nuevoContacto.nombre = Console.ReadLine();
            Console.WriteLine("Introduzca el apellido");
            nuevoContacto.apellido = Console.ReadLine();
            Console.WriteLine("Introduzca el número para su nuevo contacto");
            nuevoContacto.numero = Convert.ToInt32(Console.ReadLine());

            return nuevoContacto;
        }
        static void VerContacto(contacto contactoAMostrar)
        {
            if (contactoAMostrar.nombre == "Vacio")
            {
                Console.WriteLine("No hay ningún contacto");
            }
            else
            {
                Console.WriteLine(contactoAMostrar.nombre);
                Console.WriteLine(contactoAMostrar.apellido);
                Console.WriteLine(contactoAMostrar.numero);
            }

        }
        static void BorrarContacto(ref contacto contactoABorrar)
        {
            contactoABorrar.nombre = "Vacio";
            contactoABorrar.apellido = "Vacio";
            contactoABorrar.numero = 0;
        }
        static void MenuAgenda()
        {
            Console.WriteLine("Elige una opción:");
            Console.WriteLine("Presiona 1 para almacenar contacto");
            Console.WriteLine("Presiona 2 para ver contacto");
            Console.WriteLine("Presiona 3 para borrar contacto");
            Console.WriteLine("Presiona 4 para salir");
        }
    }
}
