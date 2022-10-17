using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Deposito
    {
        /// <summary>
        /// Lista de Producto y capacidad maxima del deposito
        /// </summary>
        private List<Producto> productos;
        private int capacidadMaxima;
        private static string nombreComercio;

        /// <summary>
        /// Propiedades
        /// </summary>
        public List<Producto> Productos
        {
            get { return productos; }

        }

        public int CapacidadMaxima
        {
            get { return capacidadMaxima; }
            set { capacidadMaxima = value; }
        }

        public string NombreComercio
        {
            get { return nombreComercio; }
        }

        /// <summary>
        /// Inicializa el nombre del comercio
        /// </summary>
        static Deposito()
        {
            nombreComercio = "Electronica Ultra";
        }

        /// <summary>
        /// Constructor privado que inicializa la lista de productos
        /// </summary>
       
        private Deposito()
        {
            this.productos = new List<Producto>();
        }

        /// <summary>
        /// Constructor publico que inicializa la capacidad maxima e invoca al constructor privado
        /// </summary>
        /// <param name="capacidadMaxima"></param>
        public Deposito(int capacidadMaxima) :this()
        {
            this.capacidadMaxima = capacidadMaxima;
        }

        /// <summary>
        /// Sobrecarga del operador + que agrega un producto al deposito o si el producto ya existe, aumenta su stock mediante el metodo ModificarStock
        /// </summary>
        /// <param name="d"></param> deposito
        /// <param name="p"></param> producto
        /// <returns></returns>
        public static Deposito operator +(Deposito d, Producto p)
        {
            bool existe;
            
            if(d is not null && p is not null)
            {
                existe = p.ModificarStock(d, true);
                if (!existe)
                {
                    d.productos.Add(p);
                }
                
            }
            return d;
        }

        /// <summary>
        /// Sobrecarga del operador - que quita stock del deposito o, si el stock llega a cero, lo quita mediante el metodo ModificarStock
        /// </summary>
        /// <param name="d"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        //public static Deposito operator -(Deposito d, Producto p)
        public static bool operator -(Deposito d, Producto p)
        {
            bool existe = p.ModificarStock(d, false);

            return existe;
        }

        /// <summary>
        /// Retorna si el producto recibido por parametro ya se encuentra en el deposito
        /// </summary>
        /// <param name="deposito"></param>
        /// <param name="producto"></param>
        /// <returns></returns>
        public static bool operator ==(Deposito deposito, Producto producto)
        {
            if(deposito is not null && producto is not null)
            {
                foreach(Producto item in deposito.Productos)
                {
                    if (item.Equals(producto))
                    {
                        return true;
                    }
                }
            }

            return false;
        }
        
        public static bool operator !=(Deposito deposito, Producto producto)
        {
            return !(deposito == producto);
        }

        
        /*Celular c1 = new Celular(1234, eMarca.Samsung, "sj474", eTag.Telefonia, 80000, 128, eSistemaCelular.Android, eResolucionCamara.Mp12, true);
        Televisor t2 = new Televisor(1444, eMarca.Philips, "ph8471", eTag.Audiovisual, 100000, 42, eSistemaTV.AndroidTV, eResolucion.UHD, true);
        PC p3 = new PC(1818, eMarca.HP, "HP142", eTag.Informatica, 120000, 500, 8, eSistemaPC.Windows, eDisco.HDD);

        deposito = deposito + c1;
            deposito = deposito + t2;
            deposito = deposito + p3;*/

    }
}
