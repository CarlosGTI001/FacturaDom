using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaDom.BDO.Modelos
{
    public class FacturaTemporal
    {
        public Factura factura { get; set; }
        public List<FacturaDetalle> facturaDetalles { get; set; } = new List<FacturaDetalle>();
        public List<articulosTemporales> articulosTemporales { get; set; } = new List<articulosTemporales>();
    }
}
