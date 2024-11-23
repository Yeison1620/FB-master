using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FB.Modelo;
using FB.Controladores;
using FB.Vistas;
using System.IO;
using Newtonsoft.Json;


namespace FB.Vistas
{
    public partial class frmCambiarUbicacion : Form
    {
        private bool nuevo;

        public bool Nuevo { get => nuevo; set => nuevo = value; }

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


        public frmCambiarUbicacion(bool nuevo)
        {
            InitializeComponent();
            Nuevo = nuevo;


        }

        void actualizarComboboxEstados()
        {
            bool isNumeric = int.TryParse(paisSelecionado, out _);
            if (isNumeric)
            {



                for (int i = 0; i < dtEstados.Rows.Count; i++)
                {
                    if (dtEstados.Rows[i]["id_country"].ToString() == paisSelecionado)
                    {
                        MessageBox.Show(dtEstados.Rows[i]["name"].ToString());
                    }
                }

                DataView dvEstados = new DataView(dtEstados);
                //dvEstados.RowFilter = "id_country=" +paisSelecionado+ "";


                cmbEstado.DataSource = dvEstados;
                cmbEstado.ValueMember = dvEstados.Table.Columns[0].ToString();
                cmbEstado.DisplayMember = dvEstados.Table.Columns[2].ToString();

            }
        }

        private void frmCambiarUbicacion_Load(object sender, EventArgs e)
        {

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

            if (Nuevo)
            {
                lblRecogida.Visible = false;
                txtRecogida.Enabled = false;
                txtRecogida.Visible = false;
                lblDestino.Visible = false;
                txtDestino.Enabled = false;
                txtDestino.Visible = false;
                btnCambiarUbicacion.Enabled = false;
                btnCambiarUbicacion.Visible = false;

                lblTitulo.Text = "Escoge tu ubicación actual, por favor";
            }
            else if (!Nuevo && !clsSesion.OfreciendoServicio)
            {
                lblRecogida.Visible = true;
                txtRecogida.Enabled = true;
                txtRecogida.Visible = true;
                lblDestino.Visible = true;
                txtDestino.Enabled = true;
                txtDestino.Visible = true;
                btnCambiarUbicacion.Enabled = true;
                btnCambiarUbicacion.Visible = true;
                lblTitulo.Text = "¿Esta sigue siendo tu ubicación actual? \r\n Si es así, pulse en 'PEDIR TRANSPORTE' ";
                lblUbicacion.Text = $"Última ubicación:\r\nPaís:{clsSesion.Pais}. Estado:{clsSesion.Estado}. Ciudad: {clsSesion.Ciudad}";

                cmbCiudad.Enabled = false;
                cmbEstado.Enabled = false;
                cmbPais.Enabled = false;
                cmbPais.Text = clsSesion.Pais;
                cmbCiudad.Text = clsSesion.Ciudad;
                cmbEstado.Text = clsSesion.Estado;
            }
            else if (!Nuevo && clsSesion.OfreciendoServicio)
            {
                lblTitulo.Text = "¿Esta sigue siendo tu ubicación actual? \r\n Si es así, pulse en 'Ponerse en Servicio'";
                btnConfirmar.Text = "Ponerse en Servicio";
                lblUbicacion.Text = $"Última ubicación:\r\nPaís: {clsSesion.Pais}. Estado: {clsSesion.Estado}. Ciudad: {clsSesion.Ciudad}";
                lblRecogida.Visible = false;
                txtRecogida.Enabled = false;
                txtRecogida.Visible = false;
                lblDestino.Visible = false;
                txtDestino.Enabled = false;
                txtDestino.Visible = false;
                btnCambiarUbicacion.Enabled = true;
                btnCambiarUbicacion.Visible = true;
                cmbCiudad.Enabled = false;
                cmbEstado.Enabled = false;
                cmbPais.Enabled = false;
                cmbPais.Text = clsSesion.Pais;
                cmbCiudad.Text = clsSesion.Ciudad;
                cmbEstado.Text = clsSesion.Estado;
            }
            foreach (DataRow row in dtPaises.Rows)
            {
                if (row["name"].ToString() == clsSesion.Pais)
                {
                    paisSelecionado = row["id"].ToString();
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
                if(row["name"].ToString() == clsSesion.Estado)
                {
                    estadoSeleccionado = row["id"].ToString();
                }
            }

            

            cmbEstado.DataSource = dtEstadosPais;
            cmbEstado.ValueMember = dtEstadosPais.Columns[2].ToString();
            cmbEstado.DisplayMember = dtEstadosPais.Columns[1].ToString();
            cmbEstado.SelectedValue = estadoSeleccionado;

            //Preparar Combobox Ciudad
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
                if (row["name"].ToString() == clsSesion.Ciudad)
                {
                    ciudadSeleccionada = row["id"].ToString();
                }
            }

            cmbCiudad.DataSource = dtCiudadEstado;
            cmbCiudad.ValueMember = dtCiudadEstado.Columns[0].ToString();
            cmbCiudad.DisplayMember = dtCiudadEstado.Columns[2].ToString();
            if (ciudadSeleccionada != null && int.TryParse(paisSelecionado, out _))
            {
                cmbCiudad.SelectedValue = ciudadSeleccionada;

            }
        }
    

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            //Si es alguien que quiere pedir un servicio:
            if (!Nuevo && clsSesion.OfreciendoServicio == false)
            {
                if (btnConfirmar.Text == "Pedir Transporte")
                {
                    if(txtDestino.Text.Length < 6)
                    {
                        MessageBox.Show("La dirección de destino no puede ser menor a 6 caracteres");
                    }
                    if(txtRecogida.Text.Length < 6)
                    {
                        MessageBox.Show("La dirección de recogida no puede ser menor a 6 caracteres");
                    }
                    if(txtDestino.Text.Length >= 6 && txtDestino.Text.Length >= 6)
                    {
                        frmConductoresDisponibles formConductores = new frmConductoresDisponibles(txtRecogida.Text, txtDestino.Text);
                        this.Hide();
                        formConductores.ShowDialog();
                        this.Show();
                    }
                   
                }
                else if (btnConfirmar.Text == "Guardar cambios de ubicación")
                {
                    clsControladorUsuarios usuario = new clsControladorUsuarios(cmbPais.Text, cmbEstado.Text, cmbCiudad.Text);
                    usuario.ejecutarCambiarUbicacion();
                    cmbCiudad.Text = clsSesion.Ciudad;
                    cmbEstado.Text = clsSesion.Estado;
                    cmbPais.Text = clsSesion.Pais;
                    cmbCiudad.Enabled = false;
                    cmbEstado.Enabled = false;
                    cmbPais.Enabled = false;
                    lblUbicacion.Text = $"Última ubicación:\r\nPaís:{clsSesion.Pais}. Estado:{clsSesion.Estado}. Ciudad: {clsSesion.Ciudad}";

                    if (!clsSesion.OfreciendoServicio)
                    {
                        btnConfirmar.Text = "Pedir Transporte";
                    }
                    else
                    {
                        btnConfirmar.Text = "Ponerse en Servicio";
                    }

                    btnCambiarUbicacion.Text = "Cambiar ubicación";
                }

            }
            //Si se está por ofrecer servicio
            else if (clsSesion.OfreciendoServicio)
            {
                if (btnConfirmar.Text == "Ponerse en Servicio")
                {
                    clsControladorConductores conductor = new clsControladorConductores();
                    
                    if (conductor.ejecutarPrestarServicio())
                    {
                        frmSolicitantes solicitantesForm = new frmSolicitantes();
                        this.Hide();
                        solicitantesForm.ShowDialog();
                        this.Show();

                    }

                }
                else if (btnConfirmar.Text == "Guardar cambios de ubicación")
                {
                    clsControladorUsuarios usuario = new clsControladorUsuarios(cmbPais.Text, cmbEstado.Text, cmbCiudad.Text);
                    usuario.ejecutarCambiarUbicacion();
                    
                    cmbCiudad.Text = clsSesion.Ciudad;
                    cmbEstado.Text = clsSesion.Estado;
                    cmbPais.Text = clsSesion.Pais;
                    cmbCiudad.Enabled = false;
                    cmbEstado.Enabled = false;
                    cmbPais.Enabled = false;

                    btnConfirmar.Text = "Ponerse en Servicio";
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbPais_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCambiarUbicacion_Click(object sender, EventArgs e)
        {
            if(btnCambiarUbicacion.Text == "Descartar Cambios")
            {
                cmbEstado.Text = clsSesion.Estado;
                cmbCiudad.Text = clsSesion.Ciudad;
                cmbPais.Text = clsSesion.Pais;
                cmbPais.Enabled = false;
                cmbEstado.Enabled = false;
                cmbCiudad.Enabled = false;
                if (!clsSesion.OfreciendoServicio)
                {
                    btnConfirmar.Text = "Pedir Transporte";
                }
                else
                {
                    btnConfirmar.Text = "Ponerse en Servicio";
                }
                btnCambiarUbicacion.Text = "Cambiar ubicación";

            }
            else if(btnCambiarUbicacion.Text == "Cambiar ubicación")
            {
                cmbPais.Enabled = true;
                cmbEstado.Enabled = true;
                cmbCiudad.Enabled = true;
                btnConfirmar.Text = "Guardar cambios de ubicación";
                btnCambiarUbicacion.Text = "Descartar Cambios";
            }
           

        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(dtCiudades != null)
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
                        if (row["name"].ToString() == clsSesion.Ciudad)
                        {
                            ciudadSeleccionada = row["id"].ToString();
                        }
                    }

                    cmbCiudad.DataSource = dtCiudadEstado;
                    cmbCiudad.ValueMember = dtCiudadEstado.Columns[0].ToString();
                    cmbCiudad.DisplayMember = dtCiudadEstado.Columns[2].ToString();
                    cmbCiudad.SelectedValue = ciudadSeleccionada;
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
                
                if(dtEstados != null)
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
                        if (row["name"].ToString() == clsSesion.Estado)
                        {
                            estadoSeleccionado = row["id"].ToString();
                        }
                    }



                    cmbEstado.DataSource = dtEstadosPais;
                    cmbEstado.ValueMember = dtEstadosPais.Columns[2].ToString();
                    cmbEstado.DisplayMember = dtEstadosPais.Columns[1].ToString();
                    cmbEstado.SelectedValue = estadoSeleccionado;

                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }



        }

        private void cmbPais_SelectedValueChanged(object sender, EventArgs e)
        {
            //Estados
            //System.Threading.Thread.Sleep(1500);


           


        }
    }
}
