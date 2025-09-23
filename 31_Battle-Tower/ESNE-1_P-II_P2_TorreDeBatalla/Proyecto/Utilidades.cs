// JuegoTorreDeBatalla
// Miguel Rodríguez Gallego
// 15/05/2021
// Utilidad para hacer diferentes acciones dentro del programa

using System;
using System.Collections.Generic;
using System.Text;

namespace TorreDeBatalla
{
    class Utilidades
    {
        // Utilidad para generar números aleatorios en un rango de valores
        public static int NumAleatorio(int inicio, int fin)
        {
            Random rnd = new Random();
            int randNum = rnd.Next(inicio, fin);
            return randNum;
        }
    }
}
