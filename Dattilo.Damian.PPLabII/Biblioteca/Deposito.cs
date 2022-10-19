using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class Deposito
    {
        /// <summary>
        /// Lista de Producto y capacidad maxima del deposito
        /// </summary>
        private static List<Producto> productos;
        private static int capacidadMaxima;
        private static string nombreComercio;

        /// <summary>
        /// Propiedades
        /// </summary>
        public static List<Producto> Productos
        {
            get { return productos; }

        }

        public static int CapacidadMaxima
        {
            get { return capacidadMaxima; }
            set { capacidadMaxima = value; }
        }

        public static string NombreComercio
        {
            get { return nombreComercio; }
        }


        

        /// <summary>
        /// Constructor publico que inicializa la capacidad maxima e invoca al constructor privado
        /// </summary>
        /// <param name="capacidadMaxima"></param>
        static Deposito()
        {
            capacidadMaxima = 50;
            productos = new List<Producto>();
            nombreComercio = "Electronica Ultra";
        }

        /// <summary>
        /// Sobrecarga del operador + que agrega un producto al deposito o si el producto ya existe, aumenta su stock mediante el metodo ModificarStock
        /// </summary>
        /// <param name="d"></param> deposito
        /// <param name="p"></param> producto
        /// <returns></returns>
        public static bool AgregarProducto(Producto p)
        {
            Producto aux;

            if (p is not null)
            {
                aux = Deposito.BuscarProducto(p);
                if (aux is null)
                {
                    Deposito.Productos.Add(p);

                }
                else
                {
                    aux.Stock++;
                }
                return true;

            }
            return false;
        }

        /// <summary>
        /// Sobrecarga del operador - que quita stock del deposito o, si el stock llega a cero, lo quita mediante el metodo ModificarStock
        /// </summary>
        /// <param name="d"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        //public static Deposito operator -(Deposito d, Producto p)
        public static bool RemoverProducto(Producto p)
        {
            Producto aux = Deposito.BuscarProducto(p);
            if (p is not null && aux is not null)
            {
                if (aux.Stock > 0)
                {
                    aux.Stock--;
                    return true;
                }
            }
            return false;
        }

        public static Producto BuscarProducto(Producto p)
        {
            if (p is not null)
            {
                foreach (Producto item in Deposito.Productos)
                {
                    if (p == item)
                    {
                        return p;
                    }
                }
            }
            return null;
        }


    }
}
