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
            movimientoInventarioBindingSource = new BindingSource(components);
            deTime = new MetroFramework.Controls.MetroDateTime();
            hastaTime = new MetroFramework.Controls.MetroDateTime();
            filtrarProducto = new MetroFramework.Controls.MetroTile();
            metroLabel1 = new MetroFramework.Controls.MetroLabel();
            metroLabel2 = new MetroFramework.Controls.MetroLabel();
            movimientoInventarioBindingSource1 = new BindingSource(components);
            movimientoIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            codigoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userCodeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaMovimientoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cantidadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)movimientoGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)movimientoInventarioBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)movimientoInventarioBindingSource1).BeginInit();
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
            // movimientoInventarioBindingSource
            // 
            movimientoInventarioBindingSource.DataSource = typeof(Data.MovimientoInventario);
            // 
            // deTime
            // 
            deTime.Location = new Point(444, 83);
            deTime.MinimumSize = new Size(0, 29);
            deTime.Name = "deTime";
            deTime.Size = new Size(200, 29);
            deTime.TabIndex = 1;
            // 
            // hastaTime
            // 
            hastaTime.Location = new Point(444, 118);
            hastaTime.MinimumSize = new Size(0, 29);
            hastaTime.Name = "hastaTime";
            hastaTime.Size = new Size(200, 29);
            hastaTime.TabIndex = 2;
            // 
            // filtrarProducto
            // 
            filtrarProducto.ActiveControl = null;
            filtrarProducto.BackColor = Color.SteelBlue;
            filtrarProducto.BackgroundImageLayout = ImageLayout.Stretch;
            filtrarProducto.Location = new Point(663, 83);
            filtrarProducto.Name = "filtrarProducto";
            filtrarProducto.Size = new Size(114, 64);
            filtrarProducto.TabIndex = 10;
            filtrarProducto.Text = "Filtrar";
            filtrarProducto.UseCustomBackColor = true;
            filtrarProducto.UseSelectable = true;
            filtrarProducto.UseTileImage = true;
            filtrarProducto.UseVisualStyleBackColor = false;
            // 
            // metroLabel1
            // 
            metroLabel1.AutoSize = true;
            metroLabel1.Location = new Point(386, 93);
            metroLabel1.Name = "metroLabel1";
            metroLabel1.Size = new Size(52, 19);
            metroLabel1.TabIndex = 11;
            metroLabel1.Text = "Desde: ";
            // 
            // metroLabel2
            // 
            metroLabel2.AutoSize = true;
            metroLabel2.Location = new Point(386, 128);
            metroLabel2.Name = "metroLabel2";
            metroLabel2.Size = new Size(48, 19);
            metroLabel2.TabIndex = 12;
            metroLabel2.Text = "Hasta: ";
            // 
            // movimientoInventarioBindingSource1
            // 
            movimientoInventarioBindingSource1.DataSource = typeof(Data.MovimientoInventario);
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
            // HistorialInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(metroLabel2);
            Controls.Add(metroLabel1);
            Controls.Add(filtrarProducto);
            Controls.Add(hastaTime);
            Controls.Add(deTime);
            Controls.Add(movimientoGrid);
            Name = "HistorialInventario";
            Text = "Movimiento de Inventario";
            Load += HistorialInventario_Load;
            ((System.ComponentModel.ISupportInitialize)movimientoGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)movimientoInventarioBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)movimientoInventarioBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MetroFramework.Controls.MetroGrid movimientoGrid;
        private MetroFramework.Controls.MetroDateTime deTime;
        private MetroFramework.Controls.MetroDateTime hastaTime;
        private MetroFramework.Controls.MetroTile filtrarProducto;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
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