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
    public partial class Agregar : MetroForm
    {
        public Articulo articulo;
        public articulosController articulos;
        public Agregar()
        {
            InitializeComponent();
        }

        private void Agregar_Load(object sender, EventArgs e)
        {
            agregarProducto.TileImage = IconChar.Save.ToBitmap(Color.White, 64);
            codigoP.Text = articulo.Codigo;
            nombreP.Text = articulo.Nombre;
            precioBox.Text = articulo.Precio.ToString();
            precioLabel.Visible = false;
            precioBox.Visible = false;
        }

        private void agregarProducto_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(cantidadText.Text, out decimal value) && decimal.TryParse(precioBox.Text, out decimal precio))
            {
                if (modPrecio.Checked && cantidadText.Text == "0")
                {
                    articulos.cambiarPrecio(articulo.Codigo, precio);
                }
                else if (modPrecio.Checked)
                {
                    articulos.anadirProducto(articulo.Codigo, value, precio);
                }
                else
                {
                    articulos.anadirProducto(articulo.Codigo, value);
                }
                alerta alerta = new alerta();
                alerta.Text = "Operacion exitosa";
                alerta.label1.Text = "Se realizo el cambio correctamente.";
                var iconImage = IconChar.Check.ToBitmap(size: 128, color: Color.Green, iconFont: IconFont.Auto);
                alerta.icon.Image = iconImage;
                if (alerta.ShowDialog() != null)
                {
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                alerta alerta = new alerta();
                alerta.Text = "Aviso";
                alerta.label1.Text = "No se pudo actualizar el producto. Revise que la cantidad ingresada tiene un formato valido.";
                var iconImage = IconChar.Warning.ToBitmap(size: 128, color: Color.Red, iconFont: IconFont.Auto);
                alerta.icon.Image = iconImage;
                alerta.ShowDialog();
            }
        }

        private void modPrecio_CheckedChanged(object sender, EventArgs e)
        {
            if (modPrecio.Checked)
            {
                precioLabel.Visible = true;
                precioBox.Visible = true;
            }
            else
            {
                precioLabel.Visible = false;
                precioBox.Visible = false;
            }
        }
    }
}
