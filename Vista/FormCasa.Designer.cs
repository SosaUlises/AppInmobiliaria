namespace Vista
{
    partial class FormCasa
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
            label6 = new Label();
            label7 = new Label();
            txtDireccion = new TextBox();
            txtTitular = new TextBox();
            txtCatastro = new TextBox();
            txtCantM2Terreno = new TextBox();
            txtValorM2Terreno = new TextBox();
            txtCantidadM2Construido = new TextBox();
            txtValorM2Construido = new TextBox();
            btnAgregar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(txtValorM2Construido);
            groupBox1.Controls.Add(txtCantidadM2Construido);
            groupBox1.Controls.Add(txtValorM2Terreno);
            groupBox1.Controls.Add(txtCantM2Terreno);
            groupBox1.Controls.Add(txtCatastro);
            groupBox1.Controls.Add(txtTitular);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(48, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(356, 373);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Crear Casa";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 45);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Direccion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 86);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Titular";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 127);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Catastro";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 166);
            label4.Name = "label4";
            label4.Size = new Size(117, 15);
            label4.TabIndex = 3;
            label4.Text = "Cantidad M2 Terreno";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 206);
            label5.Name = "label5";
            label5.Size = new Size(95, 15);
            label5.TabIndex = 4;
            label5.Text = "Valor M2 Terreno";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(54, 250);
            label6.Name = "label6";
            label6.Size = new Size(137, 15);
            label6.TabIndex = 5;
            label6.Text = "Cantidad M2 Construido";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(56, 292);
            label7.Name = "label7";
            label7.Size = new Size(115, 15);
            label7.TabIndex = 6;
            label7.Text = "Valor M2 Construido";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(198, 37);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(100, 23);
            txtDireccion.TabIndex = 7;
            // 
            // txtTitular
            // 
            txtTitular.Location = new Point(198, 78);
            txtTitular.Name = "txtTitular";
            txtTitular.Size = new Size(100, 23);
            txtTitular.TabIndex = 8;
            // 
            // txtCatastro
            // 
            txtCatastro.Location = new Point(198, 119);
            txtCatastro.Name = "txtCatastro";
            txtCatastro.Size = new Size(100, 23);
            txtCatastro.TabIndex = 9;
            // 
            // txtCantM2Terreno
            // 
            txtCantM2Terreno.Location = new Point(198, 158);
            txtCantM2Terreno.Name = "txtCantM2Terreno";
            txtCantM2Terreno.Size = new Size(100, 23);
            txtCantM2Terreno.TabIndex = 10;
            // 
            // txtValorM2Terreno
            // 
            txtValorM2Terreno.Location = new Point(198, 197);
            txtValorM2Terreno.Name = "txtValorM2Terreno";
            txtValorM2Terreno.Size = new Size(100, 23);
            txtValorM2Terreno.TabIndex = 11;
            // 
            // txtCantidadM2Construido
            // 
            txtCantidadM2Construido.Location = new Point(198, 242);
            txtCantidadM2Construido.Name = "txtCantidadM2Construido";
            txtCantidadM2Construido.Size = new Size(100, 23);
            txtCantidadM2Construido.TabIndex = 12;
            // 
            // txtValorM2Construido
            // 
            txtValorM2Construido.Location = new Point(198, 284);
            txtValorM2Construido.Name = "txtValorM2Construido";
            txtValorM2Construido.Size = new Size(100, 23);
            txtValorM2Construido.TabIndex = 13;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(136, 334);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 23);
            btnAgregar.TabIndex = 14;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // FormCasa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 450);
            Controls.Add(groupBox1);
            Name = "FormCasa";
            Text = "FormCasa";
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
        private Label label7;
        private Label label6;
        private Button btnAgregar;
        private TextBox txtValorM2Construido;
        private TextBox txtCantidadM2Construido;
        private TextBox txtValorM2Terreno;
        private TextBox txtCantM2Terreno;
        private TextBox txtCatastro;
        private TextBox txtTitular;
        private TextBox txtDireccion;
    }
}