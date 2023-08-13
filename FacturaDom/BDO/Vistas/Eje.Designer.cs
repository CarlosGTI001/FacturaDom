namespace FacturaDom.BDO.Vistas
{
    partial class Eje
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
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.iconButton1 = new Rop.Winforms.Icons.IconButton();
            this.SuspendLayout();
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(494, 174);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox1.TabIndex = 0;
            this.metroComboBox1.UseSelectable = true;
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.Location = new System.Drawing.Point(387, 259);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(114, 15);
            this.metroCheckBox1.TabIndex = 1;
            this.metroCheckBox1.Text = "metroCheckBox1";
            this.metroCheckBox1.UseSelectable = true;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(96, 125);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(239, 249);
            this.metroTile1.TabIndex = 2;
            this.metroTile1.Text = "metroTile1";
            this.metroTile1.UseSelectable = true;
            // 
            // iconButton1
            // 
            this.iconButton1.BankIcon = null;
            this.iconButton1.DisabledColor = System.Drawing.Color.Gray;
            this.iconButton1.IconColor = System.Drawing.Color.Empty;
            this.iconButton1.IconScale = 125;
            this.iconButton1.Location = new System.Drawing.Point(649, 389);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.OffsetIcon = 0;
            this.iconButton1.OffsetText = 0;
            this.iconButton1.PrefixCode = null;
            this.iconButton1.Size = new System.Drawing.Size(170, 120);
            this.iconButton1.SuffixCode = null;
            this.iconButton1.TabIndex = 3;
            this.iconButton1.Text = "iconButton1";
            this.iconButton1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.iconButton1.UseIconColor = false;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // Eje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 568);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroCheckBox1);
            this.Controls.Add(this.metroComboBox1);
            this.Name = "Eje";
            this.Text = "Eje";
            this.Load += new System.EventHandler(this.Eje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private MetroFramework.Controls.MetroTile metroTile1;
        private Rop.Winforms.Icons.IconButton iconButton1;
    }
}