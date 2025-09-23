namespace Clase_Videojuego
{
    class Videojuego
    {
        // Declaro los atributos de la clase 
        private string titulo;
        private string compañia;
        private string genero;
        private int pegi;
        private double precioCompra;
        private double pvp;
        private int stock;

        public static int contador;
        public static double pvpTotal;

        // Métodos

        // Este es el constructor por defecto
        // Es un constructor pq se llama = q la clase
        // Es el constructor por defecto pq no lleva parámetros 
        public Videojuego()
        {
            contador++;
        }
        // Creo videojuego para relacionar los datos con los parámetros
        public Videojuego(string titulo, string compañia, string genero, int pegi, double precioCompra, double pvp, int stock)
        {
            // Con los this, hago que los campos se refieran a un dato de un objeto en concreto.
            this.titulo = titulo;
            this.compañia = compañia;
            this.genero = genero;
            this.pegi = pegi;
            this.precioCompra = precioCompra;
            this.pvp = pvp;
            this.stock = stock;

            contador++;
            pvpTotal = pvpTotal + pvp;
        }
        // Constructor copia. Recibe un objeto d la misma clase y copia sus valores
        public Videojuego(Videojuego vj)
        {
            this.titulo = vj.titulo;
            this.compañia = vj.compañia;
            this.genero = vj.genero;
            this.pegi = vj.pegi;
            this.precioCompra = vj.precioCompra;
            this.pvp = vj.pvp;
            this.stock = vj.stock;

            contador++;
            pvpTotal = pvpTotal + vj.pvp;
        }
        // Método para guardar los datos
        public void Guarda(string titulo, string compañia, string genero, int pegi, double precioCompra, double pvp, int stock)
        {
            this.titulo = titulo;
            this.compañia = compañia;
            this.genero = genero;
            this.pegi = pegi;
            this.precioCompra = precioCompra;
            this.pvp = pvp;
            this.stock = stock;

            pvpTotal = pvpTotal + pvp;
        }
        // Método para leer los datos
        public void Lee(ref string titulo, ref string compañia, ref string genero, ref int pegi, ref double precioCompra, ref double pvp, ref int stock)
        {
            titulo = this.titulo;
            compañia = this.compañia;
            genero = this.genero;
            pegi = this.pegi;
            precioCompra = this.precioCompra;
            pvp = this.pvp;
            stock = this.stock;
        }
        // Método para modificar el pvp
        public void ModificaPVP(double pvp)
        {
            pvpTotal = pvpTotal - this.pvp + pvp;
            this.pvp = pvp;
        }

        // Declaro un método para las ventas y recibo un argumento con las unidades
        public void Venta(int unidades)
        {
            this.stock = this.stock - unidades;
        }
        // Declaro un método para las entradas de stock y recibo un argumento con las unidades
        public void Entrada(int unidades)
        {
            this.stock = this.stock + unidades;
        }

        // Este método comprueba q el objeto actual es igual al recibido como parámetro y devuelve si es o no con un true o false.
        public bool SonLoMismo(Videojuego vj)
        {
            if(this.Equals(vj))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // Método para calcular la media del precio
        public double CalculaMedia()
        {
            if (contador > 0)
            {
                return pvpTotal / contador;
            }
            else
            {
                return 0;
            }
        }

        // Sobrecarga de operadores para la suma de videojuegos
        static public Videojuego operator +(Videojuego vj1, Videojuego vj2)
        {
            // Creo una nueva ranura de memoria para vj
            Videojuego vj = new Videojuego();

            // Muestro por pantalla el pack de 2 juegos juntos y todos sus datos
            vj.titulo = "Oferta: " + vj1.titulo + " + " + vj2.titulo;
            vj.genero = vj1.genero + " / " + vj2.genero;
            vj.stock = 1;
            vj.pvp = (vj1.pvp + vj2.pvp) * 0.6;
            vj1.stock -= 1;
            vj2.stock -= 1;
            return vj;
        }
    }
}
