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
    class clsSolicitud
    {
        private int idSolicitud;
        private string documento;
        private DateTime fecha;
        private string pais;
        private string estado;
        private string ciudad;
        private decimal precioSolicitado;
        private string recogida;
        private string destino;
        private int idConductor;

        private SqlConnection solicitudConnect = clsConexion.dbConnect();

        public string Documento { get => documento; set => documento = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Pais { get => pais; set => pais = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public decimal PrecioSolicitado { get => precioSolicitado; set => precioSolicitado = value; }
        public string Recogida { get => recogida; set => recogida = value; }
        public string Destino { get => destino; set => destino = value; }
        public int IdSolicitud { get => idSolicitud; set => idSolicitud = value; }
        public int IdConductor { get => idConductor; set => idConductor = value; }

        public clsSolicitud( decimal precioSolicitado, string recogida, string destino)
        {
            PrecioSolicitado = precioSolicitado;
            Recogida = recogida;
            Destino = destino;
        }

        public clsSolicitud(DateTime fecha)
        {
            Fecha = fecha;
        }

        public clsSolicitud(int idSol)
        {
            IdSolicitud = idSol;
        }
        public clsSolicitud(int idSol, int idConductor)
        {
            IdSolicitud = idSol;
            IdConductor = idConductor;
        }

 

        public bool crearSolicitud()
        {
            Fecha = DateTime.Now;
            clsSesion.FechaUltimaSolicitud = Fecha;
            SqlCommand consulta = new SqlCommand();
            consulta.Connection = solicitudConnect;
            consulta.Parameters.Add("@documento", SqlDbType.VarChar).Value = clsSesion.DocumentoSesion;
            consulta.Parameters.Add("@fecha", SqlDbType.DateTime).Value = Fecha;
            consulta.Parameters.Add("@pais", SqlDbType.VarChar).Value = clsSesion.Pais;
            consulta.Parameters.Add("@estado", SqlDbType.VarChar).Value = clsSesion.Estado;
            consulta.Parameters.Add("@ciudad", SqlDbType.VarChar).Value = clsSesion.Ciudad;
            consulta.Parameters.Add("@precio", SqlDbType.VarChar).Value = PrecioSolicitado;
            consulta.Parameters.Add("@recogida", SqlDbType.VarChar).Value = Recogida;
            consulta.Parameters.Add("@destino", SqlDbType.VarChar).Value = Destino;

            consulta.CommandText = "insert into tblSolicitudes values (@documento, @fecha, @pais, @estado, @ciudad, @recogida, @destino, @precio, 'Buscando', null) ";

            try
            {
                if (consulta.ExecuteNonQuery() >= 1)
                {
                    
                    consulta.CommandText = "SELECT idSolicitud from tblSolicitudes where numDocumentoSolicitante=@documento and fechaSolicitud=@fecha";
                    SqlDataReader adaptarId = consulta.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(adaptarId);
                    clsSesion.SolicitudActual = Convert.ToInt32(dt.Rows[0]["idSolicitud"]);

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

        //Método que obtiene la información de una solicitud
        public DataTable consultarSolicitud()
        {
            
            SqlCommand consulta = new SqlCommand();
            consulta.Connection = solicitudConnect;
            consulta.Parameters.Add("@idSol", SqlDbType.Int).Value = IdSolicitud;
            consulta.CommandText = "SELECT idSolicitud, tblSolicitudes.numDocumentoSolicitante, fechaSolicitud, estadoSolicitud, direccionRecogida, direccionDestino, precioSolicitado, celular, aceptadaPor" +
                " FROM tblSolicitudes INNER JOIN tblCredenciales ON tblSolicitudes.numDocumentoSolicitante = tblCredenciales.numDocumentoIdentidad " +
                "WHERE idSolicitud = @idSol";

            SqlDataReader solicitud = consulta.ExecuteReader();
            DataTable dtSolicitud = new DataTable();
            dtSolicitud.Load(solicitud);
            
            return dtSolicitud;

        }

        //Método para interrumpir la solicitud al reportar un problema.
        public bool interrumpirSoliciutd()
        {
            SqlCommand consulta = new SqlCommand();
            consulta.Connection = solicitudConnect;
            consulta.Parameters.Add("@idSolicitud", SqlDbType.Int).Value = idSolicitud;
            consulta.CommandText = "UPDATE  tblSolicitudes SET estadoSolicitud='Interrumpida' where idSolicitud=@idSolicitud";

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

        //Método para cancelar una solicitud
        public bool cancelarSolicitud()
        {
            SqlCommand consulta = new SqlCommand();
            consulta.Connection = solicitudConnect;
            consulta.Parameters.Add("@idSolicitud", SqlDbType.Int).Value = idSolicitud;
            consulta.CommandText = "UPDATE  tblSolicitudes SET estadoSolicitud='Cancelada' where idSolicitud=@idSolicitud";

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

       
        //Método para que el cliente pueda aceptar un conductor interesado en su oferta.
        public bool aceptarConductorSolicitud()
        {
            SqlCommand consulta = new SqlCommand();
            consulta.Connection = solicitudConnect;
            consulta.Parameters.Add("@idSol", SqlDbType.Int).Value = IdSolicitud;
            consulta.Parameters.Add("@idConductor", SqlDbType.Int).Value = IdConductor;

            consulta.CommandText = "EXECUTE aceptarConductorSolicitud @idSol, @idConductor";

            try
            {
                if (consulta.ExecuteNonQuery() >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return false;
            }

            
        }

        public bool clienteRecogido()
        {
            SqlCommand consulta = new SqlCommand();
            consulta.Connection = solicitudConnect;
            consulta.Parameters.Add("@idSol", SqlDbType.Int).Value = IdSolicitud;
            consulta.CommandText = "UPDATE tblSolicitudes SET estadoSolicitud='Recogido?' WHERE idSolicitud = @idSol AND estadoSolicitud='Aceptada'";

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

        public bool confirmarRecogida()
        {
            SqlCommand consulta = new SqlCommand();
            consulta.Connection = solicitudConnect;
            consulta.Parameters.Add("@idSol", SqlDbType.Int).Value = IdSolicitud;
            consulta.CommandText = "UPDATE tblSolicitudes SET estadoSolicitud='Viajando' WHERE idSolicitud = @idSol AND estadoSolicitud='Recogido?'";

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

        public bool llegarDestino()
        {
            SqlCommand consulta = new SqlCommand();
            consulta.Connection = solicitudConnect;
            consulta.Parameters.Add("@idSol", SqlDbType.Int).Value = IdSolicitud;
            consulta.CommandText = "UPDATE tblSolicitudes SET estadoSolicitud='Finalizado?' WHERE idSolicitud = @idSol AND estadoSolicitud='Viajando'";

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

        public bool confirmarLlegarDestino()
        {
            SqlCommand consulta = new SqlCommand();
            consulta.Connection = solicitudConnect;
            consulta.Parameters.Add("@idSol", SqlDbType.Int).Value = IdSolicitud;
            consulta.CommandText = "UPDATE tblSolicitudes SET estadoSolicitud='Pago Pendiente' WHERE idSolicitud = @idSol AND estadoSolicitud='Finalizado?'";

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
