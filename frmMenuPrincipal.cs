using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGestionDeDatos
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void registrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCargarCliente frmCargarCliente = new frmCargarCliente();
            frmCargarCliente.Show();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void buscarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBuscarCliente frmBuscarCliente = new frmBuscarCliente();
            frmBuscarCliente.Show();
        }

        private void mostrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMostrarCliente frmMostrarCliente = new frmMostrarCliente();
            frmMostrarCliente.Show();
        }

        private void registrarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCargarEmpleado frmCargarEmpleado = new frmCargarEmpleado();
            frmCargarEmpleado.Show();
        }

        private void buscarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBuscarEmpleado frmBuscarEmpleado = new frmBuscarEmpleado();
            frmBuscarEmpleado.Show();
        }

        private void mostrarPorveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMostrarEmpleado frmMostrarEmpleado = new frmMostrarEmpleado();
            frmMostrarEmpleado.Show();
        }

        private void ventasRegistradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCargarVentas frmCargarVentas = new frmCargarVentas();
            frmCargarVentas.Show();
        }

        private void mostarVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMostrarVentas frmMostrarVentas = new frmMostrarVentas();
            frmMostrarVentas.Show();
        }
    }
}
