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
using FB.Vistas;

namespace FB
{
    public partial class frmConductoresDisponibles : Form
    {
        //Variables y contructor de la clase
        string recogida;
        string destino;
        string nombres;
        string documentoConductor;
        string celular;
        decimal calificacion;
        public frmConductoresDisponibles(string recogida, string destino)
        {
            
            InitializeComponent();
            this.recogida = recogida;
            this.destino = destino;
        }

        //Cuando acepta un conductor...
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            clsControladorSolicitud solicitud = new clsControladorSolicitud(clsSesion.SolicitudActual, Convert.ToInt32(txtId.Text));
            if (solicitud.ejecutarAceptarConductorSolicitud())
            {
                frmViajes formViaje = new frmViajes(Convert.ToInt32(clsSesion.SolicitudActual), recogida, destino, Convert.ToDecimal(txtPropuestaPrecio.Text), false, nombres, celular, documentoConductor, calificacion, Convert.ToInt32(txtId.Text));//Convert.ToInt32(clsSesion.SolicitudActual),recogida, destino, Convert.ToDecimal(txtPropuestaPrecio.Text), false, Convert.ToInt32(txtId.Text));
                this.Hide();
                formViaje.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Este conductor ya no quiere atenderte");
            }

        }

        private void btnBuscarConductores_Click(object sender, EventArgs e)
        {
            clsControladorSolicitud solicitud = new clsControladorSolicitud(Convert.ToDecimal(txtPropuestaPrecio.Text),this.recogida, this.destino);
            if (solicitud.ejecutarCrearSolicitud())
            {
                txtPropuestaPrecio.Enabled = false;
                btnBuscarConductores.Enabled = false;
                MessageBox.Show("Solicitud creada con éxito!");

                btnCancelar.Visible = true;
                
            }
        }

        //Al cargar el formulario
        private void frmConductoresDisponibles_Load(object sender, EventArgs e)
        {

            btnCancelar.Visible = false;
            
        }

        //Cuando presiona el botón para cancelar la solicitud
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clsControladorSolicitud controladorSolicitud = new clsControladorSolicitud(clsSesion.SolicitudActual);
            if (controladorSolicitud.ejecutarCancelarSolicitud())
            {
                MessageBox.Show("Solicitud Cancelada con éxito");
                btnCancelar.Visible = false;

                txtPropuestaPrecio.Enabled = true;
                btnBuscarConductores.Enabled = true;
            }

            
        }

        //Código a ejecutar cada intervalo de Timer
        private void timerCheck_Tick(object sender, EventArgs e)
        {

            clsControladorConductores controladorConductores = new clsControladorConductores(clsSesion.SolicitudActual);
            dtgConductores.DataSource = controladorConductores.ejecutarConductoresSolicitud();
            
        }

        //Al hacer click en una celda del datagridview
        private void dtgConductores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dtgConductores.CurrentRow.Cells[1].Value.ToString();
            nombres = dtgConductores.CurrentRow.Cells[3].Value.ToString() + " " + dtgConductores.CurrentRow.Cells[4].Value.ToString();
            documentoConductor = dtgConductores.CurrentRow.Cells[2].Value.ToString();
            celular = dtgConductores.CurrentRow.Cells[5].Value.ToString();
            calificacion = Convert.ToDecimal(dtgConductores.CurrentRow.Cells[6].Value);
        }

        //Cuando se cierra el formulario
        private void frmConductoresDisponibles_FormClosing(object sender, FormClosingEventArgs e)
        {
            clsControladorSolicitud controladorSolicitud = new clsControladorSolicitud(clsSesion.SolicitudActual);
            controladorSolicitud.ejecutarCancelarSolicitud();
            timerCheck.Stop();
            timerCheck.Enabled = false;
        }
    }
}
