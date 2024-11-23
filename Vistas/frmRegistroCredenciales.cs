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

namespace FB.Vistas
{
    public partial class frmRegistroCredenciales : Form
    {
        private string Documento;
        public frmRegistroCredenciales(string numDocumento)
        {
            this.Documento = numDocumento;
            InitializeComponent();
        }

        private void btnSigueinte_Click(object sender, EventArgs e)
        {
            clsControladorUsuarios credencialesUsuario = new clsControladorUsuarios(
                Documento,
                txtEmail.Text,
                txtPassword.Text,
                txtCelular.Text
                );

            if (credencialesUsuario.ejecutarRegistrarCredenciales())
            {
                clsSesion.DocumentoSesion = Documento;
                frmPrincipal menu = new frmPrincipal();
                menu.Show();
                this.Hide();
            }
        }

        private void frmRegistroCredenciales_Load(object sender, EventArgs e)
        {

        }
    }
}
