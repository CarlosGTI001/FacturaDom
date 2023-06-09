namespace FacturaDom.BDO.Vistas
{
    partial class agregarCliente
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
            guardarUsuario = new MetroFramework.Controls.MetroTile();
            direccionText = new TextBox();
            metroLabel9 = new MetroFramework.Controls.MetroLabel();
            fechaNacimientoPicker = new MetroFramework.Controls.MetroDateTime();
            metroLabel8 = new MetroFramework.Controls.MetroLabel();
            metroLabel7 = new MetroFramework.Controls.MetroLabel();
            telefonoText = new MaskedTextBox();
            metroLabel6 = new MetroFramework.Controls.MetroLabel();
            cedulaText = new MaskedTextBox();
            apellidosText = new TextBox();
            metroLabel4 = new MetroFramework.Controls.MetroLabel();
            nombresText = new TextBox();
            metroLabel3 = new MetroFramework.Controls.MetroLabel();
            referidoText = new MetroFramework.Controls.MetroLabel();
            referido = new MaskedTextBox();
            referidoBox = new MetroFramework.Controls.MetroCheckBox();
            SuspendLayout();
            // 
            // guardarUsuario
            // 
            guardarUsuario.ActiveControl = null;
            guardarUsuario.BackColor = Color.SteelBlue;
            guardarUsuario.Location = new Point(439, 468);
            guardarUsuario.Name = "guardarUsuario";
            guardarUsuario.Size = new Size(105, 81);
            guardarUsuario.TabIndex = 53;
            guardarUsuario.Text = "Guardar\r\nCliente";
            guardarUsuario.TileImageAlign = ContentAlignment.TopRight;
            guardarUsuario.UseCustomBackColor = true;
            guardarUsuario.UseSelectable = true;
            guardarUsuario.UseTileImage = true;
            guardarUsuario.UseVisualStyleBackColor = false;
            guardarUsuario.Click += guardarUsuario_Click;
            // 
            // direccionText
            // 
            direccionText.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            direccionText.Location = new Point(39, 368);
            direccionText.Name = "direccionText";
            direccionText.Size = new Size(505, 33);
            direccionText.TabIndex = 39;
            // 
            // metroLabel9
            // 
            metroLabel9.AutoSize = true;
            metroLabel9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            metroLabel9.Location = new Point(39, 337);
            metroLabel9.Name = "metroLabel9";
            metroLabel9.Size = new Size(63, 19);
            metroLabel9.TabIndex = 51;
            metroLabel9.Text = "Direccion";
            // 
            // fechaNacimientoPicker
            // 
            fechaNacimientoPicker.FontSize = MetroFramework.MetroDateTimeSize.Tall;
            fechaNacimientoPicker.Location = new Point(39, 265);
            fechaNacimientoPicker.MinimumSize = new Size(0, 35);
            fechaNacimientoPicker.Name = "fechaNacimientoPicker";
            fechaNacimientoPicker.Size = new Size(228, 35);
            fechaNacimientoPicker.TabIndex = 38;
            // 
            // metroLabel8
            // 
            metroLabel8.AutoSize = true;
            metroLabel8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            metroLabel8.Location = new Point(39, 234);
            metroLabel8.Name = "metroLabel8";
            metroLabel8.Size = new Size(133, 19);
            metroLabel8.TabIndex = 50;
            metroLabel8.Text = "Fecha de Nacimiento";
            // 
            // metroLabel7
            // 
            metroLabel7.AutoSize = true;
            metroLabel7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            metroLabel7.Location = new Point(316, 155);
            metroLabel7.Name = "metroLabel7";
            metroLabel7.Size = new Size(130, 19);
            metroLabel7.TabIndex = 49;
            metroLabel7.Text = "Numero de Telefono";
            // 
            // telefonoText
            // 
            telefonoText.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            telefonoText.Location = new Point(316, 186);
            telefonoText.Mask = "(000)-000-0000";
            telefonoText.Name = "telefonoText";
            telefonoText.Size = new Size(228, 33);
            telefonoText.TabIndex = 37;
            // 
            // metroLabel6
            // 
            metroLabel6.AutoSize = true;
            metroLabel6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            metroLabel6.Location = new Point(39, 155);
            metroLabel6.Name = "metroLabel6";
            metroLabel6.Size = new Size(50, 19);
            metroLabel6.TabIndex = 48;
            metroLabel6.Text = "Cedula";
            // 
            // cedulaText
            // 
            cedulaText.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cedulaText.Location = new Point(39, 186);
            cedulaText.Mask = "000-0000000-0";
            cedulaText.Name = "cedulaText";
            cedulaText.Size = new Size(228, 33);
            cedulaText.TabIndex = 36;
            // 
            // apellidosText
            // 
            apellidosText.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            apellidosText.Location = new Point(316, 108);
            apellidosText.Name = "apellidosText";
            apellidosText.Size = new Size(228, 33);
            apellidosText.TabIndex = 34;
            // 
            // metroLabel4
            // 
            metroLabel4.AutoSize = true;
            metroLabel4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            metroLabel4.Location = new Point(316, 77);
            metroLabel4.Name = "metroLabel4";
            metroLabel4.Size = new Size(63, 19);
            metroLabel4.TabIndex = 46;
            metroLabel4.Text = "Apellidos";
            // 
            // nombresText
            // 
            nombresText.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            nombresText.Location = new Point(39, 108);
            nombresText.Name = "nombresText";
            nombresText.Size = new Size(228, 33);
            nombresText.TabIndex = 33;
            // 
            // metroLabel3
            // 
            metroLabel3.AutoSize = true;
            metroLabel3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            metroLabel3.Location = new Point(39, 77);
            metroLabel3.Name = "metroLabel3";
            metroLabel3.Size = new Size(68, 19);
            metroLabel3.TabIndex = 43;
            metroLabel3.Text = "Nombres ";
            // 
            // referidoText
            // 
            referidoText.AutoSize = true;
            referidoText.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            referidoText.Location = new Point(316, 234);
            referidoText.Name = "referidoText";
            referidoText.Size = new Size(59, 19);
            referidoText.TabIndex = 54;
            referidoText.Text = "Referido";
            // 
            // referido
            // 
            referido.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            referido.Location = new Point(316, 265);
            referido.Mask = "000-0000000-0";
            referido.Name = "referido";
            referido.Size = new Size(228, 33);
            referido.TabIndex = 55;
            // 
            // referidoBox
            // 
            referidoBox.AutoSize = true;
            referidoBox.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            referidoBox.Location = new Point(316, 301);
            referidoBox.Name = "referidoBox";
            referidoBox.Size = new Size(94, 25);
            referidoBox.TabIndex = 56;
            referidoBox.Text = "Referido";
            referidoBox.UseSelectable = true;
            referidoBox.CheckedChanged += referidoBox_CheckedChanged;
            // 
            // agregarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 572);
            Controls.Add(referidoBox);
            Controls.Add(referido);
            Controls.Add(referidoText);
            Controls.Add(guardarUsuario);
            Controls.Add(direccionText);
            Controls.Add(metroLabel9);
            Controls.Add(fechaNacimientoPicker);
            Controls.Add(metroLabel8);
            Controls.Add(metroLabel7);
            Controls.Add(telefonoText);
            Controls.Add(metroLabel6);
            Controls.Add(cedulaText);
            Controls.Add(apellidosText);
            Controls.Add(metroLabel4);
            Controls.Add(nombresText);
            Controls.Add(metroLabel3);
            Name = "agregarCliente";
            Text = "Nuevo Cliente";
            Load += agregarCliente_Load;
            ResumeLayout(false);
            PerformLayout();
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