using FacturaDom.BDO.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaDom.Data
{
    public class MovimientoInventario
    {
        [Key]
        public string MovimientoId { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string UserCode { get; set; }
        public string UserName { get; set; }
        public DateTime FechaMovimiento { get; set; }
        public decimal Cantidad { get; set; }
        public string Tipo { get; set; }
    }
}
