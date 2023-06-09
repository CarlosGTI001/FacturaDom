namespace FacturaDom.BDO.Vistas
{
    partial class AdminUser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.nuevoUsuario = new MetroFramework.Controls.MetroTile();
            this.eliminarUsuario = new MetroFramework.Controls.MetroTile();
            this.menu = new MetroFramework.Controls.MetroPanel();
            this.editarContrasena = new MetroFramework.Controls.MetroTile();
            this.buscarUsuario = new MetroFramework.Controls.MetroTile();
            this.usuariosGrid = new MetroFramework.Controls.MetroGrid();
            this.userCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroTelefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.busquedaText = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.userText = new System.Windows.Forms.TextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nuevoUsuario
            // 
            this.nuevoUsuario.ActiveControl = null;
            this.nuevoUsuario.BackColor = System.Drawing.Color.SteelBlue;
            this.nuevoUsuario.Location = new System.Drawing.Point(153, 16);
            this.nuevoUsuario.Name = "nuevoUsuario";
            this.nuevoUsuario.Size = new System.Drawing.Size(114, 110);
            this.nuevoUsuario.TabIndex = 1;
            this.nuevoUsuario.Text = "Nuevo \r\nUsuario";
            this.nuevoUsuario.UseCustomBackColor = true;
            this.nuevoUsuario.UseSelectable = true;
            this.nuevoUsuario.UseTileImage = true;
            this.nuevoUsuario.UseVisualStyleBackColor = false;
            this.nuevoUsuario.Click += new System.EventHandler(this.nuevoUsuario_Click);
            // 
            // eliminarUsuario
            // 
            this.eliminarUsuario.ActiveControl = null;
            this.eliminarUsuario.BackColor = System.Drawing.Color.SteelBlue;
            this.eliminarUsuario.Location = new System.Drawing.Point(291, 16);
            this.eliminarUsuario.Name = "eliminarUsuario";
            this.eliminarUsuario.Size = new System.Drawing.Size(114, 110);
            this.eliminarUsuario.TabIndex = 2;
            this.eliminarUsuario.Text = "Eliminar\r\nUsuario";
            this.eliminarUsuario.UseCustomBackColor = true;
            this.eliminarUsuario.UseSelectable = true;
            this.eliminarUsuario.UseTileImage = true;
            this.eliminarUsuario.UseVisualStyleBackColor = false;
            this.eliminarUsuario.Click += new System.EventHandler(this.eliminarUsuario_Click);
            // 
            // menu
            // 
            this.menu.Controls.Add(this.editarContrasena);
            this.menu.Controls.Add(this.buscarUsuario);
            this.menu.Controls.Add(this.eliminarUsuario);
            this.menu.Controls.Add(this.nuevoUsuario);
            this.menu.HorizontalScrollbarBarColor = true;
            this.menu.HorizontalScrollbarHighlightOnWheel = false;
            this.menu.HorizontalScrollbarSize = 10;
            this.menu.Location = new System.Drawing.Point(284, 63);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(558, 142);
            this.menu.TabIndex = 3;
            this.menu.VerticalScrollbarBarColor = true;
            this.menu.VerticalScrollbarHighlightOnWheel = false;
            this.menu.VerticalScrollbarSize = 10;
            // 
            // editarContrasena
            // 
            this.editarContrasena.ActiveControl = null;
            this.editarContrasena.BackColor = System.Drawing.Color.SteelBlue;
            this.editarContrasena.Location = new System.Drawing.Point(429, 16);
            this.editarContrasena.Name = "editarContrasena";
            this.editarContrasena.Size = new System.Drawing.Size(114, 110);
            this.editarContrasena.TabIndex = 3;
            this.editarContrasena.Text = "Editar \r\nContraseña";
            this.editarContrasena.UseCustomBackColor = true;
            this.editarContrasena.UseSelectable = true;
            this.editarContrasena.UseTileImage = true;
            this.editarContrasena.UseVisualStyleBackColor = false;
            this.editarContrasena.Click += new System.EventHandler(this.editarContrasena_Click);
            // 
            // buscarUsuario
            // 
            this.buscarUsuario.ActiveControl = null;
            this.buscarUsuario.BackColor = System.Drawing.Color.SteelBlue;
            this.buscarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buscarUsuario.Location = new System.Drawing.Point(15, 16);
            this.buscarUsuario.Name = "buscarUsuario";
            this.buscarUsuario.Size = new System.Drawing.Size(114, 110);
            this.buscarUsuario.TabIndex = 2;
            this.buscarUsuario.Text = "Buscar\r\nUsuario";
            this.buscarUsuario.UseCustomBackColor = true;
            this.buscarUsuario.UseSelectable = true;
            this.buscarUsuario.UseTileImage = true;
            this.buscarUsuario.UseVisualStyleBackColor = false;
            this.buscarUsuario.Click += new System.EventHandler(this.buscarUsuario_Click);
            // 
            // usuariosGrid
            // 
            this.usuariosGrid.AllowUserToAddRows = false;
            this.usuariosGrid.AllowUserToDeleteRows = false;
            this.usuariosGrid.AllowUserToResizeRows = false;
            this.usuariosGrid.AutoGenerateColumns = false;
            this.usuariosGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.usuariosGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usuariosGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.usuariosGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usuariosGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.usuariosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuariosGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userCodeDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.userPassDataGridViewTextBoxColumn,
            this.createDateDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.cedulaDataGridViewTextBoxColumn,
            this.numeroTelefonoDataGridViewTextBoxColumn,
            this.fechaNacimientoDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn});
            this.usuariosGrid.DataSource = this.usuarioBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.usuariosGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.usuariosGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.usuariosGrid.EnableHeadersVisualStyles = false;
            this.usuariosGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.usuariosGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.usuariosGrid.Location = new System.Drawing.Point(20, 232);
            this.usuariosGrid.Name = "usuariosGrid";
            this.usuariosGrid.ReadOnly = true;
            this.usuariosGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usuariosGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.usuariosGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.usuariosGrid.RowTemplate.Height = 25;
            this.usuariosGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usuariosGrid.Size = new System.Drawing.Size(822, 299);
            this.usuariosGrid.TabIndex = 4;
            this.usuariosGrid.UseStyleColors = true;
            this.usuariosGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usuariosGrid_CellClick);
            // 
            // userCodeDataGridViewTextBoxColumn
            // 
            this.userCodeDataGridViewTextBoxColumn.DataPropertyName = "UserCode";
            this.userCodeDataGridViewTextBoxColumn.HeaderText = "Codigo Usuario";
            this.userCodeDataGridViewTextBoxColumn.Name = "userCodeDataGridViewTextBoxColumn";
            this.userCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "Nombre de Usuario";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userPassDataGridViewTextBoxColumn
            // 
            this.userPassDataGridViewTextBoxColumn.DataPropertyName = "UserPass";
            this.userPassDataGridViewTextBoxColumn.HeaderText = "UserPass";
            this.userPassDataGridViewTextBoxColumn.Name = "userPassDataGridViewTextBoxColumn";
            this.userPassDataGridViewTextBoxColumn.ReadOnly = true;
            this.userPassDataGridViewTextBoxColumn.Visible = false;
            // 
            // createDateDataGridViewTextBoxColumn
            // 
            this.createDateDataGridViewTextBoxColumn.DataPropertyName = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.HeaderText = "Fecha de Creacion";
            this.createDateDataGridViewTextBoxColumn.Name = "createDateDataGridViewTextBoxColumn";
            this.createDateDataGridViewTextBoxColumn.ReadOnly = true;
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
            // cedulaDataGridViewTextBoxColumn
            // 
            this.cedulaDataGridViewTextBoxColumn.DataPropertyName = "Cedula";
            this.cedulaDataGridViewTextBoxColumn.HeaderText = "Cedula";
            this.cedulaDataGridViewTextBoxColumn.Name = "cedulaDataGridViewTextBoxColumn";
            this.cedulaDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.fechaNacimientoDataGridViewTextBoxColumn.HeaderText = "Fecha de Nacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn.Name = "fechaNacimientoDataGridViewTextBoxColumn";
            this.fechaNacimientoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(FacturaDom.BDO.Modelos.Usuario);
            // 
            // busquedaText
            // 
            this.busquedaText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.busquedaText.Location = new System.Drawing.Point(23, 92);
            this.busquedaText.Name = "busquedaText";
            this.busquedaText.Size = new System.Drawing.Size(228, 33);
            this.busquedaText.TabIndex = 5;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroLabel1.Location = new System.Drawing.Point(23, 64);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(53, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Codigo";
            // 
            // userText
            // 
            this.userText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userText.Location = new System.Drawing.Point(23, 172);
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(228, 33);
            this.userText.TabIndex = 7;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroLabel2.Location = new System.Drawing.Point(23, 144);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(53, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Usuario";
            // 
            // AdminUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 551);
            this.Controls.Add(this.userText);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.busquedaText);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.usuariosGrid);
            this.Controls.Add(this.menu);
            this.Name = "AdminUser";
            this.Text = "AdminUser";
            this.Load += new System.EventHandler(this.AdminUser_Load);
            this.menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usuariosGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private global::MetroFramework.Controls.MetroTile nuevoUsuario;
        private global::MetroFramework.Controls.MetroTile eliminarUsuario;
        private global::MetroFramework.Controls.MetroPanel menu;
        private global::MetroFramework.Controls.MetroTile buscarUsuario;
        private global::MetroFramework.Controls.MetroTile editarContrasena;
        private global::MetroFramework.Controls.MetroGrid usuariosGrid;
        private BindingSource usuarioBindingSource;
        private DataGridViewTextBoxColumn userCodeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userPassDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numeroTelefonoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private TextBox busquedaText;
        private global::MetroFramework.Controls.MetroLabel metroLabel1;
        private TextBox userText;
        private global::MetroFramework.Controls.MetroLabel metroLabel2;
    }
}