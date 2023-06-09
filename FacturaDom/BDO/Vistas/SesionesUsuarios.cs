using FacturaDom.BDO.Controladores;
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
    public partial class SesionesUsuarios : MetroForm
    {
        logonController logonController = new logonController();
        public SesionesUsuarios()
        {
            InitializeComponent();
        }

        private void SesionesUsuarios_Load(object sender, EventArgs e)
        {
            sesionesGrid.DataSource = logonController.obtenerSesiones();
            sesionesGrid.Refresh();
        }
    }
}
