// JuegoTorreDeBatalla
// Miguel Rodríguez Gallego
// 15/05/2021
// Estadísticas de los enemigos

using System;
using System.Collections.Generic;
using System.Text;

namespace TorreDeBatalla
{
    // Declaro las variables
    class Enemigo
    {
        private string nombre = "";
        private int vida = 0;
        private int fuerza = 0;
        private int defensa = 0;
        private int poder_magico = 0;
        private int barrera_magica = 0;
        private int energia = 0;

        // Generador de tamaño de las estadísticas de cada enemigo según el nº total de enemigos
        public Enemigo()
        {
            this.Vida = Utilidades.NumAleatorio(15, 20);
            this.Fuerza = Utilidades.NumAleatorio(4, 6);
            this.Defensa = Utilidades.NumAleatorio(1, 3);
            this.Poder_magico = Utilidades.NumAleatorio(7, 9);
            this.Barrera_magica = Utilidades.NumAleatorio(4, 6);
            this.Energia = Utilidades.NumAleatorio(15, 20);
            this.Nombre = this.generarNombre();
        }

        // Métodos para cambiar los valores de las variables privadas (getters y setters)
        public string Nombre { get => nombre; set => nombre = value; }
        public int Vida { get => vida; set => vida = value; }
        public int Fuerza { get => fuerza; set => fuerza = value; }
        public int Defensa { get => defensa; set => defensa = value; }
        public int Poder_magico { get => poder_magico; set => poder_magico = value; }
        public int Barrera_magica { get => barrera_magica; set => barrera_magica = value; }
        public int Energia { get => energia; set => energia = value; }

        // Generador aleatorio de nombres para los enemigos
        public string generarNombre()
        {           
            int numPersonaje = Utilidades.NumAleatorio(0, 9);
            int numAdjetivo = Utilidades.NumAleatorio(0, 9);

            string[] personajes = new string[] { "Brujo", "Guerrero", "Arquero", "Caballero", "Gladiador", "Principe", "Troll", "Gigante", "Enano", "Mendigo" };
            string[] adjetivos = new string[] { "loco", "peludo", "piojoso", "fuerte", "rápido", "veloz", "sucio", "cojo", "tuerto", "despiadado" };

            return personajes[numPersonaje] + " " + adjetivos[numAdjetivo];            
        }       
    }
}
