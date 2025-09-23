using System;
// Miguel Rodríguez Gallego
namespace Clase_Videojuego
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaro variables para los datos propuestos en el ejercicio
            string titulo = "";
            string compañia = "";
            string genero = "";
            int pegi = 0;
            double precioCompra = 0.0;
            double pvp = 0.0;
            int stock = 0;

            // Creo una nueva dirección de memoria para la clase videojuego asignándole a la vez la variable vj (Recordar q el new crea una nueva dirección de memoria para la info)
            Videojuego vj = new Videojuego();
            Videojuego vj2;

            // Uso la memoria "vj" creada lineas atrás para mediante un método de la clase videojuego guardar los datos. 
            vj.Guarda("Zelda", "Nintendo", "RPG", 7, 19.99, 29.99, 500);
            // Lo mismo pero lo leo mediante el método lee creado en la clase videojuego
            vj.Lee(ref titulo, ref compañia, ref genero, ref pegi, ref precioCompra, ref pvp, ref stock);
            // Muestro por pantalla
            Console.WriteLine("Título = " + titulo);
            Console.WriteLine("compañia = " + compañia);
            Console.WriteLine("genero = " + genero);
            Console.WriteLine("pegi = " + pegi);
            Console.WriteLine("precioCompra = " + precioCompra);
            Console.WriteLine("pvp = " + pvp);
            Console.WriteLine("stock = " + stock);

            // "Console.ReadLine()" Para que pare la consola y poder leer los datos
            Console.ReadLine();

            // Ej asignación de objetos en la clase videojuego.
            // Paso los datos de la variable "vj" a "vj2" igualándolas
            vj2 = vj;
            // Leo los datos y los muestro por pantalla
            vj2.Lee(ref titulo, ref compañia, ref genero, ref pegi, ref precioCompra, ref pvp, ref stock);
            // Muestro por pantalla
            Console.WriteLine("vj2");
            Console.WriteLine("Título = " + titulo);
            Console.WriteLine("compañia = " + compañia);
            Console.WriteLine("genero = " + genero);
            Console.WriteLine("pegi = " + pegi);
            Console.WriteLine("precioCompra = " + precioCompra);
            Console.WriteLine("pvp = " + pvp);
            Console.WriteLine("stock = " + stock);

            Console.ReadLine();
            
            // Ej constructor copia
            // Creo una nueva variable para guardar datos llamada "vj3" y guardo en esta los datos de "vj2" igualándolos a la vez que creo un nuevo espacio de memoria para "vj3"
            Videojuego vj3 = new Videojuego(vj2);

            vj3.Lee(ref titulo, ref compañia, ref genero, ref pegi, ref precioCompra, ref pvp, ref stock);

            Console.WriteLine("vj3");
            Console.WriteLine("Título = " + titulo);
            Console.WriteLine("compañia = " + compañia);
            Console.WriteLine("genero = " + genero);
            Console.WriteLine("pegi = " + pegi);
            Console.WriteLine("precioCompra = " + precioCompra);
            Console.WriteLine("pvp = " + pvp);
            Console.WriteLine("stock = " + stock);

            Console.ReadLine();

            // Modifico el PVP de vj mediante el método "ModificaPVP" creado en la clase videojuegos
            vj.ModificaPVP(24.99);

            vj.Lee(ref titulo, ref compañia, ref genero, ref pegi, ref precioCompra, ref pvp, ref stock);
            // Muestro por pantalla el dato cambiado junto al resto
            Console.WriteLine("Título = " + titulo);
            Console.WriteLine("compañia = " + compañia);
            Console.WriteLine("genero = " + genero);
            Console.WriteLine("pegi = " + pegi);
            Console.WriteLine("precioCompra = " + precioCompra);
            Console.WriteLine("pvp = " + pvp);
            Console.WriteLine("stock = " + stock);

            Console.ReadLine();

            // Modifico el precio de venta de vj mediante el método "venta" creado en la clase videojuegos
            vj.Venta(200);

            vj.Lee(ref titulo, ref compañia, ref genero, ref pegi, ref precioCompra, ref pvp, ref stock);
            // Muestro por pantalla el dato cambiado junto al resto
            Console.WriteLine("Título = " + titulo);
            Console.WriteLine("compañia = " + compañia);
            Console.WriteLine("genero = " + genero);
            Console.WriteLine("pegi = " + pegi);
            Console.WriteLine("precioCompra = " + precioCompra);
            Console.WriteLine("pvp = " + pvp);
            Console.WriteLine("stock = " + stock);

            Console.ReadLine();

            // Modifico el precio de entrada de vj mediante el método "Entrada" creado en la clase videojuegos
            vj.Entrada(333);

            vj.Lee(ref titulo, ref compañia, ref genero, ref pegi, ref precioCompra, ref pvp, ref stock);
            // Muestro por pantalla el dato cambiado junto al resto
            Console.WriteLine("Título = " + titulo);
            Console.WriteLine("compañia = " + compañia);
            Console.WriteLine("genero = " + genero);
            Console.WriteLine("pegi = " + pegi);
            Console.WriteLine("precioCompra = " + precioCompra);
            Console.WriteLine("pvp = " + pvp);
            Console.WriteLine("stock = " + stock);

            Console.ReadLine();


            // Ejercicio de prueba del método SonLoMismo
            // Comparo "vj" y "vj2" mediante el método de la clase videojuego "SonLoMismo" para comprobar si tienen los mismos datos y plasmarlo por pantalla en el programa mediante este bucle if
            Console.WriteLine(vj.SonLoMismo(vj2));
            if (vj.Equals(vj2))
            {
                Console.WriteLine("vj = vj2");
            }
            else
            {
                Console.WriteLine("Son distintos");
            }

            Console.ReadLine();

            // Visualizamos las variables estáticas de la clase videojuego
            Console.WriteLine("Total de objetos = " + Videojuego.contador);
            Console.WriteLine("Precio total = " + Videojuego.pvpTotal);
            Console.WriteLine("Precio medio = " + vj.CalculaMedia());

            Console.ReadLine();


            // Sobrecarga de operadores para la suma de videojuegos
            Videojuego vj4;
            vj4 = vj2 + vj3;

            vj4.Lee(ref titulo, ref compañia, ref genero, ref pegi, ref precioCompra, ref pvp, ref stock);

            Console.WriteLine("Título = " + titulo);
            Console.WriteLine("compañia = " + compañia);
            Console.WriteLine("genero = " + genero);
            Console.WriteLine("pegi = " + pegi);
            Console.WriteLine("precioCompra = " + precioCompra);
            Console.WriteLine("pvp = " + pvp);
            Console.WriteLine("stock = " + stock);

            Console.ReadLine();
        }
    }
}
