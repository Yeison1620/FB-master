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
    class clsUsuario
    {
        
        private SqlConnection usersConnect = clsConexion.dbConnect();

        private string numDocumentoIdentidad;
        private string primerNombreUsuario;
        private string segundoNombreUsuario;
        private string primerApellidoUsuario;
        private string segundoApellidoUsuario;
        private DateTime fechNacimientoUsuario;
        private string email;
        private string contraseña;
        private string celular;
        private string sexo;
        private string paisActual;
        private string estadoActual;
        private string ciudadActual;
        private decimal saldo;
        private string rol;
        private string estadoCuenta;
        private string credencialIngreso;

        private string direccionRecogida;
        private string direccionDestion;
        private decimal precioSolicitado;
        


        public string NumDocumentoIdentidad { get => numDocumentoIdentidad; set => numDocumentoIdentidad = value; }
        public string PrimerNombreUsuario { get => primerNombreUsuario; set => primerNombreUsuario = value; }
        public string SegundoNombreUsuario { get => segundoNombreUsuario; set => segundoNombreUsuario = value; }
        public string PrimerApellidoUsuario { get => primerApellidoUsuario; set => primerApellidoUsuario = value; }
        public string SegundoApellidoUsuario { get => segundoApellidoUsuario; set => segundoApellidoUsuario = value; }
        public DateTime FechNacimientoUsuario { get => fechNacimientoUsuario; set => fechNacimientoUsuario = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string PaisActual { get => paisActual; set => paisActual = value; }
        public string EstadoActual { get => estadoActual; set => estadoActual = value; }
        public string CiudadActual { get => ciudadActual; set => ciudadActual = value; }
        public string Email { get => email; set => email = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string Celular { get => celular; set => celular = value; }
        public string CredencialIngreso { get => credencialIngreso; set => credencialIngreso = value; }
        public decimal Saldo { get => saldo; set => saldo = value; }
        public string Rol { get => rol; set => rol = value; }
        public string EstadoCuenta { get => estadoCuenta; set => estadoCuenta = value; }
        public string DireccionRecogida { get => direccionRecogida; set => direccionRecogida = value; }
        public string DireccionDestion { get => direccionDestion; set => direccionDestion = value; }
        public decimal PrecioSolicitado { get => precioSolicitado; set => precioSolicitado = value; }

        public clsUsuario (string email_o_celular, string contraseña)
        {
            CredencialIngreso = email_o_celular;
            Contraseña = contraseña;
            
            usersConnect = clsConexion.dbConnect();
        }

        public clsUsuario()
        {

        }

        //Toca revisar este constructor
        public clsUsuario(string numDocumentoIdentidad, string primerNombreUsuario, string segundoNombreUsuario, string primerApellidoUsuario, string segundoApellidoUsuario, DateTime fechNacimientoUsuario, string sexo, string paisActual, string estadoActual, string ciudadActual, string email, string password,string celular)
        {
            NumDocumentoIdentidad = numDocumentoIdentidad;
            PrimerNombreUsuario = primerNombreUsuario;
            SegundoNombreUsuario = segundoNombreUsuario;
            PrimerApellidoUsuario = primerApellidoUsuario;
            SegundoApellidoUsuario = segundoApellidoUsuario;
            FechNacimientoUsuario = fechNacimientoUsuario;
            Sexo = sexo;
            PaisActual = paisActual;
            EstadoActual = estadoActual;
            CiudadActual = ciudadActual;
            Email = email;
            Contraseña = password;
            Celular = celular;
            usersConnect = clsConexion.dbConnect();
        }
        public clsUsuario(string pais, string estado, string ciudad)
        {
            EstadoActual = estado;
            PaisActual = pais;
            CiudadActual = ciudad;
            usersConnect = clsConexion.dbConnect();
        }
        public clsUsuario(string documento, string email, string password, string celular)
        {
            NumDocumentoIdentidad = documento;
           
            usersConnect = clsConexion.dbConnect();
        }

        public clsUsuario(string documento)
        {
            NumDocumentoIdentidad = documento;
            usersConnect = clsConexion.dbConnect();
        }

        public clsUsuario(string direccionRecogida, string direccionDestion, decimal precioSolicitado)
        {
            DireccionRecogida = direccionRecogida;
            DireccionDestion = direccionDestion;
            PrecioSolicitado = precioSolicitado;
            usersConnect = clsConexion.dbConnect();
        }
        
        public void obtenerUsuarioUnico()
        {

        }

        public bool registrarUsuario()
        {
            SqlCommand consulta = new SqlCommand();
            consulta.Connection = usersConnect;
            consulta.CommandText = "EXECUTE registrarUsuario @documento, @primerNom, @segundoNom, @primerApe, @segundoApe, @fechaNacimiento, " +
                "@sexo, @pais, @estado, @ciudad, @email, @password, @celular";
            consulta.Parameters.Add("@documento", SqlDbType.VarChar).Value = numDocumentoIdentidad;
            consulta.Parameters.Add("@primerNom", SqlDbType.VarChar).Value = primerNombreUsuario;
            consulta.Parameters.Add("@segundoNom", SqlDbType.VarChar).Value = segundoNombreUsuario;
            consulta.Parameters.Add("@primerApe", SqlDbType.VarChar).Value = primerApellidoUsuario;
            consulta.Parameters.Add("@segundoApe", SqlDbType.VarChar).Value = segundoApellidoUsuario;
            consulta.Parameters.Add("@fechaNacimiento", SqlDbType.Date).Value = fechNacimientoUsuario;
            consulta.Parameters.Add("@sexo", SqlDbType.VarChar).Value = sexo;
            consulta.Parameters.Add("@pais", SqlDbType.VarChar).Value = paisActual;
            consulta.Parameters.Add("@estado", SqlDbType.VarChar).Value = estadoActual;
            consulta.Parameters.Add("@ciudad", SqlDbType.VarChar).Value = ciudadActual;
            consulta.Parameters.Add("@email", SqlDbType.VarChar).Value = Email;
            consulta.Parameters.Add("@password", SqlDbType.VarChar).Value = Contraseña;
            consulta.Parameters.Add("@celular", SqlDbType.VarChar).Value = Celular;

            try
            {
                if (consulta.ExecuteNonQuery() >= 1)
                {
                    clsSesion.DocumentoSesion = NumDocumentoIdentidad;
                    clsSesion.Ciudad = Celular;
                    clsSesion.PrimerNombre = PrimerNombreUsuario;
                    clsSesion.SegundoNombre = SegundoNombreUsuario;
                    clsSesion.PrimerApellido = PrimerApellidoUsuario;
                    clsSesion.SegundoApellido = SegundoApellidoUsuario;
                    clsSesion.Pais = paisActual;
                    clsSesion.Estado = EstadoActual;
                    clsSesion.Ciudad = CiudadActual;

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

        public bool registrarCredenciales()
        {
            SqlCommand consulta = new SqlCommand();
            consulta.Connection = usersConnect;
            consulta.CommandText = "insert into tblCredenciales values (@documento, @email, @password, @celular)";
            consulta.Parameters.Add("documento", SqlDbType.VarChar).Value = numDocumentoIdentidad;
            consulta.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            consulta.Parameters.Add("@password", SqlDbType.VarChar).Value = contraseña;
            consulta.Parameters.Add("@celular", SqlDbType.VarChar).Value = celular;
            
            try
            {
                if (consulta.ExecuteNonQuery() >= 1)
                {
                    clsSesion.DocumentoSesion = numDocumentoIdentidad;
                    clsSesion.Celular = celular;
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
        public DataTable loginUsuario()
        {
            SqlCommand consulta = new SqlCommand();
            consulta.Connection = usersConnect;
            consulta.Parameters.Add("@credencial", SqlDbType.VarChar).Value = CredencialIngreso;
            consulta.Parameters.Add("@contraseña", SqlDbType.VarChar).Value = FB.secret.Encrypt.encryptPassowrd(Contraseña);
            consulta.CommandText = "select * from tblCredenciales where (emailUsuario=@credencial or celular=@credencial) and contraseña=@contraseña";

            SqlDataReader lista = consulta.ExecuteReader();
            DataTable infoLogin = new DataTable();
            infoLogin.Load(lista);

            if(infoLogin.Rows.Count > 0)
            {

                clsSesion.DocumentoSesion = infoLogin.Rows[0]["numDocumentoIdentidad"].ToString();
                clsSesion.Celular = infoLogin.Rows[0]["celular"].ToString();

                consulta.Parameters.Add("@documento", SqlDbType.VarChar).Value = infoLogin.Rows[0]["numDocumentoIdentidad"];
                consulta.CommandText = "select * from tblUsuarios where numDocumentoIdentidad=@documento";
                SqlDataReader consultaInfoUsuario = consulta.ExecuteReader();
                DataTable infoUsuario = new DataTable();
                infoUsuario.Load(consultaInfoUsuario);

                
                 clsSesion.PrimerNombre = infoUsuario.Rows[0]["primerNombreUsuario"].ToString();
                 clsSesion.SegundoNombre = infoUsuario.Rows[0]["segundoNombreUsuario"].ToString();
                clsSesion.PrimerApellido =infoUsuario.Rows[0]["primerApellidoUsuario"].ToString();
                clsSesion.SegundoApellido = infoUsuario.Rows[0]["segundoApellidoUsuario"].ToString();
                
                clsSesion.Pais = infoUsuario.Rows[0]["paisActual"].ToString();
                 clsSesion.Estado = infoUsuario.Rows[0]["estadoActual"].ToString();
                 clsSesion.Ciudad = infoUsuario.Rows[0]["ciudadActual"].ToString();

            }


            return infoLogin;

        }

        //Comprueba si el usuario de la sesión es un conductor ya registrado
        public bool comprobarUsuarioConductor()
        {
            SqlCommand consulta = new SqlCommand();
            consulta.Connection = usersConnect;
            consulta.Parameters.Add("@documento", SqlDbType.VarChar).Value = NumDocumentoIdentidad;
            consulta.CommandText = "select * from tblConductores where numDocumentoIdentidad=@documento";

            SqlDataReader lista = consulta.ExecuteReader();
            DataTable dt = new DataTable();
            

            dt.Load(lista);

            

            if(dt.Rows.Count == 1)
            {
                clsSesion.IdConductor = Convert.ToInt32(dt.Rows[0]["idConductor"]);
                return true;
            }
            else
            {
                return false;
            }
        }

       public bool actualizarUbicacionUsuario()
        {
            SqlCommand consulta = new SqlCommand();
            consulta.Connection = usersConnect;
            consulta.Parameters.Add("@documento", SqlDbType.VarChar).Value = clsSesion.DocumentoSesion;
            consulta.Parameters.Add("@ciudad", SqlDbType.VarChar).Value = CiudadActual;
            consulta.Parameters.Add("@estado", SqlDbType.VarChar).Value = EstadoActual;
            consulta.Parameters.Add("@pais", SqlDbType.VarChar).Value = PaisActual;

            consulta.CommandText = "UPDATE tblUsuarios SET ciudadActual=@ciudad, estadoActual=@estado, paisActual=@pais where numDocumentoIdentidad=@documento";
            
            try
            {
                if (consulta.ExecuteNonQuery() >= 1)
                {
                    clsSesion.Estado = EstadoActual;
                    clsSesion.Pais = PaisActual;
                    clsSesion.Ciudad = CiudadActual;
                    MessageBox.Show("Ubicaión Actualizada correctamente");
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

        public DataTable usuariosSolicitando()
        {
            SqlCommand consulta = new SqlCommand();
            consulta.Connection = usersConnect;
            consulta.Parameters.Add("@ciudad", SqlDbType.VarChar).Value = clsSesion.Ciudad;
            consulta.Parameters.Add("@estado", SqlDbType.VarChar).Value = clsSesion.Estado;
            consulta.Parameters.Add("@pais", SqlDbType.VarChar).Value = clsSesion.Pais;
            consulta.CommandText = "select idSolicitud, numDocumentoSolicitante, primerNombreUsuario,primerApellidoUsuario, direccionRecogida, direccionDestino, precioSolicitado FROM usuariosSolicitando WHERE ciudadActual=@ciudad and estadoActual=@estado and paisActual=@pais ";

            SqlDataReader listaUsuariosSolicitando = consulta.ExecuteReader();
            DataTable infoUsuariosSolicitando = new DataTable();
            infoUsuariosSolicitando.Load(listaUsuariosSolicitando);

            return infoUsuariosSolicitando;
            
        }

        public bool aceptarConductor()
        {
            SqlCommand consulta = new SqlCommand();
            consulta.Connection = usersConnect;
            consulta.CommandText = "UPDATE tblSolicitudes SET estadoSolicitud='Aceptada' where idSolicitud=@idSol";

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
