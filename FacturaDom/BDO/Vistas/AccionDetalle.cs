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
    public partial class AccionDetalle : MetroForm
    {
        DetalleFactura articulo = new DetalleFactura();
        public AccionDetalle(Modelos.DetalleFactura modificable)
        {
            InitializeComponent();
            articulo = modificable;
        }

        private void AccionDetalle_Load(object sender, EventArgs e)
        {
            articuloNombre.Text = articulo.Nombre;
            precioLbl.Text = "RD$" + articulo.Precio;
            totalLbl.Text = "RD$" + 0;
            cantidadArticulo.Text = articulo.Cantidad.ToString();
            retirarArticulo.TileImage = IconChar.Trash.ToBitmap(size: 54, color: Color.White, iconFont: IconFont.Auto);
            cambiarArticulo.TileImage = IconChar.CartPlus.ToBitmap(size: 54, color: Color.White, iconFont: IconFont.Auto);
        }

        private void cantidadArticulo_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(cantidadArticulo.Text, out decimal result) && articulo != null)
            {
                totalLbl.Text = "RD$" + (result * articulo.Precio);
            }
        }

        private void retirarArticulo_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void cambiarArticulo_Click(object sender, EventArgs e)
        {
            articulo.Cantidad = decimal.Parse(cantidadArticulo.Text);
            DialogResult = DialogResult.Cancel;
        }
    }
}
