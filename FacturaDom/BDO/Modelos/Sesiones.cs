using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaDom.BDO.Modelos
{
    public class Sesiones
    {
        [Key]
        public string SesionId { get; set; }
        public Usuario usuario { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime entrada { get; set; }
        public DateTime salida { get; set; }
    }
}
