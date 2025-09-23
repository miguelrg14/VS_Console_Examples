using System;

namespace Ejercicios_clases_y_parejas
{
    class Pareja
    {
        // Propiedades
        private int numPar1;
        private int numPar2;

        // Métodos
        public void Guarda(int nuevoNum1, int nuevoNum2)
        {
            numPar1 = nuevoNum1;
            numPar2 = nuevoNum2;
        }

        public void Lee(out int valor1, out int valor2)
        {
            valor1 = numPar1;
            valor2 = numPar2;
        }
    }
}
