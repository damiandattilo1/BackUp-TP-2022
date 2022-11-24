using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Goma :Util
    {
        private bool paraLapiz;
        private int largo;

        public bool ParaLapiz
        {
            get { return paraLapiz; }
            set { paraLapiz = value; }
        }

        public int Largo
        {
            get { return largo; }
            set { largo = value; }
        }

        public Goma(string marca, int precio, bool paraLapiz, int largo):base(marca, precio)
        {
            this.paraLapiz = paraLapiz;
            this.largo = largo;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Marca: {base.Marca}");
            sb.AppendLine($"Es para lapiz: {this.ParaLapiz.ToString()}");
            sb.AppendLine($"Largo: {this.Largo.ToString()}");
            sb.AppendLine($"Precio: {base.Precio.ToString()}");

            return sb.ToString();

        }
    }

}
