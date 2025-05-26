namespace BancoSimpleProyecto
{
    partial class TransaccionForm
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
            btnsalir.Location = new Point(854, 568);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(112, 34);
            btnsalir.TabIndex = 1;
            btnsalir.Text = "Salir";
            btnsalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // TransaccionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 600);
            Controls.Add(btnsalir);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TransaccionForm";
            Text = "TransaccionForm";
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnsalir;
    }
}