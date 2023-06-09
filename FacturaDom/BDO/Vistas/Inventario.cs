using FacturaDom.BDO.Controladores;
using FacturaDom.BDO.Modelos;
using FontAwesome.Sharp;
using MetroFramework.Forms;
using Microsoft.Reporting.WinForms;
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
    public partial class Inventario : MetroForm
    {
        articulosController articulos = new articulosController();
        public Inventario()
        {
            InitializeComponent();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            var iconImage = IconChar.Box.ToBitmap(size: 64, color: Color.White, iconFont: IconFont.Auto);
            nuevoProducto.TileImage = iconImage;
            iconImage = IconChar.Print.ToBitmap(size: 64, color: Color.White, iconFont: IconFont.Auto);
            imprimirReporte.TileImage = iconImage;
            iconImage = IconChar.FileEdit.ToBitmap(size: 64, color: Color.White, iconFont: IconFont.Auto);
            modificarProducto.TileImage = iconImage;
            iconImage = IconChar.Clock.ToBitmap(size: 64, color: Color.White, iconFont: IconFont.Auto);
            historialInventario.TileImage = iconImage;
            inventarioGrid.DataSource = articulos.obtenerArticulos();
        }

        private void nuevoProducto_Click(object sender, EventArgs e)
        {
            NuevoArticulo nuevoArticulo = new NuevoArticulo();
            this.Hide();
            nuevoArticulo.articulos = articulos;
            if (nuevoArticulo.ShowDialog() != null)
            {
                this.Show();
                inventarioGrid.DataSource = articulos.obtenerArticulos();
            }
        }

        private void Inventario_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }


        Articulo Articulo;

        private void inventarioGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var codigo = inventarioGrid.SelectedRows[0].Cells[0].Value.ToString();
            Articulo = articulos.obtenerArticulos().Where(a => a.Codigo == codigo).FirstOrDefault();
            codigoProducto.Text = codigo;
            nombreProducto.Text = Articulo.Nombre;
        }

        private void historialInventario_Click(object sender, EventArgs e)
        {
            HistorialInventario historialInventario = new HistorialInventario();
            historialInventario.articulos = articulos;
            this.Hide();
            if (historialInventario.ShowDialog() != null)
            {
                this.Show();
            }
        }

        private void modificarProducto_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(codigoProducto.Text))
            {
                Agregar agregar = new Agregar();
                agregar.articulos = articulos;
                agregar.articulo = Articulo;
                this.Hide();
                if (agregar.ShowDialog() != null)
                {
                    this.Show();
                }
            }
        }

        private void codigoProducto_TextChanged(object sender, EventArgs e)
        {
            inventarioGrid.DataSource = articulos.filtrarArticulosCodigo(codigoProducto.Text);
        }

        private void nombreProducto_TextChanged(object sender, EventArgs e)
        {
            inventarioGrid.DataSource = articulos.filtrarArticulosNombre(nombreProducto.Text);
        }

        private void imprimirReporte_Click(object sender, EventArgs e)
        {
            VisorDeReportes reporte = new VisorDeReportes();
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "PP";
            rds.Value = articulos.obtenerArticulos();
            reporte.reporteVisor.LocalReport.ReportEmbeddedResource = "FacturaDom.Inventario.rdlc";
            reporte.reporteVisor.LocalReport.DataSources.Add(rds);
            reporte.reporteVisor.RefreshReport();
            reporte.Text += " Inventario"; 
            reporte.ShowDialog();
        }
    }
}
