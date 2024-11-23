using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin.Properties;
using MaterialSkin.Animations;
using System.Data.SqlClient;
using FB.Controladores;
using FB.Vistas;

namespace FB
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            
           
        }

        private void label1_Click(object sender, EventArgs e)
        {


            
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            try
            {

               Controladores.clsControladorUsuarios peticionIngreso = new Controladores.clsControladorUsuarios(txtEmail.Text, txtPassword.Text);
                if (peticionIngreso.controladorLogin())
                {


                   frmPrincipal menu = new frmPrincipal();
                   menu.Show();
                   this.Hide();
                }
                else
                {
                    MessageBox.Show("Credenciales Inválidas, verifica tu datos ingresados");
                }
                
                
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            frmRegistro registro = new frmRegistro();
            registro.ShowDialog();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
