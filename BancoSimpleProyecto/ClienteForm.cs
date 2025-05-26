using BancoSimpleProyecto.Data;
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
    public partial class ClienteForm : Form
    {
        private BancoSimpleFreeContext db = new BancoSimpleFreeContext();
        public ClienteForm()
        {
            InitializeComponent();
            Cargar();
        }
        public void Cargar()
        {
            dgvCliente.DataSource = db.ClienteTabla.ToList();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            try
            {
                var form = new AgregarClienteForm_
                    ();
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)
                {
                    db.ClienteTabla.Add(form.c);
                    db.SaveChanges();
                    Cargar();
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
