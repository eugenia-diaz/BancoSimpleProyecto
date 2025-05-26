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
        private BancoSimpleFreeContext dbs = new BancoSimpleFreeContext();
        public ClienteForm()
        {
            InitializeComponent();
            Cargar();
        }
        public void Cargar()
        {
            dgvCliente.DataSource = dbs.ClienteTabla.ToList();
            dgvcuentas.DataSource = dbs.CuentaTabla.ToList();   
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

                    dbs.ClienteTabla.Add(form.c);

                    dbs.SaveChanges();
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

        private void btnborrar_Click(object sender, EventArgs e)
        {
            try
            {

                if (dgvCliente.CurrentRow != null)
                {

                    int id = (int)dgvCliente.CurrentRow.Cells["ClienteId"].Value;

                    var encontrado = dbs.ClienteTabla.Find(id);
                    if (encontrado != null)
                    {
                        dbs.ClienteTabla.Remove(encontrado); dbs.SaveChanges();
                        Cargar();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar.", "Seleccione un cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {

           

                if(dgvCliente.SelectedRows.Count == 0)
                {
                   
                        MessageBox.Show("No se pudo crear", "Seleccione un cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    if (dgvCliente.CurrentRow != null)
                    {
                        int id = (int)dgvCliente.CurrentRow.Cells["ClienteId"].Value;
                        var form = new CuentaAgregarForm(id);
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            dbs.CuentaTabla.Add(form.NuevaCuenta);
                            dbs.SaveChanges();
                            Cargar();
                        }
                    }
                  
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
 
