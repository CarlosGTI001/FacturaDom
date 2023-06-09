using FacturaDom.BDO.Modelos;
using FacturaDom.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaDom.BDO.Controladores
{
    public class facturaController
    {
        DBDataContext db = DBDataContext.Instance;

        public List<Factura> obtenerFacturas()
        {
            return db.Factura.ToList();
        }

        public Factura obtenerFactura(string Codigo)
        {
            return db.Factura.Find(Codigo);
        }

        public List<Factura> facturaPorCliente()
        {
            return new List<Factura>();
        }

        public List<Factura> facturaPorFecha()
        {
            return new List<Factura>();
        }

        public List<Factura> filtrarFactura()
        {
            return new List<Factura>();
        }

        public bool nuevaFactura(Factura factura)
        {
            try
            {
                db.Factura.Add(factura);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}