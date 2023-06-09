namespace FacturaDom.BDO.Vistas
{
    partial class Inventario
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
            codigoProducto = new TextBox();
            metroLabel1 = new MetroFramework.Controls.MetroLabel();
            inventarioGrid = new MetroFramework.Controls.MetroGrid();
            codigoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            precioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipoMedidaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stockDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descripcionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            articuloBindingSource = new BindingSource(components);
            nombreProducto = new TextBox();
            metroLabel2 = new MetroFramework.Controls.MetroLabel();
            imprimirReporte = new MetroFramework.Controls.MetroTile();
            nuevoProducto = new MetroFramework.Controls.MetroTile();
            modificarProducto = new MetroFramework.Controls.MetroTile();
            historialInventario = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)inventarioGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)articuloBindingSource).BeginInit();
            SuspendLayout();
            // 
            // codigoProducto
            // 
            codigoProducto.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            codigoProducto.Location = new Point(23, 94);
            codigoProducto.Name = "codigoProducto";
            codigoProducto.Size = new Size(228, 33);
            codigoProducto.TabIndex = 9;
            codigoProducto.TextChanged += codigoProducto_TextChanged;
            // 
            // metroLabel1
            // 
            metroLabel1.AutoSize = true;
            metroLabel1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            metroLabel1.Location = new Point(23, 66);
            metroLabel1.Name = "metroLabel1";
            metroLabel1.Size = new Size(53, 19);
            metroLabel1.TabIndex = 10;
            metroLabel1.Text = "Codigo";
            // 
            // inventarioGrid
            // 
            inventarioGrid.AllowUserToAddRows = false;
            inventarioGrid.AllowUserToDeleteRows = false;
            inventarioGrid.AllowUserToResizeRows = false;
            inventarioGrid.AutoGenerateColumns = false;
            inventarioGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            inventarioGrid.BackgroundColor = Color.FromArgb(255, 255, 255);
            inventarioGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            inventarioGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            inventarioGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            inventarioGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            inventarioGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            inventarioGrid.Columns.AddRange(new DataGridViewColumn[] { codigoDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, precioDataGridViewTextBoxColumn, tipoMedidaDataGridViewTextBoxColumn, stockDataGridViewTextBoxColumn, descripcionDataGridViewTextBoxColumn });
            inventarioGrid.DataSource = articuloBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            inventarioGrid.DefaultCellStyle = dataGridViewCellStyle2;
            inventarioGrid.Dock = DockStyle.Bottom;
            inventarioGrid.EnableHeadersVisualStyles = false;
            inventarioGrid.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            inventarioGrid.GridColor = Color.FromArgb(255, 255, 255);
            inventarioGrid.Location = new Point(20, 221);
            inventarioGrid.Name = "inventarioGrid";
            inventarioGrid.ReadOnly = true;
            inventarioGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            inventarioGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            inventarioGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            inventarioGrid.RowTemplate.Height = 25;
            inventarioGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            inventarioGrid.Size = new Size(845, 299);
            inventarioGrid.TabIndex = 8;
            inventarioGrid.UseStyleColors = true;
            inventarioGrid.CellClick += inventarioGrid_CellClick;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Producto";
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            precioDataGridViewTextBoxColumn.HeaderText = "Valor";
            precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            precioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoMedidaDataGridViewTextBoxColumn
            // 
            tipoMedidaDataGridViewTextBoxColumn.DataPropertyName = "TipoMedida";
            tipoMedidaDataGridViewTextBoxColumn.HeaderText = "Medida";
            tipoMedidaDataGridViewTextBoxColumn.Name = "tipoMedidaDataGridViewTextBoxColumn";
            tipoMedidaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            stockDataGridViewTextBoxColumn.HeaderText = "Cantidad Disponible";
            stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            stockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // articuloBindingSource
            // 
            articuloBindingSource.DataSource = typeof(Modelos.Articulo);
            // 
            // nombreProducto
            // 
            nombreProducto.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            nombreProducto.Location = new Point(23, 171);
            nombreProducto.Name = "nombreProducto";
            nombreProducto.Size = new Size(228, 33);
            nombreProducto.TabIndex = 11;
            nombreProducto.TextChanged += nombreProducto_TextChanged;
            // 
            // metroLabel2
            // 
            metroLabel2.AutoSize = true;
            metroLabel2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            metroLabel2.Location = new Point(23, 143);
            metroLabel2.Name = "metroLabel2";
            metroLabel2.Size = new Size(59, 19);
            metroLabel2.TabIndex = 12;
            metroLabel2.Text = "Nombre";
            // 
            // imprimirReporte
            // 
            imprimirReporte.ActiveControl = null;
            imprimirReporte.BackColor = Color.SteelBlue;
            imprimirReporte.BackgroundImageLayout = ImageLayout.Stretch;
            imprimirReporte.Location = new Point(746, 94);
            imprimirReporte.Name = "imprimirReporte";
            imprimirReporte.Size = new Size(114, 110);
            imprimirReporte.TabIndex = 7;
            imprimirReporte.Text = "Imprimir";
            imprimirReporte.UseCustomBackColor = true;
            imprimirReporte.UseSelectable = true;
            imprimirReporte.UseTileImage = true;
            imprimirReporte.UseVisualStyleBackColor = false;
            imprimirReporte.Click += imprimirReporte_Click;
            // 
            // nuevoProducto
            // 
            nuevoProducto.ActiveControl = null;
            nuevoProducto.BackColor = Color.SteelBlue;
            nuevoProducto.BackgroundImageLayout = ImageLayout.Stretch;
            nuevoProducto.Location = new Point(350, 94);
            nuevoProducto.Name = "nuevoProducto";
            nuevoProducto.Size = new Size(114, 110);
            nuevoProducto.TabIndex = 8;
            nuevoProducto.Text = "Nuevo\r\nProducto";
            nuevoProducto.UseCustomBackColor = true;
            nuevoProducto.UseSelectable = true;
            nuevoProducto.UseTileImage = true;
            nuevoProducto.UseVisualStyleBackColor = false;
            nuevoProducto.Click += nuevoProducto_Click;
            // 
            // modificarProducto
            // 
            modificarProducto.ActiveControl = null;
            modificarProducto.BackColor = Color.SteelBlue;
            modificarProducto.BackgroundImageLayout = ImageLayout.Stretch;
            modificarProducto.Location = new Point(482, 94);
            modificarProducto.Name = "modificarProducto";
            modificarProducto.Size = new Size(114, 110);
            modificarProducto.TabIndex = 9;
            modificarProducto.Text = "Manejar\r\nProducto";
            modificarProducto.UseCustomBackColor = true;
            modificarProducto.UseSelectable = true;
            modificarProducto.UseTileImage = true;
            modificarProducto.UseVisualStyleBackColor = false;
            modificarProducto.Click += modificarProducto_Click;
            // 
            // historialInventario
            // 
            historialInventario.ActiveControl = null;
            historialInventario.BackColor = Color.SteelBlue;
            historialInventario.BackgroundImageLayout = ImageLayout.Stretch;
            historialInventario.Location = new Point(614, 94);
            historialInventario.Name = "historialInventario";
            historialInventario.Size = new Size(114, 110);
            historialInventario.TabIndex = 9;
            historialInventario.Text = "Historial\r\nde inventario";
            historialInventario.UseCustomBackColor = true;
            historialInventario.UseSelectable = true;
            historialInventario.UseTileImage = true;
            historialInventario.UseVisualStyleBackColor = false;
            historialInventario.Click += historialInventario_Click;
            // 
            // Inventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 540);
            Controls.Add(historialInventario);
            Controls.Add(modificarProducto);
            Controls.Add(nuevoProducto);
            Controls.Add(nombreProducto);
            Controls.Add(metroLabel2);
            Controls.Add(imprimirReporte);
            Controls.Add(codigoProducto);
            Controls.Add(metroLabel1);
            Controls.Add(inventarioGrid);
            Name = "Inventario";
            Text = "Inventario";
            FormClosed += Inventario_FormClosed;
            Load += Inventario_Load;
            ((System.ComponentModel.ISupportInitialize)inventarioGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)articuloBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox codigoProducto;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid inventarioGrid;
        private BindingSource articuloBindingSource;
        private TextBox nombreProducto;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoMedidaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroTile imprimirReporte;
        private MetroFramework.Controls.MetroTile nuevoProducto;
        private MetroFramework.Controls.MetroTile modificarProducto;
        private MetroFramework.Controls.MetroTile historialInventario;
    }
}