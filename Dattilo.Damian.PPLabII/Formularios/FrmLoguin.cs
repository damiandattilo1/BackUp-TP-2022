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
    /// <summary>
    /// Formulario Para hacer el loguin a la aplicacion
    /// </summary>
    public partial class FrmLoguin : Form
    {
        
        public FrmLoguin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento del boton Loguin que verifica que usuario y contrasena correspondan al vendedor o al dueno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoguin_Click(object sender, EventArgs e)
        {
            switch(Cuenta.IniciarSesion(txtUsuario.Text, txtPassword.Text).TipoUsuario)
            {
                case eTipoUsuario.Dueño:
                    {
                        FrmMenuPrincipal menu = new FrmMenuPrincipal();
                        this.Hide();
                        menu.ShowDialog();
                        this.Close();
                        break;

                    }
                case eTipoUsuario.Vendedor:
                    {
                        this.Hide();
                        FrmVenta frmVenta = new FrmVenta(false);
                        frmVenta.ShowDialog();
                        this.Close();
                        break;
                    }
                case eTipoUsuario.Contador:
                    {
                        this.Hide();
                        FrmEstadisticas frmEstadisticas = new FrmEstadisticas();
                        frmEstadisticas.ShowDialog();
                        this.Close();
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Usuario o password incorrecto/s", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
            }
        }

        /// <summary>
        /// Da entrada al dueno si coinciden los datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnDueño_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = Loguin.UsuDuenio;
            txtPassword.Text = Loguin.PassDuenio;
        }

        /// <summary>
        /// da entrada al vendedor si coinciden los datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVendedor_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = Loguin.UsuVendedor;
            txtPassword.Text = Loguin.PassVendedor;
        }

        

        private void btnContador_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = Loguin.UsuContador;
            txtPassword.Text = Loguin.PassContador;
        }

        
    }
}
