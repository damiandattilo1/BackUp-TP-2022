using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Sacapunta : Util 
    {
        private bool esElectrico;
        private int capacidad;
        
        public bool EsElectrico
        {
            get { return esElectrico; }
            set { esElectrico = value; }
        }

        public int Capacidad
        {
            get { return capacidad; }
            set { capacidad = value; }
        }
        public Sacapunta(string marca, int precio, bool esElectrico, int capacidad) :base(marca, precio)
        {
            this.esElectrico = esElectrico;
            this.capacidad = capacidad;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Marca: {base.Marca}");
            sb.AppendLine($"Es electrico: {this.EsElectrico.ToString()}");
            sb.AppendLine($"Capacidad: {this.Capacidad.ToString()}");
            sb.AppendLine($"Precio: {base.Precio.ToString()}");

            return sb.ToString();

        }
    }
}
