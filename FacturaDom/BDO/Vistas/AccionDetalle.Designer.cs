namespace FacturaDom.BDO.Vistas
{
    partial class AccionDetalle
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
            this.totalLbl = new MetroFramework.Controls.MetroLabel();
            this.precioLbl = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.articuloNombre = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.retirarArticulo = new MetroFramework.Controls.MetroTile();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cantidadArticulo = new System.Windows.Forms.TextBox();
            this.cambiarArticulo = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalLbl.Location = new System.Drawing.Point(153, 211);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(43, 19);
            this.totalLbl.TabIndex = 26;
            this.totalLbl.Text = "RD$ -";
            this.totalLbl.UseCustomBackColor = true;
            // 
            // precioLbl
            // 
            this.precioLbl.AutoSize = true;
            this.precioLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.precioLbl.Location = new System.Drawing.Point(163, 126);
            this.precioLbl.Name = "precioLbl";
            this.precioLbl.Size = new System.Drawing.Size(43, 19);
            this.precioLbl.TabIndex = 25;
            this.precioLbl.Text = "RD$ -";
            this.precioLbl.UseCustomBackColor = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroLabel8.Location = new System.Drawing.Point(108, 211);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(39, 19);
            this.metroLabel8.TabIndex = 24;
            this.metroLabel8.Text = "Total:";
            this.metroLabel8.UseCustomBackColor = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroLabel7.Location = new System.Drawing.Point(108, 126);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(49, 19);
            this.metroLabel7.TabIndex = 23;
            this.metroLabel7.Text = "Precio:";
            this.metroLabel7.UseCustomBackColor = true;
            // 
            // articuloNombre
            // 
            this.articuloNombre.AutoSize = true;
            this.articuloNombre.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.articuloNombre.Location = new System.Drawing.Point(163, 100);
            this.articuloNombre.Name = "articuloNombre";
            this.articuloNombre.Size = new System.Drawing.Size(15, 19);
            this.articuloNombre.TabIndex = 22;
            this.articuloNombre.Text = "-";
            this.articuloNombre.UseCustomBackColor = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroLabel5.Location = new System.Drawing.Point(99, 100);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(58, 19);
            this.metroLabel5.TabIndex = 21;
            this.metroLabel5.Text = "Articulo:";
            this.metroLabel5.UseCustomBackColor = true;
            // 
            // retirarArticulo
            // 
            this.retirarArticulo.ActiveControl = null;
            this.retirarArticulo.BackColor = System.Drawing.Color.SteelBlue;
            this.retirarArticulo.Enabled = false;
            this.retirarArticulo.Location = new System.Drawing.Point(219, 264);
            this.retirarArticulo.Name = "retirarArticulo";
            this.retirarArticulo.Size = new System.Drawing.Size(114, 59);
            this.retirarArticulo.TabIndex = 18;
            this.retirarArticulo.Text = "Retirar\r\nArticulo";
            this.retirarArticulo.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.retirarArticulo.UseCustomBackColor = true;
            this.retirarArticulo.UseSelectable = true;
            this.retirarArticulo.UseTileImage = true;
            this.retirarArticulo.UseVisualStyleBackColor = false;
            this.retirarArticulo.Click += new System.EventHandler(this.retirarArticulo_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroLabel4.Location = new System.Drawing.Point(99, 151);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(62, 19);
            this.metroLabel4.TabIndex = 20;
            this.metroLabel4.Text = "Cantidad";
            this.metroLabel4.UseCustomBackColor = true;
            // 
            // cantidadArticulo
            // 
            this.cantidadArticulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cantidadArticulo.Location = new System.Drawing.Point(99, 175);
            this.cantidadArticulo.Name = "cantidadArticulo";
            this.cantidadArticulo.Size = new System.Drawing.Size(180, 33);
            this.cantidadArticulo.TabIndex = 19;
            this.cantidadArticulo.Text = "0";
            this.cantidadArticulo.TextChanged += new System.EventHandler(this.cantidadArticulo_TextChanged);
            // 
            // cambiarArticulo
            // 
            this.cambiarArticulo.ActiveControl = null;
            this.cambiarArticulo.BackColor = System.Drawing.Color.SteelBlue;
            this.cambiarArticulo.Location = new System.Drawing.Point(99, 264);
            this.cambiarArticulo.Name = "cambiarArticulo";
            this.cambiarArticulo.Size = new System.Drawing.Size(114, 59);
            this.cambiarArticulo.TabIndex = 17;
            this.cambiarArticulo.Text = "Cambiar\r\nCantidad";
            this.cambiarArticulo.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cambiarArticulo.UseCustomBackColor = true;
            this.cambiarArticulo.UseSelectable = true;
            this.cambiarArticulo.UseTileImage = true;
            this.cambiarArticulo.UseVisualStyleBackColor = false;
            this.cambiarArticulo.Click += new System.EventHandler(this.cambiarArticulo_Click);
            // 
            // AccionDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 373);
            this.Controls.Add(this.totalLbl);
            this.Controls.Add(this.precioLbl);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.articuloNombre);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.retirarArticulo);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.cantidadArticulo);
            this.Controls.Add(this.cambiarArticulo);
            this.Name = "AccionDetalle";
            this.Text = "Que desea hacer con el detalle?";
            this.Load += new System.EventHandler(this.AccionDetalle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel totalLbl;
        private MetroFramework.Controls.MetroLabel precioLbl;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel articuloNombre;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTile retirarArticulo;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private TextBox cantidadArticulo;
        private MetroFramework.Controls.MetroTile cambiarArticulo;
    }
}