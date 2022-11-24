using System;

namespace Biblioteca
{
    public abstract class Util
    {

        private int precio;
        private string marca;

        public int Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public Util() { }

        public Util(string marca, int precio) :base()
        {
            this.precio = precio;
            this.marca = marca;
        }

        
    }
}
