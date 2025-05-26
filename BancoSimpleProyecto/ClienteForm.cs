using BancoSimpleProyecto.Data;
using BancoSimpleProyecto.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BancoSimpleProyecto
{
    public partial class ClienteForm : Form
    {
        public ClienteForm()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            using var contexto = new BancoSimpleFreeContext();
            dgvCliente.DataSource = contexto.ClienteTabla.ToList();
            dgvcuentas.DataSource = contexto.CuentasTabla.ToList();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                using var form = new AgregarClienteForm();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    using var contexto = new BancoSimpleFreeContext();
                    contexto.ClienteTabla.Add(form.Cliente);
                    contexto.SaveChanges();
                    CargarDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                var cliente = ObtenerClienteSeleccionado();
                if (cliente == null)
                {
                    MessageBox.Show("Seleccione un cliente válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using var contexto = new BancoSimpleFreeContext();
                contexto.ClienteTabla.Remove(cliente);
                contexto.SaveChanges();
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private ClienteClase ObtenerClienteSeleccionado()
        {
            if (dgvCliente.CurrentRow == null)
                return null;

            var id = (int)dgvCliente.CurrentRow.Cells["ClienteId"].Value;

            using var contexto = new BancoSimpleFreeContext();
            return contexto.ClienteTabla.Find(id);
        }

        private void btnAgregarCuenta_Click(object sender, EventArgs e)
        {
            try
            {
                var cliente = ObtenerClienteSeleccionado();
                if (cliente == null)
                {
                    MessageBox.Show("Seleccione un cliente antes de agregar una cuenta.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using var form = new CuentaAgregarForm(cliente.ClienteId);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    using var contexto = new BancoSimpleFreeContext();
                    contexto.CuentasTabla.Add(form.NuevaCuenta);
                    contexto.SaveChanges();
                    CargarDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar cuenta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

         
