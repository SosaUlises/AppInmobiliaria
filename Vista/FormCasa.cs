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
    public partial class FormCasa : Form
    {
        RepositorioPropiedades instRepo = RepositorioPropiedades.Instancia;
        GestorPropiedades instGestor = GestorPropiedades.Instancia;
        public FormCasa()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                // Agregamos un obj Casa
                Casa nuevaCasa = new Casa();
                nuevaCasa.Direccion = txtDireccion.Text;
                nuevaCasa.Titular = txtTitular.Text;
                nuevaCasa.NCatastro = Convert.ToInt32(txtCatastro.Text);
                nuevaCasa.CantidadM2 = Convert.ToDouble(txtCantM2Terreno.Text);
                nuevaCasa.ValorM2 = Convert.ToDouble(txtValorM2Terreno.Text);
                nuevaCasa.ValorM2Construido = Convert.ToDouble(txtValorM2Construido.Text);
                nuevaCasa.CantidadM2Construido = Convert.ToDouble(txtCantidadM2Construido.Text);

                var respuesta = instGestor.CrearPropiedad(nuevaCasa, instRepo);
                MessageBox.Show(respuesta, "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Validacion de textBoxs
        public bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                string.IsNullOrWhiteSpace(txtTitular.Text) ||
                string.IsNullOrWhiteSpace(txtCatastro.Text) || !int.TryParse(txtCatastro.Text, out _) ||
                string.IsNullOrWhiteSpace(txtCantM2Terreno.Text) || !double.TryParse(txtCantM2Terreno.Text, out _) ||
                string.IsNullOrWhiteSpace(txtValorM2Terreno.Text) || !double.TryParse(txtValorM2Terreno.Text, out _) ||
                string.IsNullOrWhiteSpace(txtValorM2Construido.Text) || !double.TryParse(txtValorM2Construido.Text, out _) ||
                string.IsNullOrWhiteSpace(txtCantidadM2Construido.Text) || !double.TryParse(txtCantidadM2Construido.Text, out _)

                )
            {
                MessageBox.Show("Campos invalidos", "Error de Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
