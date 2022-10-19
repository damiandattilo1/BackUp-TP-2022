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
    public partial class FrmListado : Form
    {
        public FrmListado()
        {
            InitializeComponent();
        }

        private void rdbTelevisor_CheckedChanged(object sender, EventArgs e)
        {

            //Retorno una lista de los televisores que hay en el deposito
            List<Televisor> televisores = new List<Televisor>(Deposito.Productos.Where((a) => a is Televisor).ToList().Cast<Televisor>());

            //Actualizo el DataGridView
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = televisores;

            //Deshabilito los otros RadioButtons
            txtRAM.Enabled = false;
            txtResolucion.Enabled = false;
            txtSmart.Enabled = true;
        }

        private void rdbPc_CheckedChanged(object sender, EventArgs e)
        {

            List<PC> pcs = new List<PC>(Deposito.Productos.Where((a) => a is PC).ToList().Cast<PC>());

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = pcs;

            txtResolucion.Enabled = false;
            txtSmart.Enabled = false;
            txtRAM.Enabled = true;
        }

        private void rdbCelular_CheckedChanged(object sender, EventArgs e)
        {

            List<Celular> celulares = new List<Celular>(Deposito.Productos.Where((a) => a is Celular).ToList().Cast<Celular>());

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = celulares;

            txtRAM.Enabled = false;
            txtSmart.Enabled = false;
            txtResolucion.Enabled = true;
        }
    }
}
