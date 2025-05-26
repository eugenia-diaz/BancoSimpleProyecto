namespace BancoSimpleProyecto
{
    partial class ClienteForm
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
            btnsalir = new FontAwesome.Sharp.IconButton();
            dgvCliente = new DataGridView();
            dgvcuentas = new DataGridView();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvcuentas).BeginInit();
            SuspendLayout();
            // 
            // btnsalir
            // 
            btnsalir.FlatAppearance.BorderSize = 0;
            btnsalir.FlatStyle = FlatStyle.Flat;
            btnsalir.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            btnsalir.IconColor = Color.Black;
            btnsalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnsalir.IconSize = 35;
            btnsalir.Location = new Point(932, 647);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(112, 34);
            btnsalir.TabIndex = 1;
            btnsalir.Text = "Salir";
            btnsalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // dgvCliente
            // 
            dgvCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCliente.Location = new Point(27, 75);
            dgvCliente.Name = "dgvCliente";
            dgvCliente.RowHeadersWidth = 62;
            dgvCliente.Size = new Size(395, 454);
            dgvCliente.TabIndex = 2;
            // 
            // dgvcuentas
            // 
            dgvcuentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvcuentas.Location = new Point(594, 75);
            dgvcuentas.Name = "dgvcuentas";
            dgvcuentas.RowHeadersWidth = 62;
            dgvcuentas.Size = new Size(395, 454);
            dgvcuentas.TabIndex = 3;
            // 
            // iconButton1
            // 
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 35;
            iconButton1.Location = new Point(99, 535);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(214, 34);
            iconButton1.TabIndex = 4;
            iconButton1.Text = "Agregar cliente";
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // iconButton2
            // 
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 35;
            iconButton2.Location = new Point(680, 535);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(214, 34);
            iconButton2.TabIndex = 5;
            iconButton2.Text = "Agregar cuenta";
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // ClienteForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1046, 682);
            Controls.Add(iconButton2);
            Controls.Add(iconButton1);
            Controls.Add(dgvcuentas);
            Controls.Add(dgvCliente);
            Controls.Add(btnsalir);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ClienteForm";
            Text = "ClienteForm";
            ((System.ComponentModel.ISupportInitialize)dgvCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvcuentas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnsalir;
        private DataGridView dgvCliente;
        private DataGridView dgvcuentas;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}