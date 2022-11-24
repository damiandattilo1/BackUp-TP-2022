using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// exepcion que se dispara cuando el objeto a agregar supera la capacidad de la cartuchera
    /// </summary>
    public class CartucheraLlenaException : Exception
    {
        public CartucheraLlenaException() :base()
        {

        }
        public CartucheraLlenaException(string message) :base (message)
        {

        }
        public CartucheraLlenaException(string message, Exception innerException) :base(message, innerException)
        {
            
        }
    }
}
