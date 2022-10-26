using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Venta
    {

        private Producto producto;
        private DateTime fecha;

        [Browsable(false)] // No se muestra la propiedad
        public Producto Producto
        {
            get { return producto; }
            set { producto = value; }
        }

        public int Id
        {
            get { return producto.Id; }
        }

        public string Marca
        {
            get { return producto.Marca.ToString(); }
        }

        public string Modelo
        {
            get { return producto.Modelo.ToString(); }
        }
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        
        public Venta(Producto producto, DateTime fecha)
        {
            this.producto = producto;
            this.fecha = fecha;
        }
    }
}
