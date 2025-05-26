using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoSimpleProyecto
{
    public partial class TransaccionForm : Form
    {
        // Constructor del formulario
        public TransaccionForm()
        {
            InitializeComponent(); // Inicializa los componentes del formulario
            StartPosition = FormStartPosition.CenterScreen; // Centra el formulario en la pantalla al abrirse
        }

        // Evento que se dispara cuando se hace clic en el botón "Salir"
        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                // Intenta cerrar el formulario actual
                Close();
            }
            catch (Exception ex)
            {
                // Si ocurre un error al cerrar, muestra un mensaje detallado
                MessageBox.Show(
                    $"Error al cerrar el formulario: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
