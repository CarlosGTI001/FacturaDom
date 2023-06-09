using FacturaDom.BDO.Herencia;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaDom.BDO.Modelos
{
    public class Usuario : Persona
    {
        [Key]
        public string UserCode { get; set; }
        public string UserName { get; set; }
        public string UserPass { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
