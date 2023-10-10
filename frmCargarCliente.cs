using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Newtonsoft.Json;

namespace pryGestionDeDatos
{
    public partial class frmCargarCliente : Form
    {
        public frmCargarCliente()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMenuPrincipal principal = new frmMenuPrincipal();    
            principal.Show();
        }

        public static String[] VNombres = new String[3];
        public static String[] VApellidos = new String[3];
        public static Int32[] VEdad = new Int32[3];
        public static Int32[] VDni = new Int32[3];
        public static String[] VProvincias = new String[3];
        public static String[] VDepartamentos = new String[3];
        public static String[] VDomicilio = new String[3];

        public static Int32 i = 0;

        //USO DE APIS PARA PPROVINCIAS Y LOCALIDADES

        public async Task CargarNombresProvincias()
        {
            HttpClient client = new HttpClient();

            try
            {
                HttpResponseMessage response = await client.GetAsync("https://infra.datos.gob.ar/catalog/modernizacion/dataset/7/distribution/7.2/download/provincias.json");

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();

                    dynamic data = Newtonsoft.Json.JsonConvert.DeserializeObject(json);

                    dynamic provincias = data.provincias;

                    cmbProvincias.Items.Clear(); 

                    foreach (var provincia in provincias)
                    {
                        string nombre = provincia.nombre;
                        cmbProvincias.Items.Add(nombre);
                        
                    }
                }
                else
                {
                    MessageBox.Show("La solicitud a la API Provincias ha fallado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error: " + ex.Message);
            }
            finally
            {
                client.Dispose();
            }
        }


        public async Task CargarDepartamentos()
        {
            if (cmbProvincias.Items.Count > 0 && cmbProvincias.SelectedIndex != -1)
            {
                string provinciaSeleccionada = cmbProvincias.SelectedItem.ToString();

                HttpClient client = new HttpClient();

                try
                {
                    HttpResponseMessage response = await client.GetAsync("https://infra.datos.gob.ar/catalog/modernizacion/dataset/7/distribution/7.3/download/departamentos.json");

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();

                        dynamic data = JsonConvert.DeserializeObject(json);

                        dynamic departamentos = data.departamentos;

                        cmbDepartamentos.Items.Clear();

                        foreach (var departamento in departamentos)
                        {
                            string nombre = departamento.nombre;
                            string provincia = departamento.provincia.nombre;

                            if (provincia.Equals(provinciaSeleccionada, StringComparison.OrdinalIgnoreCase))
                            {
                                cmbDepartamentos.Items.Add(nombre);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("La solicitud a la API Departamentos ha fallado.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se ha producido un error: " + ex.Message);
                }
                finally
                {
                    client.Dispose();
                }
            }
        }


        public async void frmCargarCliente_Load(object sender, EventArgs e)
        {
            await CargarNombresProvincias();

        }

        
        public void btnCargar_Click(object sender, EventArgs e)
        {
            if (i < VNombres.Length)
            {
                VNombres[i] = txtNombreCli.Text;
                VApellidos[i] = txtApellidoCli.Text;
                VEdad[i] = Convert.ToInt32(txtEdadCli.Text);
                VDni[i] = Convert.ToInt32(txtDniCli.Text);
                VProvincias[i] = Convert.ToString(cmbProvincias.SelectedItem);
                VDepartamentos[i]= Convert.ToString(cmbDepartamentos.SelectedItem);
                VDomicilio[i] = txtDomicilioCli.Text;



                MessageBox.Show("DATO GUARDADO");
                txtNombreCli.Clear();
                txtApellidoCli.Clear();
                txtEdadCli.Clear();
                txtDniCli.Clear();
                txtDomicilioCli.Clear();
                cmbProvincias.Text = "";
                cmbDepartamentos.Text = "";
                i++;
            }
            else
            {
                MessageBox.Show("NO ENTRAN MAS DATOS");
                txtNombreCli.Clear();
                txtApellidoCli.Clear();
                txtEdadCli.Clear();
                txtDniCli.Clear();
                txtDomicilioCli.Clear();
                cmbProvincias.Text = "";
                cmbDepartamentos.Text = "";



            }

            CargarNombresProvincias();
            CargarDepartamentos();

        }

        public void btnVolver_Click_1(object sender, EventArgs e)
        {
            this.Close();
            frmMenuPrincipal principal = new frmMenuPrincipal();
            principal.Show();
        }

        public async void cmbProvincias_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                await CargarDepartamentos();

            }
        }

        private void cmbDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
