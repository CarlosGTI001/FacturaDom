using FacturaDom.BDO.Controladores;
using FacturaDom.BDO.Modelos;
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
    public partial class NuevoArticulo : MetroForm
    {
        public articulosController articulos;
        public NuevoArticulo()
        {
            InitializeComponent();
        }

        private void NuevoArticulo_Load(object sender, EventArgs e)
        {
            guardarArticulo.TileImage = IconChar.Save.ToBitmap(Color.White, 32);
            generarCodigo.TileImage = IconChar.Barcode.ToBitmap(Color.White, 32);
        }

        private void generarCodigo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nombre.Text) && decimal.TryParse(precio.Text, out decimal _precio))
            {
                var gen = nombre.Text.Substring(0, 2) + DateTime.Now.ToString("MMddhhmm") + Math.Round(_precio, 0).ToString();
                codigo.Text = gen;
            }
            else
            {
                alerta alerta = new alerta();
                alerta.cancelBtn.Hide();
                alerta.Text = "Aviso";
                var iconImage = IconChar.Warning.ToBitmap(size: 128, color: Color.Orange, iconFont: IconFont.Auto);
                alerta.icon.Image = iconImage;
                alerta.label1.Text = "No debe dejar ningun dato de la informacion del producto, ya que con ellos se genera el codigo del producto.";
                alerta.ShowDialog();
            }
        }

        private void guardarArticulo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nombre.Text) && tipoMedidaCbx.SelectedIndex > -1 && decimal.TryParse(cantidad.Text, out decimal _cantidad) && decimal.TryParse(precio.Text, out decimal _precio))
            {
                var resultado = articulos.ingresarProducto(new Articulo
                {
                    Codigo = codigo.Text,
                    Nombre = nombre.Text,
                    TipoMedida = tipoMedidaCbx.Text,
                    Precio = _precio,
                    Stock = _cantidad,
                    Descripcion = descripcion.Text
                }, 
                UserSession.Instance.UserCode, _cantidad, "Entrada");

                if (resultado)
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    alerta alerta = new alerta();
                    alerta.Text = "Aviso";
                    alerta.label1.Text = "No se pudo ingresar el producto.";
                    var iconImage = IconChar.Warning.ToBitmap(size: 128, color: Color.Red, iconFont: IconFont.Auto);
                    alerta.icon.Image = iconImage;
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
                alerta.label1.Text = "No debe dejar ningun dato de la informacion del producto.";
                alerta.ShowDialog();
            }
        }
    }
}
