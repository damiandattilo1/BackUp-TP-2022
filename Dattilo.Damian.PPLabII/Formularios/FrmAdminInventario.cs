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
    public partial class FrmAdminInventario : Form
    {
        
        Deposito deposito;
        
        /// <summary>
        /// Constructor publico del formulario que recibe el deposito para asignar
        /// </summary>
        /// <param name="deposito"></param>
        public FrmAdminInventario(Deposito deposito)
        {
            InitializeComponent();
            this.deposito = deposito;
        }

        /// <summary>
        /// Evento Load que invoca al metodo CargarDatos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAdminInventario_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Evento del boton sumar stock que Suma stock a un producto previamente existente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSumarStock_Click(object sender, EventArgs e)
        {
            if(lstProductos.SelectedItem is not null)
            {
                Producto p = (Producto)lstProductos.SelectedItem;
                p.Stock++;
                CargarDatos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Actualiza la lista de productos del formulario
        /// </summary>
        private void CargarDatos()
        {
            lstProductos.Items.Clear();
            foreach (Producto item in deposito.Productos)
            {
                lstProductos.Items.Add(item);
            }
        }

        /// <summary>
        /// Instancia al formulario de producto nuevo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevoProducto frmNuevoProducto = new FrmNuevoProducto(deposito);
            this.Hide();
            frmNuevoProducto.ShowDialog();
            CargarDatos();
            this.Show();
        }

        /// <summary>
        /// Evento del boton vender que administra la venta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVender_Click(object sender, EventArgs e)
        {
            Producto producto = lstProductos.SelectedItem as Producto;
            if (producto is not null)
            {
                if (producto.Stock > 0)
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
    }
}
