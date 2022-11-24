namespace Forms
{
    partial class FrmMostrar
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
            this.dgvMostrar = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbLapiz = new System.Windows.Forms.RadioButton();
            this.rbGoma = new System.Windows.Forms.RadioButton();
            this.rbSacapunta = new System.Windows.Forms.RadioButton();
            this.btnVolver = new System.Windows.Forms.Button();
            this.Serializar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Deserializar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMostrar
            // 
            this.dgvMostrar.AllowUserToAddRows = false;
            this.dgvMostrar.AllowUserToDeleteRows = false;
            this.dgvMostrar.AllowUserToResizeColumns = false;
            this.dgvMostrar.AllowUserToResizeRows = false;
            this.dgvMostrar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Serializar,
            this.btnBorrar,
            this.Deserializar});
            this.dgvMostrar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvMostrar.Location = new System.Drawing.Point(0, 116);
            this.dgvMostrar.Name = "dgvMostrar";
            this.dgvMostrar.ReadOnly = true;
            this.dgvMostrar.RowHeadersWidth = 51;
            this.dgvMostrar.RowTemplate.Height = 29;
            this.dgvMostrar.Size = new System.Drawing.Size(984, 334);
            this.dgvMostrar.TabIndex = 0;
            this.dgvMostrar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMostrar_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbLapiz);
            this.groupBox1.Controls.Add(this.rbGoma);
            this.groupBox1.Controls.Add(this.rbSacapunta);
            this.groupBox1.Location = new System.Drawing.Point(353, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 98);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione un util";
            // 
            // rbLapiz
            // 
            this.rbLapiz.AutoSize = true;
            this.rbLapiz.Location = new System.Drawing.Point(73, 74);
            this.rbLapiz.Name = "rbLapiz";
            this.rbLapiz.Size = new System.Drawing.Size(65, 24);
            this.rbLapiz.TabIndex = 2;
            this.rbLapiz.TabStop = true;
            this.rbLapiz.Text = "Lapiz";
            this.rbLapiz.UseVisualStyleBackColor = true;
            this.rbLapiz.CheckedChanged += new System.EventHandler(this.rbLapiz_CheckedChanged);
            // 
            // rbGoma
            // 
            this.rbGoma.AutoSize = true;
            this.rbGoma.Location = new System.Drawing.Point(73, 48);
            this.rbGoma.Name = "rbGoma";
            this.rbGoma.Size = new System.Drawing.Size(70, 24);
            this.rbGoma.TabIndex = 1;
            this.rbGoma.TabStop = true;
            this.rbGoma.Text = "Goma";
            this.rbGoma.UseVisualStyleBackColor = true;
            this.rbGoma.CheckedChanged += new System.EventHandler(this.rbGoma_CheckedChanged);
            // 
            // rbSacapunta
            // 
            this.rbSacapunta.AutoSize = true;
            this.rbSacapunta.Location = new System.Drawing.Point(73, 18);
            this.rbSacapunta.Name = "rbSacapunta";
            this.rbSacapunta.Size = new System.Drawing.Size(99, 24);
            this.rbSacapunta.TabIndex = 0;
            this.rbSacapunta.TabStop = true;
            this.rbSacapunta.Text = "Sacapunta";
            this.rbSacapunta.UseVisualStyleBackColor = true;
            this.rbSacapunta.CheckedChanged += new System.EventHandler(this.rbSacapunta_CheckedChanged);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.Control;
            this.btnVolver.Location = new System.Drawing.Point(725, 34);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(171, 50);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // Serializar
            // 
            this.Serializar.HeaderText = "Serializar";
            this.Serializar.MinimumWidth = 6;
            this.Serializar.Name = "Serializar";
            this.Serializar.ReadOnly = true;
            this.Serializar.Text = "Serializar en Xml y JSON";
            this.Serializar.UseColumnTextForButtonValue = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.HeaderText = "Borrar";
            this.btnBorrar.MinimumWidth = 6;
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.ReadOnly = true;
            this.btnBorrar.Text = "Borrar Util";
            // 
            // Deserializar
            // 
            this.Deserializar.HeaderText = "Deserializar";
            this.Deserializar.MinimumWidth = 6;
            this.Deserializar.Name = "Deserializar";
            this.Deserializar.ReadOnly = true;
            // 
            // FrmMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(984, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvMostrar);
            this.Name = "FrmMostrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMostrar";
            this.Load += new System.EventHandler(this.FrmMostrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMostrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbLapiz;
        private System.Windows.Forms.RadioButton rbGoma;
        private System.Windows.Forms.RadioButton rbSacapunta;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridViewButtonColumn Serializar;
        private System.Windows.Forms.DataGridViewButtonColumn btnBorrar;
        private System.Windows.Forms.DataGridViewButtonColumn Deserializar;
    }
}