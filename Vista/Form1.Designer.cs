namespace Vista
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnTerreno = new Button();
            btnCasa = new Button();
            btnDepartamento = new Button();
            btnPropiedades = new Button();
            SuspendLayout();
            // 
            // btnTerreno
            // 
            btnTerreno.Location = new Point(55, 43);
            btnTerreno.Name = "btnTerreno";
            btnTerreno.Size = new Size(157, 23);
            btnTerreno.TabIndex = 0;
            btnTerreno.Text = "Cargar Terreno";
            btnTerreno.UseVisualStyleBackColor = true;
            btnTerreno.Click += btnTerreno_Click;
            // 
            // btnCasa
            // 
            btnCasa.Location = new Point(55, 95);
            btnCasa.Name = "btnCasa";
            btnCasa.Size = new Size(157, 23);
            btnCasa.TabIndex = 1;
            btnCasa.Text = "Cargar Casa";
            btnCasa.UseVisualStyleBackColor = true;
            btnCasa.Click += btnCasa_Click;
            // 
            // btnDepartamento
            // 
            btnDepartamento.Location = new Point(55, 144);
            btnDepartamento.Name = "btnDepartamento";
            btnDepartamento.Size = new Size(157, 23);
            btnDepartamento.TabIndex = 2;
            btnDepartamento.Text = "Cargar departamento";
            btnDepartamento.UseVisualStyleBackColor = true;
            btnDepartamento.Click += btnDepartamento_Click;
            // 
            // btnPropiedades
            // 
            btnPropiedades.Location = new Point(55, 194);
            btnPropiedades.Name = "btnPropiedades";
            btnPropiedades.Size = new Size(157, 23);
            btnPropiedades.TabIndex = 3;
            btnPropiedades.Text = "Listado de propiedades";
            btnPropiedades.UseVisualStyleBackColor = true;
            btnPropiedades.Click += btnPropiedades_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(271, 262);
            Controls.Add(btnPropiedades);
            Controls.Add(btnDepartamento);
            Controls.Add(btnCasa);
            Controls.Add(btnTerreno);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnTerreno;
        private Button btnCasa;
        private Button btnDepartamento;
        private Button btnPropiedades;
    }
}
