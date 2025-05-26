using BancoSimpleProyecto.Models;
using System;
using System.Windows.Forms;

namespace BancoSimpleProyecto
{
    public partial class CuentaAgregarForm : Form
    {
        public CuentaClase NuevaCuenta { get; private set; }
        private readonly int _clienteId;

        public CuentaAgregarForm(int clienteId)
        {
            InitializeComponent();
            _clienteId = clienteId;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos())
                    return;

                NuevaCuenta = new CuentaClase
                {
                    NumeroCuenta = txtnumero.Text.Trim(),
                    Saldo = decimal.Parse(txtsaldo.Text),
                    ClienteId = _clienteId,
                    Activo = true
                };

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Formato de saldo inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar cuenta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if (string.IsNullOrWhiteSpace(txtnumero.Text))
            {
                errorProvider1.SetError(txtnumero, "El número de cuenta es obligatorio.");
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtsaldo.Text))
            {
                errorProvider1.SetError(txtsaldo, "El saldo es obligatorio.");
                esValido = false;
            }
            else if (!decimal.TryParse(txtsaldo.Text, out _))
            {
                errorProvider1.SetError(txtsaldo, "Ingrese un valor numérico válido.");
                esValido = false;
            }

            return esValido;
        }

        private void txtsaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarEntradaNumerica(e, txtsaldo);
        }

        private void ValidarEntradaNumerica(KeyPressEventArgs e, TextBox textBox)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == (char)Keys.Back)
            {
                if (e.KeyChar == '.' && textBox.Text.Contains("."))
                {
                    e.Handled = true;
                    MessageBox.Show("Solo se permite un punto decimal.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
