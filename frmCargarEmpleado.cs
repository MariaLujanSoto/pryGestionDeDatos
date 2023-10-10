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
    public partial class frmCargarEmpleado : Form
    {
        public frmCargarEmpleado()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMenuPrincipal principal = new frmMenuPrincipal();
            principal.Show();
        }

        private void frmCargarEmpleado_Load(object sender, EventArgs e)
        {

        }

        public static String[] VNombresEmp = new String[3];
        public static String[] VApellidosEmp = new String[3];
        public static Int32[] VDniEmp = new Int32[3];
        public static Int32[] VEdadEmp = new Int32[3];
        public static String[] VDomicilioEmp = new String[3];

        public static Int32 i = 0;
        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (i < VNombresEmp.Length)
            {
                VNombresEmp[i] = txtNombreEmp.Text;
                VApellidosEmp[i] = txtApellidoEmp.Text;
                VEdadEmp[i] = Convert.ToInt32(txtEdadEmp.Text);
                VDniEmp[i] = Convert.ToInt32(txtDniEmp.Text);
                VDomicilioEmp[i] = txtDomicilioEmp.Text;



                MessageBox.Show("DATO GUARDADO");
                txtNombreEmp.Clear();
                txtApellidoEmp.Clear();
                txtEdadEmp.Clear();
                txtDniEmp.Clear();
                txtDomicilioEmp.Clear();
                i++;
            }
            else
            {
                MessageBox.Show("NO ENTRAN MAS DATOS");
                txtNombreEmp.Clear();
                txtApellidoEmp.Clear();
                txtEdadEmp.Clear();
                txtDniEmp.Clear();
                txtDomicilioEmp.Clear();



            }
        }
    }
}
