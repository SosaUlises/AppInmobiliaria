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
    public partial class FormDepartamento : Form
    {
        RepositorioPropiedades instRepo = RepositorioPropiedades.Instancia;
        GestorPropiedades instGestor = GestorPropiedades.Instancia;
        public FormDepartamento()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                // Agregamos un obj Departamento
                Departamento nuevoDpto = new Departamento();
                nuevoDpto.Direccion = txtDireccion.Text;
                nuevoDpto.Titular = txtTitular.Text;
                nuevoDpto.NCatastro = Convert.ToInt32(txtCatastro.Text);
                nuevoDpto.CantidadM2 = Convert.ToDouble(txtCantidadM2Terreno.Text);
                nuevoDpto.ValorM2 = Convert.ToDouble(txtValorM2Terreno.Text);
                nuevoDpto.Piso = Convert.ToInt32(txtPiso.Text);
                nuevoDpto.NumeroDepartamento = Convert.ToInt32(txtNDpto.Text);
                nuevoDpto.CostoConstruccion = Convert.ToDouble(txtCostoConstruccion.Text);

                var respuesta = instGestor.CrearPropiedad(nuevoDpto, instRepo);
                MessageBox.Show(respuesta, "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Validacion de textBoxs
        public bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                string.IsNullOrWhiteSpace(txtTitular.Text) ||
                string.IsNullOrWhiteSpace(txtCatastro.Text) || !int.TryParse(txtCatastro.Text, out _) ||
                string.IsNullOrWhiteSpace(txtCantidadM2Terreno.Text) || !double.TryParse(txtCantidadM2Terreno.Text, out _) ||
                string.IsNullOrWhiteSpace(txtValorM2Terreno.Text) || !double.TryParse(txtValorM2Terreno.Text, out _) ||
                string.IsNullOrWhiteSpace(txtPiso.Text) || !int.TryParse(txtPiso.Text, out _) ||
                string.IsNullOrWhiteSpace(txtNDpto.Text) || !int.TryParse(txtNDpto.Text, out _) ||
                string.IsNullOrWhiteSpace(txtCostoConstruccion.Text) || !double.TryParse(txtCostoConstruccion.Text, out _)

                )
            {
                MessageBox.Show("Campos invalidos", "Error de Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
