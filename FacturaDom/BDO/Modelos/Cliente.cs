 using FacturaDom.BDO.Herencia;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaDom.BDO.Modelos
{
    public class Cliente : Persona
    {
        [Key]
        public string CodigoCliente { get; set; }
        public int ComprasCliente { get; set; }
        public string ClienteReferido { get; set; }
        [DataType(DataType.Currency)]
        public decimal ComprasTotales { get; set; }
    }
}
