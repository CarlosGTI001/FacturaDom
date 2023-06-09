namespace FacturaDom.BDO.Vistas
{
    partial class logon
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
            this.loginBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.passTxt = new System.Windows.Forms.TextBox();
            this.userText = new System.Windows.Forms.TextBox();
            this.imagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(95, 354);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(84, 46);
            this.loginBtn.TabIndex = 3;
            this.loginBtn.Text = "Iniciar";
            this.loginBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.loginBtn.UseSelectable = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroLabel1.Location = new System.Drawing.Point(23, 181);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(53, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Usuario";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroLabel2.Location = new System.Drawing.Point(23, 263);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(75, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Contraseña";
            // 
            // passTxt
            // 
            this.passTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passTxt.Location = new System.Drawing.Point(23, 291);
            this.passTxt.Name = "passTxt";
            this.passTxt.PasswordChar = '*';
            this.passTxt.Size = new System.Drawing.Size(228, 33);
            this.passTxt.TabIndex = 2;
            // 
            // userText
            // 
            this.userText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userText.Location = new System.Drawing.Point(23, 209);
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(228, 33);
            this.userText.TabIndex = 1;
            // 
            // imagen
            // 
            this.imagen.Location = new System.Drawing.Point(82, 63);
            this.imagen.Name = "imagen";
            this.imagen.Size = new System.Drawing.Size(114, 108);
            this.imagen.TabIndex = 4;
            this.imagen.TabStop = false;
            // 
            // logon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 433);
            this.Controls.Add(this.imagen);
            this.Controls.Add(this.userText);
            this.Controls.Add(this.passTxt);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.loginBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "logon";
            this.Text = "Iniciar Sesion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.logon_FormClosed);
            this.Load += new System.EventHandler(this.logon_Load);
            this.Click += new System.EventHandler(this.logon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private global::MetroFramework.Controls.MetroButton loginBtn;
        private global::MetroFramework.Controls.MetroLabel metroLabel1;
        private global::MetroFramework.Controls.MetroLabel metroLabel2;
        private TextBox passTxt;
        private TextBox userText;
        private PictureBox imagen;
    }
}