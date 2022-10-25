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
        
        public FrmEstadisticas() 
        {
            InitializeComponent();
  
            
        }

        private int CalcularCantidadVentas()
        {
            int cont = 0;
            foreach(Venta item in Datos.Ventas)
            {
                cont ++;
            }
            return cont;
        }

        private double CalcularPromedioAudio()
        {
            double precioAudio = 0;

            int cantAudio = 0;

            foreach(Venta item in Datos.Ventas)
            {
                if(item.Producto.Tag == eTag.Audiovisual)
                {
                    cantAudio++;
                    precioAudio += (item.Producto.Precio);
                     
                }
            }

            return precioAudio / (int)cantAudio;
        }

        private double CalcularPromedioInfo()
        {
            double precioInfo = 0;

            int cantInfo = 0;

            foreach (Venta item in Datos.Ventas)
            {
                if (item.Producto.Tag == eTag.Informatica)
                {
                    cantInfo++;
                    precioInfo += (item.Producto.Precio);

                }
            }

            return precioInfo / (int)cantInfo;
        }

        private double CalcularPromedioTelefonia()
        {
            double precioTelefonia = 0;

            int cantTelefonia = 0;

            foreach (Venta item in Datos.Ventas)
            {
                if (item.Producto.Tag == eTag.Telefonia)
                {
                    cantTelefonia++;
                    precioTelefonia += (item.Producto.Precio);

                }
            }

            return precioTelefonia / (int)cantTelefonia;
        }

        private double CalcularGananciaTotal()
        {
            double acumGanancia = 0;
            foreach(Venta item in Datos.Ventas)
            {
                acumGanancia += (item.Producto.Precio);
            }

            return acumGanancia;
        }

        private int CalcularVentas(Producto producto)
        {
            int ventas = 0;

            foreach(Venta item in Datos.Ventas)
            {
                if (item.Producto == producto)
                {
                    ventas++;
                }
            }
            return ventas;
        }

        private Producto CalcularMayorVendidoAudiovisual()
        {
            Producto masVendido = null;
            bool primero = false;
            foreach(Venta item in Datos.Ventas)
            {
                if(item.Producto.Tag == eTag.Audiovisual)
                {
                    if(primero == false)
                    {
                        masVendido = item.Producto;
                        primero = true;
                    }
                    else
                    {
                        if(CalcularVentas(item.Producto) > CalcularVentas(masVendido))
                        {
                            masVendido = item.Producto;
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
            foreach (Venta item in Datos.Ventas)
            {
                if (item.Producto.Tag == eTag.Informatica)
                {
                    if (primero == false)
                    {
                        masVendido = item.Producto;
                        primero = true;
                    }
                    else
                    {
                        if (CalcularVentas(item.Producto) > CalcularVentas(masVendido))
                        {
                            masVendido = item.Producto;
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
            foreach (Venta item in Datos.Ventas)
            {
                if (item.Producto.Tag == eTag.Telefonia)
                {
                    if (primero == false)
                    {
                        masVendido = item.Producto;
                        primero = true;
                    }
                    else
                    {
                        if (CalcularVentas(item.Producto) > CalcularVentas(masVendido))
                        {
                            masVendido = item.Producto;
                        }
                    }

                }
            }
            return masVendido;
        }

        private void FrmEstadisticas_Load(object sender, EventArgs e)
        {
            BackColor = Cuenta.ColorFormulario;
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
