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

        private void FrmListado_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void rdbTelevisor_CheckedChanged(object sender, EventArgs e)
        {
            ModificarUI();
        }

        private void rdbPc_CheckedChanged(object sender, EventArgs e)
        {
            ModificarUI();
        }

        private void rdbCelular_CheckedChanged(object sender, EventArgs e)
        {
            ModificarUI();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarProducto();
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void AgregarProducto()
        {

            Producto producto;
            if (Validar())
            {
                if (rdbTelevisor.Checked)
                {

                    producto = new Televisor((eMarca)cmbMarca.SelectedItem, txtModelo.Text, (eTag)cmbTag.SelectedItem, double.Parse(txtPrecio.Text), int.Parse(txt2.Text), (eSistemaTV)cmb1.SelectedItem, (eResolucion)cmb2.SelectedItem, cbx1.Checked);


                }
                else if (rdbCelular.Checked)
                {
                    producto = new Celular((eMarca)cmbMarca.SelectedItem, txtModelo.Text, (eTag)cmbTag.SelectedItem, double.Parse(txtPrecio.Text), int.Parse(txt2.Text), (eSistemaCelular)cmb1.SelectedItem, (eResolucionCamara)cmb2.SelectedItem, cbx1.Checked);
                }
                else
                {
                    producto = new PC((eMarca)cmbMarca.SelectedItem, txtModelo.Text, (eTag)cmbTag.SelectedItem, double.Parse(txtPrecio.Text), int.Parse(txt2.Text), int.Parse(txt2.Text), (eSistemaPC)cmb1.SelectedItem, (eDisco)cmb2.SelectedItem);
                }

                Deposito.AgregarProducto(producto);

                RefrescarDGV();

                Console.Beep();
            }
            else
            {
                MessageBox.Show("Ingrese correctamente los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefrescarDGV<T>()
        {
            List<T> producto = new List<T>(Deposito.Productos.Where((a) => a is T).ToList().Cast<T>());

            dgvProductos.DataSource = null;
            dgvProductos.DataSource = producto;
        }

        private void RefrescarDGV()
        {
            RadioButton? buttons = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);

            if (buttons is not null)
            {
                if (buttons.Equals(rdbTelevisor))
                {
                    RefrescarDGV<Televisor>();
                }
                else if (buttons.Equals(rdbCelular))
                {
                    RefrescarDGV<Celular>();
                }
                else if (buttons.Equals(rdbPc))
                {
                    RefrescarDGV<PC>();
                }
            }
        }

        private void ModificarUI()
        {
            RadioButton? buttons = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);

            if (buttons is not null)
            {
                if (buttons.Equals(rdbTelevisor))
                {
                    RefrescarDGV<Televisor>();

                    lbl1.Text = "EsSmart";
                    lbl2.Text = "Pulgadas";
                    lbl3.Text = "SistemaOperativo";
                    lbl4.Text = "Resolucion";

                    ClearComboBox();

                    cmb1.Items.Add(eSistemaTV.AndroidTV);
                    cmb1.Items.Add(eSistemaTV.Tizen);
                    cmb1.Items.Add(eSistemaTV.Linux);

                    cmb2.Items.Add(eResolucion.Standard);
                    cmb2.Items.Add(eResolucion.HD);
                    cmb2.Items.Add(eResolucion.UHD);


                    cbx1.Visible = true;
                    txt1.Visible = false;
                    txt2.Visible = true;
                    cmb1.Visible = true;
                    cmb2.Visible = true;
                }

                if (buttons.Equals(rdbPc))
                {
                    RefrescarDGV<PC>();


                    lbl1.Text = "MemoriaDisco";
                    lbl2.Text = "RAM";
                    lbl3.Text = "SistemaOperativo";
                    lbl4.Text = "Disco";

                    ClearComboBox();
                    cmb2.Items.Add(eDisco.SSD);
                    cmb2.Items.Add(eDisco.HDD);


                    cmb1.Items.Add(eSistemaPC.Linux);
                    cmb1.Items.Add(eSistemaPC.Windows);

                    cbx1.Visible = false;
                    txt1.Visible = true;
                    txt2.Visible = true;
                    cmb1.Visible = true;
                    cmb2.Visible = true;
                }

                if (buttons.Equals(rdbCelular))
                {
                    RefrescarDGV<Celular>();

                    lbl1.Text = "EsLiberado";
                    lbl2.Text = "MEMORIA";
                    lbl3.Text = "SistemaOperativo";
                    lbl4.Text = "ResolucionCamara";


                    ClearComboBox();
                    cmb2.Items.Add(eResolucionCamara.Mp10);
                    cmb2.Items.Add(eResolucionCamara.Mp12);
                    cmb2.Items.Add(eResolucionCamara.Mp15);

                    cmb1.Items.Add(eSistemaCelular.Android);
                    cmb1.Items.Add(eSistemaCelular.iOS);
                    cmb1.Items.Add(eSistemaCelular.WindowsPhone);


                    cbx1.Visible = true;
                    txt1.Visible = false;
                    txt2.Visible = true;
                    cmb1.Visible = true;
                    cmb2.Visible = true;
                }
            }
        }

        private void Inicializar()
        {
            BackColor = Cuenta.ColorFormulario;

            ClearComboBox();

            cmbMarca.Items.Add(eMarca.Sony);
            cmbMarca.Items.Add(eMarca.HP);
            cmbMarca.Items.Add(eMarca.Samsung);
            cmbMarca.Items.Add(eMarca.Philips);

            cmbTag.Items.Add(eTag.Audiovisual);
            cmbTag.Items.Add(eTag.Telefonia);
            cmbTag.Items.Add(eTag.Informatica);


            ModificarUI();

        }

        private bool Validar()
        {

            if (cmbMarca is not null && txtPrecio is not null && txtModelo is not null && cmbTag is not null && txt1 is not null && txt2 is not null && cmb1 is not null && cmb2 is not null)
            {
                return true;
            }

            return false;
        }

        private void ClearComboBox()
        {
            cmb1.Items.Clear();
            cmb2.Items.Clear();

        }

    }
}
