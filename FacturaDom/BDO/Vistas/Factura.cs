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
    public partial class Factura : MetroForm
    {
        public string clienteCedula;
        clienteController clienteController = new clienteController();

        public Factura()
        {
            InitializeComponent();
            this.BackgroundImage = IconChar.FileInvoiceDollar.ToBitmap(Color.SteelBlue, 128, 0);
        }

        private void Factura_Load(object sender, EventArgs e)
        {
            eliminarFactura.TileImage = IconChar.Trash.ToBitmap(size: 64, color: Color.White, iconFont: IconFont.Auto);
            nuevaFactura.TileImage = IconChar.FileCirclePlus.ToBitmap(size: 64, color: Color.White, iconFont: IconFont.Auto);
            agregarArticulo.TileImage = IconChar.Add.ToBitmap(size: 54, color: Color.White, iconFont: IconFont.Auto);
            imprimirFactura.TileImage = IconChar.Print.ToBitmap(size: 54, color: Color.White, iconFont: IconFont.Auto);
            buscarArticulo.TileImage = IconChar.Search.ToBitmap(size: 54, color: Color.White, iconFont: IconFont.Auto);
            facturarPanel.Hide();
            clientePanel.Hide();
            productosPanel.Hide();
            eliminarFactura.Hide();
            detalleGrid.DataSource = detalleFacturaBindingSource;
        }

        public Cliente cliente;
        facturaController facturaController = new facturaController();
        public Modelos.Factura factura;

        private void nuevaFactura_Click(object sender, EventArgs e)
        {
            ElegirCliente elegirCliente = new ElegirCliente(this);
            if (elegirCliente.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(clienteCedula))
            {
                facturarPanel.Show();
                clientePanel.Show();
                productosPanel.Show();
                cliente = clienteController.obtenerCliente(clienteCedula);
                clienteLbl.Text = cliente.Nombre + " " + cliente.Apellido + " (Cedula: " + cliente.Cedula + ")";
                facturaBox.Hide();
                var numero = facturaController.obtenerFacturas().Count() + 1;
                codigoLbl.Text = numero.ToString().PadLeft(6, '0');
                direccionLbl.Text = cliente.Direccion;
                factura = new Modelos.Factura
                {
                    CodigoFactura = codigoLbl.Text,
                    CodigoCliente = cliente.Cedula,
                    UserCode = UserSession.Instance.UserCode,
                    UserName = UserSession.Instance.UserName
                };
                DBDataContext.Instance.Factura.Add(factura);
                DBDataContext.Instance.SaveChanges();
                eliminarFactura.Show();
            }

        }

        private void facturaBox_Click(object sender, EventArgs e)
        {

        }

        private void eliminarFactura_Click(object sender, EventArgs e)
        {
            DBDataContext.Instance.Factura.Remove(factura);
            DBDataContext.Instance.SaveChanges();
            facturarPanel.Hide();
            clientePanel.Hide();
            productosPanel.Hide();
            eliminarFactura.Hide();
            clienteLbl.Text = "-";
            cliente = null;
            codigoLbl.Text = "-";
            direccionLbl.Text = "-";
            facturaBox.Show();
        }

        private void agregarArticulo_Click(object sender, EventArgs e)
        {
            detalle.Add(new DetalleFactura
            {
                Codigo = "DET" + articulo.Codigo + detalle.Count() + DateTime.Now.ToString("ddMMyymmss"),
                Nombre = articulo.Nombre,
                Descripcion = articulo.Descripcion,
                Precio = articulo.Precio,
                TipoMedida = articulo.TipoMedida,
                Cantidad = decimal.Parse(cantidadArticulo.Text),
                Total = decimal.Parse(totalLbl.Text.Replace("RD$", ""))
            });

            totalRds.Text = "RD$" + detalle.Sum(a => a.Total);
            articulosCantidad.Text = detalle.Count().ToString();
            detalleGrid.DataSource = detalle;
            quitar();
        }

        public List<Modelos.DetalleFactura> detalle = new List<DetalleFactura>();
        public Modelos.Articulo articulo;



        private void buscarArticulo_Click(object sender, EventArgs e)
        {
            ElegirArticulo elegirArticulo = new ElegirArticulo(this);

            if (elegirArticulo.ShowDialog() == DialogResult.OK)
            {
                articuloNombre.Text = articulo.Nombre;
                precioLbl.Text = "RD$" + articulo.Precio;
                totalLbl.Text = "RD$" + 0;
                agregarArticulo.Enabled = true;
            }
        }

        private void cantidadArticulo_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(cantidadArticulo.Text, out decimal result))
            {
                totalLbl.Text = "RD$" + (result * articulo.Precio);
            }
        }

        private void quitarArticulo_Click(object sender, EventArgs e)
        {
            quitar();
        }

        public void quitar()
        {
            agregarArticulo.Enabled = false;
            articuloNombre.Text = "-";
            precioLbl.Text = "RD$" + "-";
            totalLbl.Text = "RD$" + "-";
            articulosCantidad.Text = "0";
            articulo = null;
        }

        private void facturarPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
