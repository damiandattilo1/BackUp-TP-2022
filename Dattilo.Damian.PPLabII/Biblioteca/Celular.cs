using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Clase Celular heredada de producto
    /// </summary>
    public class Celular : Producto
    {
        /// <summary>
        /// Atributos
        /// </summary>
        private int memoria;
        private eSistemaCelular sistemaOperativo;
        private eResolucionCamara resolucionCamara;
        private bool esLiberado;

        /// <summary>
        /// Propuedades para cada atributo
        /// </summary>
        public int Memoria
        {
            get { return this.memoria; }
            set { memoria = value; }
        }

        public eSistemaCelular SistemaOperativo
        {
            get { return this.sistemaOperativo; }
            set { sistemaOperativo = value; }
        }

        public eResolucionCamara ResolucionCamara
        {
            get { return this.resolucionCamara; }
            set { resolucionCamara = value; }
        }

        public bool EsLiberado
        {
            get { return this.esLiberado; }
            set { esLiberado = value; }
        }


        /// <summary>
        /// Constructor publico de celular que reutiliza el constructor de la clase base
        /// </summary>
        /// <param name="id"></param>
        /// <param name="marca"></param>
        /// <param name="modelo"></param>
        /// <param name="tag"></param>
        /// <param name="precio"></param>
        /// <param name="memoria"></param>
        /// <param name="sistemaOperativo"></param>
        /// <param name="resolucionCamara"></param>
        /// <param name="esLiberado"></param>
        public Celular(eMarca marca, string modelo, eTag tag, double precio, int memoria,eSistemaCelular sistemaOperativo, eResolucionCamara resolucionCamara, bool esLiberado) : base(marca, modelo,tag, precio, 3)
        {
            this.memoria = memoria;
            this.sistemaOperativo = sistemaOperativo;
            this.resolucionCamara = resolucionCamara;
            this.esLiberado = esLiberado;
        }

        /// <summary>
        /// Polimorfismo de ToString que reutiliza el polimorfismo de la clase base y agrega datos propios del Celular
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.ToString());

            sb.AppendLine($"Memoria: {this.Memoria} GB");
            sb.AppendLine($"Sistema Operativo: {this.SistemaOperativo.ToString()}");
            sb.AppendLine($"Resolucion Camara: {this.ResolucionCamara.ToString()}");
            sb.Append("Es liberado: ");
            if (!this.EsLiberado)
            {
                sb.AppendLine("No");
            }
            else
            {
                sb.AppendLine("Si");
            }

            sb.Append(base.DatosExtra());

            return sb.ToString();
        }

        

        /// <summary>
        /// Sobrecarga de operador == Dos celulares son iguales si sus productos y sus modelos son iguales
        /// </summary>
        /// <param name="celular1"></param>
        /// <param name="celular2"></param>
        /// <returns></returns>
        public static bool operator ==(Celular celular1, Celular celular2)
        {
            if (celular1 is not null && celular2 is not null)
            {
                return (Producto)celular1 == (Producto)celular2 && celular1.Modelo == celular2.Modelo;
            }
            return false;
        }

        public static bool operator !=(Celular celular1, Celular celular2)
        {
            return !(celular1 == celular2);
        }

        
    }
}
