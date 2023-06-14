namespace FacturaDom.BDO.Vistas
{
    partial class HistorialInventario
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
            movimientoGrid = new MetroFramework.Controls.MetroGrid();
            movimientoIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            codigoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userCodeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaMovimientoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cantidadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            movimientoInventarioBindingSource1 = new BindingSource(components);
            movimientoInventarioBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)movimientoGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)movimientoInventarioBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)movimientoInventarioBindingSource).BeginInit();
            SuspendLayout();
            // 
            // movimientoGrid
            // 
            movimientoGrid.AllowUserToAddRows = false;
            movimientoGrid.AllowUserToDeleteRows = false;
            movimientoGrid.AllowUserToResizeRows = false;
            movimientoGrid.AutoGenerateColumns = false;
            movimientoGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            movimientoGrid.BackgroundColor = Color.FromArgb(255, 255, 255);
            movimientoGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            movimientoGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            movimientoGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            movimientoGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            movimientoGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            movimientoGrid.Columns.AddRange(new DataGridViewColumn[] { movimientoIdDataGridViewTextBoxColumn, codigoDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, userCodeDataGridViewTextBoxColumn, tipoDataGridViewTextBoxColumn, fechaMovimientoDataGridViewTextBoxColumn, cantidadDataGridViewTextBoxColumn, userNameDataGridViewTextBoxColumn });
            movimientoGrid.DataSource = movimientoInventarioBindingSource1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            movimientoGrid.DefaultCellStyle = dataGridViewCellStyle2;
            movimientoGrid.EnableHeadersVisualStyles = false;
            movimientoGrid.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            movimientoGrid.GridColor = Color.FromArgb(255, 255, 255);
            movimientoGrid.Location = new Point(23, 162);
            movimientoGrid.Name = "movimientoGrid";
            movimientoGrid.ReadOnly = true;
            movimientoGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            movimientoGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            movimientoGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            movimientoGrid.RowTemplate.Height = 25;
            movimientoGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            movimientoGrid.Size = new Size(754, 254);
            movimientoGrid.TabIndex = 0;
            // 
            // movimientoIdDataGridViewTextBoxColumn
            // 
            movimientoIdDataGridViewTextBoxColumn.DataPropertyName = "MovimientoId";
            movimientoIdDataGridViewTextBoxColumn.HeaderText = "Codigo Movimiento";
            movimientoIdDataGridViewTextBoxColumn.Name = "movimientoIdDataGridViewTextBoxColumn";
            movimientoIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            codigoDataGridViewTextBoxColumn.HeaderText = "Codigo Producto";
            codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            codigoDataGridViewTextBoxColumn.ReadOnly = true;
            codigoDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre Producto";
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userCodeDataGridViewTextBoxColumn
            // 
            userCodeDataGridViewTextBoxColumn.DataPropertyName = "UserCode";
            userCodeDataGridViewTextBoxColumn.HeaderText = "UserCode";
            userCodeDataGridViewTextBoxColumn.Name = "userCodeDataGridViewTextBoxColumn";
            userCodeDataGridViewTextBoxColumn.ReadOnly = true;
            userCodeDataGridViewTextBoxColumn.Visible = false;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            tipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaMovimientoDataGridViewTextBoxColumn
            // 
            fechaMovimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaMovimiento";
            fechaMovimientoDataGridViewTextBoxColumn.HeaderText = "Fecha de Movimiento";
            fechaMovimientoDataGridViewTextBoxColumn.Name = "fechaMovimientoDataGridViewTextBoxColumn";
            fechaMovimientoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            userNameDataGridViewTextBoxColumn.HeaderText = "Movido Por";
            userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            userNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // movimientoInventarioBindingSource1
            // 
            movimientoInventarioBindingSource1.DataSource = typeof(Data.MovimientoInventario);
            // 
            // movimientoInventarioBindingSource
            // 
            movimientoInventarioBindingSource.DataSource = typeof(Data.MovimientoInventario);
            // 
            // HistorialInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(movimientoGrid);
            Name = "HistorialInventario";
            Text = "Movimiento de Inventario";
            Load += HistorialInventario_Load;
            ((System.ComponentModel.ISupportInitialize)movimientoGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)movimientoInventarioBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)movimientoInventarioBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MetroFramework.Controls.MetroGrid movimientoGrid;
        private DataGridViewTextBoxColumn articuloDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private BindingSource movimientoInventarioBindingSource;
        private DataGridViewTextBoxColumn movimientoIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userCodeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaMovimientoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private BindingSource movimientoInventarioBindingSource1;
    }
}