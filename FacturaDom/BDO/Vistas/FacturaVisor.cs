using FacturaDom.BDO.Modelos;
using MetroFramework.Forms;
using Microsoft.Reporting.WinForms;
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
    public partial class FacturaVisor : MetroForm
    {
        public List<FacturaDetalle> FacturaDetalle;
        public FacturaVisor(List<FacturaDetalle> _FacturaDetalle)
        {
            FacturaDetalle = _FacturaDetalle;
            InitializeComponent();
        }

        private void FacturaVisor_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "Factura2";
            rds.Value = FacturaDetalle;
            this.Text = "Reporte - Factura";
            reporteVisor.LocalReport.ReportEmbeddedResource = "FacturaDom.Facturar.rdlc";
            reporteVisor.LocalReport.DataSources.Add(rds);
            reporteVisor.RefreshReport();
        }
    }
}
