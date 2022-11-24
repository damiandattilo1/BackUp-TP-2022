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
    public partial class FrmDeserializar : Form
    {
        Lapiz lapiz;
        public FrmDeserializar(Lapiz lapiz)
        {
            InitializeComponent();
            this.lapiz = lapiz;
        }

        private void FrmDeserializar_Load(object sender, EventArgs e)
        {
            //cartuchera.Lista.AddRange(GomaDAO.Leer);
        }

        private void btnXml_Click(object sender, EventArgs e)
        {
            try
            {
                this.lapiz = lapiz.DeserializaEnXml();
                rtbMostrar.Text = lapiz.ToString();
                MessageBox.Show("Se deserializo correctamente en XML");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnJson_Click(object sender, EventArgs e)
        {
            try
            {
                this.lapiz = lapiz.DeserializaEnJson();
                rtbMostrar.Text = lapiz.ToString();
                MessageBox.Show("Se deserializo correctamente en JSON");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
