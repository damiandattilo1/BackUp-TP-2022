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
    public partial class FrmPC : Form
    {
        private Deposito deposito;
        public FrmPC(Deposito deposito)
        {
            InitializeComponent();
            this.deposito = deposito;
        }
        /// <summary>
        /// evento load donde se inicializan todos los comboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPC_Load(object sender, EventArgs e)
        {
            cmbDisco.Items.Clear();
            cmbMarca.Items.Clear();
            cmbSistOp.Items.Clear();
            cmbTag.Items.Clear();

            cmbDisco.Items.Add(eDisco.SSD);
            cmbDisco.Items.Add(eDisco.HDD);

            cmbMarca.Items.Add(eMarca.Sony);
            cmbMarca.Items.Add(eMarca.HP);
            cmbMarca.Items.Add(eMarca.Samsung);
            cmbMarca.Items.Add(eMarca.Philips);

            cmbSistOp.Items.Add(eSistemaPC.Linux);
            cmbSistOp.Items.Add(eSistemaPC.Windows);

            cmbTag.Items.Add(eTag.Audiovisual);
            cmbTag.Items.Add(eTag.Telefonia);
            cmbTag.Items.Add(eTag.Informatica);
        }

       
        /// <summary>
        /// agrega el producto pc previa validacion de todos los campos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                PC pc = new PC(int.Parse(txtId.Text), (eMarca)cmbMarca.SelectedItem, txtModelo.Text, (eTag)cmbTag.SelectedItem, double.Parse(txtPrecio.Text), int.Parse(txtMemoriaDisco.Text), int.Parse(txtMemoriaRam.Text),(eSistemaPC)cmbSistOp.SelectedItem, (eDisco)cmbDisco.SelectedItem);

                if (deposito == pc)
                {
                    MessageBox.Show("La pc ya esta ingresado en el comercio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    deposito = deposito + pc;
                    MessageBox.Show("Se ha agregado la PC exitosamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }

            }
            else
            {
                MessageBox.Show("Ingrese correctamente los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// metodo que valida todos los campos
        /// </summary>
        /// <returns></returns>
        private bool Validar()
        {
            int auxInt;
            double auxDouble;

            if (int.TryParse(txtId.Text, out auxInt) && double.TryParse(txtPrecio.Text, out auxDouble) && int.TryParse(txtMemoriaDisco.Text, out auxInt) && int.TryParse(txtMemoriaRam.Text, out auxInt) && cmbDisco is not null && cmbMarca is not null && cmbSistOp is not null && cmbTag is not null)
            {
                return true;
            }

            return false;
        }
    }
}
