namespace BancoSimpleProyecto
{
    public partial class BancoForm : Form
    {
        public BancoForm()
        {
            InitializeComponent();
        }

        private Form activo = null;

        private void Abrir(Form nuevo)
        {
            if (activo != null)
            {

                if (activo.GetType() != nuevo.GetType())
                {
                    activo.Close();
                    activo.Dispose();
                }


            }

            activo = nuevo;
            activo.TopLevel = false;
            activo.FormBorderStyle = FormBorderStyle.None;
            activo.Dock = DockStyle.Fill;

            panelBanco.Controls.Clear();
            panelBanco.Controls.Add(activo);
            activo.BringToFront();
            activo.Show();




        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            try
            {
                var clienteF = new ClienteForm();
                Abrir(clienteF);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message
                    );
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            try
            {
                var transaccionf = new TransaccionForm();
                Abrir(transaccionf);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message
                    );
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
