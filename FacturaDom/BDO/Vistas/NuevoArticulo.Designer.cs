namespace FacturaDom.BDO.Vistas
{
    partial class NuevoArticulo
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
            generarCodigo = new MetroFramework.Controls.MetroTile();
            guardarArticulo = new MetroFramework.Controls.MetroTile();
            descripcion = new TextBox();
            metroLabel9 = new MetroFramework.Controls.MetroLabel();
            metroLabel7 = new MetroFramework.Controls.MetroLabel();
            metroLabel6 = new MetroFramework.Controls.MetroLabel();
            tipoMedidaCbx = new MetroFramework.Controls.MetroComboBox();
            metroLabel5 = new MetroFramework.Controls.MetroLabel();
            nombre = new TextBox();
            metroLabel4 = new MetroFramework.Controls.MetroLabel();
            codigo = new TextBox();
            metroLabel3 = new MetroFramework.Controls.MetroLabel();
            cantidad = new TextBox();
            precio = new TextBox();
            SuspendLayout();
            // 
            // generarCodigo
            // 
            generarCodigo.ActiveControl = null;
            generarCodigo.BackColor = Color.SteelBlue;
            generarCodigo.BackgroundImageLayout = ImageLayout.Stretch;
            generarCodigo.Location = new Point(300, 470);
            generarCodigo.Name = "generarCodigo";
            generarCodigo.Size = new Size(105, 84);
            generarCodigo.TabIndex = 53;
            generarCodigo.Text = "Generar\r\nCodigo";
            generarCodigo.TileImageAlign = ContentAlignment.MiddleRight;
            generarCodigo.UseCustomBackColor = true;
            generarCodigo.UseSelectable = true;
            generarCodigo.UseTileImage = true;
            generarCodigo.UseVisualStyleBackColor = false;
            generarCodigo.Click += generarCodigo_Click;
            // 
            // guardarArticulo
            // 
            guardarArticulo.ActiveControl = null;
            guardarArticulo.BackColor = Color.SteelBlue;
            guardarArticulo.Location = new Point(423, 470);
            guardarArticulo.Name = "guardarArticulo";
            guardarArticulo.Size = new Size(105, 84);
            guardarArticulo.TabIndex = 52;
            guardarArticulo.Text = "Guardar\r\nArticulo";
            guardarArticulo.TileImageAlign = ContentAlignment.MiddleRight;
            guardarArticulo.UseCustomBackColor = true;
            guardarArticulo.UseSelectable = true;
            guardarArticulo.UseTileImage = true;
            guardarArticulo.UseVisualStyleBackColor = false;
            guardarArticulo.Click += guardarArticulo_Click;
            // 
            // descripcion
            // 
            descripcion.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            descripcion.Location = new Point(23, 349);
            descripcion.Multiline = true;
            descripcion.Name = "descripcion";
            descripcion.Size = new Size(505, 104);
            descripcion.TabIndex = 39;
            // 
            // metroLabel9
            // 
            metroLabel9.AutoSize = true;
            metroLabel9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            metroLabel9.Location = new Point(23, 318);
            metroLabel9.Name = "metroLabel9";
            metroLabel9.Size = new Size(76, 19);
            metroLabel9.TabIndex = 50;
            metroLabel9.Text = "Descripcion";
            // 
            // metroLabel7
            // 
            metroLabel7.AutoSize = true;
            metroLabel7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            metroLabel7.Location = new Point(23, 242);
            metroLabel7.Name = "metroLabel7";
            metroLabel7.Size = new Size(82, 19);
            metroLabel7.TabIndex = 48;
            metroLabel7.Text = "Precio (RD$)";
            // 
            // metroLabel6
            // 
            metroLabel6.AutoSize = true;
            metroLabel6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            metroLabel6.Location = new Point(300, 164);
            metroLabel6.Name = "metroLabel6";
            metroLabel6.Size = new Size(62, 19);
            metroLabel6.TabIndex = 47;
            metroLabel6.Text = "Cantidad";
            // 
            // tipoMedidaCbx
            // 
            tipoMedidaCbx.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            tipoMedidaCbx.FormattingEnabled = true;
            tipoMedidaCbx.ItemHeight = 29;
            tipoMedidaCbx.Items.AddRange(new object[] { "Elegir uno...", "Unidad", "Cajas", "SixPack", "Paquete", "Metro", "Centimetros", "Pulgada", "Pies", "Libras", "Kilogramos", "Gramos", "Litros", "Galones", "Onzas", "Barriles" });
            tipoMedidaCbx.Location = new Point(23, 195);
            tipoMedidaCbx.Name = "tipoMedidaCbx";
            tipoMedidaCbx.Size = new Size(228, 35);
            tipoMedidaCbx.TabIndex = 35;
            tipoMedidaCbx.UseSelectable = true;
            // 
            // metroLabel5
            // 
            metroLabel5.AutoSize = true;
            metroLabel5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            metroLabel5.Location = new Point(23, 164);
            metroLabel5.Name = "metroLabel5";
            metroLabel5.Size = new Size(103, 19);
            metroLabel5.TabIndex = 46;
            metroLabel5.Text = "Tipo de Medida";
            // 
            // nombre
            // 
            nombre.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            nombre.Location = new Point(300, 119);
            nombre.Name = "nombre";
            nombre.Size = new Size(228, 33);
            nombre.TabIndex = 34;
            // 
            // metroLabel4
            // 
            metroLabel4.AutoSize = true;
            metroLabel4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            metroLabel4.Location = new Point(300, 88);
            metroLabel4.Name = "metroLabel4";
            metroLabel4.Size = new Size(59, 19);
            metroLabel4.TabIndex = 45;
            metroLabel4.Text = "Nombre";
            // 
            // codigo
            // 
            codigo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            codigo.Location = new Point(23, 119);
            codigo.Name = "codigo";
            codigo.Size = new Size(228, 33);
            codigo.TabIndex = 33;
            // 
            // metroLabel3
            // 
            metroLabel3.AutoSize = true;
            metroLabel3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            metroLabel3.Location = new Point(23, 88);
            metroLabel3.Name = "metroLabel3";
            metroLabel3.Size = new Size(53, 19);
            metroLabel3.TabIndex = 42;
            metroLabel3.Text = "Codigo";
            // 
            // cantidad
            // 
            cantidad.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cantidad.Location = new Point(300, 195);
            cantidad.Name = "cantidad";
            cantidad.Size = new Size(228, 33);
            cantidad.TabIndex = 54;
            // 
            // precio
            // 
            precio.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            precio.Location = new Point(23, 273);
            precio.Name = "precio";
            precio.Size = new Size(228, 33);
            precio.TabIndex = 55;
            // 
            // NuevoArticulo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 603);
            Controls.Add(precio);
            Controls.Add(cantidad);
            Controls.Add(generarCodigo);
            Controls.Add(guardarArticulo);
            Controls.Add(descripcion);
            Controls.Add(metroLabel9);
            Controls.Add(metroLabel7);
            Controls.Add(metroLabel6);
            Controls.Add(tipoMedidaCbx);
            Controls.Add(metroLabel5);
            Controls.Add(nombre);
            Controls.Add(metroLabel4);
            Controls.Add(codigo);
            Controls.Add(metroLabel3);
            Name = "NuevoArticulo";
            Text = "Nuevo Articulo";
            Load += NuevoArticulo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MetroFramework.Controls.MetroTile generarCodigo;
        private MetroFramework.Controls.MetroTile guardarArticulo;
        private TextBox descripcion;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroComboBox tipoMedidaCbx;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private TextBox nombre;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private TextBox codigo;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private TextBox cantidad;
        private TextBox precio;
    }
}