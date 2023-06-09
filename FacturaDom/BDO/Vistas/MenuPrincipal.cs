using FacturaDom.BDO.Controladores;
using FacturaDom.Data;
using FontAwesome.Sharp;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacturaDom.BDO.Vistas
{
    public partial class MenuPrincipal : MetroForm
    {
        logonController logonController = new logonController();
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            userName.Text = UserSession.Instance.UserName;
            var iconImage = IconChar.FileInvoiceDollar.ToBitmap(size: 128, color: Color.White, iconFont: IconFont.Auto);
            crearFactura.TileImage = iconImage;
            iconImage = IconChar.Calendar.ToBitmap(size: 128, color: Color.White, iconFont: IconFont.Auto);
            historialFactura.TileImage = iconImage;
            iconImage = IconChar.Users.ToBitmap(size: 128, color: Color.White, iconFont: IconFont.Auto);
            administrarUsuario.TileImage = iconImage;
            iconImage = IconChar.UserClock.ToBitmap(size: 128, color: Color.White, iconFont: IconFont.Auto);
            historialSesiones.TileImage = iconImage;
            iconImage = IconChar.Warehouse.ToBitmap(size: 128, color: Color.White, iconFont: IconFont.Auto);
            registroInventario.TileImage = iconImage;
            iconImage = IconChar.Gears.ToBitmap(size: 128, color: Color.White, iconFont: IconFont.Auto);
            administrarClientes.TileImage = iconImage;
            iconImage = IconChar.WindowClose.ToBitmap(size: 128, color: Color.White, iconFont: IconFont.Auto);
            cerrarSesion.TileImage = iconImage;
            iconImage = IconChar.User.ToBitmap(size: 32, color: Color.White, iconFont: IconFont.Auto);
            picImg.BackgroundImage = iconImage;
            iconImage = IconChar.UserGear.ToBitmap(size: 32, color: Color.White, iconFont: IconFont.Auto, flip: FlipOrientation.Normal);

        }
        bool serrar = true;
        private void cerrarSesion_Click(object sender, EventArgs e)
        {
            logon logon = new logon();
            alerta alerta = new alerta();
            alerta.Text = "Aviso";
            var iconImage = IconChar.QuestionCircle.ToBitmap(size: 128, color: Color.Blue, iconFont: IconFont.Auto);
            alerta.icon.Image = iconImage;
            alerta.label1.Text = "En realidad desea salir?";
            logonController.cerrarSeccion();
            var a = alerta.ShowDialog();
            if (a == DialogResult.OK)
            {
                serrar = false;
                this.Dispose();
                logon.Show();
            }
            else
            {
                alerta.Close();
            }
        }

        private void administrarUsuario_Click(object sender, EventArgs e)
        {
            if (UserSession.Instance.UserCode.Contains("ADM") || UserSession.Instance.UserCode == "US0001")
            {
                AdminUser adminUser = new AdminUser();
                this.Hide();
                if (adminUser.ShowDialog() != null)
                {
                    this.Show();
                }
            }
            else
            {
                alerta alerta = new alerta();
                alerta.cancelBtn.Hide();
                alerta.Text = "Error";
                var iconImage = IconChar.Warning.ToBitmap(size: 128, color: Color.Red, iconFont: IconFont.Auto);
                alerta.icon.Image = iconImage;
                alerta.label1.Text = "No eres administrador para ingresar a esta parte del sistema.";
                alerta.ShowDialog();
            }
        }

        private void MenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serrar)
            {
                logon logon = new logon();
                alerta alerta = new alerta();
                alerta.Text = "Aviso";
                var iconImage = IconChar.QuestionCircle.ToBitmap(size: 128, color: Color.Blue, iconFont: IconFont.Auto);
                alerta.icon.Image = iconImage;
                alerta.label1.Text = "En realidad desea salir?";
                var a = alerta.ShowDialog();
                if (a == DialogResult.OK)
                {
                    logon.Show();
                    logonController.cerrarSeccion();
                    alerta.Close();
                    serrar = false;
                    this.Dispose();
                }
                else
                {
                    e.Cancel = true;
                    alerta.Close();
                }
            }
        }

        private void crearFactura_Click(object sender, EventArgs e)
        {
            Factura factura = new Factura();
            this.Hide();

            if (factura.ShowDialog() != null)
            {
                this.Show();
            }
        }

        private void historialFactura_Click(object sender, EventArgs e)
        {

        }

        private void historialSesiones_Click(object sender, EventArgs e)
        {
            if (UserSession.Instance.UserCode.Contains("ADM") || UserSession.Instance.UserCode == "US0001")
            {
                SesionesUsuarios sesionesUsuarios = new SesionesUsuarios();
                this.Hide();

                if (sesionesUsuarios.ShowDialog() != null)
                {
                    this.Show();
                }
;
            }
            else
            {
                alerta alerta = new alerta();
                alerta.cancelBtn.Hide();
                alerta.Text = "Error";
                var iconImage = IconChar.Warning.ToBitmap(size: 128, color: Color.Red, iconFont: IconFont.Auto);
                alerta.icon.Image = iconImage;
                alerta.label1.Text = "No eres administrador para ingresar a esta parte del sistema.";
                alerta.ShowDialog();
            }
        }

        private void registroInventario_Click(object sender, EventArgs e)
        {
            Inventario inventario = new Inventario();
            this.Hide();
            if (inventario.ShowDialog() != null)
            {
                this.Show();
            }
        }

        private void configuracionSistema_Click(object sender, EventArgs e)
        {
            if (UserSession.Instance.UserCode.Contains("ADM") || UserSession.Instance.UserCode == "US0001")
            {

            }
            else
            {
                alerta alerta = new alerta();
                alerta.cancelBtn.Hide();
                alerta.Text = "Error";
                var iconImage = IconChar.Warning.ToBitmap(size: 128, color: Color.Red, iconFont: IconFont.Auto);
                alerta.icon.Image = iconImage;
                alerta.label1.Text = "No eres administrador para ingresar a esta parte del sistema.";
                alerta.ShowDialog();
            }
        }

        private void administrarClientes_Click(object sender, EventArgs e)
        {
            if (UserSession.Instance.UserCode.Contains("ADM") || UserSession.Instance.UserCode == "US0001")
            {
                Clientes clientes = new Clientes();
                this.Hide();
                if (clientes.ShowDialog() != null)
                {
                    this.Show();
                }
            }
            else
            {
                alerta alerta = new alerta();
                alerta.cancelBtn.Hide();
                alerta.Text = "Error";
                var iconImage = IconChar.Warning.ToBitmap(size: 128, color: Color.Red, iconFont: IconFont.Auto);
                alerta.icon.Image = iconImage;
                alerta.label1.Text = "No eres administrador para ingresar a esta parte del sistema.";
                alerta.ShowDialog();
            }
        }
    }
}
