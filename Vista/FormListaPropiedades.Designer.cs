namespace Vista
{
    partial class FormListaPropiedades
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
            groupBox1 = new GroupBox();
            dgvTerrenos = new DataGridView();
            groupBox2 = new GroupBox();
            dgvCasas = new DataGridView();
            groupBox3 = new GroupBox();
            dgvDepartamentos = new DataGridView();
            lblGastadoTerreno = new Label();
            lblGastadoCasas = new Label();
            lblGastadoDpto = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTerrenos).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCasas).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDepartamentos).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblGastadoTerreno);
            groupBox1.Controls.Add(dgvTerrenos);
            groupBox1.Location = new Point(47, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(419, 189);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista Terrenos";
            // 
            // dgvTerrenos
            // 
            dgvTerrenos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTerrenos.Location = new Point(44, 22);
            dgvTerrenos.Name = "dgvTerrenos";
            dgvTerrenos.Size = new Size(344, 124);
            dgvTerrenos.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblGastadoCasas);
            groupBox2.Controls.Add(dgvCasas);
            groupBox2.Location = new Point(47, 207);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(419, 180);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lista Casas";
            // 
            // dgvCasas
            // 
            dgvCasas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCasas.Location = new Point(44, 22);
            dgvCasas.Name = "dgvCasas";
            dgvCasas.Size = new Size(344, 124);
            dgvCasas.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblGastadoDpto);
            groupBox3.Controls.Add(dgvDepartamentos);
            groupBox3.Location = new Point(47, 393);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(419, 183);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Lista Departamentos";
            // 
            // dgvDepartamentos
            // 
            dgvDepartamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDepartamentos.Location = new Point(44, 17);
            dgvDepartamentos.Name = "dgvDepartamentos";
            dgvDepartamentos.Size = new Size(344, 124);
            dgvDepartamentos.TabIndex = 0;
            // 
            // lblGastadoTerreno
            // 
            lblGastadoTerreno.AutoSize = true;
            lblGastadoTerreno.Location = new Point(43, 160);
            lblGastadoTerreno.Name = "lblGastadoTerreno";
            lblGastadoTerreno.Size = new Size(0, 15);
            lblGastadoTerreno.TabIndex = 1;
            // 
            // lblGastadoCasas
            // 
            lblGastadoCasas.AutoSize = true;
            lblGastadoCasas.Location = new Point(50, 155);
            lblGastadoCasas.Name = "lblGastadoCasas";
            lblGastadoCasas.Size = new Size(0, 15);
            lblGastadoCasas.TabIndex = 1;
            // 
            // lblGastadoDpto
            // 
            lblGastadoDpto.AutoSize = true;
            lblGastadoDpto.Location = new Point(40, 156);
            lblGastadoDpto.Name = "lblGastadoDpto";
            lblGastadoDpto.Size = new Size(0, 15);
            lblGastadoDpto.TabIndex = 1;
            // 
            // FormListaPropiedades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 598);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormListaPropiedades";
            Text = "FormListaPropiedades";
            Load += FormListaPropiedades_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTerrenos).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCasas).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDepartamentos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgvTerrenos;
        private GroupBox groupBox2;
        private DataGridView dgvCasas;
        private GroupBox groupBox3;
        private DataGridView dgvDepartamentos;
        private Label lblGastadoTerreno;
        private Label lblGastadoCasas;
        private Label lblGastadoDpto;
    }
}