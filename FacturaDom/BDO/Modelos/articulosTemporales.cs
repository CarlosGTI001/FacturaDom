using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaDom.BDO.Modelos
{
    public class articulosTemporales
    {
        public string Codigo { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Precio { get; set; }
        public decimal Stock { get; set; }
        public string TipoMedida { get; set; }

        
    }
}
