// JuegoTorreDeBatalla
// Miguel Rodríguez Gallego
// 15/05/2021
// Estadísticas del personaje del jugador

using System;
using System.Collections.Generic;
using System.Text;

namespace TorreDeBatalla
{
    class Jugador
    {
        // Declaro las variables
        private int vida = 0;
        private int fuerza = 0;
        private int defensa = 0;
        private int poder_magico = 0;
        private int barrera_magica = 0;
        private int energia = 0;

        // Constructor
        public Jugador()
        {            
        }

        // Generador de tamaño de las estadísticas del jugador según el nº total de enemigos
        public Jugador(int numEnemigos)
        {
            this.Vida = Utilidades.NumAleatorio(15*numEnemigos, 20*numEnemigos);
            this.Fuerza = Utilidades.NumAleatorio(4, 6);
            this.Defensa = Utilidades.NumAleatorio(1, 3);
            this.Poder_magico = Utilidades.NumAleatorio(7, 9);
            this.Barrera_magica = Utilidades.NumAleatorio(4, 6);
            this.Energia = Utilidades.NumAleatorio(15*numEnemigos, 20*numEnemigos);
        }

        // Métodos para cambiar los valores de las variables privadas (getters y setters)
        public int Vida { get => vida; set => vida = value; }
        public int Fuerza { get => fuerza; set => fuerza = value; }
        public int Defensa { get => defensa; set => defensa = value; }
        public int Poder_magico { get => poder_magico; set => poder_magico = value; }
        public int Barrera_magica { get => barrera_magica; set => barrera_magica = value; }
        public int Energia { get => energia; set => energia = value; }       
    }
}
