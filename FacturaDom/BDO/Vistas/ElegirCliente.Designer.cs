namespace FacturaDom.BDO.Vistas
{
    partial class ElegirCliente
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
            this.clienteGrid = new MetroFramework.Controls.MetroGrid();
            this.codigoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteReferidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasTotalesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroTelefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habilitadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.busquedaText = new System.Windows.Forms.TextBox();
            this.elegir_Cliente = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.clienteGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // clienteGrid
            // 
            this.clienteGrid.AllowUserToAddRows = false;
            this.clienteGrid.AllowUserToDeleteRows = false;
            this.clienteGrid.AllowUserToResizeRows = false;
            this.clienteGrid.AutoGenerateColumns = false;
            this.clienteGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clienteGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.clienteGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clienteGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.clienteGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clienteGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.clienteGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clienteGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoClienteDataGridViewTextBoxColumn,
            this.cedulaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.comprasClienteDataGridViewTextBoxColumn,
            this.clienteReferidoDataGridViewTextBoxColumn,
            this.comprasTotalesDataGridViewTextBoxColumn,
            this.numeroTelefonoDataGridViewTextBoxColumn,
            this.fechaNacimientoDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.habilitadoDataGridViewCheckBoxColumn});
            this.clienteGrid.DataSource = this.clienteBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.clienteGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.clienteGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.clienteGrid.EnableHeadersVisualStyles = false;
            this.clienteGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.clienteGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.clienteGrid.Location = new System.Drawing.Point(20, 202);
            this.clienteGrid.Name = "clienteGrid";
            this.clienteGrid.ReadOnly = true;
            this.clienteGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clienteGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.clienteGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.clienteGrid.RowTemplate.Height = 25;
            this.clienteGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clienteGrid.Size = new System.Drawing.Size(521, 204);
            this.clienteGrid.TabIndex = 0;
            this.clienteGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clienteGrid_CellClick);
            // 
            // codigoClienteDataGridViewTextBoxColumn
            // 
            this.codigoClienteDataGridViewTextBoxColumn.DataPropertyName = "CodigoCliente";
            this.codigoClienteDataGridViewTextBoxColumn.HeaderText = "CodigoCliente";
            this.codigoClienteDataGridViewTextBoxColumn.Name = "codigoClienteDataGridViewTextBoxColumn";
            this.codigoClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoClienteDataGridViewTextBoxColumn.Visible = false;
            // 
            // cedulaDataGridViewTextBoxColumn
            // 
            this.cedulaDataGridViewTextBoxColumn.DataPropertyName = "Cedula";
            this.cedulaDataGridViewTextBoxColumn.HeaderText = "Cedula";
            this.cedulaDataGridViewTextBoxColumn.Name = "cedulaDataGridViewTextBoxColumn";
            this.cedulaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            this.apellidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // comprasClienteDataGridViewTextBoxColumn
            // 
            this.comprasClienteDataGridViewTextBoxColumn.DataPropertyName = "ComprasCliente";
            this.comprasClienteDataGridViewTextBoxColumn.HeaderText = "ComprasCliente";
            this.comprasClienteDataGridViewTextBoxColumn.Name = "comprasClienteDataGridViewTextBoxColumn";
            this.comprasClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.comprasClienteDataGridViewTextBoxColumn.Visible = false;
            // 
            // clienteReferidoDataGridViewTextBoxColumn
            // 
            this.clienteReferidoDataGridViewTextBoxColumn.DataPropertyName = "ClienteReferido";
            this.clienteReferidoDataGridViewTextBoxColumn.HeaderText = "ClienteReferido";
            this.clienteReferidoDataGridViewTextBoxColumn.Name = "clienteReferidoDataGridViewTextBoxColumn";
            this.clienteReferidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.clienteReferidoDataGridViewTextBoxColumn.Visible = false;
            // 
            // comprasTotalesDataGridViewTextBoxColumn
            // 
            this.comprasTotalesDataGridViewTextBoxColumn.DataPropertyName = "ComprasTotales";
            this.comprasTotalesDataGridViewTextBoxColumn.HeaderText = "ComprasTotales";
            this.comprasTotalesDataGridViewTextBoxColumn.Name = "comprasTotalesDataGridViewTextBoxColumn";
            this.comprasTotalesDataGridViewTextBoxColumn.ReadOnly = true;
            this.comprasTotalesDataGridViewTextBoxColumn.Visible = false;
            // 
            // numeroTelefonoDataGridViewTextBoxColumn
            // 
            this.numeroTelefonoDataGridViewTextBoxColumn.DataPropertyName = "NumeroTelefono";
            this.numeroTelefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.numeroTelefonoDataGridViewTextBoxColumn.Name = "numeroTelefonoDataGridViewTextBoxColumn";
            this.numeroTelefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaNacimientoDataGridViewTextBoxColumn
            // 
            this.fechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "fechaNacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn.HeaderText = "fechaNacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn.Name = "fechaNacimientoDataGridViewTextBoxColumn";
            this.fechaNacimientoDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaNacimientoDataGridViewTextBoxColumn.Visible = false;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            this.direccionDataGridViewTextBoxColumn.Visible = false;
            // 
            // habilitadoDataGridViewCheckBoxColumn
            // 
            this.habilitadoDataGridViewCheckBoxColumn.DataPropertyName = "Habilitado";
            this.habilitadoDataGridViewCheckBoxColumn.HeaderText = "Habilitado";
            this.habilitadoDataGridViewCheckBoxColumn.Name = "habilitadoDataGridViewCheckBoxColumn";
            this.habilitadoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.habilitadoDataGridViewCheckBoxColumn.Visible = false;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(FacturaDom.BDO.Modelos.Cliente);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroLabel3.Location = new System.Drawing.Point(23, 109);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(50, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Cedula";
            // 
            // busquedaText
            // 
            this.busquedaText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.busquedaText.Location = new System.Drawing.Point(23, 135);
            this.busquedaText.Name = "busquedaText";
            this.busquedaText.Size = new System.Drawing.Size(180, 33);
            this.busquedaText.TabIndex = 8;
            this.busquedaText.TextChanged += new System.EventHandler(this.busquedaText_TextChanged);
            // 
            // elegir_Cliente
            // 
            this.elegir_Cliente.ActiveControl = null;
            this.elegir_Cliente.BackColor = System.Drawing.Color.SteelBlue;
            this.elegir_Cliente.Location = new System.Drawing.Point(424, 109);
            this.elegir_Cliente.Name = "elegir_Cliente";
            this.elegir_Cliente.Size = new System.Drawing.Size(114, 59);
            this.elegir_Cliente.TabIndex = 10;
            this.elegir_Cliente.Text = "Elegir\r\nCliente";
            this.elegir_Cliente.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.elegir_Cliente.UseCustomBackColor = true;
            this.elegir_Cliente.UseSelectable = true;
            this.elegir_Cliente.UseTileImage = true;
            this.elegir_Cliente.UseVisualStyleBackColor = false;
            this.elegir_Cliente.Click += new System.EventHandler(this.elegir_Cliente_Click);
            // 
            // ElegirCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 426);
            this.Controls.Add(this.elegir_Cliente);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.busquedaText);
            this.Controls.Add(this.clienteGrid);
            this.Name = "ElegirCliente";
            this.Text = "Elegir Cliente";
            this.Load += new System.EventHandler(this.ElegirCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clienteGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid clienteGrid;
        private DataGridViewTextBoxColumn codigoClienteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn comprasClienteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn clienteReferidoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn comprasTotalesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numeroTelefonoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn habilitadoDataGridViewCheckBoxColumn;
        private BindingSource clienteBindingSource;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private TextBox busquedaText;
        private MetroFramework.Controls.MetroTile elegir_Cliente;
    }
}