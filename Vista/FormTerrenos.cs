using Controladora;
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
    public partial class FormTerrenos : Form
    {
        RepositorioPropiedades instRepo = RepositorioPropiedades.Instancia;
        GestorPropiedades instGestor = GestorPropiedades.Instancia;

        public FormTerrenos()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                // Agregamos un obj Terreno
                Terreno nuevoTerreno = new Terreno();
                nuevoTerreno.Direccion = txtDireccion.Text;
                nuevoTerreno.Titular = txtTitular.Text;
                nuevoTerreno.NCatastro = Convert.ToInt32(txtCatastro.Text);
                nuevoTerreno.CantidadM2 = Convert.ToDouble(txtCantidadM2.Text);
                nuevoTerreno.ValorM2 = Convert.ToDouble(txtValorM2.Text);

                var respuesta = instGestor.CrearPropiedad(nuevoTerreno, instRepo);
                MessageBox.Show(respuesta, "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Validacion de textBoxs
        public bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                string.IsNullOrWhiteSpace(txtTitular.Text) ||
                string.IsNullOrWhiteSpace(txtCatastro.Text) || !int.TryParse(txtCatastro.Text, out _) ||
                string.IsNullOrWhiteSpace(txtCantidadM2.Text) || !double.TryParse(txtCantidadM2.Text, out _) ||
                string.IsNullOrWhiteSpace(txtValorM2.Text) || !double.TryParse(txtValorM2.Text, out _) 
                )
            {
                MessageBox.Show("Campos invalidos", "Error de Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
