namespace Vista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTerreno_Click(object sender, EventArgs e)
        {
            FormTerrenos form = new FormTerrenos();
            form.Show();
        }

        private void btnCasa_Click(object sender, EventArgs e)
        {
            FormCasa form = new FormCasa();
            form.Show();
        }

        private void btnDepartamento_Click(object sender, EventArgs e)
        {
            FormDepartamento form = new FormDepartamento();
            form.Show();
        }

        private void btnPropiedades_Click(object sender, EventArgs e)
        {
            FormListaPropiedades form = new FormListaPropiedades();
            form.Show();
        }
    }
}
