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
        Deposito deposito;
        public FrmMenuPrincipal(Deposito deposito)
        {
            InitializeComponent();
            this.deposito = deposito;
        }

        /// <summary>
        /// LLEva al dueno al inventario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInventario_Click(object sender, EventArgs e)
        {
            FrmAdminInventario frmAdminInventario = new FrmAdminInventario(deposito);
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
            FrmVenta formVenta = new FrmVenta(deposito, true);
            this.Hide();
            formVenta.ShowDialog();
            this.Show();
        }

    }
}
