namespace FacturaDom.BDO.Vistas
{
    partial class FacturasHistorial
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
            facturaGrid = new MetroFramework.Controls.MetroGrid();
            codigoFacturaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            codeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descripcionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            codigoClienteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreClienteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userCodeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalFacturaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaFacturaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            precioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cantidadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipoMedidaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descuentoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            apellidoClienteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cedulaClienteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            codigoProductoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            facturaDetalleBindingSource1 = new BindingSource(components);
            facturaBindingSource = new BindingSource(components);
            facturaDetalleBindingSource = new BindingSource(components);
            busquedaText = new TextBox();
            metroLabel3 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)facturaGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)facturaDetalleBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)facturaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)facturaDetalleBindingSource).BeginInit();
            SuspendLayout();
            // 
            // facturaGrid
            // 
            facturaGrid.AllowUserToAddRows = false;
            facturaGrid.AllowUserToDeleteRows = false;
            facturaGrid.AllowUserToResizeRows = false;
            facturaGrid.AutoGenerateColumns = false;
            facturaGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            facturaGrid.BackgroundColor = Color.FromArgb(255, 255, 255);
            facturaGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            facturaGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            facturaGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            facturaGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            facturaGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            facturaGrid.Columns.AddRange(new DataGridViewColumn[] { codigoFacturaDataGridViewTextBoxColumn, codeDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, descripcionDataGridViewTextBoxColumn, codigoClienteDataGridViewTextBoxColumn, nombreClienteDataGridViewTextBoxColumn, userCodeDataGridViewTextBoxColumn, userNameDataGridViewTextBoxColumn, totalFacturaDataGridViewTextBoxColumn, fechaFacturaDataGridViewTextBoxColumn, precioDataGridViewTextBoxColumn, cantidadDataGridViewTextBoxColumn, tipoMedidaDataGridViewTextBoxColumn, descuentoDataGridViewTextBoxColumn, totalDataGridViewTextBoxColumn, apellidoClienteDataGridViewTextBoxColumn, cedulaClienteDataGridViewTextBoxColumn, codigoProductoDataGridViewTextBoxColumn });
            facturaGrid.DataSource = facturaDetalleBindingSource1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            facturaGrid.DefaultCellStyle = dataGridViewCellStyle2;
            facturaGrid.EnableHeadersVisualStyles = false;
            facturaGrid.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            facturaGrid.GridColor = Color.FromArgb(255, 255, 255);
            facturaGrid.Location = new Point(23, 182);
            facturaGrid.Name = "facturaGrid";
            facturaGrid.ReadOnly = true;
            facturaGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            facturaGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            facturaGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            facturaGrid.RowTemplate.Height = 25;
            facturaGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            facturaGrid.Size = new Size(754, 271);
            facturaGrid.TabIndex = 0;
            facturaGrid.CellDoubleClick += facturaGrid_CellDoubleClick;
            // 
            // codigoFacturaDataGridViewTextBoxColumn
            // 
            codigoFacturaDataGridViewTextBoxColumn.DataPropertyName = "CodigoFactura";
            codigoFacturaDataGridViewTextBoxColumn.HeaderText = "N. Factura";
            codigoFacturaDataGridViewTextBoxColumn.Name = "codigoFacturaDataGridViewTextBoxColumn";
            codigoFacturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            codeDataGridViewTextBoxColumn.HeaderText = "code";
            codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            codeDataGridViewTextBoxColumn.ReadOnly = true;
            codeDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.ReadOnly = true;
            nombreDataGridViewTextBoxColumn.Visible = false;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            descripcionDataGridViewTextBoxColumn.Visible = false;
            // 
            // codigoClienteDataGridViewTextBoxColumn
            // 
            codigoClienteDataGridViewTextBoxColumn.DataPropertyName = "CodigoCliente";
            codigoClienteDataGridViewTextBoxColumn.HeaderText = "Cliente Cedula";
            codigoClienteDataGridViewTextBoxColumn.Name = "codigoClienteDataGridViewTextBoxColumn";
            codigoClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreClienteDataGridViewTextBoxColumn
            // 
            nombreClienteDataGridViewTextBoxColumn.DataPropertyName = "NombreCliente";
            nombreClienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            nombreClienteDataGridViewTextBoxColumn.Name = "nombreClienteDataGridViewTextBoxColumn";
            nombreClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userCodeDataGridViewTextBoxColumn
            // 
            userCodeDataGridViewTextBoxColumn.DataPropertyName = "UserCode";
            userCodeDataGridViewTextBoxColumn.HeaderText = "UserCode";
            userCodeDataGridViewTextBoxColumn.Name = "userCodeDataGridViewTextBoxColumn";
            userCodeDataGridViewTextBoxColumn.ReadOnly = true;
            userCodeDataGridViewTextBoxColumn.Visible = false;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            userNameDataGridViewTextBoxColumn.HeaderText = "Vendedor";
            userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            userNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalFacturaDataGridViewTextBoxColumn
            // 
            totalFacturaDataGridViewTextBoxColumn.DataPropertyName = "TotalFactura";
            totalFacturaDataGridViewTextBoxColumn.HeaderText = "Total";
            totalFacturaDataGridViewTextBoxColumn.Name = "totalFacturaDataGridViewTextBoxColumn";
            totalFacturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaFacturaDataGridViewTextBoxColumn
            // 
            fechaFacturaDataGridViewTextBoxColumn.DataPropertyName = "FechaFactura";
            fechaFacturaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            fechaFacturaDataGridViewTextBoxColumn.Name = "fechaFacturaDataGridViewTextBoxColumn";
            fechaFacturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            precioDataGridViewTextBoxColumn.ReadOnly = true;
            precioDataGridViewTextBoxColumn.Visible = false;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            cantidadDataGridViewTextBoxColumn.Visible = false;
            // 
            // tipoMedidaDataGridViewTextBoxColumn
            // 
            tipoMedidaDataGridViewTextBoxColumn.DataPropertyName = "TipoMedida";
            tipoMedidaDataGridViewTextBoxColumn.HeaderText = "TipoMedida";
            tipoMedidaDataGridViewTextBoxColumn.Name = "tipoMedidaDataGridViewTextBoxColumn";
            tipoMedidaDataGridViewTextBoxColumn.ReadOnly = true;
            tipoMedidaDataGridViewTextBoxColumn.Visible = false;
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
            totalDataGridViewTextBoxColumn.Visible = false;
            // 
            // apellidoClienteDataGridViewTextBoxColumn
            // 
            apellidoClienteDataGridViewTextBoxColumn.DataPropertyName = "ApellidoCliente";
            apellidoClienteDataGridViewTextBoxColumn.HeaderText = "ApellidoCliente";
            apellidoClienteDataGridViewTextBoxColumn.Name = "apellidoClienteDataGridViewTextBoxColumn";
            apellidoClienteDataGridViewTextBoxColumn.ReadOnly = true;
            apellidoClienteDataGridViewTextBoxColumn.Visible = false;
            // 
            // cedulaClienteDataGridViewTextBoxColumn
            // 
            cedulaClienteDataGridViewTextBoxColumn.DataPropertyName = "CedulaCliente";
            cedulaClienteDataGridViewTextBoxColumn.HeaderText = "CedulaCliente";
            cedulaClienteDataGridViewTextBoxColumn.Name = "cedulaClienteDataGridViewTextBoxColumn";
            cedulaClienteDataGridViewTextBoxColumn.ReadOnly = true;
            cedulaClienteDataGridViewTextBoxColumn.Visible = false;
            // 
            // codigoProductoDataGridViewTextBoxColumn
            // 
            codigoProductoDataGridViewTextBoxColumn.DataPropertyName = "CodigoProducto";
            codigoProductoDataGridViewTextBoxColumn.HeaderText = "CodigoProducto";
            codigoProductoDataGridViewTextBoxColumn.Name = "codigoProductoDataGridViewTextBoxColumn";
            codigoProductoDataGridViewTextBoxColumn.ReadOnly = true;
            codigoProductoDataGridViewTextBoxColumn.Visible = false;
            // 
            // facturaDetalleBindingSource1
            // 
            facturaDetalleBindingSource1.DataSource = typeof(Modelos.FacturaDetalle);
            // 
            // facturaBindingSource
            // 
            facturaBindingSource.DataSource = typeof(Modelos.Factura);
            // 
            // facturaDetalleBindingSource
            // 
            facturaDetalleBindingSource.DataSource = typeof(Modelos.FacturaDetalle);
            // 
            // busquedaText
            // 
            busquedaText.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            busquedaText.Location = new Point(22, 133);
            busquedaText.Name = "busquedaText";
            busquedaText.Size = new Size(228, 33);
            busquedaText.TabIndex = 18;
            busquedaText.TextChanged += nombresText_TextChanged;
            // 
            // metroLabel3
            // 
            metroLabel3.AutoSize = true;
            metroLabel3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            metroLabel3.Location = new Point(22, 102);
            metroLabel3.Name = "metroLabel3";
            metroLabel3.Size = new Size(66, 19);
            metroLabel3.TabIndex = 19;
            metroLabel3.Text = "Busqueda";
            // 
            // FacturasHistorial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 476);
            Controls.Add(busquedaText);
            Controls.Add(metroLabel3);
            Controls.Add(facturaGrid);
            Name = "FacturasHistorial";
            Text = "Facturas";
            Load += FacturasHistorial_Load;
            ((System.ComponentModel.ISupportInitialize)facturaGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)facturaDetalleBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)facturaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)facturaDetalleBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MetroFramework.Controls.MetroGrid facturaGrid;
        private BindingSource facturaBindingSource;
        private DataGridViewTextBoxColumn codigoFacturaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codigoClienteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreClienteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userCodeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalFacturaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaFacturaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoMedidaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descuentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidoClienteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cedulaClienteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codigoProductoDataGridViewTextBoxColumn;
        private BindingSource facturaDetalleBindingSource1;
        private BindingSource facturaDetalleBindingSource;
        private TextBox busquedaText;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}