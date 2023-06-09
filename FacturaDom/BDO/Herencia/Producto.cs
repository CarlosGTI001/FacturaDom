using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaDom.BDO.Herencia
{
    public class Producto
    {
        [Key]
        public string Codigo { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }

        [DataType(DataType.Currency)]
        public double Precio { get; set; }
    }
}
