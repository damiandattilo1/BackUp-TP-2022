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
    public partial class FrmAgregar : Form
    {
        Cartuchera<Util> cartuchera;
        public FrmAgregar(Cartuchera<Util> cartuchera)
        {
            InitializeComponent();
            this.cartuchera = cartuchera;
        }

        private void rbLapiz_CheckedChanged(object sender, EventArgs e)
        {
            Modificar();
        }


        private void rbGoma_CheckedChanged(object sender, EventArgs e)
        {
            Modificar();
        }

        private void rbSacapuntas_CheckedChanged(object sender, EventArgs e)
        {
            Modificar();
        }
        private void Modificar()
        {
            RadioButton? buttons = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);

            if (buttons is not null)
            {
                if (buttons.Equals(rbGoma))
                {
                    //RefrescarDGV<Goma>();


                    label3.Text = "Para Lapiz";
                    label4.Text = "largo";

                    comboBox3.Visible = false;
                    comboBox4.Visible = false;
                    checkBox1.Visible = true;
                    textBox4.Visible = true;
                }

                if (buttons.Equals(rbLapiz))
                {
                    //RefrescarDGV<Lapiz>();


                    label3.Text = "Color";
                    label4.Text = "Trazo";

                    ClearComboBox();
                    comboBox3.Items.Add(eColor.Rojo);
                    comboBox3.Items.Add(eColor.Verde);
                    comboBox3.Items.Add(eColor.Azul);

                    comboBox4.Items.Add(eTrazo.H);
                    comboBox4.Items.Add(eTrazo.HB);
                    comboBox4.Items.Add(eTrazo.B);



                    comboBox3.Visible = true;
                    comboBox4.Visible = true;
                    checkBox1.Visible = false;
                    textBox4.Visible = false;
                }

                if (buttons.Equals(rbSacapuntas))
                {
                    //RefrescarDGV<Sacapunta>();


                    label3.Text = "Es Electrico";
                    label4.Text = "Capacidad";


                    comboBox3.Visible = false;
                    comboBox4.Visible = false;
                    checkBox1.Visible = true;
                    textBox4.Visible = true;
                }
            }
        }

        private void ClearComboBox()
        {
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            Agregar();

        }
        private void Agregar()
        {
            LapizDAO lapizDAO;
            GomaDAO gomaDAO;
            SacapuntasDAO sacapuntasDAO;

            Util? util = null;
            if (txtMarca.Text != "" && txtPrecio.Text != "")
            {
                if (rbLapiz.Checked && comboBox3.SelectedItem is not null && comboBox4.SelectedItem is not null)
                {
                    util = new Lapiz(txtMarca.Text, int.Parse(txtPrecio.Text), (eColor)comboBox3.SelectedItem, (eTrazo)comboBox4.SelectedItem);
                }
                else if (rbSacapuntas.Checked && textBox4.Text != "")
                {
                    util = new Sacapunta(txtMarca.Text, int.Parse(txtPrecio.Text), checkBox1.Checked, int.Parse(textBox4.Text));
                }
                else if (textBox4.Text != "")
                {
                    util = new Goma(txtMarca.Text, int.Parse(txtPrecio.Text), checkBox1.Checked, int.Parse(textBox4.Text));
                }
                
            }
            else
            {
                MessageBox.Show("ERROR, campos vacios");
            }


            try
            {
                if (util is not null)
                {
                    cartuchera += util;
                    if (util is Lapiz)
                    {
                        Lapiz lapiz = (Lapiz)util;
                        lapizDAO = new LapizDAO();
                        lapizDAO.Insertar(lapiz);
                    }
                    else if (util is Sacapunta)
                    {
                        Sacapunta sacapunta = (Sacapunta)util;
                        sacapuntasDAO = new SacapuntasDAO();
                        sacapuntasDAO.Insertar(sacapunta);
                    }
                    else
                    {
                        Goma goma = (Goma)util;
                        gomaDAO = new GomaDAO();
                        gomaDAO.Insertar(goma);
                    }

                    Console.Beep();
                    MessageBox.Show("El util se ha agregado con exito");
                }
                else
                {
                    throw new Exception("El util es null");
                }
            }
            catch (CartucheraLlenaException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }




      

        /// <summary>
        /// Permite que solo se puedan escribir numeros el los textbox txtPrecio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
