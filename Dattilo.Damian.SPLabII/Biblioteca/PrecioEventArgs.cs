using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class PrecioEventArgs : EventArgs
    {
        private int precioCartuchera;

        public int PrecioCartuchera
        {
            get { return precioCartuchera; }
            set { precioCartuchera = value; }
        }

        public PrecioEventArgs(int precioCartuchera)
        {
            this.precioCartuchera = precioCartuchera;
        }
    }
}
