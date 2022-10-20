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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.cmbTag = new System.Windows.Forms.ComboBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.cmb1 = new System.Windows.Forms.ComboBox();
            this.cmb2 = new System.Windows.Forms.ComboBox();
            this.cbx1 = new System.Windows.Forms.CheckBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
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
            this.dataGridView1.Size = new System.Drawing.Size(1190, 293);
            this.dataGridView1.TabIndex = 0;
            // 
            // rdbTelevisor
            // 
            this.rdbTelevisor.AutoSize = true;
            this.rdbTelevisor.Location = new System.Drawing.Point(6, 26);
            this.rdbTelevisor.Name = "rdbTelevisor";
            this.rdbTelevisor.Size = new System.Drawing.Size(88, 24);
            this.rdbTelevisor.TabIndex = 1;
            this.rdbTelevisor.Text = "Televisor";
            this.rdbTelevisor.UseVisualStyleBackColor = true;
            this.rdbTelevisor.CheckedChanged += new System.EventHandler(this.rdbTelevisor_CheckedChanged);
            // 
            // rdbPc
            // 
            this.rdbPc.AutoSize = true;
            this.rdbPc.Checked = true;
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
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(1045, 57);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(185, 65);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Marca";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(329, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Precio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(329, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Modelo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(329, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Tag";
            // 
            // cmbMarca
            // 
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(410, 14);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(151, 28);
            this.cmbMarca.TabIndex = 20;
            // 
            // cmbTag
            // 
            this.cmbTag.FormattingEnabled = true;
            this.cmbTag.Location = new System.Drawing.Point(409, 113);
            this.cmbTag.Name = "cmbTag";
            this.cmbTag.Size = new System.Drawing.Size(151, 28);
            this.cmbTag.TabIndex = 21;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(410, 76);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(125, 27);
            this.txtModelo.TabIndex = 23;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(625, 17);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(106, 20);
            this.lbl1.TabIndex = 24;
            this.lbl1.Text = "MemoriaDisco";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(662, 51);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(39, 20);
            this.lbl2.TabIndex = 25;
            this.lbl2.Text = "Ram";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(604, 82);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(127, 20);
            this.lbl3.TabIndex = 26;
            this.lbl3.Text = "SistemaOperativo";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(662, 113);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(46, 20);
            this.lbl4.TabIndex = 27;
            this.lbl4.Text = "Disco";
            // 
            // cmb1
            // 
            this.cmb1.FormattingEnabled = true;
            this.cmb1.Location = new System.Drawing.Point(756, 79);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(151, 28);
            this.cmb1.TabIndex = 30;
            // 
            // cmb2
            // 
            this.cmb2.FormattingEnabled = true;
            this.cmb2.Location = new System.Drawing.Point(756, 113);
            this.cmb2.Name = "cmb2";
            this.cmb2.Size = new System.Drawing.Size(151, 28);
            this.cmb2.TabIndex = 31;
            // 
            // cbx1
            // 
            this.cbx1.AutoSize = true;
            this.cbx1.Location = new System.Drawing.Point(787, 17);
            this.cbx1.Name = "cbx1";
            this.cbx1.Size = new System.Drawing.Size(18, 17);
            this.cbx1.TabIndex = 32;
            this.cbx1.UseVisualStyleBackColor = true;
            this.cbx1.Visible = false;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(410, 43);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(125, 27);
            this.txtPrecio.TabIndex = 33;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(756, 46);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(151, 27);
            this.txt2.TabIndex = 34;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(756, 14);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(151, 27);
            this.txt1.TabIndex = 35;
            // 
            // FrmListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1272, 496);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.cbx1);
            this.Controls.Add(this.cmb2);
            this.Controls.Add(this.cmb1);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.cmbTag);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmListado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListado";
            this.Load += new System.EventHandler(this.FrmListado_Load);
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
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.ComboBox cmbTag;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.ComboBox cmb1;
        private System.Windows.Forms.ComboBox cmb2;
        private System.Windows.Forms.CheckBox cbx1;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
    }
}