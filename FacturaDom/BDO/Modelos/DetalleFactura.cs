using FacturaDom.BDO.Herencia;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaDom.BDO.Modelos
{
    public class DetalleFactura : Producto
    {
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public new decimal Precio { get; set; }

        public decimal Cantidad { get; set; }
        public string TipoMedida { get; set; }
        public decimal descuento { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Total { get; set; }
        public string CodigoFactura { get; set; }
        public string _Codigo { get; set; }
        public string? _Nombre { get; set; }
        public string? _Descripcion { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal _Precio { get; set; }
        public decimal _Stock { get; set; }
        public string _TipoMedida { get; set; }
    }
}
