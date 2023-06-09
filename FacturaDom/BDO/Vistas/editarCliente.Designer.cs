namespace FacturaDom.BDO.Vistas
{
    partial class editarCliente
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
            this.guardarUsuario = new MetroFramework.Controls.MetroTile();
            this.direccionText = new System.Windows.Forms.TextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.fechaNacimientoPicker = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.telefonoText = new System.Windows.Forms.MaskedTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.cedulaText = new System.Windows.Forms.MaskedTextBox();
            this.apellidosText = new System.Windows.Forms.TextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.nombresText = new System.Windows.Forms.TextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.referidoText = new MetroFramework.Controls.MetroLabel();
            this.referido = new System.Windows.Forms.MaskedTextBox();
            this.referidoBox = new MetroFramework.Controls.MetroCheckBox();
            this.SuspendLayout();
            // 
            // guardarUsuario
            // 
            this.guardarUsuario.ActiveControl = null;
            this.guardarUsuario.BackColor = System.Drawing.Color.SteelBlue;
            this.guardarUsuario.Location = new System.Drawing.Point(439, 468);
            this.guardarUsuario.Name = "guardarUsuario";
            this.guardarUsuario.Size = new System.Drawing.Size(105, 81);
            this.guardarUsuario.TabIndex = 53;
            this.guardarUsuario.Text = "Guardar\r\nCliente";
            this.guardarUsuario.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.guardarUsuario.UseCustomBackColor = true;
            this.guardarUsuario.UseSelectable = true;
            this.guardarUsuario.UseTileImage = true;
            this.guardarUsuario.UseVisualStyleBackColor = false;
            this.guardarUsuario.Click += new System.EventHandler(this.guardarUsuario_Click);
            // 
            // direccionText
            // 
            this.direccionText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.direccionText.Location = new System.Drawing.Point(39, 368);
            this.direccionText.Name = "direccionText";
            this.direccionText.Size = new System.Drawing.Size(505, 33);
            this.direccionText.TabIndex = 39;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroLabel9.Location = new System.Drawing.Point(39, 337);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(63, 19);
            this.metroLabel9.TabIndex = 51;
            this.metroLabel9.Text = "Direccion";
            // 
            // fechaNacimientoPicker
            // 
            this.fechaNacimientoPicker.FontSize = MetroFramework.MetroDateTimeSize.Tall;
            this.fechaNacimientoPicker.Location = new System.Drawing.Point(39, 265);
            this.fechaNacimientoPicker.MinimumSize = new System.Drawing.Size(0, 35);
            this.fechaNacimientoPicker.Name = "fechaNacimientoPicker";
            this.fechaNacimientoPicker.Size = new System.Drawing.Size(228, 35);
            this.fechaNacimientoPicker.TabIndex = 38;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroLabel8.Location = new System.Drawing.Point(39, 234);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(133, 19);
            this.metroLabel8.TabIndex = 50;
            this.metroLabel8.Text = "Fecha de Nacimiento";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroLabel7.Location = new System.Drawing.Point(316, 155);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(130, 19);
            this.metroLabel7.TabIndex = 49;
            this.metroLabel7.Text = "Numero de Telefono";
            // 
            // telefonoText
            // 
            this.telefonoText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.telefonoText.Location = new System.Drawing.Point(316, 186);
            this.telefonoText.Mask = "(000)-000-0000";
            this.telefonoText.Name = "telefonoText";
            this.telefonoText.Size = new System.Drawing.Size(228, 33);
            this.telefonoText.TabIndex = 37;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroLabel6.Location = new System.Drawing.Point(39, 155);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(50, 19);
            this.metroLabel6.TabIndex = 48;
            this.metroLabel6.Text = "Cedula";
            // 
            // cedulaText
            // 
            this.cedulaText.Enabled = false;
            this.cedulaText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cedulaText.Location = new System.Drawing.Point(39, 186);
            this.cedulaText.Mask = "000-0000000-0";
            this.cedulaText.Name = "cedulaText";
            this.cedulaText.Size = new System.Drawing.Size(228, 33);
            this.cedulaText.TabIndex = 36;
            // 
            // apellidosText
            // 
            this.apellidosText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.apellidosText.Location = new System.Drawing.Point(316, 108);
            this.apellidosText.Name = "apellidosText";
            this.apellidosText.Size = new System.Drawing.Size(228, 33);
            this.apellidosText.TabIndex = 34;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroLabel4.Location = new System.Drawing.Point(316, 77);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(63, 19);
            this.metroLabel4.TabIndex = 46;
            this.metroLabel4.Text = "Apellidos";
            // 
            // nombresText
            // 
            this.nombresText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nombresText.Location = new System.Drawing.Point(39, 108);
            this.nombresText.Name = "nombresText";
            this.nombresText.Size = new System.Drawing.Size(228, 33);
            this.nombresText.TabIndex = 33;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroLabel3.Location = new System.Drawing.Point(39, 77);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(68, 19);
            this.metroLabel3.TabIndex = 43;
            this.metroLabel3.Text = "Nombres ";
            // 
            // referidoText
            // 
            this.referidoText.AutoSize = true;
            this.referidoText.Enabled = false;
            this.referidoText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.referidoText.Location = new System.Drawing.Point(316, 234);
            this.referidoText.Name = "referidoText";
            this.referidoText.Size = new System.Drawing.Size(59, 19);
            this.referidoText.TabIndex = 54;
            this.referidoText.Text = "Referido";
            // 
            // referido
            // 
            this.referido.Enabled = false;
            this.referido.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.referido.Location = new System.Drawing.Point(316, 265);
            this.referido.Mask = "000-0000000-0";
            this.referido.Name = "referido";
            this.referido.Size = new System.Drawing.Size(228, 33);
            this.referido.TabIndex = 55;
            // 
            // referidoBox
            // 
            this.referidoBox.AutoSize = true;
            this.referidoBox.Enabled = false;
            this.referidoBox.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.referidoBox.Location = new System.Drawing.Point(316, 301);
            this.referidoBox.Name = "referidoBox";
            this.referidoBox.Size = new System.Drawing.Size(94, 25);
            this.referidoBox.TabIndex = 56;
            this.referidoBox.Text = "Referido";
            this.referidoBox.UseSelectable = true;
            // 
            // editarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 572);
            this.Controls.Add(this.referidoBox);
            this.Controls.Add(this.referido);
            this.Controls.Add(this.referidoText);
            this.Controls.Add(this.guardarUsuario);
            this.Controls.Add(this.direccionText);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.fechaNacimientoPicker);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.telefonoText);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.cedulaText);
            this.Controls.Add(this.apellidosText);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.nombresText);
            this.Controls.Add(this.metroLabel3);
            this.Name = "editarCliente";
            this.Text = "Editar Cliente";
            this.Load += new System.EventHandler(this.editarCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTile guardarUsuario;
        private TextBox direccionText;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroDateTime fechaNacimientoPicker;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MaskedTextBox telefonoText;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MaskedTextBox cedulaText;
        private TextBox apellidosText;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private TextBox nombresText;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel referidoText;
        private MaskedTextBox referido;
        private MetroFramework.Controls.MetroCheckBox referidoBox;

    }
}