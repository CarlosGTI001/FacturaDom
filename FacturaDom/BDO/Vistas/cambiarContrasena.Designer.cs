namespace FacturaDom.BDO.Vistas
{
    partial class cambiarContrasena
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
            this.con2 = new System.Windows.Forms.TextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.con1 = new System.Windows.Forms.TextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.guardarContrasena = new MetroFramework.Controls.MetroTile();
            this.noCoincide = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.codigoLbl = new MetroFramework.Controls.MetroLabel();
            this.usuarioLbl = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // con2
            // 
            this.con2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.con2.Location = new System.Drawing.Point(33, 264);
            this.con2.Name = "con2";
            this.con2.PasswordChar = '*';
            this.con2.Size = new System.Drawing.Size(228, 33);
            this.con2.TabIndex = 20;
            this.con2.TextChanged += new System.EventHandler(this.con2_TextChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroLabel4.Location = new System.Drawing.Point(33, 233);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(121, 19);
            this.metroLabel4.TabIndex = 22;
            this.metroLabel4.Text = "Repetir Contraseña";
            // 
            // con1
            // 
            this.con1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.con1.Location = new System.Drawing.Point(33, 178);
            this.con1.Name = "con1";
            this.con1.PasswordChar = '*';
            this.con1.Size = new System.Drawing.Size(228, 33);
            this.con1.TabIndex = 19;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroLabel3.Location = new System.Drawing.Point(33, 147);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(75, 19);
            this.metroLabel3.TabIndex = 21;
            this.metroLabel3.Text = "Contraseña";
            // 
            // guardarContrasena
            // 
            this.guardarContrasena.ActiveControl = null;
            this.guardarContrasena.Location = new System.Drawing.Point(156, 345);
            this.guardarContrasena.Name = "guardarContrasena";
            this.guardarContrasena.Size = new System.Drawing.Size(105, 81);
            this.guardarContrasena.TabIndex = 32;
            this.guardarContrasena.Text = "Guardar\r\nContraseña";
            this.guardarContrasena.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.guardarContrasena.UseSelectable = true;
            this.guardarContrasena.UseTileImage = true;
            this.guardarContrasena.Click += new System.EventHandler(this.guardarContrasena_Click_1);
            // 
            // noCoincide
            // 
            this.noCoincide.AutoSize = true;
            this.noCoincide.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.noCoincide.ForeColor = System.Drawing.Color.Red;
            this.noCoincide.Location = new System.Drawing.Point(33, 301);
            this.noCoincide.Name = "noCoincide";
            this.noCoincide.Size = new System.Drawing.Size(177, 19);
            this.noCoincide.TabIndex = 33;
            this.noCoincide.Text = "Las contraseñas no coinciden";
            this.noCoincide.UseCustomForeColor = true;
            this.noCoincide.Visible = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroLabel2.Location = new System.Drawing.Point(33, 72);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(53, 19);
            this.metroLabel2.TabIndex = 34;
            this.metroLabel2.Text = "Codigo";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroLabel5.Location = new System.Drawing.Point(156, 72);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(53, 19);
            this.metroLabel5.TabIndex = 35;
            this.metroLabel5.Text = "Usuario";
            // 
            // codigoLbl
            // 
            this.codigoLbl.AutoSize = true;
            this.codigoLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.codigoLbl.Location = new System.Drawing.Point(33, 106);
            this.codigoLbl.Name = "codigoLbl";
            this.codigoLbl.Size = new System.Drawing.Size(15, 19);
            this.codigoLbl.TabIndex = 36;
            this.codigoLbl.Text = "-";
            // 
            // usuarioLbl
            // 
            this.usuarioLbl.AutoSize = true;
            this.usuarioLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usuarioLbl.Location = new System.Drawing.Point(156, 106);
            this.usuarioLbl.Name = "usuarioLbl";
            this.usuarioLbl.Size = new System.Drawing.Size(15, 19);
            this.usuarioLbl.TabIndex = 37;
            this.usuarioLbl.Text = "-";
            // 
            // cambiarContrasena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 449);
            this.Controls.Add(this.usuarioLbl);
            this.Controls.Add(this.codigoLbl);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.noCoincide);
            this.Controls.Add(this.guardarContrasena);
            this.Controls.Add(this.con2);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.con1);
            this.Controls.Add(this.metroLabel3);
            this.Name = "cambiarContrasena";
            this.Text = "Cambio de Contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox con2;
        private global::MetroFramework.Controls.MetroLabel metroLabel4;
        private TextBox con1;
        private global::MetroFramework.Controls.MetroLabel metroLabel3;
        private global::MetroFramework.Controls.MetroTile guardarContrasena;
        private global::MetroFramework.Controls.MetroLabel noCoincide;
        private global::MetroFramework.Controls.MetroLabel metroLabel2;
        private global::MetroFramework.Controls.MetroLabel metroLabel5;
        private global::MetroFramework.Controls.MetroLabel codigoLbl;
        private global::MetroFramework.Controls.MetroLabel usuarioLbl;
    }
}