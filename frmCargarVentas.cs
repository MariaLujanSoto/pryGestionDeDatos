using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGestionDeDatos
{
    public partial class frmCargarVentas : Form
    {
        public frmCargarVentas()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        public static String[] VNombresCliVentas = new String[3];
        public static String[] VApellidosCliVentas = new String[3];
        public static String[] VNombresEmpVentas = new String[3];
        public static String[] VApellidosEmpVentas = new String[3];
        public static Int32[] VMontos = new Int32[3];
        public static String[] VCodVenta = new String[3];
        public static Int32 i = 0;
        Double montoAPagar = 0;

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Double manicura = 2000;
            Double pedicura = 2500;
            Double masajes = 3000;
            Double pestañas = 5000;
            Double mascarillas = 1500;
            Double depilacion = 3000;


            if (chkManicura.Checked)
            {
                montoAPagar += manicura;
            }
            if (chkPedicura.Checked)
            {
                montoAPagar += pedicura;
            }
            if (chkMasajes.Checked)
            {
                montoAPagar += masajes;
            }
            if (chkPestañas.Checked)
            {
                montoAPagar += pestañas;
            }
            if (chkMascarillas.Checked)
            {
                montoAPagar += mascarillas;
            }
            if (chkDepilacion.Checked)
            {
                montoAPagar += depilacion;
            }


            // COMBOS
            if (chkManicura.Checked && chkPedicura.Checked)
            {
                lblCombos.Text = ("Combo Pink Activado (10% desc)");
                montoAPagar -= montoAPagar * 0.10;

                if (chkPestañas.Checked && chkMascarillas.Checked)
                {
                    lblCombos.Text = ("Combo GOLD Activado (20% desc)");
                    montoAPagar -= montoAPagar * 0.20;
                }
            }
            else if (chkMasajes.Checked && chkMascarillas.Checked)
            {
                lblCombos.Text = ("Combo Relax Activado (15% desc)");
                montoAPagar -= montoAPagar * 0.15;
            }

            else
            {
                lblCombos.Text = ("No aplica ningun Combo");

            }


            //MEDIOS DE PAGO
            switch (true)
            {
                case var _ when optDebito.Checked:
                    montoAPagar += montoAPagar * 0.10;
                    lblPagos.Text = "Con este medio tiene un 10% de recargo";
                    break;

                case var _ when optCredito.Checked:
                    montoAPagar += montoAPagar * 0.20;
                    lblPagos.Text = "Con este medio tiene un 20% de recargo";
                    break;

                case var _ when optEfvo.Checked:
                    montoAPagar -= montoAPagar * 0.10;
                    lblPagos.Text = "Con este medio tiene un 10% de descuento";
                    break;

                case var _ when optTransf.Checked:
                    montoAPagar += montoAPagar * 0.10;
                    lblPagos.Text = "Con este medio tiene un 10% de recargo";
                    break;

                default:

                    lblPagos.Text = "Ningún método de pago seleccionado";
                    break;
            }

            lblMontoAbonar.Text = "$" + montoAPagar;
            btnCalcular.Enabled = false;
            btnLimpiar.Enabled = true;

            Int32 datoBuscadoCli = Convert.ToInt32(txtDniClienteB.Text);
            Int32 datoBuscadoEmp = Convert.ToInt32(txtDniEmpB.Text);

            bool datoEncontradoCli = false;
            bool datoEncontradoEmp = false;


            for (int i = 0; i < VMontos.Length; i++)
            {
                if (datoBuscadoCli == frmCargarCliente.VDni[i])
                {
                    lblApCliEnc.Text = frmCargarCliente.VApellidos[i];
                    lblNombCliEnc.Text = frmCargarCliente.VNombres[i];
                    datoEncontradoCli = true;


                }
                if (datoBuscadoEmp == frmCargarEmpleado.VDniEmp[i])
                {
                    lblApEmpEnc.Text = frmCargarEmpleado.VApellidosEmp[i];
                    lblNombEmpEnc.Text = frmCargarEmpleado.VNombresEmp[i];
                    datoEncontradoEmp = true;
                }

            }

            if (datoEncontradoEmp && datoEncontradoCli)
            {
                if ((chkManicura.Checked || chkDepilacion.Checked || chkMasajes.Checked || chkPestañas.Checked || chkPedicura.Checked || chkMascarillas.Checked) && (optCredito.Checked || optDebito.Checked || optEfvo.Checked || optTransf.Checked))
                {
                    btnFinalizar.Enabled = true;

                    lblHabilitado.Text = "Operacion Habilitada";
                }
                else
                {
                    MessageBox.Show("Debe seleccionar Servicio y Metodo de Pago");
                }

                
            }
            if (!datoEncontradoEmp || !datoEncontradoCli)
            {
                lblHabilitado.Text = "El empleado y cliente deben estar registrados previamente";

            }

        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMenuPrincipal principal = new frmMenuPrincipal();
            principal.Show();
        }

        private void bntFinalizar_Click(object sender, EventArgs e)
        {

            if (i < VCodVenta.Length)
            {
                
                VMontos[i] = Convert.ToInt32(montoAPagar);
                VCodVenta[i] = txtCodVenta.Text;
                VNombresCliVentas[i]= lblNombCliEnc.Text;
                VApellidosCliVentas[i]= lblApCliEnc.Text;
                VNombresEmpVentas[i] = lblNombEmpEnc.Text;
                VApellidosEmpVentas[i] = lblApEmpEnc.Text;

                lblNombEmpEnc.Text = "";
                lblApEmpEnc.Text = "";
                lblApCliEnc.Text = "";
                lblNombCliEnc.Text = "";
                txtDniClienteB.Clear();
                txtDniEmpB.Clear();
                montoAPagar = 0;
                lblMontoAbonar.Text = "";
                txtCodVenta.Clear();
                MessageBox.Show("DATOS CARGADOS");
                i++;
                chkDepilacion.Checked = false;
                chkManicura.Checked = false;
                chkMasajes.Checked = false;
                chkPedicura.Checked = false;
                chkPestañas.Checked = false;
                chkMascarillas.Checked = false;
                optCredito.Checked = false;
                optDebito.Checked = false;
                optEfvo.Checked = false;
                optTransf.Checked = false;
                btnFinalizar.Enabled = false;
            }
            else
            {
                txtDniClienteB.Clear();
                txtDniEmpB.Clear();

                txtCodVenta.Clear();

                lblMontoAbonar.Text = "";
                txtCodVenta.Clear();
                MessageBox.Show("NO ENTRAN MAS DATOS");

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            btnCalcular.Enabled = true;
            montoAPagar = 0;
            lblMontoAbonar.Text = "";
            txtDniClienteB.Clear();
            txtDniEmpB.Clear();
            lblNombEmpEnc.Text = "";
            lblApEmpEnc.Text = "";
            lblApCliEnc.Text = "";
            lblNombCliEnc.Text = "";         
            txtCodVenta.Clear();

            lblMontoAbonar.Text = "";
            txtCodVenta.Clear();
            chkDepilacion.Checked = false;
            chkManicura.Checked = false;
            chkMasajes.Checked = false;
            chkPedicura.Checked = false;
            chkPestañas.Checked = false;
            chkMascarillas.Checked = false;
            optCredito.Checked = false;
            optDebito.Checked = false;
            optEfvo.Checked = false;
            optTransf.Checked = false;

            btnLimpiar.Enabled = false;
            btnFinalizar.Enabled = false;

        }

        private void frmCargarVentas_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < VMontos.Length; i++)
            {
                VNombresEmpVentas[i] = frmCargarEmpleado.VNombresEmp[i];
                VApellidosEmpVentas[i] = frmCargarEmpleado.VApellidosEmp[i];
                VNombresCliVentas[i] = frmCargarCliente.VNombres[i];
                VApellidosCliVentas[i] = frmCargarCliente.VApellidos[i];
                

            }
        }
    }
}