﻿using System;
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
    public partial class FrmHistorial : Form
    {
        public FrmHistorial()
        {
            InitializeComponent();
        }

        private void FrmHistorial_Load(object sender, EventArgs e)
        {
            dgvHistorial.DataSource = Datos.Ventas;
            BackColor = Cuenta.ColorFormulario;
        }
    }
}
