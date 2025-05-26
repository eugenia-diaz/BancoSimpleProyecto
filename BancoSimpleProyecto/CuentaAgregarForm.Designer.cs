namespace BancoSimpleProyecto
{
    partial class CuentaAgregarForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            btncancelar = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            txtnumero = new TextBox();
            label2 = new Label();
            txtsaldo = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.Check;
            btnAgregar.IconColor = Color.Black;
            btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregar.IconSize = 35;
            btnAgregar.Location = new Point(12, 289);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(172, 34);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btncancelar
            // 
            btncancelar.FlatAppearance.BorderSize = 0;
            btncancelar.FlatStyle = FlatStyle.Flat;
            btncancelar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btncancelar.IconColor = Color.Black;
            btncancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btncancelar.IconSize = 30;
            btncancelar.Location = new Point(347, 289);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(172, 34);
            btncancelar.TabIndex = 6;
            btncancelar.Text = "Cancelar";
            btncancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btncancelar.UseVisualStyleBackColor = true;
            btncancelar.Click += btncancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 40);
            label1.Name = "label1";
            label1.Size = new Size(134, 25);
            label1.TabIndex = 7;
            label1.Text = "Numero cuenta";
            // 
            // txtnumero
            // 
            txtnumero.Location = new Point(236, 40);
            txtnumero.Name = "txtnumero";
            txtnumero.Size = new Size(223, 31);
            txtnumero.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 157);
            label2.Name = "label2";
            label2.Size = new Size(57, 25);
            label2.TabIndex = 9;
            label2.Text = "Saldo";
            // 
            // txtsaldo
            // 
            txtsaldo.Location = new Point(236, 154);
            txtsaldo.Name = "txtsaldo";
            txtsaldo.Size = new Size(223, 31);
            txtsaldo.TabIndex = 10;
            txtsaldo.KeyPress += txtsaldo_KeyPress;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // CuentaAgregarForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(543, 335);
            Controls.Add(txtsaldo);
            Controls.Add(label2);
            Controls.Add(txtnumero);
            Controls.Add(label1);
            Controls.Add(btncancelar);
            Controls.Add(btnAgregar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CuentaAgregarForm";
            Text = "CuentaAgregarForm";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnAgregar;
        private FontAwesome.Sharp.IconButton btncancelar;
        private Label label1;
        private TextBox txtnumero;
        private Label label2;
        private TextBox txtsaldo;
        private ErrorProvider errorProvider1;
    }
}