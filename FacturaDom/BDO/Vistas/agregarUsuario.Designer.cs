namespace FacturaDom.BDO.Vistas
{
    partial class agregarUsuario
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
            nombresText = new TextBox();
            metroLabel3 = new MetroFramework.Controls.MetroLabel();
            contrasenaText = new TextBox();
            metroLabel2 = new MetroFramework.Controls.MetroLabel();
            userText = new TextBox();
            metroLabel1 = new MetroFramework.Controls.MetroLabel();
            apellidosText = new TextBox();
            metroLabel4 = new MetroFramework.Controls.MetroLabel();
            metroLabel5 = new MetroFramework.Controls.MetroLabel();
            tipoUsuarioCbx = new MetroFramework.Controls.MetroComboBox();
            cedulaText = new MaskedTextBox();
            metroLabel6 = new MetroFramework.Controls.MetroLabel();
            metroLabel7 = new MetroFramework.Controls.MetroLabel();
            telefonoText = new MaskedTextBox();
            metroLabel8 = new MetroFramework.Controls.MetroLabel();
            fechaNacimientoPicker = new MetroFramework.Controls.MetroDateTime();
            direccionText = new TextBox();
            metroLabel9 = new MetroFramework.Controls.MetroLabel();
            codigoText = new TextBox();
            metroLabel10 = new MetroFramework.Controls.MetroLabel();
            generarCredenciales = new MetroFramework.Controls.MetroTile();
            guardarUsuario = new MetroFramework.Controls.MetroTile();
            SuspendLayout();
            // 
            // nombresText
            // 
            nombresText.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            nombresText.Location = new Point(39, 114);
            nombresText.Name = "nombresText";
            nombresText.Size = new Size(228, 33);
            nombresText.TabIndex = 1;
            // 
            // metroLabel3
            // 
            metroLabel3.AutoSize = true;
            metroLabel3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            metroLabel3.Location = new Point(39, 83);
            metroLabel3.Name = "metroLabel3";
            metroLabel3.Size = new Size(68, 19);
            metroLabel3.TabIndex = 12;
            metroLabel3.Text = "Nombres ";
            // 
            // contrasenaText
            // 
            contrasenaText.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            contrasenaText.Location = new Point(39, 496);
            contrasenaText.Name = "contrasenaText";
            contrasenaText.PasswordChar = '*';
            contrasenaText.Size = new Size(228, 33);
            contrasenaText.TabIndex = 10;
            // 
            // metroLabel2
            // 
            metroLabel2.AutoSize = true;
            metroLabel2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            metroLabel2.Location = new Point(39, 465);
            metroLabel2.Name = "metroLabel2";
            metroLabel2.Size = new Size(75, 19);
            metroLabel2.TabIndex = 16;
            metroLabel2.Text = "Contrasena";
            // 
            // userText
            // 
            userText.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            userText.Location = new Point(39, 420);
            userText.Name = "userText";
            userText.Size = new Size(228, 33);
            userText.TabIndex = 8;
            // 
            // metroLabel1
            // 
            metroLabel1.AutoSize = true;
            metroLabel1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            metroLabel1.Location = new Point(39, 389);
            metroLabel1.Name = "metroLabel1";
            metroLabel1.Size = new Size(126, 19);
            metroLabel1.TabIndex = 14;
            metroLabel1.Text = "Nombre de Usuario";
            // 
            // apellidosText
            // 
            apellidosText.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            apellidosText.Location = new Point(316, 114);
            apellidosText.Name = "apellidosText";
            apellidosText.Size = new Size(228, 33);
            apellidosText.TabIndex = 2;
            // 
            // metroLabel4
            // 
            metroLabel4.AutoSize = true;
            metroLabel4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            metroLabel4.Location = new Point(316, 83);
            metroLabel4.Name = "metroLabel4";
            metroLabel4.Size = new Size(63, 19);
            metroLabel4.TabIndex = 18;
            metroLabel4.Text = "Apellidos";
            // 
            // metroLabel5
            // 
            metroLabel5.AutoSize = true;
            metroLabel5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            metroLabel5.Location = new Point(39, 159);
            metroLabel5.Name = "metroLabel5";
            metroLabel5.Size = new Size(102, 19);
            metroLabel5.TabIndex = 19;
            metroLabel5.Text = "Tipo de Usuario";
            // 
            // tipoUsuarioCbx
            // 
            tipoUsuarioCbx.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            tipoUsuarioCbx.FormattingEnabled = true;
            tipoUsuarioCbx.ItemHeight = 29;
            tipoUsuarioCbx.Items.AddRange(new object[] { "Elegir uno...", "Administrador", "Usuario" });
            tipoUsuarioCbx.Location = new Point(39, 190);
            tipoUsuarioCbx.Name = "tipoUsuarioCbx";
            tipoUsuarioCbx.Size = new Size(228, 35);
            tipoUsuarioCbx.TabIndex = 3;
            tipoUsuarioCbx.UseSelectable = true;
            // 
            // cedulaText
            // 
            cedulaText.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cedulaText.Location = new Point(316, 190);
            cedulaText.Mask = "000-0000000-0";
            cedulaText.Name = "cedulaText";
            cedulaText.Size = new Size(228, 33);
            cedulaText.TabIndex = 4;
            // 
            // metroLabel6
            // 
            metroLabel6.AutoSize = true;
            metroLabel6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            metroLabel6.Location = new Point(316, 159);
            metroLabel6.Name = "metroLabel6";
            metroLabel6.Size = new Size(50, 19);
            metroLabel6.TabIndex = 22;
            metroLabel6.Text = "Cedula";
            // 
            // metroLabel7
            // 
            metroLabel7.AutoSize = true;
            metroLabel7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            metroLabel7.Location = new Point(39, 237);
            metroLabel7.Name = "metroLabel7";
            metroLabel7.Size = new Size(130, 19);
            metroLabel7.TabIndex = 24;
            metroLabel7.Text = "Numero de Telefono";
            // 
            // telefonoText
            // 
            telefonoText.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            telefonoText.Location = new Point(39, 268);
            telefonoText.Mask = "(000)-000-0000";
            telefonoText.Name = "telefonoText";
            telefonoText.Size = new Size(228, 33);
            telefonoText.TabIndex = 5;
            // 
            // metroLabel8
            // 
            metroLabel8.AutoSize = true;
            metroLabel8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            metroLabel8.Location = new Point(316, 237);
            metroLabel8.Name = "metroLabel8";
            metroLabel8.Size = new Size(133, 19);
            metroLabel8.TabIndex = 25;
            metroLabel8.Text = "Fecha de Nacimiento";
            // 
            // fechaNacimientoPicker
            // 
            fechaNacimientoPicker.FontSize = MetroFramework.MetroDateTimeSize.Tall;
            fechaNacimientoPicker.Location = new Point(316, 268);
            fechaNacimientoPicker.MinimumSize = new Size(0, 35);
            fechaNacimientoPicker.Name = "fechaNacimientoPicker";
            fechaNacimientoPicker.Size = new Size(228, 35);
            fechaNacimientoPicker.TabIndex = 6;
            fechaNacimientoPicker.ValueChanged += fechaNacimientoPicker_ValueChanged;
            // 
            // direccionText
            // 
            direccionText.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            direccionText.Location = new Point(39, 344);
            direccionText.Name = "direccionText";
            direccionText.Size = new Size(505, 33);
            direccionText.TabIndex = 7;
            // 
            // metroLabel9
            // 
            metroLabel9.AutoSize = true;
            metroLabel9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            metroLabel9.Location = new Point(39, 313);
            metroLabel9.Name = "metroLabel9";
            metroLabel9.Size = new Size(63, 19);
            metroLabel9.TabIndex = 28;
            metroLabel9.Text = "Direccion";
            // 
            // codigoText
            // 
            codigoText.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            codigoText.Location = new Point(316, 420);
            codigoText.Name = "codigoText";
            codigoText.Size = new Size(228, 33);
            codigoText.TabIndex = 9;
            // 
            // metroLabel10
            // 
            metroLabel10.AutoSize = true;
            metroLabel10.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            metroLabel10.Location = new Point(316, 389);
            metroLabel10.Name = "metroLabel10";
            metroLabel10.Size = new Size(120, 19);
            metroLabel10.TabIndex = 30;
            metroLabel10.Text = "Codigo de Usuario";
            // 
            // generarCredenciales
            // 
            generarCredenciales.ActiveControl = null;
            generarCredenciales.BackColor = Color.SteelBlue;
            generarCredenciales.BackgroundImageLayout = ImageLayout.Stretch;
            generarCredenciales.Location = new Point(316, 465);
            generarCredenciales.Name = "generarCredenciales";
            generarCredenciales.Size = new Size(105, 81);
            generarCredenciales.TabIndex = 32;
            generarCredenciales.Text = "Generar\r\nCredenciales";
            generarCredenciales.TileImageAlign = ContentAlignment.TopRight;
            generarCredenciales.UseCustomBackColor = true;
            generarCredenciales.UseSelectable = true;
            generarCredenciales.UseTileImage = true;
            generarCredenciales.UseVisualStyleBackColor = false;
            generarCredenciales.Click += generarCredenciales_Click;
            // 
            // guardarUsuario
            // 
            guardarUsuario.ActiveControl = null;
            guardarUsuario.BackColor = Color.SteelBlue;
            guardarUsuario.Location = new Point(439, 465);
            guardarUsuario.Name = "guardarUsuario";
            guardarUsuario.Size = new Size(105, 81);
            guardarUsuario.TabIndex = 31;
            guardarUsuario.Text = "Guardar\r\nUsuario";
            guardarUsuario.TileImageAlign = ContentAlignment.TopRight;
            guardarUsuario.UseCustomBackColor = true;
            guardarUsuario.UseSelectable = true;
            guardarUsuario.UseTileImage = true;
            guardarUsuario.UseVisualStyleBackColor = false;
            guardarUsuario.Click += guardarUsuario_Click;
            // 
            // agregarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 572);
            Controls.Add(generarCredenciales);
            Controls.Add(guardarUsuario);
            Controls.Add(codigoText);
            Controls.Add(metroLabel10);
            Controls.Add(direccionText);
            Controls.Add(metroLabel9);
            Controls.Add(fechaNacimientoPicker);
            Controls.Add(metroLabel8);
            Controls.Add(metroLabel7);
            Controls.Add(telefonoText);
            Controls.Add(metroLabel6);
            Controls.Add(cedulaText);
            Controls.Add(tipoUsuarioCbx);
            Controls.Add(metroLabel5);
            Controls.Add(apellidosText);
            Controls.Add(metroLabel4);
            Controls.Add(contrasenaText);
            Controls.Add(metroLabel2);
            Controls.Add(userText);
            Controls.Add(metroLabel1);
            Controls.Add(nombresText);
            Controls.Add(metroLabel3);
            Name = "agregarUsuario";
            Text = "Nuevo Usuario";
            FormClosing += agregarUsuario_FormClosing;
            Load += agregarUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nombresText;
        private global::MetroFramework.Controls.MetroLabel metroLabel3;
        private TextBox contrasenaText;
        private global::MetroFramework.Controls.MetroLabel metroLabel2;
        private TextBox userText;
        private global::MetroFramework.Controls.MetroLabel metroLabel1;
        private TextBox apellidosText;
        private global::MetroFramework.Controls.MetroLabel metroLabel4;
        private global::MetroFramework.Controls.MetroLabel metroLabel5;
        private global::MetroFramework.Controls.MetroComboBox tipoUsuarioCbx;
        private MaskedTextBox cedulaText;
        private global::MetroFramework.Controls.MetroLabel metroLabel6;
        private global::MetroFramework.Controls.MetroLabel metroLabel7;
        private MaskedTextBox telefonoText;
        private global::MetroFramework.Controls.MetroLabel metroLabel8;
        private global::MetroFramework.Controls.MetroDateTime fechaNacimientoPicker;
        private TextBox direccionText;
        private global::MetroFramework.Controls.MetroLabel metroLabel9;
        private TextBox codigoText;
        private global::MetroFramework.Controls.MetroLabel metroLabel10;
        private global::MetroFramework.Controls.MetroTile generarCredenciales;
        private global::MetroFramework.Controls.MetroTile guardarUsuario;
    }
}