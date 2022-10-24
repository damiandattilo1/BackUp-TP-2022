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

namespace Formularios
{
    /// <summary>
    /// Formulario que muestra la factura con los detalles del producto y confirma la venta
    /// </summary>
    public partial class FrmConfirmarVenta : Form
    {
        Producto producto;
        public FrmConfirmarVenta(Producto producto)
        {
            InitializeComponent();
            this.producto = producto;
        }

        /// <summary>
        /// Muestra el producto 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmConfirmarVenta_Load(object sender, EventArgs e)
        {
            rtbMostrarProducto.Text = producto.ToString();
            BackColor = Cuenta.ColorFormulario;
        }

        /// <summary>
        /// Confirma la venta y resta una unidad de stock al producto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            producto.Stock--;
            producto.Ventas++;
            this.Close();
        }
    }
}
