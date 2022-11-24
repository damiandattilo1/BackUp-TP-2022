using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Biblioteca
{
    /// <summary>
    /// Clase generica para agregar utiles
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Cartuchera<T> where T: Util
    {
        /// <summary>
        /// delegado para el evento cambio precio
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public delegate void NotificadorPrecio(object a, PrecioEventArgs b);
        
        /// <summary>
        /// Evento cambio precio que notifica cuando el valor total de la cartuchera llega a 500
        /// </summary>
        public event NotificadorPrecio CambioPrecio;
        
        /// <summary>
        /// atributos capacidad y lista generica para agregar utiles
        /// </summary>
        private short capacidad;
        private List<T> lista;

        /// <summary>
        /// Propiedades de los atributos
        /// </summary>
        public short Capacidad
        {
            get { return this.capacidad; }
            set { this.capacidad = value; }
        }

        public List<T> Lista
        {
            get { return this.lista; }
            set { this.lista = value; }
        }

        /// <summary>
        /// propiedad precio total que al superar los 500 dispara el evento
        /// </summary>
        public int PrecioTotal
        {
            get
            {
                int total = 0;
                foreach(T item in this.lista)
                {
                    total += item.Precio;
                }
                return total;
            }
        }

        private Cartuchera()
        {
            this.lista = new List<T>();
            this.CambioPrecio += Imprimir;
        }

        public Cartuchera(short capacidad) :this()
        {
            this.capacidad = capacidad;
        }

        /// <summary>
        /// sobrecarga del operador + que incluye el evento 
        /// </summary>
        /// <param name="cartuchera"></param>
        /// <param name="util"></param>
        /// <returns></returns>
        /// <exception cref="CartucheraLlenaException"></exception>
        /// <exception cref="Exception"></exception>
        public static Cartuchera<T> operator +(Cartuchera<T> cartuchera, T util)
        {

            if(cartuchera is not null && util is not null && cartuchera.Capacidad > cartuchera.Lista.Count)
            {
                cartuchera.Lista.Add(util);
                if(cartuchera.PrecioTotal > 500)
                {
                    PrecioEventArgs eventoPrecio = new PrecioEventArgs(cartuchera.PrecioTotal);
                    if(cartuchera.CambioPrecio is not null)
                    {
                        cartuchera.CambioPrecio.Invoke(cartuchera, eventoPrecio);
                    }
                }
                
            }
            else if(cartuchera.Capacidad == cartuchera.Lista.Count)
            {
                throw new CartucheraLlenaException("ERROR: No hay mas lugar en la cartuchera");
            }
            else if (util is null)
            {
                throw new Exception();
            }
            return cartuchera;
        }

        /// <summary>
        /// Metodo asociado al evento cambio precio que imprime el contenido de la cartuchera en un archivo de texto
        /// </summary>
        /// <param name="cartuchera"></param>
        /// <param name="evento"></param>
        private void Imprimir(object cartuchera, PrecioEventArgs evento)
        {
            FileStream stream = new FileStream((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Tickets.log"), FileMode.Append);
            using (StreamWriter sw = new StreamWriter(stream))
            {
                sw.WriteLine($"------------------{DateTime.Now.ToString()}----------------------");
                sw.WriteLine(cartuchera.ToString());
            }
        }

        /// <summary>
        /// Metodo que lee desde el archivo de texto
        /// </summary>
        /// <returns></returns>
        public string Leer()
        {
            string lectura;
            using (FileStream stream = new FileStream((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Tickets.log"), FileMode.Open))
            using (StreamReader sw = new StreamReader(stream))
            {
                lectura = sw.ReadToEnd();
            }
            return lectura;
        }

        /// <summary>
        /// sobrecarga del to string para imprimir la cartuchera
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Capacidad de la cartuchera: {this.Capacidad}");
            sb.AppendLine("Contenido de la cartuchera:");

            foreach (T item in this.lista)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }
    }
}
