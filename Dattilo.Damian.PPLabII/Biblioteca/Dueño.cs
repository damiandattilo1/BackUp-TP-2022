using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Dueño :Usuario
    {
        private static string usuDueño;
        private static string passDueño;

        public Dueño() :base("dueño@gmail.com", "123utn456") { }


    }
}
