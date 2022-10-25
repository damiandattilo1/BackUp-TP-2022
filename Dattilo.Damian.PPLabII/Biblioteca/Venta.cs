using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Venta
    {
        private Producto producto;
        private DateTime fecha;

        public Producto Producto
        {
            get { return producto; }
            set { producto = value; }
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
