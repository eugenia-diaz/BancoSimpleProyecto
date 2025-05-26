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
    public partial class CuentaAgregarForm : Form
    {
        public CuentaClase NuevaCuenta { get; set; }
        private int _clienteId;
        public CuentaAgregarForm(int clienteId)
        {
            InitializeComponent();
            _clienteId = clienteId;
            this.StartPosition = FormStartPosition.CenterScreen;    
        }
        public bool ValidarTextBox()
        {
            bool vali = true;

            if (txtnumero.Text == string.Empty)
            {
                vali = false;
                errorProvider1.SetError(txtnumero, "Llene el campo");

            }
            if (txtsaldo.Text == string.Empty)
            {
                vali = false;
                errorProvider1.SetError(txtsaldo, "Llene el campo");

            }
            return vali;



        }
        public void ValidarEntrada(KeyPressEventArgs e, TextBox t)

        {
            switch (e.KeyChar)
            {
                case char c when char.IsDigit(c):
                    if (c == '0' && string.IsNullOrEmpty(t.Text))
                    {
                        e.Handled = true;
                        MessageBox.Show("Intentelo de nuevo", "Caracter inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return;

                case '.':
                    if (!t.Text.Contains(".") && (t.Text.Length > 0 || t.Text == "0"))
                    {
                        return;
                    }
                    e.Handled = true;
                    MessageBox.Show("Intentelo de nuevo", "Caracter inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                case (char)Keys.Back:
                    return;

                default:
                    e.Handled = true;
                    MessageBox.Show("Intentelo de nuevo", "Caracter inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarTextBox())
                {
                    NuevaCuenta = new CuentaClase
                    {
                        NumeroCuenta = txtnumero.Text,
                        Saldo = decimal.Parse(txtsaldo.Text),
                        ClienteId = _clienteId,
                        Activo = true


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

        private void txtsaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarEntrada(e, txtsaldo);
        }
    }
}
