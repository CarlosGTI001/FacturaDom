using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacturaDom.BDO.Herencia;

namespace FacturaDom.BDO.Modelos
{
    public class Factura
    {
        [Key]
        public string CodigoFactura { get; set; }
        
        [Display(Name = "Codigo Cliente")]
        public string CodigoCliente { get; set; }

        [Display(Name = "Codigo Vendedor")]
        public string UserCode { get; set; }

        [Display(Name = "Vendedor")]
        public string  UserName { get; set; }
        public decimal TotalFactura { get; set; }
        public DateTime FechaFactura { get; set; }
    }
}
