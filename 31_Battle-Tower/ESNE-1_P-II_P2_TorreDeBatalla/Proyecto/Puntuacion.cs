// JuegoTorreDeBatalla
// Miguel Rodríguez Gallego
// 15/05/2021
// Controlo la recogida de puntuación

using System;
using System.Collections.Generic;
using System.Text;

namespace TorreDeBatalla
{
    class Puntuacion
    {
        // Declaro la variable de la fecha y de los puntos
        private DateTime fecha;      
        private int puntos;

        // Constructor
        public Puntuacion()
        {
            this.fecha = DateTime.Now;
        }

        // Métodos para cambiar los valores de las variables privadas (getters y setters)
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int Puntos { get => puntos; set => puntos = value; }
    }
}
