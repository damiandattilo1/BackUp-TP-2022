namespace Forms
{
    partial class FrmDeserializar
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
            this.btnXml = new System.Windows.Forms.Button();
            this.btnJson = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbMostrar
            // 
            this.rtbMostrar.Location = new System.Drawing.Point(12, 90);
            this.rtbMostrar.Name = "rtbMostrar";
            this.rtbMostrar.ReadOnly = true;
            this.rtbMostrar.Size = new System.Drawing.Size(776, 348);
            this.rtbMostrar.TabIndex = 0;
            this.rtbMostrar.Text = "";
            // 
            // btnXml
            // 
            this.btnXml.Location = new System.Drawing.Point(53, 12);
            this.btnXml.Name = "btnXml";
            this.btnXml.Size = new System.Drawing.Size(178, 50);
            this.btnXml.TabIndex = 1;
            this.btnXml.Text = "Deserializar en Xml";
            this.btnXml.UseVisualStyleBackColor = true;
            this.btnXml.Click += new System.EventHandler(this.btnXml_Click);
            // 
            // btnJson
            // 
            this.btnJson.Location = new System.Drawing.Point(313, 12);
            this.btnJson.Name = "btnJson";
            this.btnJson.Size = new System.Drawing.Size(163, 50);
            this.btnJson.TabIndex = 2;
            this.btnJson.Text = "Deserializar en Json";
            this.btnJson.UseVisualStyleBackColor = true;
            this.btnJson.Click += new System.EventHandler(this.btnJson_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(566, 12);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(140, 50);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FrmDeserializar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnJson);
            this.Controls.Add(this.btnXml);
            this.Controls.Add(this.rtbMostrar);
            this.Name = "FrmDeserializar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDeserializar";
            this.Load += new System.EventHandler(this.FrmDeserializar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbMostrar;
        private System.Windows.Forms.Button btnXml;
        private System.Windows.Forms.Button btnJson;
        private System.Windows.Forms.Button btnVolver;
    }
}