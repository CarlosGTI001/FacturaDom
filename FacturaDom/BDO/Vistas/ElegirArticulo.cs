using FacturaDom.BDO.Controladores;
using FacturaDom.BDO.Modelos;
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
        articulosController articulosController = new articulosController();
        Factura Factura;
        public ElegirArticulo(Factura _Factura)
        {
            Factura = _Factura;
            InitializeComponent();
        }
        Articulo Articulo = new Articulo();
        private void ElegirArticulo_Load(object sender, EventArgs e)
        {
            articuloGrid.DataSource = articulosController.obtenerArticulos().Where(a => a.Stock > 0).ToList();
        }

        private void articuloGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Articulo = articulosController.obtenerArticulos()
                .Where(a => a.Codigo.Equals(articuloGrid
                .Rows[e.RowIndex]
                .Cells[0]
                .Value
                .ToString())).FirstOrDefault();
        }
    }
}
