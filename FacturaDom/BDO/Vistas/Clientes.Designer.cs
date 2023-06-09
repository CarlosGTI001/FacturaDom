namespace FacturaDom.BDO.Vistas
{
    partial class Clientes
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
            clientText = new TextBox();
            Nombre = new MetroFramework.Controls.MetroLabel();
            clientesGrid = new MetroFramework.Controls.MetroGrid();
            codigoClienteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            apellidoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cedulaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numeroTelefonoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaNacimientoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            direccionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            comprasClienteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clienteReferidoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            comprasTotalesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            habilitadoDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            clienteBindingSource = new BindingSource(components);
            menu = new MetroFramework.Controls.MetroPanel();
            editarClientes = new MetroFramework.Controls.MetroTile();
            eliminarUsuario = new MetroFramework.Controls.MetroTile();
            nuevoUsuario = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)clientesGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).BeginInit();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // clientText
            // 
            clientText.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            clientText.Location = new Point(23, 126);
            clientText.Name = "clientText";
            clientText.Size = new Size(228, 33);
            clientText.TabIndex = 13;
            clientText.TextChanged += clientText_TextChanged;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Nombre.Location = new Point(23, 102);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(66, 19);
            Nombre.TabIndex = 14;
            Nombre.Text = "Busqueda";
            // 
            // clientesGrid
            // 
            clientesGrid.AllowUserToAddRows = false;
            clientesGrid.AllowUserToDeleteRows = false;
            clientesGrid.AllowUserToResizeRows = false;
            clientesGrid.AutoGenerateColumns = false;
            clientesGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            clientesGrid.BackgroundColor = Color.FromArgb(255, 255, 255);
            clientesGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            clientesGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            clientesGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            clientesGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            clientesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clientesGrid.Columns.AddRange(new DataGridViewColumn[] { codigoClienteDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, apellidoDataGridViewTextBoxColumn, cedulaDataGridViewTextBoxColumn, numeroTelefonoDataGridViewTextBoxColumn, fechaNacimientoDataGridViewTextBoxColumn, direccionDataGridViewTextBoxColumn, comprasClienteDataGridViewTextBoxColumn, clienteReferidoDataGridViewTextBoxColumn, comprasTotalesDataGridViewTextBoxColumn, habilitadoDataGridViewCheckBoxColumn });
            clientesGrid.DataSource = clienteBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            clientesGrid.DefaultCellStyle = dataGridViewCellStyle2;
            clientesGrid.Dock = DockStyle.Bottom;
            clientesGrid.EnableHeadersVisualStyles = false;
            clientesGrid.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            clientesGrid.GridColor = Color.FromArgb(255, 255, 255);
            clientesGrid.Location = new Point(20, 232);
            clientesGrid.Name = "clientesGrid";
            clientesGrid.ReadOnly = true;
            clientesGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            clientesGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            clientesGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            clientesGrid.RowTemplate.Height = 25;
            clientesGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            clientesGrid.Size = new Size(822, 299);
            clientesGrid.TabIndex = 10;
            clientesGrid.UseStyleColors = true;
            clientesGrid.CellClick += clientesGrid_CellClick;
            // 
            // codigoClienteDataGridViewTextBoxColumn
            // 
            codigoClienteDataGridViewTextBoxColumn.DataPropertyName = "CodigoCliente";
            codigoClienteDataGridViewTextBoxColumn.HeaderText = "CodigoCliente";
            codigoClienteDataGridViewTextBoxColumn.Name = "codigoClienteDataGridViewTextBoxColumn";
            codigoClienteDataGridViewTextBoxColumn.ReadOnly = true;
            codigoClienteDataGridViewTextBoxColumn.Visible = false;
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
            // cedulaDataGridViewTextBoxColumn
            // 
            cedulaDataGridViewTextBoxColumn.DataPropertyName = "Cedula";
            cedulaDataGridViewTextBoxColumn.HeaderText = "Cedula";
            cedulaDataGridViewTextBoxColumn.Name = "cedulaDataGridViewTextBoxColumn";
            cedulaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroTelefonoDataGridViewTextBoxColumn
            // 
            numeroTelefonoDataGridViewTextBoxColumn.DataPropertyName = "NumeroTelefono";
            numeroTelefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            numeroTelefonoDataGridViewTextBoxColumn.Name = "numeroTelefonoDataGridViewTextBoxColumn";
            numeroTelefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaNacimientoDataGridViewTextBoxColumn
            // 
            fechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "fechaNacimiento";
            fechaNacimientoDataGridViewTextBoxColumn.HeaderText = "Nacimiento";
            fechaNacimientoDataGridViewTextBoxColumn.Name = "fechaNacimientoDataGridViewTextBoxColumn";
            fechaNacimientoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            direccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // comprasClienteDataGridViewTextBoxColumn
            // 
            comprasClienteDataGridViewTextBoxColumn.DataPropertyName = "ComprasCliente";
            comprasClienteDataGridViewTextBoxColumn.HeaderText = "ComprasCliente";
            comprasClienteDataGridViewTextBoxColumn.Name = "comprasClienteDataGridViewTextBoxColumn";
            comprasClienteDataGridViewTextBoxColumn.ReadOnly = true;
            comprasClienteDataGridViewTextBoxColumn.Visible = false;
            // 
            // clienteReferidoDataGridViewTextBoxColumn
            // 
            clienteReferidoDataGridViewTextBoxColumn.DataPropertyName = "ClienteReferido";
            clienteReferidoDataGridViewTextBoxColumn.HeaderText = "ClienteReferido";
            clienteReferidoDataGridViewTextBoxColumn.Name = "clienteReferidoDataGridViewTextBoxColumn";
            clienteReferidoDataGridViewTextBoxColumn.ReadOnly = true;
            clienteReferidoDataGridViewTextBoxColumn.Visible = false;
            // 
            // comprasTotalesDataGridViewTextBoxColumn
            // 
            comprasTotalesDataGridViewTextBoxColumn.DataPropertyName = "ComprasTotales";
            comprasTotalesDataGridViewTextBoxColumn.HeaderText = "ComprasTotales";
            comprasTotalesDataGridViewTextBoxColumn.Name = "comprasTotalesDataGridViewTextBoxColumn";
            comprasTotalesDataGridViewTextBoxColumn.ReadOnly = true;
            comprasTotalesDataGridViewTextBoxColumn.Visible = false;
            // 
            // habilitadoDataGridViewCheckBoxColumn
            // 
            habilitadoDataGridViewCheckBoxColumn.DataPropertyName = "Habilitado";
            habilitadoDataGridViewCheckBoxColumn.HeaderText = "Habilitado";
            habilitadoDataGridViewCheckBoxColumn.Name = "habilitadoDataGridViewCheckBoxColumn";
            habilitadoDataGridViewCheckBoxColumn.ReadOnly = true;
            habilitadoDataGridViewCheckBoxColumn.Visible = false;
            // 
            // clienteBindingSource
            // 
            clienteBindingSource.DataSource = typeof(Modelos.Cliente);
            // 
            // menu
            // 
            menu.Controls.Add(editarClientes);
            menu.Controls.Add(eliminarUsuario);
            menu.Controls.Add(nuevoUsuario);
            menu.HorizontalScrollbarBarColor = true;
            menu.HorizontalScrollbarHighlightOnWheel = false;
            menu.HorizontalScrollbarSize = 10;
            menu.Location = new Point(354, 64);
            menu.Name = "menu";
            menu.Size = new Size(433, 142);
            menu.TabIndex = 9;
            menu.VerticalScrollbarBarColor = true;
            menu.VerticalScrollbarHighlightOnWheel = false;
            menu.VerticalScrollbarSize = 10;
            menu.Paint += menu_Paint;
            // 
            // editarClientes
            // 
            editarClientes.ActiveControl = null;
            editarClientes.BackColor = Color.SteelBlue;
            editarClientes.Location = new Point(300, 15);
            editarClientes.Name = "editarClientes";
            editarClientes.Size = new Size(114, 110);
            editarClientes.TabIndex = 3;
            editarClientes.Text = "Editar \r\nCliente";
            editarClientes.UseCustomBackColor = true;
            editarClientes.UseSelectable = true;
            editarClientes.UseTileImage = true;
            editarClientes.UseVisualStyleBackColor = false;
            editarClientes.Click += editarCliente_Click;
            // 
            // eliminarUsuario
            // 
            eliminarUsuario.ActiveControl = null;
            eliminarUsuario.BackColor = Color.SteelBlue;
            eliminarUsuario.Location = new Point(162, 15);
            eliminarUsuario.Name = "eliminarUsuario";
            eliminarUsuario.Size = new Size(114, 110);
            eliminarUsuario.TabIndex = 2;
            eliminarUsuario.Text = "Eliminar\rCliente";
            eliminarUsuario.UseCustomBackColor = true;
            eliminarUsuario.UseSelectable = true;
            eliminarUsuario.UseTileImage = true;
            eliminarUsuario.UseVisualStyleBackColor = false;
            eliminarUsuario.Click += eliminarCliente_Click;
            // 
            // nuevoUsuario
            // 
            nuevoUsuario.ActiveControl = null;
            nuevoUsuario.BackColor = Color.SteelBlue;
            nuevoUsuario.Location = new Point(24, 15);
            nuevoUsuario.Name = "nuevoUsuario";
            nuevoUsuario.Size = new Size(114, 110);
            nuevoUsuario.TabIndex = 1;
            nuevoUsuario.Text = "Nuevo \r\nCliente";
            nuevoUsuario.UseCustomBackColor = true;
            nuevoUsuario.UseSelectable = true;
            nuevoUsuario.UseTileImage = true;
            nuevoUsuario.UseVisualStyleBackColor = false;
            nuevoUsuario.Click += nuevoUsuario_Click;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 551);
            Controls.Add(clientText);
            Controls.Add(Nombre);
            Controls.Add(clientesGrid);
            Controls.Add(menu);
            Name = "Clientes";
            Text = "Administrar Cliente";
            Load += Clientes_Load;
            ((System.ComponentModel.ISupportInitialize)clientesGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).EndInit();
            menu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox clientText;
        private MetroFramework.Controls.MetroLabel Nombre;
        private MetroFramework.Controls.MetroGrid clientesGrid;
        private MetroFramework.Controls.MetroPanel menu;
        private MetroFramework.Controls.MetroTile editarClientes;
        private MetroFramework.Controls.MetroTile eliminarUsuario;
        private MetroFramework.Controls.MetroTile nuevoUsuario;
        private BindingSource clienteBindingSource;
        private DataGridViewTextBoxColumn codigoClienteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numeroTelefonoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn comprasClienteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn clienteReferidoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn comprasTotalesDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn habilitadoDataGridViewCheckBoxColumn;
    }
}