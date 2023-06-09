using FacturaDom.BDO.Controladores;
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
    public partial class Clientes : MetroForm
    {
        clienteController context = new clienteController();
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            clientesGrid.DataSource = context.obtenerClientes();
            var iconImage = IconChar.UserPlus.ToBitmap(size: 64, color: Color.White, iconFont: IconFont.Auto);
            nuevoUsuario.TileImage = iconImage;
            iconImage = IconChar.UsersSlash.ToBitmap(size: 64, color: Color.White, iconFont: IconFont.Auto);
            eliminarUsuario.TileImage = iconImage;
            iconImage = IconChar.UserEdit.ToBitmap(size: 64, color: Color.White, iconFont: IconFont.Auto);
            editarClientes.TileImage = iconImage;
        }

        private void menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void clientText_TextChanged(object sender, EventArgs e)
        {
            clientesGrid.DataSource = context.buscarClientes(clientText.Text);
        }

        private void nuevoUsuario_Click(object sender, EventArgs e)
        {
            agregarCliente agregarCliente = new agregarCliente();
            if (agregarCliente.ShowDialog() == DialogResult.OK)
            {
                alerta alerta = new alerta();
                alerta.Text = "Correcto";
                alerta.label1.Text = "El usuario fue añadido al sistema correctamente.";
                var iconImage = IconChar.CheckCircle.ToBitmap(size: 64, color: Color.Green, iconFont: IconFont.Auto);
                alerta.icon.Image = iconImage;
                alerta.ShowDialog();
                clientesGrid.DataSource = context.obtenerClientes();
            }
        }

        private void editarCliente_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cedula))
            {
                var cliente = context.obtenerCliente(cedula);
                editarCliente editar = new editarCliente();
                editar.cliente = cliente;
                editar.clienteController = context;
                if (editar.ShowDialog() == DialogResult.OK)
                {
                    alerta alerta = new alerta();
                    alerta.Text = "Correcto";
                    alerta.label1.Text = "El usuario fue editado correctamente.";
                    var iconImage = IconChar.CheckCircle.ToBitmap(size: 64, color: Color.Green, iconFont: IconFont.Auto);
                    alerta.icon.Image = iconImage;
                    alerta.ShowDialog();
                    clientesGrid.DataSource = context.obtenerClientes();
                }
            }
        }
        string cedula;
        private void clientesGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cedula = clientesGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void eliminarCliente_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(cedula))
            {
                alerta alerta = new alerta();
                alerta.Text = "Aviso";
                alerta.label1.Text = "En realidad desea eliminar al cliente seleccionado?";
                var iconImage = IconChar.QuestionCircle.ToBitmap(size: 128, color: Color.Blue, iconFont: IconFont.Auto);
                alerta.icon.Image = iconImage;
                var a = alerta.ShowDialog();
                if (a == DialogResult.OK)
                {
                    var realizado = context.eliminarCliente(cedula);
                    if (realizado)
                    {
                        alerta = new alerta();
                        alerta.Text = "Correcto";
                        alerta.label1.Text = "Se ha eliminado el cliente.";
                        iconImage = IconChar.CheckCircle.ToBitmap(size: 64, color: Color.Green, iconFont: IconFont.Auto);
                        alerta.icon.Image = iconImage;
                        alerta.ShowDialog();
                        //DialogResult = DialogResult.OK;
                        cedula = "";
                        clientesGrid.DataSource = context.obtenerClientes();
                    }
                    else
                    {
                        alerta = new alerta();
                        alerta.Text = "Aviso";
                        alerta.label1.Text = "No se pudo eliminar al cliente.";
                        iconImage = IconChar.Warning.ToBitmap(size: 64, color: Color.Red, iconFont: IconFont.Auto);
                        alerta.icon.Image = iconImage;
                        alerta.ShowDialog();
                    }
                }
            }
        }
    }
}
