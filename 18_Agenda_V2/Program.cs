using System;

namespace MiAgenda2
{
    class Program
    {
        struct Contacto
        {
            public string nombre;
            public string apellidos;
            public int edad;
            public int telefono;
        }
        static void Main(string[] args)
        {
            Contacto contacto;

            contacto.nombre = "Vacío";
            contacto.apellidos = "Vacío";
            contacto.edad = 0;
            contacto.telefono = 0;

            int opcion;

            do
            {
                //Console.Clear();
                // Menú de selección por consola
                Console.WriteLine(" ");
                Console.WriteLine("Elige que hacer: ");
                Console.WriteLine(" ");
                Console.WriteLine("1 - Almacenar contacto");
                Console.WriteLine("2 - Ver contacto");
                Console.WriteLine("3 - Borrar contacto");
                Console.WriteLine("4 - Salir");
                Console.WriteLine(" ");

                opcion = Convert.ToInt32(Console.ReadLine());


                switch (opcion)
                {
                    // Almacenar contacto
                    case 1:
                        {
                            AlmacenarContacto1(ref contacto);

                            /*
                            Console.Write("Nombre: ");                        
                            contacto.nombre = Console.ReadLine();
                            Console.WriteLine(" ");
                            Console.Write("Apellidos: ");
                            contacto.apellidos = Console.ReadLine();
                            Console.WriteLine(" ");
                            Console.Write("Edad: ");
                            contacto.edad = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(" ");
                            Console.Write("Teléfono: ");
                            contacto.telefono = Convert.ToInt32(Console.ReadLine());
                            */
                            break;
                        }

                    // Ver Contacto
                    case 2:
                        {
                            VerContacto(contacto);
                            break;
                        }

                    // Borrar contacto
                    case 3:
                        {
                            BorrarContacto(ref contacto);
                            break;
                        }

                    // Salir
                    case 4:
                        {

                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Valor equivocado... Vuelve a introducir otro!");
                            break;
                        }
                }
            } while (opcion < 4);
        }

        /*
        static Contacto AlmacenarContacto()
        {
            Contacto nuevoContacto;

            Console.WriteLine("Introduzca un nombre para el nuevo contacto");
            nuevoContacto.nombre = Console.ReadLine();
            Console.WriteLine("Introduzca el apellido");
            nuevoContacto.apellidos = Console.ReadLine();
            Console.WriteLine("Introduzca la edad");
            nuevoContacto.edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca el número para su nuevo contacto");
            nuevoContacto.telefono = Convert.ToInt32(Console.ReadLine());

            return nuevoContacto;
        }
        */


        static void AlmacenarContacto1(ref Contacto nuevoContacto)
        {

            Console.WriteLine("Introduzca un nombre para el nuevo contacto");
            nuevoContacto.nombre = Console.ReadLine();
            Console.WriteLine("Introduzca el apellido");
            nuevoContacto.apellidos = Console.ReadLine();
            Console.WriteLine("Introduzca la edad");
            nuevoContacto.edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca el número para su nuevo contacto");
            nuevoContacto.telefono = Convert.ToInt32(Console.ReadLine());

        }


        static void VerContacto(Contacto contactoAMostrar)
        {
            if (contactoAMostrar.nombre == "Vacio")
            {
                Console.WriteLine("No hay ningún contacto");
            }
            else
            {
                Console.WriteLine(contactoAMostrar.nombre);
                Console.WriteLine(contactoAMostrar.apellidos);
                Console.WriteLine(contactoAMostrar.edad);
                Console.WriteLine(contactoAMostrar.telefono);
            }
        }
        static void BorrarContacto(ref Contacto contactoABorrar)
        {
            contactoABorrar.nombre = "Vacio";
            contactoABorrar.apellidos = "Vacio";
            contactoABorrar.edad = 0;
            contactoABorrar.telefono = 0;
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
