using FacturaDom.BDO.Controladores;
using FontAwesome.Sharp;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacturaDom.BDO.Vistas
{
    public partial class HistorialInventario : MetroForm
    {
        public articulosController articulos;
        public HistorialInventario()
        {
            InitializeComponent();
        }

        private void HistorialInventario_Load(object sender, EventArgs e)
        {
            movimientoGrid.DataSource = articulos.obtenerHistorial();
        }
    }
}
