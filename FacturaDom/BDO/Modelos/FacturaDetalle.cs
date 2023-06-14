using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaDom.BDO.Modelos
{
    public class FacturaDetalle
    {
        [Key]
        public int code { get; set; }
        public string CodigoFactura { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }

        [Display(Name = "Codigo Cliente")]
        public string CodigoCliente { get; set; }

        [Display(Name = "Codigo Vendedor")]
        public string UserCode { get; set; }

        [Display(Name = "Vendedor")]
        public string UserName { get; set; }
        public decimal TotalFactura { get; set; }
        public DateTime FechaFactura { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Precio { get; set; }
        public decimal Cantidad { get; set; }
        public string TipoMedida { get; set; }
        public decimal descuento { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Total { get; set; }
        public string NombreCliente { get; set; }
        public string ApellidoCliente { get; set; }
        public string CedulaCliente { get; set; }
        public string CodigoProducto { get; set; }
    }
}
