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
using Microsoft.Reporting.WinForms;
using FacturaDom.BDO;
using FacturaDom.BDO.Controladores;
using FacturaDom.BDO.Modelos;

namespace FacturaDom.BDO.Vistas
{
    public partial class VisorDeReportes : MetroForm
    {
        articulosController art = new articulosController();
        public VisorDeReportes()
        {
            InitializeComponent();
        }

        private void VisorDeReportes_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "PP";
            rds.Value = art.obtenerArticulos();
            reporteVisor.LocalReport.ReportEmbeddedResource = "FacturaDom.Inventario.rdlc";
            reporteVisor.LocalReport.DataSources.Add(rds);
            reporteVisor.RefreshReport();
        }
    }
}
