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

namespace Forms
{
    public partial class FrmMostrarArchivo : Form
    {
        Cartuchera<Util> cartuchera;
        public FrmMostrarArchivo(Cartuchera<Util> cartuchera)
        {
            InitializeComponent();
            this.cartuchera = cartuchera;
        }

        private void FrmMostrarArchivo_Load(object sender, EventArgs e)
        {
            try
            {
                rtbMostrar.Text = cartuchera.Leer();
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR El archivo no existe");
            }
        }
    }
}
