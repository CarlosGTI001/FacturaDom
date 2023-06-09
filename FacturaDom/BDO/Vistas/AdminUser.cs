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
using Rop.Winforms.Icons;
using Rop.Winforms.Icons.Helpers;
using FontAwesome.Sharp;
using FacturaDom.Data;
using FacturaDom.BDO.Controladores;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace FacturaDom.BDO.Vistas
{
    public partial class AdminUser : MetroForm
    {
        logonController logonController;
        public AdminUser()
        {
            InitializeComponent();
            logonController = new logonController();
        }

        private void AdminUser_Load(object sender, EventArgs e)
        {
            var iconImage = IconChar.Search.ToBitmap(size: 64, color: Color.White, iconFont: IconFont.Auto);
            buscarUsuario.TileImage = iconImage;
            iconImage = IconChar.UserPlus.ToBitmap(size: 64, color: Color.White, iconFont: IconFont.Auto);
            nuevoUsuario.TileImage = iconImage;
            iconImage = IconChar.UsersSlash.ToBitmap(size: 64, color: Color.White, iconFont: IconFont.Auto);
            eliminarUsuario.TileImage = iconImage;
            iconImage = IconChar.UserEdit.ToBitmap(size: 64, color: Color.White, iconFont: IconFont.Auto);
            editarContrasena.TileImage = iconImage;
        }

        private void AdminUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void buscarUsuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userText.Text) && string.IsNullOrEmpty(busquedaText.Text))
            {

                usuarioBindingSource.DataSource = logonController.leerUsuarios();

            }
            else
            {
                usuarioBindingSource.DataSource = logonController.filtrarUsuarios(userText.Text, busquedaText.Text);
            }
        }

        private void buscarUsuario_Click_1(object sender, EventArgs e)
        {

        }

        private void nuevoUsuario_Click(object sender, EventArgs e)
        {
            var dialogo = new agregarUsuario();
            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                alerta alerta = new alerta();
                alerta.Text = "Correcto";
                alerta.label1.Text = "El usuario fue añadido al sistema correctamente.";
                var iconImage = IconChar.CheckCircle.ToBitmap(size: 64, color: Color.Green, iconFont: IconFont.Auto);
                alerta.icon.Image = iconImage;
                alerta.ShowDialog();
                //DialogResult = DialogResult.OK;
                usuarioBindingSource.DataSource = logonController.leerUsuarios();
            }
            else
            {
                //alerta alerta = new alerta();
                //alerta.Text = "Aviso";
                //alerta.label1.Text = "Hubo un error al intentar ingresar al usuario.";
                //var iconImage = IconChar.Warning.ToBitmap(size: 64, color: Color.Red, iconFont: IconFont.Auto);
                //alerta.icon.Image = iconImage;
                //alerta.ShowDialog();
            }
        }

        private void eliminarUsuario_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(userText.Text))
            {
                alerta alerta = new alerta();
                alerta.Text = "Aviso";
                alerta.label1.Text = "En realidad desea eliminar al cliente seleccionado?";
                var iconImage = IconChar.QuestionCircle.ToBitmap(size: 128, color: Color.Blue, iconFont: IconFont.Auto);
                alerta.icon.Image = iconImage;
                var a = alerta.ShowDialog();
                if (a == DialogResult.OK)
                {
                    var realizado = logonController.eliminarUsuario(userText.Text);
                    if (realizado)
                    {
                        alerta = new alerta();
                        alerta.Text = "Correcto";
                        alerta.label1.Text = "Se ha eliminado el usuario.";
                        iconImage = IconChar.CheckCircle.ToBitmap(size: 64, color: Color.Green, iconFont: IconFont.Auto);
                        alerta.icon.Image = iconImage;
                        alerta.ShowDialog();
                        //DialogResult = DialogResult.OK;
                        userText.Clear();
                        usuarioBindingSource.DataSource = logonController.leerUsuarios();
                    }
                    else
                    {
                        alerta = new alerta();
                        alerta.Text = "Aviso";
                        alerta.label1.Text = "No se pudo eliminar el usuario del sistema.";
                        iconImage = IconChar.Warning.ToBitmap(size: 64, color: Color.Red, iconFont: IconFont.Auto);
                        alerta.icon.Image = iconImage;
                        alerta.ShowDialog();
                    }
                }
            }
        }

        private void usuariosGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var codigo = usuariosGrid.SelectedRows[0].Cells[0].Value.ToString();
                busquedaText.Text = codigo;
                var usuario = usuariosGrid.SelectedRows[0].Cells[1].Value.ToString();
                userText.Text = usuario;
            }
        }

        private void editarContrasena_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(busquedaText.Text))
            {
                cambiarContrasena cambiar = new cambiarContrasena(busquedaText.Text, userText.Text);
                cambiar.ShowDialog();
                busquedaText.Clear();
                userText.Clear();
                usuarioBindingSource.DataSource = logonController.leerUsuarios();
            }
        }
    }
}