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
    public partial class frmBuscarCliente : Form
    {
        public frmBuscarCliente()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMenuPrincipal principal = new frmMenuPrincipal();
            principal.Show();
        }
        

        private void frmBuscarCliente_Load(object sender, EventArgs e)
        {
           
        }

        private void lblApellido_Click(object sender, EventArgs e)
        {

        }

        private void lblPais_Click(object sender, EventArgs e)
        {

        }

        private void lblProvincia_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
        public static Int32 i = 0;

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Int32 datoBuscado = Convert.ToInt32(txtDniBuscado.Text);
            bool datoEncontrado = false;

            for (int i = 0; i < frmCargarCliente.VDni.Length; i++)
            {
                if (datoBuscado == frmCargarCliente.VDni[i])
                {
                    lblApellido.Text = frmCargarCliente.VApellidos[i];
                    lblNombre.Text = frmCargarCliente.VNombres[i];
                    lblEdad.Text = Convert.ToString(frmCargarCliente.VEdad[i]);
                    lblDomicilio.Text = frmCargarCliente.VDomicilio[i];
                    lblProvincia.Text = Convert.ToString(frmCargarCliente.VProvincias[i]);
                    lblDepartamento.Text = frmCargarCliente.VDepartamentos[i];
                    datoEncontrado = true;
                    break;
                }
                
            }

            if (!datoEncontrado)
            {
                MessageBox.Show("El DNI ingresado no coincide con los Clientes Registrados");
                lblNombre.Text = "";
                lblApellido.Text = "";
                lblEdad.Text = "";
                lblDomicilio.Text = "";
                lblProvincia.Text = "";
                lblDepartamento.Text = "";




            }
        }
        private void lblDomicilio_Click(object sender, EventArgs e)
        {

        }

        private void lblEdad_Click(object sender, EventArgs e)
        {

        }

        private void txtDniIngresado_Click(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void Domicilio_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
