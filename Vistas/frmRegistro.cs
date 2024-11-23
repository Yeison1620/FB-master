using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FB.Controladores;
using FB.Vistas;
using System.IO;
using Newtonsoft.Json;
using FB.secret;

namespace FB
{
    public partial class frmRegistro : Form
    {
        string directorioPaises;
        string archivoPaises;
        DataSet paises;
        DataTable dtPaises;
        string paisSelecionado;

        string directorioEstados;
        string archivoEstados;
        DataSet estados;
        DataTable dtEstados;
        string estadoSeleccionado;

        string directorioCiudades;
        string archivoCiudades;
        DataSet ciudades;
        DataTable dtCiudades;
        string ciudadSeleccionada;
        public frmRegistro()
        {
            InitializeComponent();

        }

        private void frmRegistrocs_Load(object sender, EventArgs e)
        {
            cmbPais.Text = "Colombia";
            //Paises
            directorioPaises = (Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\Importados\countries.json")));
            archivoPaises = File.ReadAllText(directorioPaises);
            paises = JsonConvert.DeserializeObject<DataSet>(archivoPaises);
            dtPaises = paises.Tables["countries"];

            cmbPais.DataSource = dtPaises;
            cmbPais.ValueMember = dtPaises.Columns[1].ToString();
            cmbPais.DisplayMember = dtPaises.Columns[1].ToString();

            //Estados
            directorioEstados = (Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\Importados\states.json")));
            archivoEstados = File.ReadAllText(directorioEstados);
            estados = JsonConvert.DeserializeObject<DataSet>(archivoEstados);
            dtEstados = estados.Tables["states"];

            //Ciudades
            directorioCiudades = (Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\Importados\cities.json")));
            archivoCiudades = File.ReadAllText(directorioCiudades);
            ciudades = JsonConvert.DeserializeObject<DataSet>(archivoCiudades);
            dtCiudades = ciudades.Tables["cities"];

            rdoHombre.Checked = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            string sexo;
            if (rdoHombre.Checked)
            {
                sexo = rdoHombre.Text;
            }
            else
            {
                sexo = rdoMujer.Text;
            }




        }
    


        private void rdoHombre_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string sexo = "";
            if (rdoHombre.Checked)
            {
                sexo = "Masculino";
            }
            else if (rdoMujer.Checked)
            {
                sexo = "Femenino";
            }

            try
            {
                if(txtConfirmarPassword.Text == txtPassword.Text)
                {
                    string password = Encrypt.encryptPassowrd(txtPassword.Text);
                    clsControladorUsuarios controladorUsuarios = new clsControladorUsuarios(txtDocumentoIdentidad.Text, txtPrimerNombre.Text, txtSegundoNombre.Text, txtPrimerApellido.Text, txtSegundoApellido.Text, dtpFechaNacimiento.Value, sexo, cmbPais.Text, cmbEstado.Text, cmbCiudad.Text, txtEmail.Text, password, txtCelular.Text);
                    if (controladorUsuarios.ejecutarRegistrarUsuario())
                    {
                        
                        frmPrincipal principal = new frmPrincipal();
                        principal.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Las contraseñas NO coinciden. Revísalas");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void cmbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtEstados != null)
                {
                    foreach (DataRow pais in dtPaises.Rows)
                    {
                        if (cmbPais.Text == pais["name"].ToString())
                        {
                            paisSelecionado = pais["id"].ToString();
                            break;
                        }
                    }


                    DataTable dtEstadosPais = new DataTable();
                    DataColumn dc = new DataColumn("id_country", typeof(String));
                    dtEstadosPais.Columns.Add(dc);
                    dc = new DataColumn("name", typeof(String));
                    dtEstadosPais.Columns.Add(dc);
                    dc = new DataColumn("id", typeof(String));
                    dtEstadosPais.Columns.Add(dc);

                    foreach (DataRow row in dtEstados.Rows)
                    {
                        if (row["id_country"].ToString() == paisSelecionado)
                        {
                            DataRow estado = dtEstadosPais.NewRow();
                            estado["id_country"] = row["id_country"].ToString();
                            estado["name"] = row["name"].ToString();
                            estado["id"] = row["id"].ToString();

                            dtEstadosPais.Rows.Add(estado);
                        }
                      
                    }

                    cmbEstado.DataSource = dtEstadosPais;
                    cmbEstado.ValueMember = dtEstadosPais.Columns[2].ToString();
                    cmbEstado.DisplayMember = dtEstadosPais.Columns[1].ToString();
                    

                    if(estadoSeleccionado != null)
                    {
                        cmbEstado.SelectedValue = estadoSeleccionado;
                    }
                }

            }
            catch (Exception err)
            {
                MessageBox.Show( err.Message);
            }
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtCiudades != null)
                {
                    foreach (DataRow estado in dtEstados.Rows)
                    {
                        if (cmbEstado.Text == estado["name"].ToString())
                        {
                            estadoSeleccionado = estado["id"].ToString();
                            break;
                        }
                    }
                    DataTable dtCiudadEstado = new DataTable();
                    DataColumn dcCiudad = new DataColumn("idC", typeof(String));
                    dtCiudadEstado.Columns.Add(dcCiudad);
                    dcCiudad = new DataColumn("id_state", typeof(String));
                    dtCiudadEstado.Columns.Add(dcCiudad);
                    dcCiudad = new DataColumn("nameC", typeof(String));
                    dtCiudadEstado.Columns.Add(dcCiudad);
                    foreach (DataRow row in dtCiudades.Rows)
                    {
                        if (row["id_state"].ToString() == estadoSeleccionado)
                        {
                            DataRow ciudad = dtCiudadEstado.NewRow();
                            ciudad["id_state"] = row["id_state"].ToString();
                            ciudad["nameC"] = row["name"].ToString();
                            ciudad["idC"] = row["id"].ToString();

                            dtCiudadEstado.Rows.Add(ciudad);
                        }
                        
                    }

                    cmbCiudad.DataSource = dtCiudadEstado;
                    cmbCiudad.ValueMember = dtCiudadEstado.Columns[0].ToString();
                    cmbCiudad.DisplayMember = dtCiudadEstado.Columns[2].ToString();
                    if(ciudadSeleccionada != null)
                    {
                        cmbCiudad.SelectedValue = ciudadSeleccionada;
                    }
                    
                }
            }
            catch (Exception err)
            {
               
                MessageBox.Show(err.ToString());
            }
        }
    }
}
