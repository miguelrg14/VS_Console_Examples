using System;

namespace Ejercicios_clases_y_parejas
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            Pareja par;
            par = new Pareja();

            Console.WriteLine(par);

            par.Guarda(12, 32);
            par.Lee(out x, out y);
        }
    }
}
