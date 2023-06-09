using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using FacturaDom.BDO.Controladores;
using FacturaDom.Data;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using FontAwesome.Sharp;

namespace FacturaDom.BDO.Vistas
{
    public partial class logon : MetroForm
    {
        logonController logonController;
        public logon()
        {
            InitializeComponent();
            logonController = new logonController();
        }

        private void logon_Load(object sender, EventArgs e)
        {
            var _Imagen = IconChar.UserShield.ToBitmap(size: 128, color: Color.SteelBlue, iconFont: IconFont.Auto);
            imagen.Image = _Imagen;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            var usr = logonController.verificar(usuario: userText.Text, contrasena: passTxt.Text);
            if (usr != null)
            {
                MenuPrincipal menu = new MenuPrincipal();
                UserSession.Instance.UserName = userText.Text;
                string userCode = usr.UserCode;
                UserSession.Instance.UserCode = userCode;
                menu.Show();
                this.Hide();
            }
            else
            {
                alerta alerta = new alerta();
                alerta.cancelBtn.Hide();
                alerta.Text = "Error";
                var iconImage = IconChar.Warning.ToBitmap(size: 128, color: Color.Red, iconFont: IconFont.Auto);
                alerta.icon.Image = iconImage;
                alerta.label1.Text = "Combinacion de Usuario y Contraseña incorrectas, vuelva a intentarlo";
                alerta.ShowDialog();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {

        }

        private void logon_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void logon_Load_1(object sender, EventArgs e)
        {
            
        }

        private void logon_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}