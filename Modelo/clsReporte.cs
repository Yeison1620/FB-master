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
    class clsReporte
    {
        private int idSolicitudReporte;
        private string documentoReportante, documentoReportado, descripcion, respuesta;
        private SqlConnection conexionReporte = clsConexion.dbConnect();
      
        public int IdSolicitudReporte { get => idSolicitudReporte; set => idSolicitudReporte = value; }
        public string DocumentoReportante { get => documentoReportante; set => documentoReportante = value; }
        public string DocumentoReportado { get => documentoReportado; set => documentoReportado = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Respuesta { get => respuesta; set => respuesta = value; }
        public clsReporte(string documentoReportante, string documentoReportado, string descripcion)
        {
            DocumentoReportante = documentoReportante;
            DocumentoReportado = documentoReportado;
            Descripcion = descripcion;
            
        }
        public bool crearReporte()
        {
            SqlCommand consulta = new SqlCommand();
            consulta.Connection = conexionReporte;
            consulta.Parameters.Add("@documentoReportante", SqlDbType.VarChar).Value = DocumentoReportante;
            consulta.Parameters.Add("@documentoReportado", SqlDbType.VarChar).Value = DocumentoReportado;
            consulta.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = Descripcion;
           

            consulta.CommandText = "insert into tblReporteProblemas values (@documentoReportante, @documentoReportado, @descripcion, null) ";

            try
            {
                if (consulta.ExecuteNonQuery() >= 1)
                {

                   

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
