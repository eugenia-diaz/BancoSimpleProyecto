using System;
using System.Windows.Forms;

namespace BancoSimpleProyecto
{
    public partial class BancoForm : Form
    {
        private Form _formActivo;

        public BancoForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void AbrirFormulario(Form nuevoFormulario)
        {
            if (_formActivo != null && _formActivo.GetType() != nuevoFormulario.GetType())
            {
                _formActivo.Close();
                _formActivo.Dispose();
            }

            _formActivo = nuevoFormulario;
            _formActivo.TopLevel = false;
            _formActivo.FormBorderStyle = FormBorderStyle.None;
            _formActivo.Dock = DockStyle.Fill;

            panelBanco.Controls.Clear();
            panelBanco.Controls.Add(_formActivo);
            _formActivo.BringToFront();
            _formActivo.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirFormulario(new ClienteForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir formulario de clientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTransacciones_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirFormulario(new TransaccionForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir formulario de transacciones: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

