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
    public partial class frmBuscarEmpleado : Form
    {
        public frmBuscarEmpleado()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMenuPrincipal principal = new frmMenuPrincipal();
            principal.Show();
        }

        private void frmBuscarEmpleado_Load(object sender, EventArgs e)
        {

        }
        public static Int32 i = 0;

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Int32 datoBuscado = Convert.ToInt32(txtDniBuscadoEmp.Text);
            bool datoEncontrado = false; 

            for (int i = 0; i < frmCargarEmpleado.VDniEmp.Length; i++)
            {
                if (datoBuscado == frmCargarEmpleado.VDniEmp[i])
                {
                    lblApellidoEmp.Text = frmCargarEmpleado.VApellidosEmp[i];
                    lblNombreEmp.Text = frmCargarEmpleado.VNombresEmp[i];
                    lblEdadEmp.Text = Convert.ToString(frmCargarEmpleado.VEdadEmp[i]);
                    lblDomicilioEmp.Text = frmCargarEmpleado.VDomicilioEmp[i];
                    datoEncontrado = true; 
                    break; 
                }
            }

            if (!datoEncontrado)
            {
                MessageBox.Show("El DNI ingresado no coincide con los Clientes Registrados");
                lblNombreEmp.Text = "";
                lblApellidoEmp.Text = "";
                lblEdadEmp.Text = "";
                lblDomicilioEmp.Text = "";
            }
        }

        private void lblEdadEmp_Click(object sender, EventArgs e)
        {

        }
    }
}
