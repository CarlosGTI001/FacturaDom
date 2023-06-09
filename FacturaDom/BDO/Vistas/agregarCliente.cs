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
    public partial class agregarCliente : MetroForm
    {
        public agregarCliente()
        {
            InitializeComponent();
        }

        private void agregarCliente_Load(object sender, EventArgs e)
        {
            referidoText.Hide();
            referido.Hide();
        }

        private void referidoBox_CheckedChanged(object sender, EventArgs e)
        {
            if (referidoBox.Checked)
            {
                referidoText.Show();
                referido.Show();
            }
            else
            {
                referidoText.Hide();
                referido.Hide();
            }
        }
        clienteController clienteController = new clienteController();
        private void guardarUsuario_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(nombresText.Text) && !string.IsNullOrWhiteSpace(apellidosText.Text) && cedulaText.MaskCompleted){
                var _referido = "000-0000000-0";
                if (referidoBox.Checked)
                {
                    _referido = referido.Text;
                }
                if (clienteController.ingresarCliente(new Modelos.Cliente
                {
                    Nombre = nombresText.Text,
                    Apellido = apellidosText.Text,
                    Cedula = cedulaText.Text,
                    NumeroTelefono = telefonoText.Text,
                    fechaNacimiento = fechaNacimientoPicker.Value,
                    Direccion = direccionText.Text,
                    Habilitado = true,
                    CodigoCliente = cedulaText.Text,
                    ClienteReferido = _referido
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
