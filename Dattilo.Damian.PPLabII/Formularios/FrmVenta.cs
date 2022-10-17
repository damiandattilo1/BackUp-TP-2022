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
    public partial class FrmVenta : Form
    {
        private Deposito deposito;
        private bool esDueño;
        public FrmVenta(Deposito deposito, bool esDueño)
        {
            InitializeComponent();
            this.deposito = deposito;
            this.esDueño = esDueño;
        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            if(!esDueño)
            {
                btnVolver.Hide();
            }
            CargarDatos();
        }

        private void CargarDatos()
        {
            lstProductos.Items.Clear();
            foreach (Producto item in deposito.Productos)
            {
                lstProductos.Items.Add(item);
            }
        }

        /// <summary>
        /// evento del boton vender que efectua la venta si hay stock
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVender_Click(object sender, EventArgs e)
        {
            Producto producto = lstProductos.SelectedItem as Producto;
            if (producto is not null)
            {
                if(producto.Stock > 0)
                {
                    FrmConfirmarVenta confirmar = new FrmConfirmarVenta(lstProductos.SelectedItem as Producto);
                    this.Hide();
                    confirmar.ShowDialog();
                    CargarDatos();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("El producto no cuenta con stock", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
