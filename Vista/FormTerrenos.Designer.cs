namespace Vista
{
    partial class FormTerrenos
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtDireccion = new TextBox();
            txtTitular = new TextBox();
            txtCatastro = new TextBox();
            txtValorM2 = new TextBox();
            txtCantidadM2 = new TextBox();
            btnAgregar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(txtCantidadM2);
            groupBox1.Controls.Add(txtValorM2);
            groupBox1.Controls.Add(txtCatastro);
            groupBox1.Controls.Add(txtTitular);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(56, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(290, 344);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cargar Terreno";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 47);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Direccion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 87);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Titular";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 130);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Catastro";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 175);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 3;
            label4.Text = "Valor M2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 222);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 4;
            label5.Text = "Cantidad M2";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(149, 39);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(100, 23);
            txtDireccion.TabIndex = 5;
            // 
            // txtTitular
            // 
            txtTitular.Location = new Point(149, 79);
            txtTitular.Name = "txtTitular";
            txtTitular.Size = new Size(100, 23);
            txtTitular.TabIndex = 6;
            // 
            // txtCatastro
            // 
            txtCatastro.Location = new Point(149, 122);
            txtCatastro.Name = "txtCatastro";
            txtCatastro.Size = new Size(100, 23);
            txtCatastro.TabIndex = 7;
            // 
            // txtValorM2
            // 
            txtValorM2.Location = new Point(149, 167);
            txtValorM2.Name = "txtValorM2";
            txtValorM2.Size = new Size(100, 23);
            txtValorM2.TabIndex = 8;
            // 
            // txtCantidadM2
            // 
            txtCantidadM2.Location = new Point(149, 214);
            txtCantidadM2.Name = "txtCantidadM2";
            txtCantidadM2.Size = new Size(100, 23);
            txtCantidadM2.TabIndex = 9;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(102, 279);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 23);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // FormTerrenos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 450);
            Controls.Add(groupBox1);
            Name = "FormTerrenos";
            Text = "FormTerrenos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnAgregar;
        private TextBox txtCantidadM2;
        private TextBox txtValorM2;
        private TextBox txtCatastro;
        private TextBox txtTitular;
        private TextBox txtDireccion;
    }
}