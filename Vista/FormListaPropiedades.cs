using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FormListaPropiedades : Form
    {
        RepositorioPropiedades instRepo = RepositorioPropiedades.Instancia;
        public FormListaPropiedades()
        {
            InitializeComponent();
        }

        private void FormListaPropiedades_Load(object sender, EventArgs e)
        {
            dgvTerrenos.DataSource = null;
            dgvCasas.DataSource = null;
            dgvDepartamentos.DataSource = null;

            // Llenamos grillas
            dgvTerrenos.DataSource = instRepo.ListaTerrenos;
            dgvCasas.DataSource = instRepo.ListaCasa;
            dgvDepartamentos.DataSource = instRepo.ListaDepartamento;

            // Mostramos el total gastado por las compras
            lblGastadoTerreno.Text = "Total gastado: " + instRepo.TotalGastadoTerreno.ToString();
            lblGastadoCasas.Text = "Total gastado: " + instRepo.TotalGastadoCasas.ToString();
            lblGastadoDpto.Text = "Total gastado: " + instRepo.TotalGastadoDptos.ToString();
        }
    }
}
