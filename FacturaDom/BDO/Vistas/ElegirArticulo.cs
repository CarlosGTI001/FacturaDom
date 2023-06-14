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
    public partial class ElegirArticulo : MetroForm
    {
        Factura Factura;
        List<articulosTemporales> articulos;
        public ElegirArticulo(Factura _Factura, List<articulosTemporales> _articulos)
        {
            articulos = _articulos;
            
            Factura = _Factura;
            InitializeComponent();
        }
        articulosTemporales Articulo = new articulosTemporales();
        internal string Busqueda;

        private void ElegirArticulo_Load(object sender, EventArgs e)
        {
            articuloGrid.DataSource = articulos.Where(a => a.Stock > 0 && !a.Codigo.Contains("#")).ToList();
        }

        private void articuloGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var articulo = articulos
                .Where(a => a.Codigo.Equals(articuloGrid
                .Rows[e.RowIndex]
                .Cells[0]
                .Value
                .ToString())).FirstOrDefault();

            busquedaText.Text = Articulo.Codigo;
            Articulo = new articulosTemporales
            {
                Nombre = articulo.Nombre,
                Codigo = articulo.Codigo + "#",
                Descripcion = articulo.Descripcion,
                Precio = articulo.Precio,
                Stock = articulo.Stock,
                TipoMedida = articulo.TipoMedida
            };
            articulo = null;
            cantidadDisponible.Text = Articulo.Stock + " " + Articulo.TipoMedida;
        }

        private void elegir_Articulo_Click(object sender, EventArgs e)
        {
            Factura.articulo = Articulo;
            DialogResult = DialogResult.OK;
        }

        private void busquedaText_TextChanged(object sender, EventArgs e)
        {
            articuloGrid.DataSource = articulos
                .Where(a => a.Stock > 0)
                .Where(a => a.Codigo
                .Contains(busquedaText.Text) || a.Nombre
                .Contains(busquedaText.Text) && !a.Codigo.Contains("#"))
                .ToList();
        }
    }
}
