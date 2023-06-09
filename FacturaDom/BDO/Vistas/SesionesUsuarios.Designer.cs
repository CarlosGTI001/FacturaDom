namespace FacturaDom.BDO.Vistas
{
    partial class SesionesUsuarios
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            metroGrid1 = new MetroFramework.Controls.MetroGrid();
            sesionesGrid = new MetroFramework.Controls.MetroGrid();
            sesionIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userCodeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            apellidoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            entradaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            salidaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sesionesUsuarioBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)metroGrid1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sesionesGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sesionesUsuarioBindingSource).BeginInit();
            SuspendLayout();
            // 
            // metroGrid1
            // 
            metroGrid1.AllowUserToAddRows = false;
            metroGrid1.AllowUserToDeleteRows = false;
            metroGrid1.AllowUserToResizeRows = false;
            metroGrid1.BackgroundColor = Color.FromArgb(255, 255, 255);
            metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            metroGrid1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            metroGrid1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            metroGrid1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            metroGrid1.EnableHeadersVisualStyles = false;
            metroGrid1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            metroGrid1.GridColor = Color.FromArgb(255, 255, 255);
            metroGrid1.Location = new Point(102, 195);
            metroGrid1.Name = "metroGrid1";
            metroGrid1.ReadOnly = true;
            metroGrid1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            metroGrid1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            metroGrid1.RowTemplate.Height = 25;
            metroGrid1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            metroGrid1.Size = new Size(240, 150);
            metroGrid1.TabIndex = 0;
            // 
            // sesionesGrid
            // 
            sesionesGrid.AllowUserToAddRows = false;
            sesionesGrid.AllowUserToDeleteRows = false;
            sesionesGrid.AllowUserToResizeRows = false;
            sesionesGrid.AutoGenerateColumns = false;
            sesionesGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            sesionesGrid.BackgroundColor = Color.FromArgb(255, 255, 255);
            sesionesGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            sesionesGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            sesionesGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            sesionesGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            sesionesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            sesionesGrid.Columns.AddRange(new DataGridViewColumn[] { sesionIDDataGridViewTextBoxColumn, userCodeDataGridViewTextBoxColumn, userNameDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, apellidoDataGridViewTextBoxColumn, entradaDataGridViewTextBoxColumn, salidaDataGridViewTextBoxColumn });
            sesionesGrid.DataSource = sesionesUsuarioBindingSource;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            sesionesGrid.DefaultCellStyle = dataGridViewCellStyle5;
            sesionesGrid.EnableHeadersVisualStyles = false;
            sesionesGrid.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            sesionesGrid.GridColor = Color.FromArgb(255, 255, 255);
            sesionesGrid.Location = new Point(23, 130);
            sesionesGrid.Name = "sesionesGrid";
            sesionesGrid.ReadOnly = true;
            sesionesGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            sesionesGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            sesionesGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            sesionesGrid.RowTemplate.Height = 25;
            sesionesGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            sesionesGrid.Size = new Size(874, 331);
            sesionesGrid.TabIndex = 1;
            // 
            // sesionIDDataGridViewTextBoxColumn
            // 
            sesionIDDataGridViewTextBoxColumn.DataPropertyName = "SesionID";
            sesionIDDataGridViewTextBoxColumn.HeaderText = "Codigo de Sesion";
            sesionIDDataGridViewTextBoxColumn.Name = "sesionIDDataGridViewTextBoxColumn";
            sesionIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userCodeDataGridViewTextBoxColumn
            // 
            userCodeDataGridViewTextBoxColumn.DataPropertyName = "UserCode";
            userCodeDataGridViewTextBoxColumn.HeaderText = "UserCode";
            userCodeDataGridViewTextBoxColumn.Name = "userCodeDataGridViewTextBoxColumn";
            userCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            userNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            apellidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // entradaDataGridViewTextBoxColumn
            // 
            entradaDataGridViewTextBoxColumn.DataPropertyName = "entrada";
            entradaDataGridViewTextBoxColumn.HeaderText = "Fecha y Hora de Entrada";
            entradaDataGridViewTextBoxColumn.Name = "entradaDataGridViewTextBoxColumn";
            entradaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salidaDataGridViewTextBoxColumn
            // 
            salidaDataGridViewTextBoxColumn.DataPropertyName = "salida";
            salidaDataGridViewTextBoxColumn.HeaderText = "Fecha y Hora de Salida";
            salidaDataGridViewTextBoxColumn.Name = "salidaDataGridViewTextBoxColumn";
            salidaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sesionesUsuarioBindingSource
            // 
            sesionesUsuarioBindingSource.DataSource = typeof(Data.SesionesUsuario);
            // 
            // SesionesUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 484);
            Controls.Add(sesionesGrid);
            Controls.Add(metroGrid1);
            Name = "SesionesUsuarios";
            Text = "Sesiones Anteriores";
            Load += SesionesUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)metroGrid1).EndInit();
            ((System.ComponentModel.ISupportInitialize)sesionesGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)sesionesUsuarioBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGrid1;
        private BindingSource logonControllerBindingSource;
        private MetroFramework.Controls.MetroGrid sesionesGrid;
        private BindingSource sesionesUsuarioBindingSource;
        private DataGridViewTextBoxColumn sesionIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userCodeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn entradaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salidaDataGridViewTextBoxColumn;
    }
}