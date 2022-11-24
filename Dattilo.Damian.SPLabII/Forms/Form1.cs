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
    public partial class Form1 : Form
    {
        Cartuchera<Util> cartuchera;
        public Form1()
        {
            InitializeComponent();
            cartuchera = new Cartuchera<Util>(10);
        }

        /// <summary>
        /// agrega 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregar frmAgregar = new FrmAgregar(cartuchera);
            this.Hide();
            frmAgregar.ShowDialog();
            this.Show();
        }

        private void btnMostrarCartuchera_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar = new FrmMostrar(cartuchera);
            this.Hide();
            frmMostrar.ShowDialog();
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GomaDAO gomaDAO = new GomaDAO();
            LapizDAO lapizDAO = new LapizDAO();
            SacapuntasDAO sacapuntasDAO = new SacapuntasDAO();
            try
            {
                cartuchera.Lista.AddRange(gomaDAO.Leer());
                cartuchera.Lista.AddRange(lapizDAO.Leer());
                cartuchera.Lista.AddRange(sacapuntasDAO.Leer());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMostarTicket_Click(object sender, EventArgs e)
        {
            FrmMostrarArchivo mostrarArchivo = new FrmMostrarArchivo(cartuchera);
            this.Hide();
            mostrarArchivo.ShowDialog();
            this.Show();
        }
    }
}
