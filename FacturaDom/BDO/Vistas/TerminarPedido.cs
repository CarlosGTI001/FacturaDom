using FacturaDom.BDO.Controladores;
using FacturaDom.BDO.Modelos;
using FacturaDom.Data;
using FontAwesome.Sharp;
using MetroFramework.Forms;
using Microsoft.EntityFrameworkCore.Storage;
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
    public partial class TerminarPedido : MetroForm
    {
        List<DetalleFactura> detalle;
        Modelos.Factura factura;
        Vistas.Factura vFactura;
        Cliente cliente;
        public TerminarPedido(List<DetalleFactura> _detalle, Modelos.Factura _factura, Vistas.Factura _vFactura, Cliente _cliente)
        {
            InitializeComponent();
            detalle = _detalle;
            factura = _factura;
            vFactura = _vFactura;
            cliente = _cliente;
        }


        List<FacturaDetalle> detalleGuardar = new List<FacturaDetalle>();
        private bool listo = false;


        private void TerminarPedido_Load(object sender, EventArgs e)
        {
            factura.TotalFactura = detalle.Sum(a => a.Total);
            pagarLbl.Text = "RD$" + factura.TotalFactura;
            var n = 0;
            foreach (var detal in detalle)
            {
                n++;
                detalleGuardar.Add(new FacturaDetalle
                {
                    code = n,
                    CodigoFactura = factura.CodigoFactura,
                    Nombre = detal.Nombre,
                    Descripcion = cliente.Direccion,
                    UserCode = UserSession.Instance.UserCode,
                    UserName = UserSession.Instance.UserName,
                    TotalFactura = factura.TotalFactura,
                    FechaFactura = DateTime.Now,
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
        }

        private void cantidadArticulo_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(efectivoText.Text, out decimal result))
            {
                var resultado = (result - factura.TotalFactura);
                if(resultado >= 0)
                {
                    //resultado = decimal.Parse(resultado.ToString().Replace("-", ""));
                    devueltaLbl.Text = "RD$" + resultado.ToString().Replace("-", "");
                }
                else
                {
                    devueltaLbl.Text = "Incompleto";
                }

            }
        }

        articulosController art = new articulosController();

        private void finalizarPedido_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(efectivoText.Text, out decimal result) && devueltaLbl.Text != "Error" && result >= factura.TotalFactura)
            {
                FacturaVisor facturaVisor = new FacturaVisor(detalleGuardar);
                var N = 0;
                foreach (var det in detalle)
                {
                    N++;
                    det.CodigoFactura = factura.CodigoFactura;
                    det._Codigo = det._Codigo.Replace("#", "");
                    DBDataContext.Instance.detalleFacturas.Add(det);
                    DBDataContext.Instance.Articulo.Find(det._Codigo.Replace("#", "")).Stock -= det.Cantidad;
                    
                    DBDataContext.Instance.Movimientos.Add(new Movimientos
                    {
                        MovimientoId = DateTime.Now.ToString("ddmmyyMMhhss" + N),
                        Articulo = DBDataContext.Instance.Articulo.Find(det._Codigo.Replace("#", "")),
                        Usuario = DBDataContext.Instance.Usuarios.Find(UserSession.Instance.UserCode),
                        FechaMovimiento = DateTime.Now,
                        Cantidad = det.Cantidad,
                        Tipo = "Salida"
                    });
                }
                factura.FechaFactura = DateTime.Now;
                DBDataContext.Instance.Factura.Add(factura);
                var eliminarArticulos = DBDataContext.Instance.Articulo.Where(a => a.Codigo.Contains("#"));
                foreach(var articulo in eliminarArticulos)
                {
                    DBDataContext.Instance.Articulo.Remove(articulo);
                }
                DBDataContext.Instance.SaveChanges();
                listo = true;
                finalizarPedido.Hide();
                facturaVisor.ShowDialog();
            }
            else
            {
                alerta alerta = new alerta();
                alerta.Text = "Aviso";
                var iconImage = IconChar.Warning.ToBitmap(size: 128, color: Color.Red, iconFont: IconFont.Auto);
                alerta.icon.Image = iconImage;
                alerta.label1.Text = "No es posible efectuar la compra, registre los datos ingresados.";
                var a = alerta.ShowDialog();
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            if (listo)
            {
                DialogResult = DialogResult.OK;

            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}