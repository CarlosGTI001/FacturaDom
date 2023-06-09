namespace FacturaDom.BDO.Vistas
{
    partial class Agregar
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
            metroLabel1 = new MetroFramework.Controls.MetroLabel();
            metroLabel2 = new MetroFramework.Controls.MetroLabel();
            codigoP = new MetroFramework.Controls.MetroLabel();
            nombreP = new MetroFramework.Controls.MetroLabel();
            agregarProducto = new MetroFramework.Controls.MetroTile();
            cantidadText = new TextBox();
            metroLabel3 = new MetroFramework.Controls.MetroLabel();
            precioBox = new TextBox();
            precioLabel = new MetroFramework.Controls.MetroLabel();
            modPrecio = new MetroFramework.Controls.MetroCheckBox();
            SuspendLayout();
            // 
            // metroLabel1
            // 
            metroLabel1.AutoSize = true;
            metroLabel1.Location = new Point(23, 112);
            metroLabel1.Name = "metroLabel1";
            metroLabel1.Size = new Size(62, 19);
            metroLabel1.TabIndex = 0;
            metroLabel1.Text = "Nombre:";
            // 
            // metroLabel2
            // 
            metroLabel2.AutoSize = true;
            metroLabel2.Location = new Point(23, 77);
            metroLabel2.Name = "metroLabel2";
            metroLabel2.Size = new Size(56, 19);
            metroLabel2.TabIndex = 1;
            metroLabel2.Text = "Codigo:";
            // 
            // codigoP
            // 
            codigoP.AutoSize = true;
            codigoP.Location = new Point(115, 77);
            codigoP.Name = "codigoP";
            codigoP.Size = new Size(15, 19);
            codigoP.TabIndex = 2;
            codigoP.Text = "-";
            // 
            // nombreP
            // 
            nombreP.AutoSize = true;
            nombreP.Location = new Point(115, 112);
            nombreP.Name = "nombreP";
            nombreP.Size = new Size(15, 19);
            nombreP.TabIndex = 3;
            nombreP.Text = "-";
            // 
            // agregarProducto
            // 
            agregarProducto.ActiveControl = null;
            agregarProducto.BackColor = Color.SteelBlue;
            agregarProducto.BackgroundImageLayout = ImageLayout.Stretch;
            agregarProducto.Location = new Point(138, 235);
            agregarProducto.Name = "agregarProducto";
            agregarProducto.Size = new Size(114, 71);
            agregarProducto.TabIndex = 11;
            agregarProducto.Text = "Guardar";
            agregarProducto.TileImageAlign = ContentAlignment.TopRight;
            agregarProducto.UseCustomBackColor = true;
            agregarProducto.UseSelectable = true;
            agregarProducto.UseTileImage = true;
            agregarProducto.UseVisualStyleBackColor = false;
            agregarProducto.Click += agregarProducto_Click;
            // 
            // cantidadText
            // 
            cantidadText.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cantidadText.Location = new Point(23, 180);
            cantidadText.Name = "cantidadText";
            cantidadText.Size = new Size(139, 33);
            cantidadText.TabIndex = 12;
            cantidadText.Text = "0";
            // 
            // metroLabel3
            // 
            metroLabel3.AutoSize = true;
            metroLabel3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            metroLabel3.Location = new Point(23, 152);
            metroLabel3.Name = "metroLabel3";
            metroLabel3.Size = new Size(130, 19);
            metroLabel3.TabIndex = 13;
            metroLabel3.Text = "Cantidad de Entrada";
            // 
            // precioBox
            // 
            precioBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            precioBox.Location = new Point(238, 180);
            precioBox.Name = "precioBox";
            precioBox.Size = new Size(139, 33);
            precioBox.TabIndex = 14;
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            precioLabel.Location = new Point(236, 152);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new Size(46, 19);
            precioLabel.TabIndex = 15;
            precioLabel.Text = "Precio";
            precioLabel.Visible = false;
            // 
            // modPrecio
            // 
            modPrecio.AutoSize = true;
            modPrecio.Location = new Point(252, 81);
            modPrecio.Name = "modPrecio";
            modPrecio.Size = new Size(110, 15);
            modPrecio.TabIndex = 16;
            modPrecio.Text = "Modificar Precio";
            modPrecio.UseSelectable = true;
            modPrecio.CheckedChanged += modPrecio_CheckedChanged;
            // 
            // Agregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 319);
            Controls.Add(modPrecio);
            Controls.Add(precioBox);
            Controls.Add(precioLabel);
            Controls.Add(cantidadText);
            Controls.Add(metroLabel3);
            Controls.Add(agregarProducto);
            Controls.Add(nombreP);
            Controls.Add(codigoP);
            Controls.Add(metroLabel2);
            Controls.Add(metroLabel1);
            Name = "Agregar";
            Text = "Agregar Articulos Existentes";
            Load += Agregar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel codigoP;
        private MetroFramework.Controls.MetroLabel nombreP;
        private MetroFramework.Controls.MetroTile agregarProducto;
        private TextBox cantidadText;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private TextBox precioBox;
        private MetroFramework.Controls.MetroLabel precioLabel;
        private MetroFramework.Controls.MetroCheckBox modPrecio;
    }
}