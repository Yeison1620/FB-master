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
    class clsViaje
    {
        private int idViaje, idSolicitud, idMetodoPago;
        private string numDocumentoPasajero, numDocumentoConductor, formaPago;
        private DateTime fechaInicio, fechaFinal;
        private decimal calificacionConductor;
        private SqlConnection conexionViaje = clsConexion.dbConnect();

        public int IdViaje { get => idViaje; set => idViaje = value; }
        public int IdSolicitud { get => idSolicitud; set => idSolicitud = value; }
        public int IdMetodoPago { get => idMetodoPago; set => idMetodoPago = value; }
        public string NumDocumentoPasajero { get => numDocumentoPasajero; set => numDocumentoPasajero = value; }
        public string NumDocumentoConductor { get => numDocumentoConductor; set => numDocumentoConductor = value; }
        public string FormaPago { get => formaPago; set => formaPago = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFinal { get => fechaFinal; set => fechaFinal = value; }
        public decimal CalificacionConductor { get => calificacionConductor; set => calificacionConductor = value; }

        public clsViaje( int idSolicitud, string numDocumentoPasajero, string numDocumentoConductor, string formaPago, DateTime fechaInicio, DateTime fechaFina, decimal calificacionConductor, int idMetodo)
        {
            IdSolicitud = idSolicitud;
            NumDocumentoPasajero = numDocumentoPasajero;
            NumDocumentoConductor = numDocumentoConductor;
            FormaPago = formaPago;
            FechaInicio = fechaInicio;
            FechaFinal = fechaFina;
            CalificacionConductor = calificacionConductor;
            IdMetodoPago = idMetodo;
        }

        public clsViaje(string numDocumentoPasajero)
        {
            NumDocumentoPasajero = numDocumentoPasajero;
        }

        public DataTable historialViajes()
        {
            SqlCommand consulta = new SqlCommand();
            consulta.Connection = conexionViaje;
            consulta.Parameters.Add("@docPasajero", SqlDbType.VarChar).Value = NumDocumentoPasajero;
            consulta.CommandText = "SELECT * from historialViajes where numDocumentoPasajero=@docPasajero order by fechaInicio DESC";

            SqlDataReader viajes = consulta.ExecuteReader();
            DataTable dtMisViajes = new DataTable();
            dtMisViajes.Load(viajes);
            return dtMisViajes;
        }

        public bool crearViaje()
        {
            SqlCommand consulta = new SqlCommand();
            consulta.Connection = conexionViaje;

            consulta.Parameters.Add("@idSolicitud", SqlDbType.Int).Value = IdSolicitud;
            consulta.Parameters.Add("@docPasajero", SqlDbType.VarChar).Value = NumDocumentoPasajero;
            consulta.Parameters.Add("@docConductor", SqlDbType.VarChar).Value = NumDocumentoConductor;
            consulta.Parameters.Add("@formaPago", SqlDbType.VarChar).Value = FormaPago;
            consulta.Parameters.Add("@FechaInicio", SqlDbType.DateTime).Value = FechaInicio;
            consulta.Parameters.Add("@FechaFinal", SqlDbType.DateTime).Value = FechaFinal;
            consulta.Parameters.Add("@calificacion", SqlDbType.Decimal).Value = CalificacionConductor;
            
            if(FormaPago == "Efectivo")
            {
                consulta.Parameters.Add("@idMetodo", SqlDbType.Int).Value = DBNull.Value;
                consulta.CommandText = "EXECUTE pagar_registrar_viaje @idSolicitud,@docPasajero,@docConductor,@FechaInicio,@FechaFinal, @calificacion ,@formaPago,@idMetodo";

            }
            else
            {
                consulta.Parameters.Add("@idMetodo", SqlDbType.Int).Value = IdMetodoPago;
                consulta.CommandText = "EXECUTE pagar_registrar_viaje @idSolicitud,@docPasajero,@docConductor,@FechaInicio,@FechaFinal, @calificacion ,@formaPago,@idMetodo";
            }
            try
            {
                if (consulta.ExecuteNonQuery() >= 1)
                {

                    MessageBox.Show("El viaje ha sido registrado exitosamente");
                    return true;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return false;
            }

            return false;
        }
    }
}
