namespace Forms
{
    partial class FrmMostrarArchivo
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
            this.rtbMostrar = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbMostrar
            // 
            this.rtbMostrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbMostrar.Location = new System.Drawing.Point(0, 0);
            this.rtbMostrar.Name = "rtbMostrar";
            this.rtbMostrar.Size = new System.Drawing.Size(800, 450);
            this.rtbMostrar.TabIndex = 0;
            this.rtbMostrar.Text = "";
            // 
            // FrmMostrarArchivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbMostrar);
            this.Name = "FrmMostrarArchivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMostrarArchivo";
            this.Load += new System.EventHandler(this.FrmMostrarArchivo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbMostrar;
    }
}