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
            lbl1.Text = "EsSmart";
            lbl2.Text = "Pulgadas";
            lbl3.Text = "SistemaOperativo";
            lbl4.Text = "Resolucion";

            cbx1.Visible = true;
            txt1.Visible = false;
            txt2.Visible = true;
            cmb1.Visible = true;
            cmb2.Visible = true;
            
        }

        private void rdbPc_CheckedChanged(object sender, EventArgs e)
        {

            List<PC> pcs = new List<PC>(Deposito.Productos.Where((a) => a is PC).ToList().Cast<PC>());

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = pcs;


            //Deshabilito los otros RadioButtons
            lbl1.Text = "MemoriaDisco";
            lbl2.Text = "RAM";
            lbl3.Text = "SistemaOperativo";
            lbl4.Text = "Disco";

            ClearComboBox();
           /* cmbDisco.Items.Add(eDisco.SSD);
            cmbDisco.Items.Add(eDisco.HDD);


            cmbSistOp.Items.Add(eSistemaPC.Linux);
            cmbSistOp.Items.Add(eSistemaPC.Windows);*/

            cbx1.Visible = false;
            txt1.Visible = true;
            txt2.Visible = true;
            cmb1.Visible = true;
            cmb2.Visible = true;
            
        }

        private void rdbCelular_CheckedChanged(object sender, EventArgs e)
        {

            List<Celular> celulares = new List<Celular>(Deposito.Productos.Where((a) => a is Celular).ToList().Cast<Celular>());

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = celulares;

            //Deshabilito los otros RadioButtons
            lbl1.Text = "EsLiberado";
            lbl2.Text = "MEMORIA";
            lbl3.Text = "SistemaOperativo";
            lbl4.Text = "ResolucionCamara";

            ClearComboBox();

            cmb2.Items.Add(eResolucion.Standard);
            cmb2.Items.Add(eResolucion.HD);
            cmb2.Items.Add(eResolucion.UHD);

            cmb1.Items.Add(eSistemaTV.AndroidTV);
            cmb1.Items.Add(eSistemaTV.Linux);
            cmb1.Items.Add(eSistemaTV.Tizen);


            cbx1.Visible = true;
            txt1.Visible = false;
            txt2.Visible = true;
            cmb1.Visible = true;
            cmb2.Visible = true;
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(rdbTelevisor.Checked)
            {
                
                //Deposito.AgregarProducto((eMarca)cmbMarca.SelectedItem, txtModelo.Text, (eTag)cmbTag.SelectedItem, double.Parse(txtPrecio.Text), int.Parse(txt2.Text), (eSistemaTV)cmb1.SelectedItem, (eResolucion)cmb2.SelectedItem, cbx1);
                //(eMarca marca, string modelo, eTag tag, double precio, int pulgadas, eSistemaTV sistemaOperativo, eResolucion resolucion, bool esSmart)
            }
        }

        private void FrmListado_Load(object sender, EventArgs e)
        {


            ClearComboBox();

            cmbMarca.Items.Add(eMarca.Sony);
            cmbMarca.Items.Add(eMarca.HP);
            cmbMarca.Items.Add(eMarca.Samsung);
            cmbMarca.Items.Add(eMarca.Philips);

            

            cmbTag.Items.Add(eTag.Audiovisual);
            cmbTag.Items.Add(eTag.Telefonia);
            cmbTag.Items.Add(eTag.Informatica);
        }

        private void ClearComboBox()
        {
            cmbMarca.Items.Clear();
            cmb1.Items.Clear();
            cmb2.Items.Clear();
            cmbTag.Items.Clear();
        }
    }
}
