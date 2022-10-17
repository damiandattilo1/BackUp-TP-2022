using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;
using System.Text;

namespace Formularios
{
    public partial class FrmEstadisticas : Form
    {
        private Deposito deposito;
        

        private FrmEstadisticas()
        {
            
        }
        public FrmEstadisticas(Deposito deposito) :this()
        {
            InitializeComponent();
            this.deposito = deposito;
            
        }

        private int CalcularCantidadVentas()
        {
            int cont = 0;
            foreach(Producto item in deposito.Productos)
            {
                cont += item.Ventas;
            }
            return cont;
        }

        private double CalcularPromedioAudio()
        {
            double precioAudio = 0;

            int cantAudio = 0;

            foreach(Producto item in deposito.Productos)
            {
                if(item.Ventas > 0)
                {
                    switch (item.Tag)
                    {
                        case eTag.Audiovisual:
                            cantAudio += item.Ventas;
                            precioAudio += (item.Precio) * item.Ventas;
                            break;
                        default:
                            break;

                    }
                }
            }

            return precioAudio / (int)cantAudio;
        }

        private double CalcularPromedioInfo()
        {
            double precioInfo = 0;

            int cantInfo = 0;

            foreach (Producto item in deposito.Productos)
            {
                if (item.Ventas > 0)
                {
                    switch (item.Tag)
                    {
                        case eTag.Informatica:
                            cantInfo += item.Ventas;
                            precioInfo += (item.Precio) * item.Ventas;
                            break;
                        default:
                            break;

                    }
                }
            }

            return precioInfo / (int)cantInfo;
        }

        private double CalcularPromedioTelefonia()
        {
            double precioTelefonia = 0;

            int cantTelefonia = 0;

            foreach (Producto item in deposito.Productos)
            {
                if (item.Ventas > 0)
                {
                    switch (item.Tag)
                    {
                        case eTag.Telefonia:
                            cantTelefonia += item.Ventas;
                            precioTelefonia += (item.Precio) * item.Ventas;
                            break;
                        default:
                            break;

                    }
                }
            }

            return precioTelefonia / (int)cantTelefonia;
        }

        private double CalcularGananciaTotal()
        {
            double acumGanancia = 0;
            foreach(Producto item in deposito.Productos)
            {
                acumGanancia += (item.Ventas * item.Precio);
            }

            return acumGanancia;
        }

        private Producto CalcularMayorVendidoAudiovisual()
        {
            Producto masVendido = null;
            bool primero = false;
            foreach(Producto item in deposito.Productos)
            {
                if(item.Tag == eTag.Telefonia)
                {
                    if(primero == false)
                    {
                        masVendido = item;
                        primero = true;
                    }
                    else
                    {
                        if(item.Ventas > masVendido.Ventas && item.Tag == eTag.Audiovisual)
                        {
                            masVendido = item;
                        }
                    }

                }
            }

            return masVendido;
        }

        private Producto CalcularMayorVendidoInformatica()
        {
            Producto masVendido = null;
            bool primero = false;
            foreach (Producto item in deposito.Productos)
            {
                if(item.Tag == eTag.Informatica)
                {
                    if (primero == false)
                    {
                        masVendido = item;
                        primero = true;
                    }
                    else
                    {
                        if (item.Ventas > masVendido.Ventas)
                        {
                            masVendido = item;
                        }
                    }

                }
            }

            return masVendido;
        }

        private Producto CalcularMayorVendidoTelefonia()
        {
            Producto masVendido = null;
            bool primero = false;
            foreach (Producto item in deposito.Productos)
            {
                if (item.Tag == eTag.Telefonia)
                {
                    if (primero == false)
                    {
                        masVendido = item;
                        primero = true;
                    }
                    else
                    {
                        if (item.Ventas > masVendido.Ventas)
                        {
                            masVendido = item;
                        }
                    }

                }
            }

            return masVendido;
        }

        private void FrmEstadisticas_Load(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Cantidad de ventas: {this.CalcularCantidadVentas()}");

            sb.AppendLine($"\nMas vendido de Audiovisual: {this.CalcularMayorVendidoAudiovisual().Marca} {this.CalcularMayorVendidoAudiovisual().Modelo}");
            sb.AppendLine($"Mas vendido de Informatica: {this.CalcularMayorVendidoInformatica().Marca} {this.CalcularMayorVendidoInformatica().Modelo}");
            sb.AppendLine($"Mas vendido de Telefonia: {this.CalcularMayorVendidoTelefonia().Marca} {this.CalcularMayorVendidoTelefonia().Modelo}");

            sb.AppendLine($"\nPromedio de ganancia de Audiovisual: {this.CalcularPromedioAudio()}");
            sb.AppendLine($"Promedio de ganancia de Informatica: {this.CalcularPromedioInfo()}");
            sb.AppendLine($"Promedio de ganancia de Telefonia: {this.CalcularPromedioTelefonia()}");

            sb.AppendLine($"\nGanancia Total: {this.CalcularGananciaTotal()}");

            rtbEstadisticas.Text = sb.ToString();
        }
    }
}
