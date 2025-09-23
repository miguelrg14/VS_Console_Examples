using System;
using System.IO;

namespace Agenda_Miguel_RodríguezGallego
{
    class Program
    {
        // Establezco un menú para cada valor
        enum Menu
        {
            Añadir_contacto,    // 0
            Borrar_contacto,    // 1
            Ver_contactos,      // 2
            Exportar_agenda,    // 3
            Importar_agenda,    // 4
            Salir               // 5
        }
        // Establezco una estructura para guardar los datos
        struct Contacto
        {
            public string nombre;
            public string apellidos;
            public int edad;
            public int telefono;
        }
        static void Main(string[] args)
        {

            int valor = 0;
            Menu opcion;

            // Creo un array poniendo dos corchetes delante de la estructura "Contacto" para poder almacenar más de 1 dato creando la variable "contactos e igualandola a "new Contacto[100]", lo cual establece el límite de contactos en 100
            Contacto[] contactos = new Contacto[100];

            // Creo una variable contacto para meter los valores de un contacto dentro de la estructura "Contacto"
            Contacto contacto;

            // Creo una variable para el índice del array
            int i = 0;

            // Establezco el bucle para no salir del margén de números del menú
            while (valor != 5)
            {
                // Escribo el menú por pantalla al usuario
                Console.WriteLine("Menú Agenda - Seleccione opción");
                Console.WriteLine("0 - Añadir contacto");
                Console.WriteLine("1 - Borrar contacto");
                Console.WriteLine("2 - Ver contactos");
                Console.WriteLine("3 - Exportar agenda");
                Console.WriteLine("4 - Importar agenda");
                Console.WriteLine("5 - Salir");

                // Pido un Valor al usuario
                valor = Convert.ToInt32(Console.ReadLine());

                // Introduzco ese valor en la estructura "Menu" mediante la variable "opcion"
                opcion = (Menu)valor;

                // Hago un switch para los diferentes casos a los que pueda entrar en el menú y establecer que ocurrirá en cada uno de ellos
                switch (opcion)
                {
                    // Opción para añadir contacto
                    case Menu.Añadir_contacto:

                        // Pido los datos
                        Console.WriteLine("Teclee nombre: ");
                        contacto.nombre = Console.ReadLine();
                        Console.WriteLine("Teclee apellidos: ");
                        contacto.apellidos = Console.ReadLine();
                        Console.WriteLine("Teclee edad: ");
                        contacto.edad = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Teclee teléfono: ");
                        contacto.telefono = Convert.ToInt32(Console.ReadLine());

                        // Añado el contacto al array de contactos y le sumo 1 al índice
                        contactos[i] = contacto;
                        i++;
                        // Finalizo el case
                        break;

                    // Opción para borrar contacto
                    case Menu.Borrar_contacto:
                        // Establezco la variable j para contabilizar y sustituir el contacto que elimine por el siguiente, quitando así el posible hueco vacio que quede en medio
                        // Establezco la variable "k" para poder pedir al usuario que contacto quiere borrar, y además, para igualarlo a "j"
                        int j = 0;
                        int k;

                        // Dentro del array contactos voy recorriendo cada uno de los elementos
                        foreach (Contacto c in contactos)
                        {
                            // Con un "if", establzco que si la variable del contacto "c.nombre" no existe no se muestre el abanico de contactos a poder borrar
                            if (c.nombre != null)
                            {
                                // Muestro por pantalla los datos del contacto
                                Console.WriteLine("# " + j);
                                Console.WriteLine("nombre: " + c.nombre);
                                Console.WriteLine("apellidos: " + c.apellidos);
                                Console.WriteLine("edad: " + c.edad);
                                Console.WriteLine("telefono: " + c.telefono);
                                Console.WriteLine(" ");
                                // Sumo una j para que en el siguiente for poder deshacer el espacio vacio entre contactos
                                j++;                                
                            }
                        }
                        // Pido y recojo el valor del contacto a borrar
                        Console.WriteLine("Teclee el nº del contacto que desea borrar");
                        k = Convert.ToInt32(Console.ReadLine());

                        // Muevo los elementos debajo del contacto que quiero borrar hacia arriba para no dejar el espacio vacío
                        for (j = k; j < 99; j++)
                        {
                            contactos[j] = contactos[j + 1];
                        }
                        break;

                    // Opción para ver contactos
                    case Menu.Ver_contactos:

                        // Se recorre el array de contactos asignando cada contacto a la variable "c"
                        foreach (Contacto c in contactos)
                        {
                            // Solo mostrará datos (hasta un máximo de 100) cuando "c.nombre" sea distinto de nulo
                            if (c.nombre!=null)
                            {
                                // Muestro los datos
                                Console.WriteLine("nombre: " + c.nombre);
                                Console.WriteLine("apellidos: " + c.apellidos);
                                Console.WriteLine("edad: " + c.edad);
                                Console.WriteLine("telefono: " + c.telefono);
                                Console.WriteLine(" ");
                            }
                        }
                        break;

                    // Opción para exportar agenda
                    case Menu.Exportar_agenda:

                        // Declaro variables
                        j = 0;

                        // Paso la ruta del fichero al lector de texto "StreamReader"
                        StreamWriter sw = File.CreateText("agenda.txt");

                        // Se recorre el array de contactos asignando cada contacto a la variable "c"
                        foreach (Contacto c in contactos)
                        {
                            // Solo mostrará datos (hasta un máximo de 100) cuando "c.nombre" sea distinto de nulo
                            if (c.nombre != null)
                            {
                                sw.WriteLine(c.nombre);
                                sw.WriteLine(c.apellidos);
                                sw.WriteLine(c.edad);
                                sw.WriteLine(c.telefono);
                            }
                        }

                        //Cierro el fichero
                        sw.Close();

                        break;


                    case Menu.Importar_agenda:

                        // Inicializo el array en este case
                        contactos = new Contacto[100];
                        // Declaro variables
                        i = 0;
                        string linea;

                        //Paso la ruta del fichero al lector de texto "StreamReader"
                        StreamReader sr = File.OpenText("agenda.txt");
                        //Leo la primera linea de fichero para comprobar que hay texto
                        linea = sr.ReadLine();
                        //Continuo leyendo hasta que terminen los datos del fichero
                        while (linea != null)
                        {
                            Contacto c;

                            // Traslado el valor que recojo con la variable "linea" a "c" en "nombre", "apellidos", "edad" y "telefono"
                            c.nombre = linea;
                            linea = sr.ReadLine();
                            c.apellidos = linea;
                            linea = sr.ReadLine();
                            c.edad = Convert.ToInt32(linea);
                            linea = sr.ReadLine();
                            c.telefono = Convert.ToInt32(linea);
                            linea = sr.ReadLine();

                            // Una vez leído un contacto lo añado al array
                            contactos[i] = c;
                            i++;
                        }
                        //Cierro el fichero
                        sr.Close();

                        break;
                }


            }


        }
    }
}
