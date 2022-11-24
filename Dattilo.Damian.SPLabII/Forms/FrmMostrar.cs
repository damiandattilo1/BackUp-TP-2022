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
    public partial class FrmMostrar : Form
    {
        Cartuchera<Util> cartuchera;

        BindingList<Lapiz> lapiz;
        BindingList<Goma> goma;
        BindingList<Sacapunta> sacapunta;
        
        public FrmMostrar(Cartuchera<Util> cartuchera)
        {
            InitializeComponent();
            this.cartuchera = cartuchera;

            this.lapiz = new BindingList<Lapiz>();
            this.goma = new BindingList<Goma>();
            this.sacapunta = new BindingList<Sacapunta>();
            
            foreach(Goma item in cartuchera.Lista.Where((a) => a is Goma))
            {
                goma.Add(item);
            }
            foreach (Lapiz item in cartuchera.Lista.Where((a) => a is Lapiz))
            {
                lapiz.Add(item);
            }
            foreach (Sacapunta item in cartuchera.Lista.Where((a) => a is Sacapunta))
            {
                sacapunta.Add(item);
            }
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            
            dgvMostrar.DataSource = goma;

            dgvMostrar.Columns["Serializar"].Visible = false;
            dgvMostrar.Columns["Deserializar"].Visible = false;

        }

        private void rbSacapunta_CheckedChanged(object sender, EventArgs e)
        {
            dgvMostrar.DataSource = sacapunta;
            dgvMostrar.Columns["Serializar"].Visible = false;
            dgvMostrar.Columns["Deserializar"].Visible = false;
        }

        private void rbGoma_CheckedChanged(object sender, EventArgs e)
        {
            dgvMostrar.DataSource=goma;

            dgvMostrar.Columns["Serializar"].Visible = false;
            dgvMostrar.Columns["Deserializar"].Visible = false;
        }

        private void rbLapiz_CheckedChanged(object sender, EventArgs e)
        {
            dgvMostrar.DataSource = lapiz;

            dgvMostrar.Columns["Serializar"].Visible = true;
            dgvMostrar.Columns["Deserializar"].Visible = true;
        }

        private void dgvMostrar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && senderGrid.Columns[e.ColumnIndex] == senderGrid.Columns["Serializar"] && e.RowIndex >= 0)
            {
                try
                {
                    lapiz[e.RowIndex].SerializaEnXml();
                    lapiz[e.RowIndex].SerializaEnJson();
                    MessageBox.Show("Se ha serializado correctamente en XLM y en JSON");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && senderGrid.Columns[e.ColumnIndex] == senderGrid.Columns["Deserializar"] && e.RowIndex >= 0)
            {
                FrmDeserializar frmDeserializar = new FrmDeserializar(lapiz[e.RowIndex]);
                this.Hide();
                frmDeserializar.ShowDialog();
                this.Show();
            }
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && senderGrid.Columns[e.ColumnIndex] == senderGrid.Columns["btnBorrar"] && e.RowIndex >= 0)
            {
                try
                {
                    if(dgvMostrar.Rows[e.RowIndex].DataBoundItem is Goma)
                    {
                        cartuchera.Lista.Remove((Goma)dgvMostrar.Rows[e.RowIndex].DataBoundItem);
                        GomaDAO gomaDAO = new GomaDAO();
                        gomaDAO.Eliminar((Goma)dgvMostrar.Rows[e.RowIndex].DataBoundItem);
                    }
                    if (dgvMostrar.Rows[e.RowIndex].DataBoundItem is Sacapunta)
                    {
                        cartuchera.Lista.Remove((Sacapunta)dgvMostrar.Rows[e.RowIndex].DataBoundItem);
                        SacapuntasDAO sacapuntasDAO = new SacapuntasDAO();
                        sacapuntasDAO.Eliminar((Sacapunta)dgvMostrar.Rows[e.RowIndex].DataBoundItem);
                    }
                    if (dgvMostrar.Rows[e.RowIndex].DataBoundItem is Lapiz)
                    {
                        cartuchera.Lista.Remove((Lapiz)dgvMostrar.Rows[e.RowIndex].DataBoundItem);
                        LapizDAO lapizDAO = new LapizDAO();
                        lapizDAO.Eliminar((Lapiz)dgvMostrar.Rows[e.RowIndex].DataBoundItem);
                    }
                    MessageBox.Show("Se ha borrado exitosamente de la cartuchera y la base de datos");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
