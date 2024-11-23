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
using FB.Modelo;

namespace FB
{
    public partial class frmRegistroMoto : Form
    {
        //Variables del formulario
        private bool propia;
        private string documentoPropietario;
        private string primerNombrePropietario;
        private string segundoNombrePropietario;
        private string primerApellidoPropietario;
        private string segundoApellidoPropietario;
        private string celularPropietario;

        //Constructor del formulario
        public frmRegistroMoto()
        {
            InitializeComponent();
            cmbColor.Items.Add("Rojo");
            cmbColor.Items.Add("Azul");
            cmbColor.Items.Add("Violeta");
            cmbColor.Items.Add("Verde");
            cmbColor.Items.Add("Amarillo");
            cmbColor.Items.Add("Marron");
            cmbColor.Items.Add("Turquesa");
            cmbColor.Items.Add("Celeste");
            cmbColor.Items.Add("Naranja");
            cmbColor.Items.Add("Blanco");
            cmbColor.Items.Add("Negro");
            cmbColor.Items.Add("Beige");
            cmbColor.Items.Add("Gris");
            cmbColor.Items.Add("Rosa");
            cmbColor.Items.Add("Cian");
            cmbColor.Items.Add("Magenta");
        }
        //Al presionar el botón "Siguiente"
        private void btnSiguiente_Click(object sender, EventArgs e)
        {

            if (rdoSi.Checked)
            {
                propia = true;
                documentoPropietario = clsSesion.DocumentoSesion;
                primerNombrePropietario = clsSesion.PrimerNombre;
                segundoNombrePropietario = clsSesion.SegundoNombre;
                primerApellidoPropietario = clsSesion.PrimerApellido;
                segundoApellidoPropietario = clsSesion.SegundoApellido;
                celularPropietario = clsSesion.Celular;

            }
            else if (rdoNo.Checked)
            {
                propia = false;
                documentoPropietario = txtNumDocumento.Text;
                primerNombrePropietario = txtPrimerNombre.Text;
                segundoNombrePropietario = txtSegundoNombre.Text;
                primerApellidoPropietario = txtPrimerApellido.Text;
                segundoApellidoPropietario = txtSegundoApellido.Text;
                celularPropietario = txtCelular.Text;
            }

            try
            {
                clsControladorConductores conductor = new clsControladorConductores(txtPlaca.Text, clsSesion.DocumentoSesion, dtpInicioLicencia.Value, dtpFinLicencia.Value, txtMatricula.Text, propia, dtpInicioSOAT.Value, dtpFinSOAT.Value, dtpInicioTecno.Value, dtpFinTecno.Value, txtMarca.Text, txtModelo.Text, txtLinea.Text, cmbColor.Text, Convert.ToInt32(txtCilindraje.Text), txtNumChasis.Text, txtNumMotor.Text, documentoPropietario, primerNombrePropietario, segundoNombrePropietario, primerApellidoPropietario, segundoApellidoPropietario, celularPropietario);
                if (conductor.ejecutarRegistrarComoConductor())
                {
                    this.Close();
                }     
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void frmRegistroMoto_Load(object sender, EventArgs e)
        {
            rdoNo.Checked = true;
        }

        //Cuando se cambia de estado el radiobuttton
        private void rdoSi_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSi.Checked)
            {
                lblCelular.Enabled = false;
                lblCelular.Visible = false;
                lblDocumento.Enabled = false;
                lblDocumento.Visible = false;
                lblPrimerApellido.Enabled = false;
                lblPrimerApellido.Visible = false;
                lblPrimerNombre.Enabled = false;
                lblPrimerNombre.Visible = false;
                lblSegundoApellido.Enabled = false;
                lblSegundoApellido.Visible = false;
                lblSegundoNombre.Enabled = false;
                lblSegundoNombre.Visible = false;

                txtCelular.Enabled = false;
                txtCelular.Visible = false;
                txtNumDocumento.Enabled = false;
                txtNumDocumento.Visible = false;
                txtPrimerApellido.Enabled = false;
                txtPrimerApellido.Visible = false;
                txtPrimerNombre.Enabled = false;
                txtPrimerNombre.Visible = false;
                txtSegundoApellido.Enabled = false;
                txtSegundoApellido.Visible = false;
                txtSegundoNombre.Enabled = false;
                txtSegundoNombre.Visible = false;
            }
            else
            {
                lblCelular.Enabled = true;
                lblCelular.Visible = true;
                lblDocumento.Enabled = true;
                lblDocumento.Visible = true;
                lblPrimerApellido.Enabled = true;
                lblPrimerApellido.Visible = true;
                lblPrimerNombre.Enabled = true;
                lblPrimerNombre.Visible = true;
                lblSegundoApellido.Enabled = true;
                lblSegundoApellido.Visible = true;
                lblSegundoNombre.Enabled = true;
                lblSegundoNombre.Visible = true;

                txtCelular.Enabled = true;
                txtCelular.Visible = true;
                txtNumDocumento.Enabled = true;
                txtNumDocumento.Visible = true;
                txtPrimerApellido.Enabled = true;
                txtPrimerApellido.Visible = true;
                txtPrimerNombre.Enabled = true;
                txtPrimerNombre.Visible = true;
                txtSegundoApellido.Enabled = true;
                txtSegundoApellido.Visible = true;
                txtSegundoNombre.Enabled = true;
                txtSegundoNombre.Visible = true;

                
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
