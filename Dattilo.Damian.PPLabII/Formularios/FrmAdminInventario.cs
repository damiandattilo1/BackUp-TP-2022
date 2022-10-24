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
        
        
        /// <summary>
        /// Constructor publico del formulario que recibe el deposito para asignar
        /// </summary>
        /// <param name="deposito"></param>
        public FrmAdminInventario()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento Load que invoca al metodo CargarDatos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAdminInventario_Load(object sender, EventArgs e)
        {
            CargarDatos();
            BackColor = Cuenta.ColorFormulario;
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
            foreach (Producto item in Deposito.Productos)
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
            FrmListado frmListado = new FrmListado();
            this.Hide();
            frmListado.ShowDialog();
            CargarDatos();
            this.Show();
        }

        
    }
}
