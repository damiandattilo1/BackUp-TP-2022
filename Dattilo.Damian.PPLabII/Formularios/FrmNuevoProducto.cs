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
    /// Formulario que permite elegir que tipo de producto agregar
    /// </summary>
    public partial class FrmNuevoProducto : Form
    {
        public FrmNuevoProducto()
        {
            InitializeComponent();
      
        }

        private void btnCelular_Click(object sender, EventArgs e)
        {
            FrmCelular frmCelular = new FrmCelular();
            this.Hide();
            frmCelular.ShowDialog();
            this.Show();
        }

        private void btnTelevisor_Click(object sender, EventArgs e)
        {
            FrmTelevisor frmTelevisor = new FrmTelevisor();
            this.Hide();
            frmTelevisor.ShowDialog();
            this.Show();
        }

        private void btnPC_Click(object sender, EventArgs e)
        {
            FrmPC frmPc = new FrmPC();
            this.Hide();
            frmPc.ShowDialog();
            this.Show();
        }
    }
}
