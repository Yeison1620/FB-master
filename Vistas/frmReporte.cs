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


namespace FB.Vistas
{
    public partial class frmReporte : Form
    {
        string docDenunciado;
        public frmReporte()
        {
            InitializeComponent();
        }

        public frmReporte(string docDenunciado)
        {
            InitializeComponent();
            this.docDenunciado = docDenunciado;
        }

        private void btnEnviarReporte_Click(object sender, EventArgs e)
        {
            clsControladorReportes reporte = new clsControladorReportes(txtDocumento.Text, txtDocumentoDenunciado.Text, txtDescripcion.Text);
            if (reporte.ejecutarNuevoReporte())
            {
                MessageBox.Show("Reporte enviado correctamente. Espera a uno de nuestros ayudantes para una respuesta acerca de tu inconveniente.");
                this.Close();
            }
        }

        private void frmReporte_Load(object sender, EventArgs e)
        {
            txtDocumento.Text = FB.Modelo.clsSesion.DocumentoSesion;
            txtDocumentoDenunciado.Text = this.docDenunciado;
        }
    }
}
