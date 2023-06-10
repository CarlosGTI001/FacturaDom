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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            facturarPanel = new MetroFramework.Controls.MetroPanel();
            articuloCantidad = new MetroFramework.Controls.MetroLabel();
            metroLabel2 = new MetroFramework.Controls.MetroLabel();
            totalRds = new MetroFramework.Controls.MetroLabel();
            metroLabel1 = new MetroFramework.Controls.MetroLabel();
            detalleGrid = new MetroFramework.Controls.MetroGrid();
            codigoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            precioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cantidadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipoMedidaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descuentoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descripcionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            detalleFacturaBindingSource = new BindingSource(components);
            imprimirFactura = new MetroFramework.Controls.MetroTile();
            productosPanel = new MetroFramework.Controls.MetroPanel();
            quitarArticulo = new MetroFramework.Controls.MetroButton();
            totalLbl = new MetroFramework.Controls.MetroLabel();
            precioLbl = new MetroFramework.Controls.MetroLabel();
            metroLabel8 = new MetroFramework.Controls.MetroLabel();
            metroLabel7 = new MetroFramework.Controls.MetroLabel();
            articuloNombre = new MetroFramework.Controls.MetroLabel();
            metroLabel5 = new MetroFramework.Controls.MetroLabel();
            agregarArticulo = new MetroFramework.Controls.MetroTile();
            metroLabel4 = new MetroFramework.Controls.MetroLabel();
            cantidadArticulo = new TextBox();
            buscarArticulo = new MetroFramework.Controls.MetroTile();
            articuloBindingSource = new BindingSource(components);
            nuevaFactura = new MetroFramework.Controls.MetroTile();
            eliminarFactura = new MetroFramework.Controls.MetroTile();
            clientePanel = new MetroFramework.Controls.MetroPanel();
            direccionLbl = new MetroFramework.Controls.MetroLabel();
            clienteLbl = new MetroFramework.Controls.MetroLabel();
            codigoLbl = new MetroFramework.Controls.MetroLabel();
            metroLabel10 = new MetroFramework.Controls.MetroLabel();
            metroLabel9 = new MetroFramework.Controls.MetroLabel();
            metroLabel6 = new MetroFramework.Controls.MetroLabel();
            facturaBox = new FontAwesome.Sharp.IconPictureBox();
            facturarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)detalleGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)detalleFacturaBindingSource).BeginInit();
            productosPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)articuloBindingSource).BeginInit();
            clientePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)facturaBox).BeginInit();
            SuspendLayout();
            // 
            // facturarPanel
            // 
            facturarPanel.Controls.Add(articuloCantidad);
            facturarPanel.Controls.Add(metroLabel2);
            facturarPanel.Controls.Add(totalRds);
            facturarPanel.Controls.Add(metroLabel1);
            facturarPanel.Controls.Add(detalleGrid);
            facturarPanel.Controls.Add(imprimirFactura);
            facturarPanel.HorizontalScrollbarBarColor = true;
            facturarPanel.HorizontalScrollbarHighlightOnWheel = false;
            facturarPanel.HorizontalScrollbarSize = 10;
            facturarPanel.Location = new Point(26, 206);
            facturarPanel.Name = "facturarPanel";
            facturarPanel.Size = new Size(552, 348);
            facturarPanel.TabIndex = 0;
            facturarPanel.VerticalScrollbarBarColor = true;
            facturarPanel.VerticalScrollbarHighlightOnWheel = false;
            facturarPanel.VerticalScrollbarSize = 10;
            // 
            // articuloCantidad
            // 
            articuloCantidad.AutoSize = true;
            articuloCantidad.FontSize = MetroFramework.MetroLabelSize.Tall;
            articuloCantidad.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            articuloCantidad.Location = new Point(385, 280);
            articuloCantidad.Name = "articuloCantidad";
            articuloCantidad.Size = new Size(22, 25);
            articuloCantidad.TabIndex = 6;
            articuloCantidad.Text = "0";
            // 
            // metroLabel2
            // 
            metroLabel2.AutoSize = true;
            metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            metroLabel2.Location = new Point(285, 280);
            metroLabel2.Name = "metroLabel2";
            metroLabel2.Size = new Size(94, 25);
            metroLabel2.TabIndex = 5;
            metroLabel2.Text = "Articulos:";
            // 
            // totalRds
            // 
            totalRds.AutoSize = true;
            totalRds.FontSize = MetroFramework.MetroLabelSize.Tall;
            totalRds.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            totalRds.Location = new Point(385, 305);
            totalRds.Name = "totalRds";
            totalRds.Size = new Size(47, 25);
            totalRds.TabIndex = 4;
            totalRds.Text = "RD$";
            // 
            // metroLabel1
            // 
            metroLabel1.AutoSize = true;
            metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            metroLabel1.Location = new Point(320, 305);
            metroLabel1.Name = "metroLabel1";
            metroLabel1.Size = new Size(59, 25);
            metroLabel1.TabIndex = 3;
            metroLabel1.Text = "Total:";
            // 
            // detalleGrid
            // 
            detalleGrid.AllowUserToAddRows = false;
            detalleGrid.AllowUserToDeleteRows = false;
            detalleGrid.AllowUserToResizeRows = false;
            detalleGrid.AutoGenerateColumns = false;
            detalleGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            detalleGrid.BackgroundColor = Color.FromArgb(255, 255, 255);
            detalleGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            detalleGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            detalleGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            detalleGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            detalleGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            detalleGrid.Columns.AddRange(new DataGridViewColumn[] { codigoDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, precioDataGridViewTextBoxColumn, cantidadDataGridViewTextBoxColumn, tipoMedidaDataGridViewTextBoxColumn, descuentoDataGridViewTextBoxColumn, totalDataGridViewTextBoxColumn, descripcionDataGridViewTextBoxColumn });
            detalleGrid.DataSource = detalleFacturaBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            detalleGrid.DefaultCellStyle = dataGridViewCellStyle2;
            detalleGrid.Dock = DockStyle.Top;
            detalleGrid.EnableHeadersVisualStyles = false;
            detalleGrid.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            detalleGrid.GridColor = Color.FromArgb(255, 255, 255);
            detalleGrid.Location = new Point(0, 0);
            detalleGrid.Name = "detalleGrid";
            detalleGrid.ReadOnly = true;
            detalleGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            detalleGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            detalleGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            detalleGrid.RowTemplate.Height = 25;
            detalleGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            detalleGrid.Size = new Size(552, 266);
            detalleGrid.TabIndex = 2;
            detalleGrid.UseStyleColors = true;
            detalleGrid.CellDoubleClick += detalleGrid_CellDoubleClick;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            codigoDataGridViewTextBoxColumn.ReadOnly = true;
            codigoDataGridViewTextBoxColumn.Visible = false;
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
            precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            precioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoMedidaDataGridViewTextBoxColumn
            // 
            tipoMedidaDataGridViewTextBoxColumn.DataPropertyName = "TipoMedida";
            tipoMedidaDataGridViewTextBoxColumn.HeaderText = "Medida";
            tipoMedidaDataGridViewTextBoxColumn.Name = "tipoMedidaDataGridViewTextBoxColumn";
            tipoMedidaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descuentoDataGridViewTextBoxColumn
            // 
            descuentoDataGridViewTextBoxColumn.DataPropertyName = "descuento";
            descuentoDataGridViewTextBoxColumn.HeaderText = "descuento";
            descuentoDataGridViewTextBoxColumn.Name = "descuentoDataGridViewTextBoxColumn";
            descuentoDataGridViewTextBoxColumn.ReadOnly = true;
            descuentoDataGridViewTextBoxColumn.Visible = false;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            totalDataGridViewTextBoxColumn.HeaderText = "Total";
            totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            descripcionDataGridViewTextBoxColumn.Visible = false;
            // 
            // detalleFacturaBindingSource
            // 
            detalleFacturaBindingSource.DataSource = typeof(Modelos.DetalleFactura);
            // 
            // imprimirFactura
            // 
            imprimirFactura.ActiveControl = null;
            imprimirFactura.BackColor = Color.SteelBlue;
            imprimirFactura.Location = new Point(19, 280);
            imprimirFactura.Name = "imprimirFactura";
            imprimirFactura.Size = new Size(114, 57);
            imprimirFactura.TabIndex = 5;
            imprimirFactura.Text = "Terminar \r\npedido";
            imprimirFactura.TileImageAlign = ContentAlignment.MiddleRight;
            imprimirFactura.UseCustomBackColor = true;
            imprimirFactura.UseSelectable = true;
            imprimirFactura.UseTileImage = true;
            imprimirFactura.UseVisualStyleBackColor = false;
            imprimirFactura.Click += imprimirFactura_Click;
            // 
            // productosPanel
            // 
            productosPanel.BackColor = Color.White;
            productosPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            productosPanel.Controls.Add(quitarArticulo);
            productosPanel.Controls.Add(totalLbl);
            productosPanel.Controls.Add(precioLbl);
            productosPanel.Controls.Add(metroLabel8);
            productosPanel.Controls.Add(metroLabel7);
            productosPanel.Controls.Add(articuloNombre);
            productosPanel.Controls.Add(metroLabel5);
            productosPanel.Controls.Add(agregarArticulo);
            productosPanel.Controls.Add(metroLabel4);
            productosPanel.Controls.Add(cantidadArticulo);
            productosPanel.Controls.Add(buscarArticulo);
            productosPanel.HorizontalScrollbarBarColor = true;
            productosPanel.HorizontalScrollbarHighlightOnWheel = false;
            productosPanel.HorizontalScrollbarSize = 10;
            productosPanel.Location = new Point(584, 206);
            productosPanel.Name = "productosPanel";
            productosPanel.Size = new Size(294, 348);
            productosPanel.TabIndex = 1;
            productosPanel.UseCustomBackColor = true;
            productosPanel.VerticalScrollbarBarColor = true;
            productosPanel.VerticalScrollbarHighlightOnWheel = false;
            productosPanel.VerticalScrollbarSize = 10;
            // 
            // quitarArticulo
            // 
            quitarArticulo.BackColor = Color.Red;
            quitarArticulo.ForeColor = SystemColors.ControlLightLight;
            quitarArticulo.Location = new Point(223, 138);
            quitarArticulo.Name = "quitarArticulo";
            quitarArticulo.Size = new Size(29, 29);
            quitarArticulo.TabIndex = 16;
            quitarArticulo.Text = "X";
            quitarArticulo.UseCompatibleTextRendering = true;
            quitarArticulo.UseCustomBackColor = true;
            quitarArticulo.UseCustomForeColor = true;
            quitarArticulo.UseSelectable = true;
            quitarArticulo.UseVisualStyleBackColor = false;
            quitarArticulo.Click += quitarArticulo_Click;
            // 
            // totalLbl
            // 
            totalLbl.AutoSize = true;
            totalLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            totalLbl.Location = new Point(91, 174);
            totalLbl.Name = "totalLbl";
            totalLbl.Size = new Size(43, 19);
            totalLbl.TabIndex = 15;
            totalLbl.Text = "RD$ -";
            totalLbl.UseCustomBackColor = true;
            // 
            // precioLbl
            // 
            precioLbl.AutoSize = true;
            precioLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            precioLbl.Location = new Point(101, 89);
            precioLbl.Name = "precioLbl";
            precioLbl.Size = new Size(43, 19);
            precioLbl.TabIndex = 14;
            precioLbl.Text = "RD$ -";
            precioLbl.UseCustomBackColor = true;
            // 
            // metroLabel8
            // 
            metroLabel8.AutoSize = true;
            metroLabel8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            metroLabel8.Location = new Point(46, 174);
            metroLabel8.Name = "metroLabel8";
            metroLabel8.Size = new Size(39, 19);
            metroLabel8.TabIndex = 13;
            metroLabel8.Text = "Total:";
            metroLabel8.UseCustomBackColor = true;
            // 
            // metroLabel7
            // 
            metroLabel7.AutoSize = true;
            metroLabel7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            metroLabel7.Location = new Point(46, 89);
            metroLabel7.Name = "metroLabel7";
            metroLabel7.Size = new Size(49, 19);
            metroLabel7.TabIndex = 12;
            metroLabel7.Text = "Precio:";
            metroLabel7.UseCustomBackColor = true;
            // 
            // articuloNombre
            // 
            articuloNombre.AutoSize = true;
            articuloNombre.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            articuloNombre.Location = new Point(101, 63);
            articuloNombre.Name = "articuloNombre";
            articuloNombre.Size = new Size(15, 19);
            articuloNombre.TabIndex = 11;
            articuloNombre.Text = "-";
            articuloNombre.UseCustomBackColor = true;
            // 
            // metroLabel5
            // 
            metroLabel5.AutoSize = true;
            metroLabel5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            metroLabel5.Location = new Point(37, 63);
            metroLabel5.Name = "metroLabel5";
            metroLabel5.Size = new Size(58, 19);
            metroLabel5.TabIndex = 10;
            metroLabel5.Text = "Articulo:";
            metroLabel5.UseCustomBackColor = true;
            // 
            // agregarArticulo
            // 
            agregarArticulo.ActiveControl = null;
            agregarArticulo.BackColor = Color.SteelBlue;
            agregarArticulo.Enabled = false;
            agregarArticulo.Location = new Point(157, 227);
            agregarArticulo.Name = "agregarArticulo";
            agregarArticulo.Size = new Size(114, 59);
            agregarArticulo.TabIndex = 5;
            agregarArticulo.Text = "Agregar\r\nArticulo";
            agregarArticulo.TileImageAlign = ContentAlignment.MiddleRight;
            agregarArticulo.UseCustomBackColor = true;
            agregarArticulo.UseSelectable = true;
            agregarArticulo.UseTileImage = true;
            agregarArticulo.UseVisualStyleBackColor = false;
            agregarArticulo.Click += agregarArticulo_Click;
            // 
            // metroLabel4
            // 
            metroLabel4.AutoSize = true;
            metroLabel4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            metroLabel4.Location = new Point(37, 114);
            metroLabel4.Name = "metroLabel4";
            metroLabel4.Size = new Size(62, 19);
            metroLabel4.TabIndex = 9;
            metroLabel4.Text = "Cantidad";
            metroLabel4.UseCustomBackColor = true;
            // 
            // cantidadArticulo
            // 
            cantidadArticulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cantidadArticulo.Location = new Point(37, 138);
            cantidadArticulo.Name = "cantidadArticulo";
            cantidadArticulo.Size = new Size(180, 33);
            cantidadArticulo.TabIndex = 8;
            cantidadArticulo.Text = "0";
            cantidadArticulo.TextChanged += cantidadArticulo_TextChanged;
            // 
            // buscarArticulo
            // 
            buscarArticulo.ActiveControl = null;
            buscarArticulo.BackColor = Color.SteelBlue;
            buscarArticulo.Location = new Point(37, 227);
            buscarArticulo.Name = "buscarArticulo";
            buscarArticulo.Size = new Size(114, 59);
            buscarArticulo.TabIndex = 4;
            buscarArticulo.Text = "Buscar\r\nArticulo";
            buscarArticulo.TileImageAlign = ContentAlignment.MiddleRight;
            buscarArticulo.UseCustomBackColor = true;
            buscarArticulo.UseSelectable = true;
            buscarArticulo.UseTileImage = true;
            buscarArticulo.UseVisualStyleBackColor = false;
            buscarArticulo.Click += buscarArticulo_Click;
            // 
            // articuloBindingSource
            // 
            articuloBindingSource.DataSource = typeof(Modelos.Articulo);
            // 
            // nuevaFactura
            // 
            nuevaFactura.ActiveControl = null;
            nuevaFactura.BackColor = Color.SteelBlue;
            nuevaFactura.Location = new Point(764, 75);
            nuevaFactura.Name = "nuevaFactura";
            nuevaFactura.Size = new Size(114, 110);
            nuevaFactura.TabIndex = 4;
            nuevaFactura.Text = "Nueva\r\nFactura";
            nuevaFactura.TileImageAlign = ContentAlignment.TopRight;
            nuevaFactura.UseCustomBackColor = true;
            nuevaFactura.UseSelectable = true;
            nuevaFactura.UseTileImage = true;
            nuevaFactura.UseVisualStyleBackColor = false;
            nuevaFactura.Click += nuevaFactura_Click;
            // 
            // eliminarFactura
            // 
            eliminarFactura.ActiveControl = null;
            eliminarFactura.BackColor = Color.SteelBlue;
            eliminarFactura.Location = new Point(26, 75);
            eliminarFactura.Name = "eliminarFactura";
            eliminarFactura.Size = new Size(114, 110);
            eliminarFactura.TabIndex = 6;
            eliminarFactura.Text = "Eliminar";
            eliminarFactura.TileImageAlign = ContentAlignment.TopRight;
            eliminarFactura.UseCustomBackColor = true;
            eliminarFactura.UseSelectable = true;
            eliminarFactura.UseTileImage = true;
            eliminarFactura.UseVisualStyleBackColor = false;
            eliminarFactura.Click += eliminarFactura_Click;
            // 
            // clientePanel
            // 
            clientePanel.BackColor = Color.White;
            clientePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            clientePanel.Controls.Add(direccionLbl);
            clientePanel.Controls.Add(clienteLbl);
            clientePanel.Controls.Add(codigoLbl);
            clientePanel.Controls.Add(metroLabel10);
            clientePanel.Controls.Add(metroLabel9);
            clientePanel.Controls.Add(metroLabel6);
            clientePanel.HorizontalScrollbarBarColor = true;
            clientePanel.HorizontalScrollbarHighlightOnWheel = false;
            clientePanel.HorizontalScrollbarSize = 10;
            clientePanel.Location = new Point(152, 75);
            clientePanel.Name = "clientePanel";
            clientePanel.Size = new Size(600, 110);
            clientePanel.TabIndex = 7;
            clientePanel.UseCustomBackColor = true;
            clientePanel.VerticalScrollbarBarColor = true;
            clientePanel.VerticalScrollbarHighlightOnWheel = false;
            clientePanel.VerticalScrollbarSize = 10;
            // 
            // direccionLbl
            // 
            direccionLbl.AutoSize = true;
            direccionLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            direccionLbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            direccionLbl.Location = new Point(109, 74);
            direccionLbl.Name = "direccionLbl";
            direccionLbl.Size = new Size(19, 25);
            direccionLbl.TabIndex = 12;
            direccionLbl.Text = "-";
            direccionLbl.UseCustomBackColor = true;
            // 
            // clienteLbl
            // 
            clienteLbl.AutoSize = true;
            clienteLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            clienteLbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            clienteLbl.Location = new Point(109, 39);
            clienteLbl.Name = "clienteLbl";
            clienteLbl.Size = new Size(19, 25);
            clienteLbl.TabIndex = 11;
            clienteLbl.Text = "-";
            clienteLbl.UseCustomBackColor = true;
            // 
            // codigoLbl
            // 
            codigoLbl.AutoSize = true;
            codigoLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            codigoLbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            codigoLbl.Location = new Point(109, 7);
            codigoLbl.Name = "codigoLbl";
            codigoLbl.Size = new Size(19, 25);
            codigoLbl.TabIndex = 10;
            codigoLbl.Text = "-";
            codigoLbl.UseCustomBackColor = true;
            // 
            // metroLabel10
            // 
            metroLabel10.AutoSize = true;
            metroLabel10.FontSize = MetroFramework.MetroLabelSize.Tall;
            metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            metroLabel10.Location = new Point(14, 7);
            metroLabel10.Name = "metroLabel10";
            metroLabel10.Size = new Size(90, 25);
            metroLabel10.TabIndex = 9;
            metroLabel10.Text = "Factura #";
            metroLabel10.UseCustomBackColor = true;
            // 
            // metroLabel9
            // 
            metroLabel9.AutoSize = true;
            metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            metroLabel9.Location = new Point(3, 74);
            metroLabel9.Name = "metroLabel9";
            metroLabel9.Size = new Size(102, 25);
            metroLabel9.TabIndex = 8;
            metroLabel9.Text = "Direccion :";
            metroLabel9.UseCustomBackColor = true;
            // 
            // metroLabel6
            // 
            metroLabel6.AutoSize = true;
            metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            metroLabel6.Location = new Point(22, 39);
            metroLabel6.Name = "metroLabel6";
            metroLabel6.Size = new Size(81, 25);
            metroLabel6.TabIndex = 7;
            metroLabel6.Text = "Cliente :";
            metroLabel6.UseCustomBackColor = true;
            // 
            // facturaBox
            // 
            facturaBox.BackColor = Color.FromArgb(255, 255, 255);
            facturaBox.ForeColor = Color.SteelBlue;
            facturaBox.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            facturaBox.IconColor = Color.SteelBlue;
            facturaBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            facturaBox.IconSize = 218;
            facturaBox.Location = new Point(323, 208);
            facturaBox.Name = "facturaBox";
            facturaBox.Size = new Size(255, 218);
            facturaBox.TabIndex = 8;
            facturaBox.TabStop = false;
            // 
            // Factura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 577);
            Controls.Add(clientePanel);
            Controls.Add(eliminarFactura);
            Controls.Add(nuevaFactura);
            Controls.Add(productosPanel);
            Controls.Add(facturarPanel);
            Controls.Add(facturaBox);
            Name = "Factura";
            Text = "Facturar";
            Load += Factura_Load;
            facturarPanel.ResumeLayout(false);
            facturarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)detalleGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)detalleFacturaBindingSource).EndInit();
            productosPanel.ResumeLayout(false);
            productosPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)articuloBindingSource).EndInit();
            clientePanel.ResumeLayout(false);
            clientePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)facturaBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MetroFramework.Controls.MetroPanel facturarPanel;
        private MetroFramework.Controls.MetroPanel productosPanel;
        private MetroFramework.Controls.MetroLabel articuloCantidad;
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
        private MetroFramework.Controls.MetroTile imprimirFactura;
        private MetroFramework.Controls.MetroTile eliminarFactura;
        private MetroFramework.Controls.MetroTile buscarArticulo;
        private MetroFramework.Controls.MetroLabel totalLbl;
        private MetroFramework.Controls.MetroLabel precioLbl;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel articuloNombre;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTile agregarArticulo;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private TextBox cantidadArticulo;
        private MetroFramework.Controls.MetroPanel clientePanel;
        private MetroFramework.Controls.MetroLabel direccionLbl;
        private MetroFramework.Controls.MetroLabel clienteLbl;
        private MetroFramework.Controls.MetroLabel codigoLbl;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private FontAwesome.Sharp.IconPictureBox facturaBox;
        private MetroFramework.Controls.MetroButton quitarArticulo;
    }
}