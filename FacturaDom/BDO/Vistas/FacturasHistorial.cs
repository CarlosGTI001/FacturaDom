using FacturaDom.BDO.Modelos;
using FacturaDom.Data;
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
    public partial class FacturasHistorial : MetroForm
    {
        public FacturasHistorial()
        {
            InitializeComponent();
        }
        public List<FacturaDetalle> facturars = new List<FacturaDetalle>();
        private void FacturasHistorial_Load(object sender, EventArgs e)
        {
            var facturas = DBDataContext.Instance.Factura.ToList();

            var n = 0;
            foreach (var factura in facturas)
            {
                var cliente = DBDataContext.Instance.Clientes.Find(factura.CodigoCliente);
                n++;
                facturars.Add(new FacturaDetalle
                {
                    code = n,
                    CodigoFactura = factura.CodigoFactura,
                    Nombre = "",
                    Descripcion = "",
                    UserCode = factura.UserCode,
                    UserName = factura.UserName,
                    TotalFactura = factura.TotalFactura,
                    FechaFactura = factura.FechaFactura,
                    Precio = 0,
                    Cantidad = 0,
                    TipoMedida = "",
                    descuento = 0,
                    Total = 0,
                    NombreCliente = cliente.Nombre,
                    CodigoCliente = cliente.CodigoCliente,
                    ApellidoCliente = cliente.Apellido,
                    CedulaCliente = cliente.CodigoCliente,
                    CodigoProducto = "",
                });
            }
            facturaGrid.DataSource = facturars.OrderBy(a => a.FechaFactura).ToList();
        }

        private void facturaGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var codigoFactura = facturaGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                Modelos.Factura factura = DBDataContext.Instance.Factura.Find(codigoFactura);
                List<FacturaDetalle> facturaDetalles = new List<FacturaDetalle>();
                var detalle = DBDataContext.Instance.detalleFacturas.Where(a => a.CodigoFactura == codigoFactura).ToList();
                var n = 0;
                foreach (var detal in detalle)
                {
                    var cliente = DBDataContext.Instance.Clientes.Find(factura.CodigoCliente);
                    n++;
                    facturaDetalles.Add(new FacturaDetalle
                    {
                        code = n,
                        CodigoFactura = factura.CodigoFactura,
                        Nombre = detal.Nombre,
                        Descripcion = cliente.Direccion,
                        UserCode = factura.UserCode,
                        UserName = factura.UserName,
                        TotalFactura = factura.TotalFactura,
                        FechaFactura = factura.FechaFactura,
                        Precio = detal.Precio,
                        Cantidad = detal.Cantidad,
                        TipoMedida = detal.TipoMedida,
                        descuento = 0,
                        Total = detal.Total,
                        NombreCliente = cliente.Nombre,
                        ApellidoCliente = cliente.Apellido,
                        CedulaCliente = cliente.CodigoCliente,
                        CodigoProducto = detal._Codigo.Replace("#", ""),
                    });
                }

                FacturaVisor imprimir = new FacturaVisor(facturaDetalles);
                imprimir.ShowDialog();
            }
        }

        private void nombresText_TextChanged(object sender, EventArgs e)
        {
            var filtrado = facturars.Where(a => a.NombreCliente.Contains(busquedaText.Text) || a.CedulaCliente.Contains(busquedaText.Text) || a.CodigoFactura.Contains(busquedaText.Text)).ToList();
            facturaGrid.DataSource = filtrado;
        }
    }
}
