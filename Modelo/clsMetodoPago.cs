using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
using System.Windows.Forms;

namespace FB.Modelo
{
    class clsMetodoPago
    {
		private int idMetodoPago;
        private string numDocumentoIdentidad, numeroTarjeta, vencimiento, tipoTarjeta, concepto, codigoSeguridad, codigoPostal;
        private SqlConnection conexionMetodoPago = clsConexion.dbConnect();

        public int IdMetodoPago { get => idMetodoPago; set => idMetodoPago = value; }
        public string NumDocumentoIdentidad { get => numDocumentoIdentidad; set => numDocumentoIdentidad = value; }
        public string NumeroTarjeta { get => numeroTarjeta; set => numeroTarjeta = value; }
        public string Vencimiento { get => vencimiento; set => vencimiento = value; }

        public string TipoTarjeta { get => tipoTarjeta; set => tipoTarjeta = value; }
        public string Concepto { get => concepto; set => concepto = value; }
        public string CodigoSeguridad { get => codigoSeguridad; set => codigoSeguridad = value; }
        public string CodigoPostal { get => codigoPostal; set => codigoPostal = value; }
        

        public clsMetodoPago(string numDocumentoIdentidad)
        {
            NumDocumentoIdentidad = numDocumentoIdentidad;
        }

        public clsMetodoPago(string numDocumentoIdentidad, string numeroTarjeta, string vencimiento, string tipoTarjeta,string concepto, string codigoSeguridad, string codigoPostal)
        {
            NumDocumentoIdentidad = numDocumentoIdentidad;
            NumeroTarjeta = numeroTarjeta;
            Vencimiento = vencimiento;
            TipoTarjeta = tipoTarjeta;
            Concepto = concepto;
            CodigoSeguridad = codigoSeguridad;
            CodigoPostal = codigoPostal;
        }

        public clsMetodoPago(int idMetodoPago, string numeroTarjeta, string vencimiento, string tipoTarjeta, string concepto, string codigoSeguridad, string codigoPostal)
        {
            IdMetodoPago = idMetodoPago;
            NumeroTarjeta = numeroTarjeta;
            Vencimiento = vencimiento;
            TipoTarjeta = tipoTarjeta;
            Concepto = concepto;
            CodigoSeguridad = codigoSeguridad;
            CodigoPostal = codigoPostal;
        }

        public DataTable consultarMetodosUsuario()
        {
            SqlCommand consulta = new SqlCommand();
            consulta.Connection = conexionMetodoPago;
            consulta.Parameters.Add("@numDocumento", SqlDbType.VarChar).Value = NumDocumentoIdentidad;
            consulta.CommandText = "select * from tblMetodosPago WHERE numDocumentoIdentidad=@numDocumento AND NOT concepto = 'Efectivo'";

            SqlDataReader listaMetodosPago = consulta.ExecuteReader();
            DataTable dtMetodosPago = new DataTable();
            dtMetodosPago.Load(listaMetodosPago);

            return dtMetodosPago;
        }

        public bool agregarMetodoPago()
        {
            SqlCommand consulta = new SqlCommand();
            consulta.Connection = conexionMetodoPago;
            consulta.Parameters.Add("@numDocumento", SqlDbType.VarChar).Value = NumDocumentoIdentidad;
            consulta.Parameters.Add("@numTarjeta", SqlDbType.VarChar).Value = NumeroTarjeta;
            consulta.Parameters.Add("@vencimiento", SqlDbType.VarChar).Value = Vencimiento;
            consulta.Parameters.Add("@tipoTarjeta", SqlDbType.VarChar).Value = TipoTarjeta;
            consulta.Parameters.Add("@concepto", SqlDbType.VarChar).Value = Concepto;
            consulta.Parameters.Add("@codigoSeguridad", SqlDbType.VarChar).Value = CodigoSeguridad;
            consulta.Parameters.Add("@codigoPostal", SqlDbType.VarChar).Value = CodigoPostal;
            consulta.CommandText = "INSERT INTO tblMetodosPago VALUES (@numDocumento, @numTarjeta,@vencimiento,@tipoTarjeta,@concepto,@codigoSeguridad,@codigoPostal)";
            try
            {
                if(consulta.ExecuteNonQuery() >= 1)
                {
                    MessageBox.Show("Método de pago agregado exitosamente");
                    return true;
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el método de pago correctamente. REPORTA");
                    return false;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return false;
            }
        }
    }
}
