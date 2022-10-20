using System;
using System.Text;
using System.Collections.Generic;

namespace Biblioteca
{
    /// <summary>
    /// Clase abstracta de la cual se van a heredar los distintos tipos de productos
    /// </summary>
    public abstract class Producto
    {
        /// <summary>
        /// Atributos de la clase
        /// </summary>
        private int id;
        private eMarca marca;
        private double precio;
        private string modelo;
        private int stock;
        private eTag tag;
        private int ventas; 


        /// <summary>
        /// Propiedades para cada atributo
        /// </summary>
       
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Ventas
        {
            get { return ventas; }
            set { ventas = value; }
        }

        public eMarca Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        public eTag Tag
        {
            get { return tag; }
            set { tag = value; }
        }

        

        /// <summary>
        /// Constructor privado que inicializa el stock
        /// </summary>
        private Producto()
        {
            this.stock = 1;
            this.ventas = 0;
        }
        /// <summary>
        /// Constructor publico 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="marca"></param>
        /// <param name="modelo"></param>
        /// <param name="precio"></param>
        public Producto(eMarca marca, string modelo, eTag tag, double precio, int ventas) :this()
        {
            this.marca = marca;
            this.modelo = modelo;
            this.tag = tag;
            this.precio = precio;
            this.ventas = ventas;
        }
       
        /// <summary>
        /// Polimorfismo del ToString para mostrar todos los datos comunes a todos los productos
        /// </summary>
        /// <returns></returns> Los datos en formato string
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Id: {this.Id} ");
            sb.AppendLine($"Marca: {this.Marca} ");
            sb.AppendLine($"Modelo: {this.Modelo} ");

            return sb.ToString();
        }

        /// <summary>
        /// Agrega datos de precio, stock y tags al ToString de cada herencia
        /// </summary>
        /// <returns></returns>

        public string DatosExtra()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Precio: {this.Precio} ");
            sb.AppendLine($"Stock: {this.Stock} ");
            sb.AppendLine($"Tags: {this.Tag}");

            return sb.ToString();
        }

        /// <summary>
        /// Sobrecarga del operador == Dos productos son iguales si tienen el mismo id
        /// </summary>
        /// <param name="p1"></param> Producto 1
        /// <param name="p2"></param> Producto 2
        /// <returns></returns>
        public static bool operator ==(Producto p1, Producto p2)
        {
            if (p1 is not null && p2 is not null)
            {
                return p1.Id == p2.Id;
            }
            return false;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        



    }
}
