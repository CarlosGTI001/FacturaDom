using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaDom.Data
{
    public class SesionesUsuario
    {
        [Key]
        public string SesionID { get; set; }
        public DateTime entrada { get; set; }
        public DateTime salida { get; set; }
        public string UserCode { get; set; }
        public string UserName { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }
}
