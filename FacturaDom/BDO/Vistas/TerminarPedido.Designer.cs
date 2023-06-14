namespace FacturaDom.BDO.Vistas
{
    partial class TerminarPedido
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
            pagarLbl = new MetroFramework.Controls.MetroLabel();
            metroLabel8 = new MetroFramework.Controls.MetroLabel();
            efectivoText = new TextBox();
            finalizarPedido = new MetroFramework.Controls.MetroTile();
            metroLabel1 = new MetroFramework.Controls.MetroLabel();
            metroTile1 = new MetroFramework.Controls.MetroTile();
            metroLabel2 = new MetroFramework.Controls.MetroLabel();
            devueltaLbl = new MetroFramework.Controls.MetroLabel();
            SuspendLayout();
            // 
            // pagarLbl
            // 
            pagarLbl.AutoSize = true;
            pagarLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            pagarLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            pagarLbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            pagarLbl.ForeColor = Color.Green;
            pagarLbl.Location = new Point(195, 94);
            pagarLbl.Name = "pagarLbl";
            pagarLbl.Size = new Size(59, 25);
            pagarLbl.TabIndex = 19;
            pagarLbl.Text = "RD$ -";
            pagarLbl.UseCustomBackColor = true;
            pagarLbl.UseCustomForeColor = true;
            // 
            // metroLabel8
            // 
            metroLabel8.AutoSize = true;
            metroLabel8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            metroLabel8.Location = new Point(45, 94);
            metroLabel8.Name = "metroLabel8";
            metroLabel8.Size = new Size(144, 25);
            metroLabel8.TabIndex = 18;
            metroLabel8.Text = "Monto a Pagar:";
            metroLabel8.UseCustomBackColor = true;
            // 
            // efectivoText
            // 
            efectivoText.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            efectivoText.Location = new Point(195, 139);
            efectivoText.Name = "efectivoText";
            efectivoText.Size = new Size(155, 33);
            efectivoText.TabIndex = 17;
            efectivoText.Text = "0";
            efectivoText.TextChanged += cantidadArticulo_TextChanged;
            // 
            // finalizarPedido
            // 
            finalizarPedido.ActiveControl = null;
            finalizarPedido.BackColor = Color.SteelBlue;
            finalizarPedido.Location = new Point(96, 239);
            finalizarPedido.Name = "finalizarPedido";
            finalizarPedido.Size = new Size(114, 59);
            finalizarPedido.TabIndex = 16;
            finalizarPedido.Text = "Finalizar\r\nPedido";
            finalizarPedido.TileImageAlign = ContentAlignment.MiddleRight;
            finalizarPedido.UseCustomBackColor = true;
            finalizarPedido.UseSelectable = true;
            finalizarPedido.UseTileImage = true;
            finalizarPedido.UseVisualStyleBackColor = false;
            finalizarPedido.Click += finalizarPedido_Click;
            // 
            // metroLabel1
            // 
            metroLabel1.AutoSize = true;
            metroLabel1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            metroLabel1.Location = new Point(96, 141);
            metroLabel1.Name = "metroLabel1";
            metroLabel1.Size = new Size(86, 25);
            metroLabel1.TabIndex = 20;
            metroLabel1.Text = "Efectivo:";
            metroLabel1.UseCustomBackColor = true;
            // 
            // metroTile1
            // 
            metroTile1.ActiveControl = null;
            metroTile1.BackColor = Color.SteelBlue;
            metroTile1.Location = new Point(216, 239);
            metroTile1.Name = "metroTile1";
            metroTile1.Size = new Size(114, 59);
            metroTile1.TabIndex = 17;
            metroTile1.Text = "Cerrar";
            metroTile1.TileImageAlign = ContentAlignment.MiddleRight;
            metroTile1.UseCustomBackColor = true;
            metroTile1.UseSelectable = true;
            metroTile1.UseTileImage = true;
            metroTile1.UseVisualStyleBackColor = false;
            metroTile1.Click += metroTile1_Click;
            // 
            // metroLabel2
            // 
            metroLabel2.AutoSize = true;
            metroLabel2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            metroLabel2.Location = new Point(89, 187);
            metroLabel2.Name = "metroLabel2";
            metroLabel2.Size = new Size(93, 25);
            metroLabel2.TabIndex = 21;
            metroLabel2.Text = "Devuelta:";
            metroLabel2.UseCustomBackColor = true;
            // 
            // devueltaLbl
            // 
            devueltaLbl.AutoSize = true;
            devueltaLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            devueltaLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            devueltaLbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            devueltaLbl.ForeColor = Color.Green;
            devueltaLbl.Location = new Point(195, 187);
            devueltaLbl.Name = "devueltaLbl";
            devueltaLbl.Size = new Size(59, 25);
            devueltaLbl.TabIndex = 22;
            devueltaLbl.Text = "RD$ -";
            devueltaLbl.UseCustomBackColor = true;
            devueltaLbl.UseCustomForeColor = true;
            // 
            // TerminarPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 340);
            Controls.Add(devueltaLbl);
            Controls.Add(metroLabel2);
            Controls.Add(metroTile1);
            Controls.Add(metroLabel1);
            Controls.Add(pagarLbl);
            Controls.Add(metroLabel8);
            Controls.Add(efectivoText);
            Controls.Add(finalizarPedido);
            Name = "TerminarPedido";
            Text = "Finalizar Pedido";
            Load += TerminarPedido_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MetroFramework.Controls.MetroLabel pagarLbl;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private TextBox efectivoText;
        private MetroFramework.Controls.MetroTile finalizarPedido;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel devueltaLbl;
    }
}