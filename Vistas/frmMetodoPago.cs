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
using System.Security.Cryptography;


namespace FB.Vistas
{
    public partial class frmMetodoPago : Form
    {
        private clsControladorMetodoPago metodoPago;
         
        public frmMetodoPago()
        {
            InitializeComponent();
        }

        private void frmMetodoPago_Load(object sender, EventArgs e)
        {
            cmbConcepto.Items.Add("MasterCard");
            cmbConcepto.Items.Add("Visa");
            cmbConcepto.Items.Add("American Express");
            cmbConcepto.Items.Add("Diners Club");

            cmbTipoTarjeta.Items.Add("Crédito");
            cmbTipoTarjeta.Items.Add("Débito");
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
             string key = "jwey89e09ewhfo24";

            FB.secret.Encrypt encrypt = new FB.secret.Encrypt();
            string numTajeta = encrypt.encrypt(txtTarjeta.Text, key);
            string fechaVencimiento = encrypt.encrypt($"{txtMesVencimiento.Text}/{txtAnoVencimiento.Text}", key);
            string tipoTarjeta = encrypt.encrypt(cmbTipoTarjeta.Text,key);
            string concepto = encrypt.encrypt(cmbConcepto.Text, key);
            string codigoSeguridad = encrypt.encrypt(txtCodigoSeguridad.Text, key);
            string codigoPostal = encrypt.encrypt(txtCodigoPostal.Text, key);

            

            try
            {
                metodoPago = new clsControladorMetodoPago(FB.Modelo.clsSesion.DocumentoSesion,numTajeta, fechaVencimiento, tipoTarjeta,concepto,codigoSeguridad,codigoPostal);
                metodoPago.ejecutarAgregarMetodoPago();           
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        
    }
}
