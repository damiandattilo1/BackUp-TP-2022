namespace Formularios
{
    partial class FrmNuevoProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCelular = new System.Windows.Forms.Button();
            this.btnTelevisor = new System.Windows.Forms.Button();
            this.btnPC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCelular
            // 
            this.btnCelular.Location = new System.Drawing.Point(212, 204);
            this.btnCelular.Name = "btnCelular";
            this.btnCelular.Size = new System.Drawing.Size(157, 80);
            this.btnCelular.TabIndex = 0;
            this.btnCelular.Text = "Agregar Celular";
            this.btnCelular.UseVisualStyleBackColor = true;
            this.btnCelular.Click += new System.EventHandler(this.btnCelular_Click);
            // 
            // btnTelevisor
            // 
            this.btnTelevisor.Location = new System.Drawing.Point(410, 204);
            this.btnTelevisor.Name = "btnTelevisor";
            this.btnTelevisor.Size = new System.Drawing.Size(148, 80);
            this.btnTelevisor.TabIndex = 1;
            this.btnTelevisor.Text = "Agregar Televisor";
            this.btnTelevisor.UseVisualStyleBackColor = true;
            this.btnTelevisor.Click += new System.EventHandler(this.btnTelevisor_Click);
            // 
            // btnPC
            // 
            this.btnPC.Location = new System.Drawing.Point(599, 204);
            this.btnPC.Name = "btnPC";
            this.btnPC.Size = new System.Drawing.Size(136, 80);
            this.btnPC.TabIndex = 2;
            this.btnPC.Text = "Agregar pc";
            this.btnPC.UseVisualStyleBackColor = true;
            this.btnPC.Click += new System.EventHandler(this.btnPC_Click);
            // 
            // FrmNuevoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(994, 449);
            this.Controls.Add(this.btnPC);
            this.Controls.Add(this.btnTelevisor);
            this.Controls.Add(this.btnCelular);
            this.Name = "FrmNuevoProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNuevoProducto";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCelular;
        private System.Windows.Forms.Button btnTelevisor;
        private System.Windows.Forms.Button btnPC;
    }
}