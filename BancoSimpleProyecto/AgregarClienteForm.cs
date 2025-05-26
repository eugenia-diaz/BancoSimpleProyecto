
using BancoSimpleProyecto.Data;

using BancoSimpleProyecto.Models;
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
    public partial class AgregarClienteForm_ : Form
    {

        public ClienteClase c { get; set; }
      
       
        public AgregarClienteForm_()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        //utilizaomos una herramienta de nuestro cuadro de herramientas errorprovider para que el usuario sepa cuales txtbox no dejar en blanco
        //asi mismo, al utilizar el bool no deja que el usuario pase hasta llenar los campos
        public bool ValidarTextBox()
        {
            bool vali = true;

            if (txtnombre.Text == string.Empty)
            {
                vali = false;
                errorProvider1.SetError(txtnombre, "Llene el campo");

            }
            if (txtidentificacion.Text == string.Empty)
            {
                vali = false;
                errorProvider1.SetError(txtidentificacion, "Llene el campo");

            }
            return vali;



        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {


                if (ValidarTextBox())
                {

                    c = new ClienteClase
                    {
                        Nombre = txtnombre.Text,
                        Identificacion = txtidentificacion.Text
                    };

               
                    DialogResult = DialogResult.OK;
                    Close();


                }






            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
             
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            try
            {



                MessageBox.Show("Cancelado", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
