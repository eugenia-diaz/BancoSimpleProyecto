
using BancoSimpleProyecto.Models;
using System;
using System.Windows.Forms;

namespace BancoSimpleProyecto
{
    public partial class AgregarClienteForm : Form
    {
        public ClienteClase Cliente { get; private set; }

        public AgregarClienteForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos())
                    return;

                Cliente = new ClienteClase
                {
                    Nombre = txtnombre.Text.Trim(),
                    Identificacion = txtidentificacion.Text.Trim()
                };

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool ValidarCampos()
        {
            errorProvider1.Clear();
            bool esValido = true;

            if (string.IsNullOrWhiteSpace(txtnombre.Text))
            {
                errorProvider1.SetError(txtnombre, "El nombre es obligatorio.");
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtidentificacion.Text))
            {
                errorProvider1.SetError(txtidentificacion, "La identificación es obligatoria.");
                esValido = false;
            }

            return esValido;
        }
    }
}
