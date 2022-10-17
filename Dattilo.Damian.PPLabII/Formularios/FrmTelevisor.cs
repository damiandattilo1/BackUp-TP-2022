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
    public partial class FrmTelevisor : Form
    {
        private Deposito deposito;

        public FrmTelevisor(Deposito deposito)
        {
            InitializeComponent();
            this.deposito = deposito;
        }

        /// <summary>
        /// agrega el producto previa validacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool esSmart;
            if(cmbSmart.Text == "Si" && Validar())
            {
                esSmart =true;
            }
            else
            {
                esSmart =false;
            }
            if (Validar())
            {
                Televisor televisor = new Televisor(int.Parse(txtId.Text), (eMarca)cmbMarca.SelectedItem, txtModelo.Text, (eTag)cmbTag.SelectedItem, double.Parse(txtPrecio.Text), int.Parse(txtPulgadas.Text), (eSistemaTV)cmbSistema.SelectedItem, (eResolucion)cmbResolucion.SelectedItem, esSmart);
                if (deposito == televisor)
                {
                    MessageBox.Show("El televisor ya esta ingresado en el comercio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    deposito = deposito + televisor;
                    MessageBox.Show("Se ha agregado el televisor exitosamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }


            }
            else
            {
                MessageBox.Show("Ingrese correctamente los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool Validar()
        {
            int auxInt;
            double auxDouble;

            if (int.TryParse(txtId.Text, out auxInt) && double.TryParse(txtPrecio.Text, out auxDouble) && int.TryParse(txtPulgadas.Text, out auxInt) && cmbMarca is not null && cmbResolucion is not null && cmbSistema is not null && cmbSmart is not null && cmbTag is not null)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// evento load que inicializa todos los comboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmTelevisor_Load(object sender, EventArgs e)
        {
            cmbMarca.Items.Clear();
            cmbResolucion.Items.Clear();
            cmbSistema.Items.Clear();
            cmbSmart.Items.Clear();
            cmbTag.Items.Clear();

            cmbSmart.Items.Add("Si");
            cmbSmart.Items.Add("No");

            cmbMarca.Items.Add(eMarca.Sony);
            cmbMarca.Items.Add(eMarca.HP);
            cmbMarca.Items.Add(eMarca.Samsung);
            cmbMarca.Items.Add(eMarca.Philips);

            cmbResolucion.Items.Add(eResolucion.Standard);
            cmbResolucion.Items.Add(eResolucion.HD);
            cmbResolucion.Items.Add(eResolucion.UHD);

            cmbSistema.Items.Add(eSistemaTV.AndroidTV);
            cmbSistema.Items.Add(eSistemaTV.Linux);
            cmbSistema.Items.Add(eSistemaTV.Tizen);

            cmbTag.Items.Add(eTag.Audiovisual);
            cmbTag.Items.Add(eTag.Telefonia);
            cmbTag.Items.Add(eTag.Informatica);
        }
    }
}
