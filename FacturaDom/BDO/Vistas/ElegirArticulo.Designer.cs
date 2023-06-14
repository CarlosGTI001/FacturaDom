namespace FacturaDom.BDO.Vistas
{
    partial class ElegirArticulo
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            articuloGrid = new MetroFramework.Controls.MetroGrid();
            Codigo = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            TipoMedida = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            articuloBindingSource1 = new BindingSource(components);
            clienteBindingSource = new BindingSource(components);
            metroLabel3 = new MetroFramework.Controls.MetroLabel();
            busquedaText = new TextBox();
            elegir_Articulo = new MetroFramework.Controls.MetroTile();
            articuloBindingSource = new BindingSource(components);
            metroLabel1 = new MetroFramework.Controls.MetroLabel();
            cantidadDisponible = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)articuloGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)articuloBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)articuloBindingSource).BeginInit();
            SuspendLayout();
            // 
            // articuloGrid
            // 
            articuloGrid.AllowUserToAddRows = false;
            articuloGrid.AllowUserToDeleteRows = false;
            articuloGrid.AllowUserToResizeRows = false;
            articuloGrid.AutoGenerateColumns = false;
            articuloGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            articuloGrid.BackgroundColor = Color.FromArgb(255, 255, 255);
            articuloGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            articuloGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            articuloGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            articuloGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            articuloGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            articuloGrid.Columns.AddRange(new DataGridViewColumn[] { Codigo, nombreDataGridViewTextBoxColumn, TipoMedida, Stock, Precio, Descripcion });
            articuloGrid.DataSource = articuloBindingSource1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            articuloGrid.DefaultCellStyle = dataGridViewCellStyle2;
            articuloGrid.Dock = DockStyle.Bottom;
            articuloGrid.EnableHeadersVisualStyles = false;
            articuloGrid.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            articuloGrid.GridColor = Color.FromArgb(255, 255, 255);
            articuloGrid.Location = new Point(20, 202);
            articuloGrid.Name = "articuloGrid";
            articuloGrid.ReadOnly = true;
            articuloGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            articuloGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            articuloGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            articuloGrid.RowTemplate.Height = 25;
            articuloGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            articuloGrid.Size = new Size(631, 204);
            articuloGrid.TabIndex = 0;
            articuloGrid.CellClick += articuloGrid_CellClick;
            // 
            // Codigo
            // 
            Codigo.DataPropertyName = "Codigo";
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TipoMedida
            // 
            TipoMedida.DataPropertyName = "TipoMedida";
            TipoMedida.HeaderText = "TipoMedida";
            TipoMedida.Name = "TipoMedida";
            TipoMedida.ReadOnly = true;
            // 
            // Stock
            // 
            Stock.DataPropertyName = "Stock";
            Stock.HeaderText = "Stock";
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.DataPropertyName = "Precio";
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // Descripcion
            // 
            Descripcion.DataPropertyName = "Descripcion";
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            // 
            // articuloBindingSource1
            // 
            articuloBindingSource1.DataSource = typeof(Modelos.Articulo);
            // 
            // clienteBindingSource
            // 
            clienteBindingSource.DataSource = typeof(Modelos.Cliente);
            // 
            // metroLabel3
            // 
            metroLabel3.AutoSize = true;
            metroLabel3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            metroLabel3.Location = new Point(23, 109);
            metroLabel3.Name = "metroLabel3";
            metroLabel3.Size = new Size(53, 19);
            metroLabel3.TabIndex = 9;
            metroLabel3.Text = "Codigo";
            // 
            // busquedaText
            // 
            busquedaText.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            busquedaText.Location = new Point(23, 135);
            busquedaText.Name = "busquedaText";
            busquedaText.Size = new Size(180, 33);
            busquedaText.TabIndex = 8;
            busquedaText.TextChanged += busquedaText_TextChanged;
            // 
            // elegir_Articulo
            // 
            elegir_Articulo.ActiveControl = null;
            elegir_Articulo.BackColor = Color.SteelBlue;
            elegir_Articulo.Location = new Point(537, 109);
            elegir_Articulo.Name = "elegir_Articulo";
            elegir_Articulo.Size = new Size(114, 59);
            elegir_Articulo.TabIndex = 10;
            elegir_Articulo.Text = "Elegir\r\nArticulo";
            elegir_Articulo.TileImageAlign = ContentAlignment.MiddleRight;
            elegir_Articulo.UseCustomBackColor = true;
            elegir_Articulo.UseSelectable = true;
            elegir_Articulo.UseTileImage = true;
            elegir_Articulo.UseVisualStyleBackColor = false;
            elegir_Articulo.Click += elegir_Articulo_Click;
            // 
            // articuloBindingSource
            // 
            articuloBindingSource.DataSource = typeof(Modelos.Articulo);
            // 
            // metroLabel1
            // 
            metroLabel1.AutoSize = true;
            metroLabel1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            metroLabel1.Location = new Point(270, 109);
            metroLabel1.Name = "metroLabel1";
            metroLabel1.Size = new Size(134, 19);
            metroLabel1.TabIndex = 11;
            metroLabel1.Text = "Cantidad Disponible: ";
            // 
            // cantidadDisponible
            // 
            cantidadDisponible.AutoSize = true;
            cantidadDisponible.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            cantidadDisponible.FontSize = MetroFramework.MetroLabelSize.Tall;
            cantidadDisponible.Location = new Point(270, 149);
            cantidadDisponible.Name = "cantidadDisponible";
            cantidadDisponible.Size = new Size(19, 25);
            cantidadDisponible.TabIndex = 12;
            cantidadDisponible.Text = "-";
            // 
            // ElegirArticulo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 426);
            Controls.Add(cantidadDisponible);
            Controls.Add(metroLabel1);
            Controls.Add(elegir_Articulo);
            Controls.Add(metroLabel3);
            Controls.Add(busquedaText);
            Controls.Add(articuloGrid);
            Name = "ElegirArticulo";
            Text = "Elegir Articulo";
            Load += ElegirArticulo_Load;
            ((System.ComponentModel.ISupportInitialize)articuloGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)articuloBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)articuloBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MetroFramework.Controls.MetroGrid articuloGrid;
        private BindingSource clienteBindingSource;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private TextBox busquedaText;
        private MetroFramework.Controls.MetroTile elegir_Articulo;
        private BindingSource articuloBindingSource1;
        private BindingSource articuloBindingSource;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn TipoMedida;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Descripcion;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel cantidadDisponible;
    }
}