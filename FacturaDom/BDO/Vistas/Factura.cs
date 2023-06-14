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
    public partial class Factura : MetroForm
    {
        public string clienteCedula;
        //clienteController clienteController = new clienteController();
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
            imprimirFactura.TileImage = IconChar.CartShopping.ToBitmap(size: 54, color: Color.White, iconFont: IconFont.Auto);
            buscarArticulo.TileImage = IconChar.Search.ToBitmap(size: 54, color: Color.White, iconFont: IconFont.Auto);
            facturarPanel.Hide();
            clientePanel.Hide();
            productosPanel.Hide();
            eliminarFactura.Hide();
        }

        public Cliente cliente;
        facturaController facturaController = new facturaController();
        public Modelos.Factura factura = null;
        public FacturaTemporal datosTemporales;
        private void nuevaFactura_Click(object sender, EventArgs e)
        {
            //cliente = null;
            //DBDataContext.Instance.Database.BeginTransaction();
            ElegirCliente elegirCliente = new ElegirCliente(this);
            

            
            if (elegirCliente.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(clienteCedula))
            {
                facturarPanel.Show();
                clientePanel.Show();
                productosPanel.Show();
                cliente = DBDataContext.Instance.Clientes.Find(clienteCedula);
                clienteLbl.Text = cliente.Nombre + " " + cliente.Apellido + " (Cedula: " + cliente.Cedula + ")";
                facturaBox.Hide();
                var resultado = true;
                while(resultado = true)
                {
                    var aleatorio = new Random().Next(100000, 999999);

                    if (DBDataContext.Instance.Factura.Find(aleatorio.ToString()) == null)
                    {
                        codigoLbl.Text = aleatorio.ToString();
                        break;
                    }
                }
                direccionLbl.Text = cliente.Direccion;
                datosTemporales = new FacturaTemporal();
                datosTemporales.factura = new Modelos.Factura
                {
                    CodigoFactura = codigoLbl.Text,
                    CodigoCliente = cliente.Cedula,
                    UserCode = UserSession.Instance.UserCode,
                    UserName = UserSession.Instance.UserName
                };
                foreach(var articunos in DBDataContext.Instance.Articulo.ToList())
                {
                    datosTemporales.articulosTemporales.Add(new articulosTemporales
                    {
                        Nombre = articunos.Nombre,
                        Codigo = articunos.Codigo,
                        Descripcion = articunos.Descripcion,
                        Precio = articunos.Precio,
                        Stock = articunos.Stock,
                        TipoMedida = articunos.TipoMedida
                    });
                }
                //DBDataContext.Instance.Factura.Add(factura);
                nuevaFactura.Hide();
                eliminarFactura.Show();
            }
        }

        private void facturaBox_Click(object sender, EventArgs e)
        {

        }

        private void eliminarFactura_Click(object sender, EventArgs e)
        {
            
            alerta alerta = new alerta();
            alerta.Text = "Aviso";
            var iconImage = IconChar.QuestionCircle.ToBitmap(size: 128, color: Color.Blue, iconFont: IconFont.Auto);
            alerta.icon.Image = iconImage;
            alerta.label1.Text = "En realidad desea eliminar la factura?";
            var a = alerta.ShowDialog();
            if (a == DialogResult.OK)
            {
                datosTemporales = new FacturaTemporal();
                //DBDataContext.Instance.Factura.Remove(factura);
                //DBDataContext.Instance.Dispose();
                //DBDataContext.Instance.Database.RollbackTransaction();
                facturarPanel.Hide();
                clientePanel.Hide();
                productosPanel.Hide();
                eliminarFactura.Hide();
                clienteLbl.Text = "-";
                detalleGrid.DataSource = "";
                cliente = null;
                factura = null;
                codigoLbl.Text = "-";
                direccionLbl.Text = "-";
                nuevaFactura.Show();
                facturaBox.Show();
            }
            else
            {
                alerta.Close();
            }
        }

        private void agregarArticulo_Click(object sender, EventArgs e)
        {
            if (articulo.Stock >= decimal.Parse(cantidadArticulo.Text))
            {
                
                detalle.Add(new DetalleFactura
                {
                    Codigo = "DET" + articulo.Codigo + detalle.Count() + DateTime.Now.ToString("ddMMyymmss"),
                    Nombre = articulo.Nombre,
                    Descripcion = articulo.Descripcion,
                    Precio = articulo.Precio,
                    TipoMedida = articulo.TipoMedida,
                    Cantidad = decimal.Parse(cantidadArticulo.Text),
                    Total = decimal.Parse(totalLbl.Text.Replace("RD$", "")),
                    _Codigo = articulo.Codigo,
                    _Nombre = articulo.Nombre,
                    _Descripcion = articulo.Descripcion,
                    _Precio = articulo.Precio,
                    _Stock = articulo.Stock,
                    _TipoMedida = articulo.TipoMedida
                });

                datosTemporales.articulosTemporales.Where(a=>a.Codigo == articulo.Codigo.Replace("#","")).First().Stock -= decimal.Parse(cantidadArticulo.Text);
                //DBDataContext.Instance.Articulo.Find(articulo.Codigo).Stock -= decimal.Parse(cantidadArticulo.Text);
                //DBDataContext.Instance.SaveChanges();
                totalRds.Text = "RD$" + detalle.Sum(a => a.Total);
                articuloCantidad.Text = detalle.Count().ToString();
                cantidadArticulo.Text = "0";
                detalleGrid.DataSource = "";
                detalleGrid.DataSource = detalle;
                quitar();
            }
            else
            {
                alerta alerta = new alerta();
                alerta.Text = "Aviso";
                var iconImage = IconChar.QuestionCircle.ToBitmap(size: 128, color: Color.Blue, iconFont: IconFont.Auto);
                alerta.icon.Image = iconImage;
                alerta.label1.Text = "El stock disponible no satisface la peticion";
                var a = alerta.ShowDialog();
            }
        }

        public List<Modelos.DetalleFactura> detalle = new List<DetalleFactura>();
        public Modelos.articulosTemporales articulo;
        private IDbContextTransaction tx;

        private void buscarArticulo_Click(object sender, EventArgs e)
        {
            
            ElegirArticulo elegirArticulo = new ElegirArticulo(this, datosTemporales.articulosTemporales);

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
            if (decimal.TryParse(cantidadArticulo.Text, out decimal result) && articulo != null)
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
            cantidadArticulo.Text = "0";
            articulo = null;
        }

        private void facturarPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void detalleGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var modificable = detalle.FirstOrDefault(a => a.Codigo == detalleGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
            if (new AccionDetalle(modificable).ShowDialog() == DialogResult.OK)
            {
                detalle.Remove(modificable);
            }
            else
            {
                int index = detalle.IndexOf(modificable);
                detalle[index].Cantidad = modificable.Cantidad;
                detalle[index].Total = modificable.Cantidad * modificable.Precio;
                detalleGrid.DataSource = null;
                detalleGrid.DataSource = detalle;
            }
            totalRds.Text = "RD$" + detalle.Sum(a => a.Total);
            articuloCantidad.Text = detalle.Count.ToString();
        }

        private void imprimirFactura_Click(object sender, EventArgs e)
        {
            if(detalle.Count() > 0)
            {
                TerminarPedido term = new TerminarPedido(detalle,datosTemporales.factura, this, cliente);
                if (term.ShowDialog() == DialogResult.OK)
                {
                    term.Hide();
                    detalle = new List<DetalleFactura>();
                    facturarPanel.Hide();
                    clientePanel.Hide();
                    productosPanel.Hide();
                    eliminarFactura.Hide();
                    clienteLbl.Text = "-";
                    cliente = null;
                    factura = null;
                    codigoLbl.Text = "-";
                    direccionLbl.Text = "-";
                    nuevaFactura.Show();
                    facturaBox.Show();
                    detalleGrid.DataSource = "";
                }
            }
        }

        private void Factura_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(factura != null)
            {
                alerta alerta = new alerta();
                alerta.Text = "Aviso";
                var iconImage = IconChar.QuestionCircle.ToBitmap(size: 128, color: Color.Blue, iconFont: IconFont.Auto);
                alerta.icon.Image = iconImage;
                alerta.label1.Text = "En realidad desea salir y eliminar la factura?";
                var a = alerta.ShowDialog();

                if (a == DialogResult.OK)
                {
                    try 
                    {
                        DialogResult = DialogResult.OK;
                        detalleGrid.DataSource = "";
                        detalle = new List<DetalleFactura>();
                        datosTemporales = new FacturaTemporal();
                    }
                    catch
                    {
                        datosTemporales = new FacturaTemporal();
                    }
                }
                else
                {
                    alerta.Close();
                    e.Cancel = true;
                }
            }
        }
    }
}
