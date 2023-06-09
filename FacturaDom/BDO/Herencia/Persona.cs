using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaDom.BDO.Herencia
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string? NumeroTelefono { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string? Direccion { get; set; }
        public bool Habilitado { get; set; } = true;
    }
}
