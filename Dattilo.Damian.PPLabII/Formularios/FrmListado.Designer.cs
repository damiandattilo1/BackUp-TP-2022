namespace Formularios
{
    partial class FrmListado
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rdbTelevisor = new System.Windows.Forms.RadioButton();
            this.rdbPc = new System.Windows.Forms.RadioButton();
            this.rdbCelular = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRAM = new System.Windows.Forms.TextBox();
            this.txtSmart = new System.Windows.Forms.TextBox();
            this.txtResolucion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(875, 293);
            this.dataGridView1.TabIndex = 0;
            // 
            // rdbTelevisor
            // 
            this.rdbTelevisor.AutoSize = true;
            this.rdbTelevisor.Location = new System.Drawing.Point(6, 26);
            this.rdbTelevisor.Name = "rdbTelevisor";
            this.rdbTelevisor.Size = new System.Drawing.Size(88, 24);
            this.rdbTelevisor.TabIndex = 1;
            this.rdbTelevisor.TabStop = true;
            this.rdbTelevisor.Text = "Televisor";
            this.rdbTelevisor.UseVisualStyleBackColor = true;
            this.rdbTelevisor.CheckedChanged += new System.EventHandler(this.rdbTelevisor_CheckedChanged);
            // 
            // rdbPc
            // 
            this.rdbPc.AutoSize = true;
            this.rdbPc.Location = new System.Drawing.Point(6, 56);
            this.rdbPc.Name = "rdbPc";
            this.rdbPc.Size = new System.Drawing.Size(44, 24);
            this.rdbPc.TabIndex = 2;
            this.rdbPc.TabStop = true;
            this.rdbPc.Text = "Pc";
            this.rdbPc.UseVisualStyleBackColor = true;
            this.rdbPc.CheckedChanged += new System.EventHandler(this.rdbPc_CheckedChanged);
            // 
            // rdbCelular
            // 
            this.rdbCelular.AutoSize = true;
            this.rdbCelular.Location = new System.Drawing.Point(6, 86);
            this.rdbCelular.Name = "rdbCelular";
            this.rdbCelular.Size = new System.Drawing.Size(76, 24);
            this.rdbCelular.TabIndex = 3;
            this.rdbCelular.TabStop = true;
            this.rdbCelular.Text = "Celular";
            this.rdbCelular.UseVisualStyleBackColor = true;
            this.rdbCelular.CheckedChanged += new System.EventHandler(this.rdbCelular_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbTelevisor);
            this.groupBox1.Controls.Add(this.rdbCelular);
            this.groupBox1.Controls.Add(this.rdbPc);
            this.groupBox1.Location = new System.Drawing.Point(58, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 125);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txtRAM
            // 
            this.txtRAM.Location = new System.Drawing.Point(586, 27);
            this.txtRAM.Name = "txtRAM";
            this.txtRAM.Size = new System.Drawing.Size(125, 27);
            this.txtRAM.TabIndex = 5;
            // 
            // txtSmart
            // 
            this.txtSmart.Location = new System.Drawing.Point(586, 68);
            this.txtSmart.Name = "txtSmart";
            this.txtSmart.Size = new System.Drawing.Size(125, 27);
            this.txtSmart.TabIndex = 6;
            // 
            // txtResolucion
            // 
            this.txtResolucion.Location = new System.Drawing.Point(586, 110);
            this.txtResolucion.Name = "txtResolucion";
            this.txtResolucion.Size = new System.Drawing.Size(125, 27);
            this.txtResolucion.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(512, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "RAM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(512, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Smart";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(499, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Resolucion";
            // 
            // FrmListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(957, 496);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResolucion);
            this.Controls.Add(this.txtSmart);
            this.Controls.Add(this.txtRAM);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmListado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListado";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rdbTelevisor;
        private System.Windows.Forms.RadioButton rdbPc;
        private System.Windows.Forms.RadioButton rdbCelular;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRAM;
        private System.Windows.Forms.TextBox txtSmart;
        private System.Windows.Forms.TextBox txtResolucion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}