using FacturaDom.BDO.Controladores;
using FacturaDom.BDO.Modelos;
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
    public partial class editarCliente : MetroForm
    {
        public Cliente? cliente;
        public clienteController clienteController;
        public editarCliente()
        {
            InitializeComponent();
        }


        private void editarCliente_Load(object sender, EventArgs e)
        {
            nombresText.Text = cliente.Nombre;
            apellidosText.Text = cliente.Apellido;
            cedulaText.Text = cliente.Cedula;
            telefonoText.Text = cliente.NumeroTelefono;
            fechaNacimientoPicker.Value = cliente.fechaNacimiento;
            direccionText.Text = cliente.Direccion;
            cedulaText.Text = cliente.Cedula;
            if (cliente.ClienteReferido == "000-0000000-0")
            {
                referido.Hide();
                referidoText.Hide();
                referidoBox.Hide();
            }
            else
            {
                referido.Show();
                referidoText.Show();
                referidoBox.Show();
                referido.Text = cliente.ClienteReferido;
                referidoBox.Checked = true;
            }
        }

        private void guardarUsuario_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nombresText.Text) && !string.IsNullOrWhiteSpace(apellidosText.Text) && cedulaText.MaskCompleted)
            {
                if (clienteController.editarCliente(cedulaText.Text, new Cliente
                {
                    Nombre = nombresText.Text,
                    Apellido = apellidosText.Text,
                    NumeroTelefono = telefonoText.Text,
                    fechaNacimiento = fechaNacimientoPicker.Value,
                    Direccion = direccionText.Text,
                    CodigoCliente = cedulaText.Text
                }))
                {

                    DialogResult = DialogResult.OK;
                }
                else
                {
                    alerta alerta = new alerta();
                    alerta.Text = "Error";
                    alerta.label1.Text = "No se pudo ingresar el cliente, revise la conexion con la base de datos.";
                    var iconImage = IconChar.Warning.ToBitmap(size: 64, color: Color.Red, iconFont: IconFont.Auto);
                    alerta.icon.Image = iconImage;
                    alerta.ShowDialog();
                }
            }
            else
            {
                alerta alerta = new alerta();
                alerta.Text = "Aviso";
                alerta.label1.Text = "No se pudo ingresar el cliente ya que faltan datos necesarios para continuar con el registro";
                var iconImage = IconChar.Warning.ToBitmap(size: 64, color: Color.Yellow, iconFont: IconFont.Auto);
                alerta.icon.Image = iconImage;
                alerta.ShowDialog();
            }
        }
    }
}
