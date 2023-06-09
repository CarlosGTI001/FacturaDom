using FacturaDom.BDO.Controladores;
using FacturaDom.BDO.Modelos;
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
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacturaDom.BDO.Vistas
{
    public partial class agregarUsuario : MetroForm
    {
        logonController logonController;
        public agregarUsuario()
        {
            InitializeComponent();
            logonController = new logonController();

        }

        private void agregarUsuario_Load(object sender, EventArgs e)
        {
            var iconImage = IconChar.Refresh.ToBitmap(size: 40, color: Color.White, iconFont: IconFont.Auto);
            generarCredenciales.TileImage = iconImage;
            iconImage = IconChar.Save.ToBitmap(size: 40, color: Color.White, iconFont: IconFont.Auto);
            guardarUsuario.TileImage = iconImage;
            tipoUsuarioCbx.SelectedIndex = 0;
        }

        private void generarCredenciales_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nombresText.Text) && !string.IsNullOrWhiteSpace(apellidosText.Text) && tipoUsuarioCbx.SelectedIndex != 0 && telefonoText.MaskFull && cedulaText.MaskCompleted && fechaCa)
            {
                var usuario = nombresText.Text.Substring(0, 2) + apellidosText.Text + fechaNacimientoPicker.Value.Month.ToString();
                var codigo = (tipoUsuarioCbx.SelectedIndex == 1 ? "ADM" : "USR") + fechaNacimientoPicker.Value.Day.ToString() + DateTime.Now.Year.ToString().Substring(2, 2) + DateTime.Now.Minute.ToString() + DateTime.Now.Hour.ToString();

                codigoText.Text = codigo;
                userText.Text = usuario;
            }
            else
            {
                alerta alerta = new alerta();
                alerta.cancelBtn.Hide();
                alerta.Text = "Aviso";
                var iconImage = IconChar.Warning.ToBitmap(size: 128, color: Color.Orange, iconFont: IconFont.Auto);
                alerta.icon.Image = iconImage;
                alerta.label1.Text = "No debe dejar ningun dato de la informacion personal, ya que con ellos se genera las credenciales.";
                alerta.ShowDialog();
            }

        }
        bool fechaCa = false;
        private bool verificado;

        private void fechaNacimientoPicker_ValueChanged(object sender, EventArgs e)
        {
            fechaCa = true;
        }

        private void guardarUsuario_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nombresText.Text) && !string.IsNullOrWhiteSpace(apellidosText.Text) && tipoUsuarioCbx.SelectedIndex != 0 && telefonoText.MaskCompleted && cedulaText.MaskCompleted && fechaCa && !string.IsNullOrEmpty(userText.Text) && !string.IsNullOrEmpty(codigoText.Text) && !string.IsNullOrEmpty(contrasenaText.Text))
            {
                try
                {
                    verificado = logonController.ingresarUsuarios(new Usuario
                    {
                        Nombre = nombresText.Text,
                        Apellido = apellidosText.Text,
                        Cedula = cedulaText.Text,
                        NumeroTelefono = telefonoText.Text,
                        fechaNacimiento = fechaNacimientoPicker.Value,
                        Direccion = direccionText.Text,
                        UserCode = codigoText.Text,
                        UserName = userText.Text,
                        UserPass = contrasenaText.Text,
                        CreateDate = DateTime.Now,
                    });


                    if (verificado)
                    {
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        alerta alerta = new alerta();
                        alerta.Text = "Aviso";
                        alerta.label1.Text = "No se pudo ingresar el usuario.";
                        var iconImage = IconChar.Warning.ToBitmap(size: 64, color: Color.Red, iconFont: IconFont.Auto);
                        alerta.icon.Image = iconImage;
                        alerta.ShowDialog();
                    }
                }
                catch
                {
                    alerta alerta = new alerta();
                    alerta.cancelBtn.Hide();
                    alerta.Text = "Aviso";
                    var iconImage = IconChar.Warning.ToBitmap(size: 128, color: Color.Red, iconFont: IconFont.Auto);
                    alerta.icon.Image = iconImage;
                    alerta.label1.Text = "Hubo un error al almacenar este usuario, revise los datos ingresados o la conexion con la base de datos.";
                    alerta.ShowDialog();
                }
            }
            else
            {
                alerta alerta = new alerta();
                alerta.cancelBtn.Hide();
                alerta.Text = "Aviso";
                var iconImage = IconChar.Warning.ToBitmap(size: 128, color: Color.Orange, iconFont: IconFont.Auto);
                alerta.icon.Image = iconImage;
                alerta.label1.Text = "No debe dejar ningun dato de la informacion personal ni las credenciales, rellena los datos faltantes para continuar con el registro.";
                alerta.ShowDialog();
            }
        }

        private void agregarUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            verificado = true;
        }
    }
}
