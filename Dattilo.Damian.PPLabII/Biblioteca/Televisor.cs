using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Clase Televisor heredada de producto
    /// </summary>
    public class Televisor : Producto
    {
        /// <summary>
        /// Atributos
        /// </summary>
        private int pulgadas;
        private eSistemaTV sistemaOperativo;
        private eResolucion resolucion;
        private bool esSmart;

        /// <summary>
        /// Propiedades para cada atributo
        /// </summary>
        public int Pulgadas
        {
            get { return pulgadas; }
            set { pulgadas = value; }
        }

        public eSistemaTV SistemaOperativo
        {
            get { return sistemaOperativo; }
            set { sistemaOperativo = value; }
        }
        public eResolucion Resolucion
        {
            get { return resolucion; }
            set { resolucion = value; }
        }

        public bool EsSmart
        {
            get { return esSmart; }
            set { esSmart = value; }
        }


        /// <summary>
        /// Constructor que reutiliza el constructor de la clase base
        /// </summary>
        /// <param name="id"></param>
        /// <param name="marca"></param>
        /// <param name="modelo"></param>
        /// <param name="precio"></param>
        /// <param name="pulgadas"></param>
        /// <param name="sistemaOperativo"></param>
        /// <param name="resolucion"></param>
        public Televisor(eMarca marca, string modelo,eTag tag, double precio, int pulgadas, eSistemaTV sistemaOperativo, eResolucion resolucion, bool esSmart, int venta) : base(marca, modelo, tag, precio, venta)
        {
            this.pulgadas = pulgadas;
            this.sistemaOperativo = sistemaOperativo;
            this.resolucion = resolucion;
            this.esSmart = esSmart;
        }

        /// <summary>
        /// Polimorfismo de ToString que reutiliza el polimorfismo de la clase base y agrega datos propios del televisor
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.ToString());
            
            sb.AppendLine($"Pulgadas: {this.Pulgadas}");
            sb.AppendLine($"Sistema Operativo: {this.SistemaOperativo.ToString()}");
            sb.AppendLine($"Resolucion: {this.Resolucion.ToString()}");
            sb.Append("Es Smart: ");
            if(esSmart)
            {
                sb.AppendLine("Si");
            }
            else
            {
                sb.AppendLine("No");
            }

            sb.Append(base.DatosExtra());

            return sb.ToString();
        }

        /// <summary>
        /// Sobrecarga de operador == Dos televisores son iguales si sus productos y modelos son iguales
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <returns></returns>
        public static bool operator ==(Televisor t1, Televisor t2)
        {
            if(t1 is not null && t2 is not null)
            {
                return (Producto)t1 == (Producto)t2 && t1.Modelo == t2.Modelo;
            }
            return false;
        }

        public static bool operator !=(Televisor t1, Televisor t2)
        {
            return !(t1 == t2);
        }

        
    }
}
