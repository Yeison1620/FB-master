using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using FB.Controladores;
using FB.Modelo;

namespace FB.Vistas
{
    public partial class frmSolicitantes : Form
    {
        DataTable info;
        DataTable estadoSolicitud;

        string modo = "", nombres, celular;
        int idSolicitd;
        public frmSolicitantes()
        {
            InitializeComponent();
        }

        private void btnDejarTrabajar_Click(object sender, EventArgs e)
        {
            clsControladorConductores conductor = new clsControladorConductores();
            if (conductor.ejecutarDejarServicio()){
                this.Close();
            }
        }

        private void frmSolicitantes_Load(object sender, EventArgs e)
        {
            
        }

        private void timerChecker_Tick(object sender, EventArgs e)
        {
            if(modo == "Esperando Respuesta")
            {
                string estado;
                clsControladorSolicitud solicitud = new clsControladorSolicitud(idSolicitd);
                estadoSolicitud = solicitud.ejecutarConsultarSolicitud();
                estado = estadoSolicitud.Rows[0]["estadoSolicitud"].ToString();
               
                if (estado=="Aceptada" && Convert.ToInt32(estadoSolicitud.Rows[0]["aceptadaPor"]) == clsSesion.IdConductor)
                {
                   
                    
                    timerChecker.Stop();
                    timerChecker.Enabled = false;
                    MessageBox.Show("El cliente ha aceptado tu propuesta!");
                    frmViajes frmViaje = new frmViajes(Convert.ToInt32(txtNumSolicitud.Text), estadoSolicitud.Rows[0]["direccionRecogida"].ToString(), estadoSolicitud.Rows[0]["direccionDestino"].ToString(), Convert.ToDecimal(estadoSolicitud.Rows[0]["precioSolicitado"]),true,nombres,celular, estadoSolicitud.Rows[0]["numDocumentoSolicitante"].ToString());//(Convert.ToInt32(txtNumSolicitud.Text),estadoSolicitud.Rows[0]["direccionRecogida"].ToString(), estadoSolicitud.Rows[0]["direccionDestino"].ToString(), Convert.ToDecimal(estadoSolicitud.Rows[0]["precioSolicitado"]), true);
                    frmViaje.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                clsControladorUsuarios controladorUsuario = new clsControladorUsuarios();
                DataTable infoPosiblesClientes = controladorUsuario.ejecutarUsuariosSolicitando();
                info = controladorUsuario.ejecutarUsuariosSolicitando();


                dtgSolicitantes.DataSource = infoPosiblesClientes;
                dtgSolicitantes.Columns[0].HeaderText = "NumeroSolicitud";
                dtgSolicitantes.Columns[1].HeaderText = "NumDocumento";
                dtgSolicitantes.Columns[2].HeaderText = "Nombre";
                dtgSolicitantes.Columns[3].HeaderText = "Apellido";
                dtgSolicitantes.Columns[4].HeaderText = "Recoges en:";
                dtgSolicitantes.Columns[5].HeaderText = "Quiere ir a:";
                dtgSolicitantes.Columns[6].HeaderText = "Precio Solicitado";
            }


        }

        private void frmSolicitantes_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            timerChecker.Stop();
            timerChecker.Enabled = false;
        }

        private void dtgConductoresActivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNumSolicitud.Text = dtgSolicitantes.CurrentRow.Cells[0].Value.ToString();
            nombres = dtgSolicitantes.CurrentRow.Cells[2].Value.ToString() + dtgSolicitantes.CurrentRow.Cells[3].Value.ToString();
        }

        private void cmbPosiblesClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        //CUando se quiere atender un usuario...
        private void btnAtender_Click(object sender, EventArgs e)
        {
            timerChecker.Enabled = true;
            timerChecker.Start();
            idSolicitd = (Convert.ToInt32(txtNumSolicitud.Text));
                clsControladorConductores controladorConductores = new clsControladorConductores(idSolicitd);
                if (controladorConductores.ejecutarCambiarSolicitudConductor())
                {
                    MessageBox.Show("Aceptaste esta solicitud");
                    modo = "Esperando Respuesta";

            }
            else
            {

            }
            
        }
    }
}
