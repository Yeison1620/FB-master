using FB.Controladores;
using FB.Modelo;
using System;
using System.Data;
using System.Windows.Forms;

namespace FB.Vistas
{
    public partial class frmPrincipal : Form
    {
        DataTable dtMetodosPago;
        DataTable dtHistorialViajes;
        private clsControladorMetodoPago metodoPago;
        private clsControladorViaje viaje;
        public frmPrincipal()
        {
            InitializeComponent();
        }
        void obtenerHistorialViajes()
        {
            viaje = new clsControladorViaje(clsSesion.DocumentoSesion);
            dtHistorialViajes = viaje.ejecutarMisViajes();
            if (dtHistorialViajes.Rows.Count == 0)
            {
                cmbViajes.Text = "Este usuario no tiene viajes registrados";
            }
            else
            {
                foreach (DataRow viaje in dtHistorialViajes.Rows)
                {
                    string recogida = viaje["direccionRecogida"].ToString();
                    string destino = viaje["direccionDestino"].ToString();
                    string fechaInicio = viaje["fechaInicio"].ToString();
                    string fechaFinal = viaje["fechaFinal"].ToString();
                    string calificacion = viaje["calificacionConductor"].ToString();
                    cmbViajes.Items.Add($" Desde: {recogida}    Hasta: {destino}    || {fechaInicio}");
                }
            }
        }
        void obtenerMetodosPago()
        {
            metodoPago = new clsControladorMetodoPago(clsSesion.DocumentoSesion);
            dtMetodosPago = metodoPago.ejecutarConsultarMetodosPago();

            if (dtMetodosPago.Rows.Count == 0)
            {
                lblAviso.Visible = true;
                cmbMetodosPago.Visible = false;

            }
            else
            {
                lblAviso.Visible = false;
                foreach (DataRow metodoPago in dtMetodosPago.Rows)
                {
                    string key = "jwey89e09ewhfo24";

                    FB.secret.Encrypt encrypt = new FB.secret.Encrypt();
                    string numTajeta = encrypt.decrypt(metodoPago["numeroTarjeta"].ToString(), key);
                    string tipo = encrypt.decrypt(metodoPago["tipoTarjeta"].ToString(), key);
                    string concepto = encrypt.decrypt(metodoPago["concepto"].ToString(), key);
                    cmbMetodosPago.Items.Add("Tarjeta de: " + tipo + "  ||  " + concepto + "  ||  " + numTajeta);
                }
            }
            lblNombre.Text = $"{clsSesion.PrimerNombre} {clsSesion.PrimerApellido}";
        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            obtenerMetodosPago();
            obtenerHistorialViajes();
        }

        private void btnOfrecerServicio_Click(object sender, EventArgs e)
        {
            clsControladorUsuarios usuario = new clsControladorUsuarios(clsSesion.DocumentoSesion);


            if (usuario.ejecutarVerificarConductor())
            {
                clsSesion.OfreciendoServicio = true;
                frmCambiarUbicacion ubicacion = new frmCambiarUbicacion(false);
                this.Hide();
                ubicacion.ShowDialog();
                this.Show();
            }
            else
            {
                frmRegistroMoto formRegistroMoto = new frmRegistroMoto();
                formRegistroMoto.ShowDialog();
            }





        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnPedirServicio_Click(object sender, EventArgs e)
        {
            if (dtMetodosPago.Rows.Count == 0)
            {
                DialogResult drAdvertencia = MessageBox.Show("Actualmente no tienes un método de pago registrado. Si no ingresas uno antes de pedir un servicio, deberás pagar por efectivo. Si no pagas el viaje, puedes tener sanciones en el servicio o incluso de forma penal. ¿Quieres continuar y pagar en efectivo?", "Advertencia", MessageBoxButtons.YesNo);
                if (drAdvertencia == DialogResult.Yes)
                {
                    clsSesion.OfreciendoServicio = false;
                    frmCambiarUbicacion ubicacion = new frmCambiarUbicacion(false);
                    this.Hide();
                    ubicacion.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                clsSesion.OfreciendoServicio = false;
                frmCambiarUbicacion ubicacion = new frmCambiarUbicacion(false);
                this.Hide();
                ubicacion.ShowDialog();
                this.Show();
            }


        }

        private void btnAgregatMetodoPago_Click(object sender, EventArgs e)
        {
            frmMetodoPago formMetodoPago = new frmMetodoPago();
            this.Hide();
            formMetodoPago.ShowDialog();
            this.Controls.Clear();
            this.InitializeComponent();
            obtenerMetodosPago();
            this.Show();
            ;

        }

        private void cmbMetodosPago_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linklblAutor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linklblAutor.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/millan2993");
        }

        private void linklblRepositorio_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linklblAutor.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/millan2993/countries");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnEditarMetodoPago_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarMetodoPago_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void cmbViajes_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblFechaInicio.Text = dtHistorialViajes.Rows[cmbViajes.SelectedIndex]["fechaInicio"].ToString();
            lblFechaFin.Text = dtHistorialViajes.Rows[cmbViajes.SelectedIndex]["fechaFinal"].ToString();
            lblConductor.Text = dtHistorialViajes.Rows[cmbViajes.SelectedIndex]["primerNombreUsuario"].ToString() + " " + dtHistorialViajes.Rows[cmbViajes.SelectedIndex]["primerApellidoUsuario"].ToString(); ;
            lblPrecio.Text = dtHistorialViajes.Rows[cmbViajes.SelectedIndex]["precioSOlicitado"].ToString();
            lblCalificacion.Text = dtHistorialViajes.Rows[cmbViajes.SelectedIndex]["calificacionConductor"].ToString();
            lblMarca.Text = dtHistorialViajes.Rows[cmbViajes.SelectedIndex]["marcaMoto"].ToString();
            lblLinea.Text = dtHistorialViajes.Rows[cmbViajes.SelectedIndex]["lineaMoto"].ToString();
            lblModelo.Text = dtHistorialViajes.Rows[cmbViajes.SelectedIndex]["modeloMoto"].ToString();
            lblColor.Text = dtHistorialViajes.Rows[cmbViajes.SelectedIndex]["color"].ToString();
            lblPlaca.Text = dtHistorialViajes.Rows[cmbViajes.SelectedIndex]["placaMoto"].ToString();


        }
    }
}
