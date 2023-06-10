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
            totalLbl = new MetroFramework.Controls.MetroLabel();
            precioLbl = new MetroFramework.Controls.MetroLabel();
            metroLabel8 = new MetroFramework.Controls.MetroLabel();
            metroLabel7 = new MetroFramework.Controls.MetroLabel();
            articuloNombre = new MetroFramework.Controls.MetroLabel();
            metroLabel5 = new MetroFramework.Controls.MetroLabel();
            retirarArticulo = new MetroFramework.Controls.MetroTile();
            metroLabel4 = new MetroFramework.Controls.MetroLabel();
            cantidadArticulo = new TextBox();
            cambiarArticulo = new MetroFramework.Controls.MetroTile();
            SuspendLayout();
            // 
            // totalLbl
            // 
            totalLbl.AutoSize = true;
            totalLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            totalLbl.Location = new Point(153, 211);
            totalLbl.Name = "totalLbl";
            totalLbl.Size = new Size(43, 19);
            totalLbl.TabIndex = 26;
            totalLbl.Text = "RD$ -";
            totalLbl.UseCustomBackColor = true;
            // 
            // precioLbl
            // 
            precioLbl.AutoSize = true;
            precioLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            precioLbl.Location = new Point(163, 126);
            precioLbl.Name = "precioLbl";
            precioLbl.Size = new Size(43, 19);
            precioLbl.TabIndex = 25;
            precioLbl.Text = "RD$ -";
            precioLbl.UseCustomBackColor = true;
            // 
            // metroLabel8
            // 
            metroLabel8.AutoSize = true;
            metroLabel8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            metroLabel8.Location = new Point(108, 211);
            metroLabel8.Name = "metroLabel8";
            metroLabel8.Size = new Size(39, 19);
            metroLabel8.TabIndex = 24;
            metroLabel8.Text = "Total:";
            metroLabel8.UseCustomBackColor = true;
            // 
            // metroLabel7
            // 
            metroLabel7.AutoSize = true;
            metroLabel7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            metroLabel7.Location = new Point(108, 126);
            metroLabel7.Name = "metroLabel7";
            metroLabel7.Size = new Size(49, 19);
            metroLabel7.TabIndex = 23;
            metroLabel7.Text = "Precio:";
            metroLabel7.UseCustomBackColor = true;
            // 
            // articuloNombre
            // 
            articuloNombre.AutoSize = true;
            articuloNombre.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            articuloNombre.Location = new Point(163, 100);
            articuloNombre.Name = "articuloNombre";
            articuloNombre.Size = new Size(15, 19);
            articuloNombre.TabIndex = 22;
            articuloNombre.Text = "-";
            articuloNombre.UseCustomBackColor = true;
            // 
            // metroLabel5
            // 
            metroLabel5.AutoSize = true;
            metroLabel5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            metroLabel5.Location = new Point(99, 100);
            metroLabel5.Name = "metroLabel5";
            metroLabel5.Size = new Size(58, 19);
            metroLabel5.TabIndex = 21;
            metroLabel5.Text = "Articulo:";
            metroLabel5.UseCustomBackColor = true;
            // 
            // retirarArticulo
            // 
            retirarArticulo.ActiveControl = null;
            retirarArticulo.BackColor = Color.SteelBlue;
            retirarArticulo.Location = new Point(219, 264);
            retirarArticulo.Name = "retirarArticulo";
            retirarArticulo.Size = new Size(114, 59);
            retirarArticulo.TabIndex = 18;
            retirarArticulo.Text = "Retirar\r\nArticulo";
            retirarArticulo.TileImageAlign = ContentAlignment.MiddleRight;
            retirarArticulo.UseCustomBackColor = true;
            retirarArticulo.UseSelectable = true;
            retirarArticulo.UseTileImage = true;
            retirarArticulo.UseVisualStyleBackColor = false;
            retirarArticulo.Click += retirarArticulo_Click;
            // 
            // metroLabel4
            // 
            metroLabel4.AutoSize = true;
            metroLabel4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            metroLabel4.Location = new Point(99, 151);
            metroLabel4.Name = "metroLabel4";
            metroLabel4.Size = new Size(62, 19);
            metroLabel4.TabIndex = 20;
            metroLabel4.Text = "Cantidad";
            metroLabel4.UseCustomBackColor = true;
            // 
            // cantidadArticulo
            // 
            cantidadArticulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cantidadArticulo.Location = new Point(99, 175);
            cantidadArticulo.Name = "cantidadArticulo";
            cantidadArticulo.Size = new Size(180, 33);
            cantidadArticulo.TabIndex = 19;
            cantidadArticulo.Text = "0";
            cantidadArticulo.TextChanged += cantidadArticulo_TextChanged;
            // 
            // cambiarArticulo
            // 
            cambiarArticulo.ActiveControl = null;
            cambiarArticulo.BackColor = Color.SteelBlue;
            cambiarArticulo.Location = new Point(99, 264);
            cambiarArticulo.Name = "cambiarArticulo";
            cambiarArticulo.Size = new Size(114, 59);
            cambiarArticulo.TabIndex = 17;
            cambiarArticulo.Text = "Cambiar\r\nCantidad";
            cambiarArticulo.TileImageAlign = ContentAlignment.MiddleRight;
            cambiarArticulo.UseCustomBackColor = true;
            cambiarArticulo.UseSelectable = true;
            cambiarArticulo.UseTileImage = true;
            cambiarArticulo.UseVisualStyleBackColor = false;
            cambiarArticulo.Click += cambiarArticulo_Click;
            // 
            // AccionDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 373);
            Controls.Add(totalLbl);
            Controls.Add(precioLbl);
            Controls.Add(metroLabel8);
            Controls.Add(metroLabel7);
            Controls.Add(articuloNombre);
            Controls.Add(metroLabel5);
            Controls.Add(retirarArticulo);
            Controls.Add(metroLabel4);
            Controls.Add(cantidadArticulo);
            Controls.Add(cambiarArticulo);
            Name = "AccionDetalle";
            Text = "Que desea hacer con el detalle?";
            Load += AccionDetalle_Load;
            ResumeLayout(false);
            PerformLayout();
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