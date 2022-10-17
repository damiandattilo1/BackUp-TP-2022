namespace Formularios
{
    partial class FrmConfirmarVenta
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
            this.rtbMostrarProducto = new System.Windows.Forms.RichTextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbMostrarProducto
            // 
            this.rtbMostrarProducto.Location = new System.Drawing.Point(78, 45);
            this.rtbMostrarProducto.Name = "rtbMostrarProducto";
            this.rtbMostrarProducto.ReadOnly = true;
            this.rtbMostrarProducto.Size = new System.Drawing.Size(649, 285);
            this.rtbMostrarProducto.TabIndex = 0;
            this.rtbMostrarProducto.Text = "";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(295, 373);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(201, 49);
            this.btnConfirmar.TabIndex = 1;
            this.btnConfirmar.Text = "ConfirmarVenta";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // FrmConfirmarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.rtbMostrarProducto);
            this.Name = "FrmConfirmarVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConfirmarVenta";
            this.Load += new System.EventHandler(this.FrmConfirmarVenta_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbMostrarProducto;
        private System.Windows.Forms.Button btnConfirmar;
    }
}