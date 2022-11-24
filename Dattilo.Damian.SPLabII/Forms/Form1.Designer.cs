namespace Forms
{
    partial class Form1
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnMostrarCartuchera = new System.Windows.Forms.Button();
            this.btnMostarTicket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(146, 188);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(190, 74);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar Util";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnMostrarCartuchera
            // 
            this.btnMostrarCartuchera.Location = new System.Drawing.Point(424, 188);
            this.btnMostrarCartuchera.Name = "btnMostrarCartuchera";
            this.btnMostrarCartuchera.Size = new System.Drawing.Size(190, 74);
            this.btnMostrarCartuchera.TabIndex = 1;
            this.btnMostrarCartuchera.Text = "Mostrar Cartuchera";
            this.btnMostrarCartuchera.UseVisualStyleBackColor = true;
            this.btnMostrarCartuchera.Click += new System.EventHandler(this.btnMostrarCartuchera_Click);
            // 
            // btnMostarTicket
            // 
            this.btnMostarTicket.Location = new System.Drawing.Point(280, 317);
            this.btnMostarTicket.Name = "btnMostarTicket";
            this.btnMostarTicket.Size = new System.Drawing.Size(193, 67);
            this.btnMostarTicket.TabIndex = 2;
            this.btnMostarTicket.Text = "Mostrar ticket";
            this.btnMostarTicket.UseVisualStyleBackColor = true;
            this.btnMostarTicket.Click += new System.EventHandler(this.btnMostarTicket_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMostarTicket);
            this.Controls.Add(this.btnMostrarCartuchera);
            this.Controls.Add(this.btnAgregar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnMostrarCartuchera;
        private System.Windows.Forms.Button btnMostarTicket;
    }
}
