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
    public partial class frmMostrarVentas : Form
    {
        public frmMostrarVentas()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMenuPrincipal principal = new frmMenuPrincipal();
            principal.Show();
        }

        private void dtvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void frmMostrarVentas_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < frmCargarVentas.VCodVenta.Length; i++)
            {
                dtvVentas.Rows.Add(frmCargarVentas.VApellidosCliVentas[i]+ " "+ frmCargarVentas.VNombresCliVentas[i]  ,frmCargarVentas.VApellidosEmpVentas[i]+ " " + frmCargarVentas.VNombresEmpVentas[i] , 
                    frmCargarVentas.VCodVenta[i], frmCargarVentas.VMontos[i]);
            }
        }
    }
}
