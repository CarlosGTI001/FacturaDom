namespace FacturaDom.BDO.Vistas
{
    partial class Factura
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.facturarPanel = new MetroFramework.Controls.MetroPanel();
            this.articulosCantidad = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.totalRds = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.detalleGrid = new MetroFramework.Controls.MetroGrid();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoMedidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosPanel = new MetroFramework.Controls.MetroPanel();
            this.totalLbl = new MetroFramework.Controls.MetroLabel();
            this.precioLbl = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.articuloNombre = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.agregarArticulo = new MetroFramework.Controls.MetroTile();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cantidadArticulo = new System.Windows.Forms.TextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.busquedaText = new System.Windows.Forms.TextBox();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.Facturar = new MetroFramework.Controls.MetroTile();
            this.articuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nuevaFactura = new MetroFramework.Controls.MetroTile();
            this.eliminarFactura = new MetroFramework.Controls.MetroTile();
            this.clientePanel = new MetroFramework.Controls.MetroPanel();
            this.direccionLbl = new MetroFramework.Controls.MetroLabel();
            this.clienteLbl = new MetroFramework.Controls.MetroLabel();
            this.codigoLbl = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.facturaBox = new FontAwesome.Sharp.IconPictureBox();
            this.facturarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detalleGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleFacturaBindingSource)).BeginInit();
            this.productosPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).BeginInit();
            this.clientePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBox)).BeginInit();
            this.SuspendLayout();
            // 
            // facturarPanel
            // 
            this.facturarPanel.Controls.Add(this.articulosCantidad);
            this.facturarPanel.Controls.Add(this.metroLabel2);
            this.facturarPanel.Controls.Add(this.totalRds);
            this.facturarPanel.Controls.Add(this.metroLabel1);
            this.facturarPanel.Controls.Add(this.detalleGrid);
            this.facturarPanel.HorizontalScrollbarBarColor = true;
            this.facturarPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.facturarPanel.HorizontalScrollbarSize = 10;
            this.facturarPanel.Location = new System.Drawing.Point(26, 206);
            this.facturarPanel.Name = "facturarPanel";
            this.facturarPanel.Size = new System.Drawing.Size(486, 348);
            this.facturarPanel.TabIndex = 0;
            this.facturarPanel.VerticalScrollbarBarColor = true;
            this.facturarPanel.VerticalScrollbarHighlightOnWheel = false;
            this.facturarPanel.VerticalScrollbarSize = 10;
            // 
            // articulosCantidad
            // 
            this.articulosCantidad.AutoSize = true;
            this.articulosCantidad.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.articulosCantidad.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.articulosCantidad.Location = new System.Drawing.Point(323, 280);
            this.articulosCantidad.Name = "articulosCantidad";
            this.articulosCantidad.Size = new System.Drawing.Size(22, 25);
            this.articulosCantidad.TabIndex = 6;
            this.articulosCantidad.Text = "0";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(223, 280);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(94, 25);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Articulos:";
            // 
            // totalRds
            // 
            this.totalRds.AutoSize = true;
            this.totalRds.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.totalRds.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.totalRds.Location = new System.Drawing.Point(323, 305);
            this.totalRds.Name = "totalRds";
            this.totalRds.Size = new System.Drawing.Size(47, 25);
            this.totalRds.TabIndex = 4;
            this.totalRds.Text = "RD$";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(258, 305);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(59, 25);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Total:";
            // 
            // detalleGrid
            // 
            this.detalleGrid.AllowUserToAddRows = false;
            this.detalleGrid.AllowUserToDeleteRows = false;
            this.detalleGrid.AllowUserToResizeRows = false;
            this.detalleGrid.AutoGenerateColumns = false;
            this.detalleGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.detalleGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.detalleGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.detalleGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.detalleGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.detalleGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.detalleGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detalleGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.tipoMedidaDataGridViewTextBoxColumn,
            this.descuentoDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn});
            this.detalleGrid.DataSource = this.detalleFacturaBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.detalleGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.detalleGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.detalleGrid.EnableHeadersVisualStyles = false;
            this.detalleGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.detalleGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.detalleGrid.Location = new System.Drawing.Point(0, 0);
            this.detalleGrid.Name = "detalleGrid";
            this.detalleGrid.ReadOnly = true;
            this.detalleGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.detalleGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.detalleGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.detalleGrid.RowTemplate.Height = 25;
            this.detalleGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.detalleGrid.Size = new System.Drawing.Size(486, 266);
            this.detalleGrid.TabIndex = 2;
            this.detalleGrid.UseStyleColors = true;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Producto";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoMedidaDataGridViewTextBoxColumn
            // 
            this.tipoMedidaDataGridViewTextBoxColumn.DataPropertyName = "TipoMedida";
            this.tipoMedidaDataGridViewTextBoxColumn.HeaderText = "Medida";
            this.tipoMedidaDataGridViewTextBoxColumn.Name = "tipoMedidaDataGridViewTextBoxColumn";
            this.tipoMedidaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descuentoDataGridViewTextBoxColumn
            // 
            this.descuentoDataGridViewTextBoxColumn.DataPropertyName = "descuento";
            this.descuentoDataGridViewTextBoxColumn.HeaderText = "descuento";
            this.descuentoDataGridViewTextBoxColumn.Name = "descuentoDataGridViewTextBoxColumn";
            this.descuentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descuentoDataGridViewTextBoxColumn.Visible = false;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionDataGridViewTextBoxColumn.Visible = false;
            // 
            // detalleFacturaBindingSource
            // 
            this.detalleFacturaBindingSource.DataSource = typeof(FacturaDom.BDO.Modelos.DetalleFactura);
            // 
            // productosPanel
            // 
            this.productosPanel.BackColor = System.Drawing.Color.White;
            this.productosPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.productosPanel.Controls.Add(this.totalLbl);
            this.productosPanel.Controls.Add(this.precioLbl);
            this.productosPanel.Controls.Add(this.metroLabel8);
            this.productosPanel.Controls.Add(this.metroLabel7);
            this.productosPanel.Controls.Add(this.articuloNombre);
            this.productosPanel.Controls.Add(this.metroLabel5);
            this.productosPanel.Controls.Add(this.agregarArticulo);
            this.productosPanel.Controls.Add(this.metroLabel4);
            this.productosPanel.Controls.Add(this.cantidadArticulo);
            this.productosPanel.Controls.Add(this.metroLabel3);
            this.productosPanel.Controls.Add(this.busquedaText);
            this.productosPanel.Controls.Add(this.metroTile2);
            this.productosPanel.Controls.Add(this.Facturar);
            this.productosPanel.HorizontalScrollbarBarColor = true;
            this.productosPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.productosPanel.HorizontalScrollbarSize = 10;
            this.productosPanel.Location = new System.Drawing.Point(518, 207);
            this.productosPanel.Name = "productosPanel";
            this.productosPanel.Size = new System.Drawing.Size(360, 347);
            this.productosPanel.TabIndex = 1;
            this.productosPanel.UseCustomBackColor = true;
            this.productosPanel.VerticalScrollbarBarColor = true;
            this.productosPanel.VerticalScrollbarHighlightOnWheel = false;
            this.productosPanel.VerticalScrollbarSize = 10;
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalLbl.Location = new System.Drawing.Point(150, 231);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(43, 19);
            this.totalLbl.TabIndex = 15;
            this.totalLbl.Text = "RD$ -";
            this.totalLbl.UseCustomBackColor = true;
            // 
            // precioLbl
            // 
            this.precioLbl.AutoSize = true;
            this.precioLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.precioLbl.Location = new System.Drawing.Point(150, 131);
            this.precioLbl.Name = "precioLbl";
            this.precioLbl.Size = new System.Drawing.Size(43, 19);
            this.precioLbl.TabIndex = 14;
            this.precioLbl.Text = "RD$ -";
            this.precioLbl.UseCustomBackColor = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroLabel8.Location = new System.Drawing.Point(105, 231);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(39, 19);
            this.metroLabel8.TabIndex = 13;
            this.metroLabel8.Text = "Total:";
            this.metroLabel8.UseCustomBackColor = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroLabel7.Location = new System.Drawing.Point(95, 131);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(49, 19);
            this.metroLabel7.TabIndex = 12;
            this.metroLabel7.Text = "Precio:";
            this.metroLabel7.UseCustomBackColor = true;
            // 
            // articuloNombre
            // 
            this.articuloNombre.AutoSize = true;
            this.articuloNombre.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.articuloNombre.Location = new System.Drawing.Point(150, 105);
            this.articuloNombre.Name = "articuloNombre";
            this.articuloNombre.Size = new System.Drawing.Size(15, 19);
            this.articuloNombre.TabIndex = 11;
            this.articuloNombre.Text = "-";
            this.articuloNombre.UseCustomBackColor = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroLabel5.Location = new System.Drawing.Point(86, 105);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(58, 19);
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "Articulo:";
            this.metroLabel5.UseCustomBackColor = true;
            // 
            // agregarArticulo
            // 
            this.agregarArticulo.ActiveControl = null;
            this.agregarArticulo.BackColor = System.Drawing.Color.SteelBlue;
            this.agregarArticulo.Location = new System.Drawing.Point(27, 268);
            this.agregarArticulo.Name = "agregarArticulo";
            this.agregarArticulo.Size = new System.Drawing.Size(114, 59);
            this.agregarArticulo.TabIndex = 5;
            this.agregarArticulo.Text = "Agregar\r\nArticulo";
            this.agregarArticulo.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.agregarArticulo.UseCustomBackColor = true;
            this.agregarArticulo.UseSelectable = true;
            this.agregarArticulo.UseTileImage = true;
            this.agregarArticulo.UseVisualStyleBackColor = false;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroLabel4.Location = new System.Drawing.Point(86, 156);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(62, 19);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Cantidad";
            this.metroLabel4.UseCustomBackColor = true;
            // 
            // cantidadArticulo
            // 
            this.cantidadArticulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cantidadArticulo.Location = new System.Drawing.Point(86, 180);
            this.cantidadArticulo.Name = "cantidadArticulo";
            this.cantidadArticulo.Size = new System.Drawing.Size(180, 33);
            this.cantidadArticulo.TabIndex = 8;
            this.cantidadArticulo.Text = "0";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroLabel3.Location = new System.Drawing.Point(19, 25);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(66, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Busqueda";
            this.metroLabel3.UseCustomBackColor = true;
            // 
            // busquedaText
            // 
            this.busquedaText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.busquedaText.Location = new System.Drawing.Point(19, 51);
            this.busquedaText.Name = "busquedaText";
            this.busquedaText.Size = new System.Drawing.Size(180, 33);
            this.busquedaText.TabIndex = 6;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.BackColor = System.Drawing.Color.SteelBlue;
            this.metroTile2.Location = new System.Drawing.Point(227, 25);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(114, 59);
            this.metroTile2.TabIndex = 4;
            this.metroTile2.Text = "Buscar\r\nArticulo";
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile2.UseCustomBackColor = true;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseTileImage = true;
            this.metroTile2.UseVisualStyleBackColor = false;
            // 
            // Facturar
            // 
            this.Facturar.ActiveControl = null;
            this.Facturar.BackColor = System.Drawing.Color.SteelBlue;
            this.Facturar.Location = new System.Drawing.Point(227, 270);
            this.Facturar.Name = "Facturar";
            this.Facturar.Size = new System.Drawing.Size(114, 57);
            this.Facturar.TabIndex = 5;
            this.Facturar.Text = "Imprimir \r\nFactura";
            this.Facturar.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Facturar.UseCustomBackColor = true;
            this.Facturar.UseSelectable = true;
            this.Facturar.UseTileImage = true;
            this.Facturar.UseVisualStyleBackColor = false;
            // 
            // articuloBindingSource
            // 
            this.articuloBindingSource.DataSource = typeof(FacturaDom.BDO.Modelos.Articulo);
            // 
            // nuevaFactura
            // 
            this.nuevaFactura.ActiveControl = null;
            this.nuevaFactura.BackColor = System.Drawing.Color.SteelBlue;
            this.nuevaFactura.Location = new System.Drawing.Point(764, 75);
            this.nuevaFactura.Name = "nuevaFactura";
            this.nuevaFactura.Size = new System.Drawing.Size(114, 110);
            this.nuevaFactura.TabIndex = 4;
            this.nuevaFactura.Text = "Nueva\r\nFactura";
            this.nuevaFactura.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.nuevaFactura.UseCustomBackColor = true;
            this.nuevaFactura.UseSelectable = true;
            this.nuevaFactura.UseTileImage = true;
            this.nuevaFactura.UseVisualStyleBackColor = false;
            this.nuevaFactura.Click += new System.EventHandler(this.nuevaFactura_Click);
            // 
            // eliminarFactura
            // 
            this.eliminarFactura.ActiveControl = null;
            this.eliminarFactura.BackColor = System.Drawing.Color.SteelBlue;
            this.eliminarFactura.Location = new System.Drawing.Point(26, 75);
            this.eliminarFactura.Name = "eliminarFactura";
            this.eliminarFactura.Size = new System.Drawing.Size(114, 110);
            this.eliminarFactura.TabIndex = 6;
            this.eliminarFactura.Text = "Eliminar";
            this.eliminarFactura.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.eliminarFactura.UseCustomBackColor = true;
            this.eliminarFactura.UseSelectable = true;
            this.eliminarFactura.UseTileImage = true;
            this.eliminarFactura.UseVisualStyleBackColor = false;
            this.eliminarFactura.Click += new System.EventHandler(this.eliminarFactura_Click);
            // 
            // clientePanel
            // 
            this.clientePanel.BackColor = System.Drawing.Color.White;
            this.clientePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.clientePanel.Controls.Add(this.direccionLbl);
            this.clientePanel.Controls.Add(this.clienteLbl);
            this.clientePanel.Controls.Add(this.codigoLbl);
            this.clientePanel.Controls.Add(this.metroLabel10);
            this.clientePanel.Controls.Add(this.metroLabel9);
            this.clientePanel.Controls.Add(this.metroLabel6);
            this.clientePanel.HorizontalScrollbarBarColor = true;
            this.clientePanel.HorizontalScrollbarHighlightOnWheel = false;
            this.clientePanel.HorizontalScrollbarSize = 10;
            this.clientePanel.Location = new System.Drawing.Point(152, 75);
            this.clientePanel.Name = "clientePanel";
            this.clientePanel.Size = new System.Drawing.Size(600, 110);
            this.clientePanel.TabIndex = 7;
            this.clientePanel.UseCustomBackColor = true;
            this.clientePanel.VerticalScrollbarBarColor = true;
            this.clientePanel.VerticalScrollbarHighlightOnWheel = false;
            this.clientePanel.VerticalScrollbarSize = 10;
            // 
            // direccionLbl
            // 
            this.direccionLbl.AutoSize = true;
            this.direccionLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.direccionLbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.direccionLbl.Location = new System.Drawing.Point(109, 74);
            this.direccionLbl.Name = "direccionLbl";
            this.direccionLbl.Size = new System.Drawing.Size(19, 25);
            this.direccionLbl.TabIndex = 12;
            this.direccionLbl.Text = "-";
            this.direccionLbl.UseCustomBackColor = true;
            // 
            // clienteLbl
            // 
            this.clienteLbl.AutoSize = true;
            this.clienteLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.clienteLbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.clienteLbl.Location = new System.Drawing.Point(109, 39);
            this.clienteLbl.Name = "clienteLbl";
            this.clienteLbl.Size = new System.Drawing.Size(19, 25);
            this.clienteLbl.TabIndex = 11;
            this.clienteLbl.Text = "-";
            this.clienteLbl.UseCustomBackColor = true;
            // 
            // codigoLbl
            // 
            this.codigoLbl.AutoSize = true;
            this.codigoLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.codigoLbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.codigoLbl.Location = new System.Drawing.Point(109, 7);
            this.codigoLbl.Name = "codigoLbl";
            this.codigoLbl.Size = new System.Drawing.Size(19, 25);
            this.codigoLbl.TabIndex = 10;
            this.codigoLbl.Text = "-";
            this.codigoLbl.UseCustomBackColor = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel10.Location = new System.Drawing.Point(14, 7);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(90, 25);
            this.metroLabel10.TabIndex = 9;
            this.metroLabel10.Text = "Factura #";
            this.metroLabel10.UseCustomBackColor = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.Location = new System.Drawing.Point(3, 74);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(102, 25);
            this.metroLabel9.TabIndex = 8;
            this.metroLabel9.Text = "Direccion :";
            this.metroLabel9.UseCustomBackColor = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(22, 39);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(81, 25);
            this.metroLabel6.TabIndex = 7;
            this.metroLabel6.Text = "Cliente :";
            this.metroLabel6.UseCustomBackColor = true;
            // 
            // facturaBox
            // 
            this.facturaBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.facturaBox.ForeColor = System.Drawing.Color.SteelBlue;
            this.facturaBox.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            this.facturaBox.IconColor = System.Drawing.Color.SteelBlue;
            this.facturaBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.facturaBox.IconSize = 218;
            this.facturaBox.Location = new System.Drawing.Point(323, 208);
            this.facturaBox.Name = "facturaBox";
            this.facturaBox.Size = new System.Drawing.Size(255, 218);
            this.facturaBox.TabIndex = 8;
            this.facturaBox.TabStop = false;
            this.facturaBox.Click += new System.EventHandler(this.facturaBox_Click);
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 577);
            this.Controls.Add(this.clientePanel);
            this.Controls.Add(this.eliminarFactura);
            this.Controls.Add(this.nuevaFactura);
            this.Controls.Add(this.productosPanel);
            this.Controls.Add(this.facturarPanel);
            this.Controls.Add(this.facturaBox);
            this.Name = "Factura";
            this.Text = "Facturar";
            this.Load += new System.EventHandler(this.Factura_Load);
            this.facturarPanel.ResumeLayout(false);
            this.facturarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detalleGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleFacturaBindingSource)).EndInit();
            this.productosPanel.ResumeLayout(false);
            this.productosPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).EndInit();
            this.clientePanel.ResumeLayout(false);
            this.clientePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel facturarPanel;
        private MetroFramework.Controls.MetroPanel productosPanel;
        private MetroFramework.Controls.MetroLabel articulosCantidad;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel totalRds;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid detalleGrid;
        private DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoMedidaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descuentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private BindingSource detalleFacturaBindingSource;
        private BindingSource articuloBindingSource;
        private MetroFramework.Controls.MetroTile nuevaFactura;
        private MetroFramework.Controls.MetroTile Facturar;
        private MetroFramework.Controls.MetroTile eliminarFactura;
        private MetroFramework.Controls.MetroTile metroTile2;
        private TextBox busquedaText;
        private MetroFramework.Controls.MetroLabel totalLbl;
        private MetroFramework.Controls.MetroLabel precioLbl;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel articuloNombre;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTile agregarArticulo;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private TextBox cantidadArticulo;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroPanel clientePanel;
        private MetroFramework.Controls.MetroLabel direccionLbl;
        private MetroFramework.Controls.MetroLabel clienteLbl;
        private MetroFramework.Controls.MetroLabel codigoLbl;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private FontAwesome.Sharp.IconPictureBox facturaBox;
    }
}