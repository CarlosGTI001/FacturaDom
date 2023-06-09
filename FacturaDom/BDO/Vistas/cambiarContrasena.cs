using FacturaDom.BDO.Controladores;
using FacturaDom.Data;
using FontAwesome.Sharp;
using MetroFramework.Forms;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacturaDom.BDO.Vistas
{
    public partial class cambiarContrasena : MetroForm
    {
        private logonController logonController;

        public cambiarContrasena(string UserCode, string UserName)
        {
            InitializeComponent();
            logonController = new logonController();
            codigoLbl.Text = UserCode;
            usuarioLbl.Text = UserName;
        }


        private void guardarContrasena_Click_1(object sender, EventArgs e)
        {
            if (con1.Text == con2.Text)
            {
                if (logonController.cambiarContrasena(codigoLbl.Text, con1.Text))
                {
                    alerta alerta = new alerta();
                    alerta.Text = "Correcto";
                    alerta.label1.Text = "Se ha cambiado la contraseña correctamente.";
                    var iconImage = IconChar.CheckCircle.ToBitmap(size: 64, color: Color.Green, iconFont: IconFont.Auto);
                    alerta.icon.Image = iconImage;
                    alerta.ShowDialog();
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    alerta alerta = new alerta();
                    alerta.Text = "Aviso";
                    alerta.label1.Text = "No se ha podido cambiar la contraseña.";
                    var iconImage = IconChar.Warning.ToBitmap(size: 64, color: Color.Red, iconFont: IconFont.Auto);
                    alerta.icon.Image = iconImage;
                    alerta.ShowDialog();
                }
            }
        }

        private void con2_TextChanged(object sender, EventArgs e)
        {
            if (con1.Text == con2.Text)
            {
                noCoincide.Hide();
            }
            else
            {
                noCoincide.Show();
            }
        }

        private void cambiarContrasena_Load(object sender, EventArgs e)
        {
            var iconImage = IconChar.Save.ToBitmap(size: 64, color: Color.White, iconFont: IconFont.Auto);
            guardarContrasena.TileImage = iconImage;
        }
    }
}
