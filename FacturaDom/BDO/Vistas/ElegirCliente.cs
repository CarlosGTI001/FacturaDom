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
    public partial class ElegirCliente : MetroForm
    {
        private Factura formularioPadre;
        clienteController clienteController = new clienteController();
        public ElegirCliente(Factura factura)
        {
            InitializeComponent();
            formularioPadre = factura;
            clienteGrid.DataSource = clienteController.obtenerClientes();
        }

        private void ElegirCliente_Load(object sender, EventArgs e)
        {
            elegir_Cliente.Hide();

        }

        private void elegir_Cliente_Click(object sender, EventArgs e)
        {
            formularioPadre.clienteCedula = Cedula;
            DialogResult = DialogResult.OK;
        }
        string Cedula;
        private void clienteGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            elegir_Cliente.Show();
            Cedula = clienteGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            busquedaText.Text = Cedula;
        }

        private void busquedaText_TextChanged(object sender, EventArgs e)
        {
            clienteGrid.DataSource = clienteController
                .obtenerClientes()
                .Where(a => a.Cedula.Contains(busquedaText.Text) || a.Nombre.Contains(busquedaText.Text) || a.Apellido.Contains(busquedaText.Text))
                .ToList();
        }
    }
}
