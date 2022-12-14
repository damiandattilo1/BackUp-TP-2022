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
    public partial class FrmMenuPrincipal : Form
    {
        
        public FrmMenuPrincipal()
        {
            InitializeComponent();
            
        }

        /// <summary>
        /// LLEva al dueno al inventario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInventario_Click(object sender, EventArgs e)
        {
            FrmAdminInventario frmAdminInventario = new FrmAdminInventario();
            this.Hide();
            frmAdminInventario.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// lleva al dueno al form de venta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVenta_Click(object sender, EventArgs e)
        {
            FrmVenta formVenta = new FrmVenta(true);
            this.Hide();
            formVenta.ShowDialog();
            this.Show();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            BackColor = Cuenta.ColorFormulario;
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            FrmHistorial frmHistorial = new FrmHistorial();
            this.Hide();
            frmHistorial.ShowDialog();
            this.Show();
        }
    }
}
