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
    public partial class frmMostrarCliente : Form
    {
        public frmMostrarCliente()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMenuPrincipal principal = new frmMenuPrincipal();
            principal.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        public void frmMostrarClliente_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < frmCargarCliente.VDni.Length; i++)
            {
                dtvClientes.Rows.Add(frmCargarCliente.VDni[i] , frmCargarCliente.VApellidos[i], frmCargarCliente.VNombres[i] , frmCargarCliente.VProvincias[i], frmCargarCliente.VDepartamentos[i], frmCargarCliente.VDomicilio[i]);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
