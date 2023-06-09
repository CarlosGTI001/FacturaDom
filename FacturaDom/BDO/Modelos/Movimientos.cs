using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaDom.BDO.Modelos
{
    public class Movimientos
    {
        [Key]
        public string MovimientoId { get; set; }
        public Articulo Articulo { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime FechaMovimiento { get; set; }
        public decimal Cantidad { get; set; }
        public string Tipo { get; set; }
    }
}
