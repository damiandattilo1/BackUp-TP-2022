namespace Formularios
{
    partial class FrmLoguin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLoguin = new System.Windows.Forms.Button();
            this.btnDueño = new System.Windows.Forms.Button();
            this.btnVendedor = new System.Windows.Forms.Button();
            this.btnContador = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnVentas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(316, 122);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PlaceholderText = "Ingrese usuario";
            this.txtUsuario.Size = new System.Drawing.Size(188, 27);
            this.txtUsuario.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(316, 213);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PlaceholderText = "Ingrese Password";
            this.txtPassword.Size = new System.Drawing.Size(188, 27);
            this.txtPassword.TabIndex = 1;
            // 
            // btnLoguin
            // 
            this.btnLoguin.Location = new System.Drawing.Point(316, 300);
            this.btnLoguin.Name = "btnLoguin";
            this.btnLoguin.Size = new System.Drawing.Size(188, 58);
            this.btnLoguin.TabIndex = 2;
            this.btnLoguin.Text = "Loguin";
            this.btnLoguin.UseVisualStyleBackColor = true;
            this.btnLoguin.Click += new System.EventHandler(this.btnLoguin_Click);
            // 
            // btnDueño
            // 
            this.btnDueño.Location = new System.Drawing.Point(62, 179);
            this.btnDueño.Name = "btnDueño";
            this.btnDueño.Size = new System.Drawing.Size(133, 61);
            this.btnDueño.TabIndex = 3;
            this.btnDueño.Text = "Ingreso Dueño";
            this.btnDueño.UseVisualStyleBackColor = true;
            this.btnDueño.Click += new System.EventHandler(this.btnDueño_Click);
            // 
            // btnVendedor
            // 
            this.btnVendedor.Location = new System.Drawing.Point(641, 179);
            this.btnVendedor.Name = "btnVendedor";
            this.btnVendedor.Size = new System.Drawing.Size(126, 61);
            this.btnVendedor.TabIndex = 4;
            this.btnVendedor.Text = "Ingreso Vendedor";
            this.btnVendedor.UseVisualStyleBackColor = true;
            this.btnVendedor.Click += new System.EventHandler(this.btnVendedor_Click);
            // 
            // btnContador
            // 
            this.btnContador.Location = new System.Drawing.Point(641, 300);
            this.btnContador.Name = "btnContador";
            this.btnContador.Size = new System.Drawing.Size(126, 58);
            this.btnContador.TabIndex = 5;
            this.btnContador.Text = "Ingreso Contador";
            this.btnContador.UseVisualStyleBackColor = true;
            this.btnContador.Click += new System.EventHandler(this.btnContador_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Location = new System.Drawing.Point(62, 309);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(150, 49);
            this.btnVentas.TabIndex = 6;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // FrmLoguin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.btnContador);
            this.Controls.Add(this.btnVendedor);
            this.Controls.Add(this.btnDueño);
            this.Controls.Add(this.btnLoguin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsuario);
            this.Name = "FrmLoguin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loguin";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLoguin;
        private System.Windows.Forms.Button btnDueño;
        private System.Windows.Forms.Button btnVendedor;
        private System.Windows.Forms.Button btnContador;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnVentas;
    }
}
