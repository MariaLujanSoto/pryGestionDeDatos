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
    public partial class frmMostrarEmpleado : Form
    {
        public frmMostrarEmpleado()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMenuPrincipal principal = new frmMenuPrincipal();
            principal.Show();
        }
        private void frmMostrarEmpleado_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < frmCargarEmpleado.VDniEmp.Length; i++)
            {
                dtvEmpleados.Rows.Add(frmCargarEmpleado.VDniEmp[i], frmCargarEmpleado.VApellidosEmp[i], frmCargarEmpleado.VNombresEmp[i], frmCargarEmpleado.VEdadEmp[i], frmCargarEmpleado.VDomicilioEmp[i]);
            }
        }

        private void dtvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
