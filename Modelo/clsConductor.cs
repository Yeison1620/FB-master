using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
using System.Windows.Forms;
using FB.Modelo;

namespace FB.Modelo
{
    class clsConductor
    {
        //Variables, objeto y propiedades
        private SqlConnection usersConnect = clsConexion.dbConnect();

        private string placaMoto;
		private string numDocumentoIdentidadConductor;
		private decimal calificacionPromedio;
		private char activo;
		private DateTime licenciaDesde;
		private DateTime licenciaHasta;
		private int solicitudActual;

        private string numeroMatricula;
        private bool motoPropia;
        private DateTime inicioSOAT;
        private DateTime finSOAT;
        private DateTime inicioTecnomecanica;
        private DateTime finTecnomecanica;

        private string marcaMoto;
        private string modeloMoto;
        private string lineaMoto;
        private string color;
        private int cilindraje;
        private string numChasis;
        private string numMotor;

        private string numDocumentoPropietario;
        private string primerNombre;
        private string segundoNombre;
        private string primerApellido;
        private string segundoApellido;
        private string celular;

        private int idConductor;

        public string PlacaMoto { get => placaMoto; set => placaMoto = value; }
        public string NumDocumentoIdentidadConductor { get => numDocumentoIdentidadConductor; set => numDocumentoIdentidadConductor = value; }
        public DateTime LicenciaDesde { get => licenciaDesde; set => licenciaDesde = value; }
        public DateTime LicenciaHasta { get => licenciaHasta; set => licenciaHasta = value; }
        public int SolicitudActual { get => solicitudActual; set => solicitudActual = value; }
        public decimal CalificacionPromedio { get => calificacionPromedio; set => calificacionPromedio = value; }
        public char Activo { get => activo; set => activo = value; }
        public string NumeroMatricula { get => numeroMatricula; set => numeroMatricula = value; }
        public bool MotoPropia { get => motoPropia; set => motoPropia = value; }
        public DateTime InicioSOAT { get => inicioSOAT; set => inicioSOAT = value; }
        public DateTime FinSOAT { get => finSOAT; set => finSOAT = value; }
        public DateTime InicioTecnomecanica { get => inicioTecnomecanica; set => inicioTecnomecanica = value; }
        public DateTime FinTecnomecanica { get => finTecnomecanica; set => finTecnomecanica = value; }
        public string MarcaMoto { get => marcaMoto; set => marcaMoto = value; }
        public string ModeloMoto { get => modeloMoto; set => modeloMoto = value; }
        public string LineaMoto { get => lineaMoto; set => lineaMoto = value; }
        public string Color { get => color; set => color = value; }
        public int Cilindraje { get => cilindraje; set => cilindraje = value; }
        public string NumChasis { get => numChasis; set => numChasis = value; }
        public string NumMotor { get => numMotor; set => numMotor = value; }
        public string NumDocumentoPropietario { get => numDocumentoPropietario; set => numDocumentoPropietario = value; }
        public string PrimerNombre { get => primerNombre; set => primerNombre = value; }
        public string SegundoNombre { get => segundoNombre; set => segundoNombre = value; }
        public string PrimerApellido { get => primerApellido; set => primerApellido = value; }
        public string SegundoApellido { get => segundoApellido; set => segundoApellido = value; }
        public string Celular { get => celular; set => celular = value; }
        public int IdConductor { get => idConductor; set => idConductor = value; }
        

        //Constructores de la clase
        public clsConductor(string numDoc, DateTime licenciaDesde, DateTime licenciaHasta)
        { 
            LicenciaDesde = licenciaDesde;
            LicenciaHasta = licenciaHasta;
            NumDocumentoIdentidadConductor = numDoc;
        }

        public clsConductor()
        {

        }

        public clsConductor(int idConductor, int solicitudActual)
        {
            IdConductor = idConductor;
            SolicitudActual = solicitudActual;
        }

        public clsConductor(int solicitudActual)
        {
            SolicitudActual = solicitudActual;
        }

        public clsConductor(string placaMoto, string numDocumentoIdentidad, DateTime licenciaDesde, DateTime licenciaHasta, string numeroMatricula, bool motoPropia, DateTime inicioSOAT, DateTime finSOAT, DateTime inicioTecnomecanica, DateTime finTecnomecanica, string marcaMoto, string modeloMoto, string lineaMoto, string color, int cilindraje, string numChasis, string numMotor, string numDocumento, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, string celular)
        {
            PlacaMoto = placaMoto;
            NumDocumentoIdentidadConductor = numDocumentoIdentidad;
            LicenciaDesde = licenciaDesde;
            LicenciaHasta = licenciaHasta;
            
            
            Activo = activo;
            NumeroMatricula = numeroMatricula;
            MotoPropia = motoPropia;
            InicioSOAT = inicioSOAT;
            FinSOAT = finSOAT;
            InicioTecnomecanica = inicioTecnomecanica;
            FinTecnomecanica = finTecnomecanica;
            MarcaMoto = marcaMoto;
            ModeloMoto = modeloMoto;
            LineaMoto = lineaMoto;
            Color = color;
            Cilindraje = cilindraje;
            NumChasis = numChasis;
            NumMotor = numMotor;
            NumDocumentoPropietario = numDocumento;
            PrimerNombre = primerNombre;
            SegundoNombre = segundoNombre;
            PrimerApellido = primerApellido;
            SegundoApellido = segundoApellido;
            Celular = celular;
        }

        //Metodo para registrar conductor por primera vez
        public bool registrarComoConductor()
        {
            SqlCommand consulta = new SqlCommand();
            consulta.Connection = usersConnect;
            consulta.CommandText = "EXECUTE registrarComoConductor @placa,@marca, @modelo, @linea, @color, @cilindraje, @numChasis, @numMotor, " +
                "@numMatricula, @motoPropia, @inicioSOAT, @finSOAT, @inicioTecnomecanica, @finTecnomecanica,@numDocumentoPropietario, @primerNombre, @segundoNombre," +
                " @primerApellido, @segundoApellido, @celular, @numDocumentoConductor, @licenciaDesde, @licenciaHasta, null";
            consulta.Parameters.Add("@placa", SqlDbType.VarChar).Value = PlacaMoto;
            consulta.Parameters.Add("@marca", SqlDbType.VarChar).Value = MarcaMoto;
            consulta.Parameters.Add("@modelo", SqlDbType.VarChar).Value = ModeloMoto;
            consulta.Parameters.Add("@linea", SqlDbType.VarChar).Value = LineaMoto;
            consulta.Parameters.Add("@color", SqlDbType.VarChar).Value = Color;
            consulta.Parameters.Add("@cilindraje", SqlDbType.Int).Value =Cilindraje ;
            consulta.Parameters.Add("@numChasis", SqlDbType.VarChar).Value = NumChasis;
            consulta.Parameters.Add("@numMotor", SqlDbType.VarChar).Value = NumMotor;
            consulta.Parameters.Add("@numMatricula", SqlDbType.VarChar).Value = NumeroMatricula.ToString();
            consulta.Parameters.Add("@motoPropia", SqlDbType.Bit).Value = MotoPropia;
            consulta.Parameters.Add("@inicioSOAT", SqlDbType.Date).Value = InicioSOAT;
            consulta.Parameters.Add("@finSOAT", SqlDbType.Date).Value = FinSOAT;
            consulta.Parameters.Add("@inicioTecnomecanica", SqlDbType.Date).Value = InicioTecnomecanica;
            consulta.Parameters.Add("@finTecnomecanica", SqlDbType.Date).Value = FinTecnomecanica;
            consulta.Parameters.Add("@numDocumentoPropietario", SqlDbType.VarChar).Value = NumDocumentoPropietario;
            consulta.Parameters.Add("@primerNombre", SqlDbType.VarChar).Value = PrimerNombre;
            consulta.Parameters.Add("@segundoNombre", SqlDbType.VarChar).Value = SegundoNombre;
            consulta.Parameters.Add("@primerApellido", SqlDbType.VarChar).Value = PrimerApellido;
            consulta.Parameters.Add("@segundoApellido", SqlDbType.VarChar).Value = SegundoApellido;
            consulta.Parameters.Add("@celular", SqlDbType.VarChar).Value = Celular;
            consulta.Parameters.Add("@numDocumentoConductor", SqlDbType.VarChar).Value = numDocumentoIdentidadConductor;
            consulta.Parameters.Add("@licenciaDesde", SqlDbType.Date).Value = LicenciaDesde;
            consulta.Parameters.Add("@licenciaHasta", SqlDbType.Date).Value = LicenciaHasta;

            try
            {
                if(consulta.ExecuteNonQuery() >= 1)
                {
                    MessageBox.Show("Registro exitoso!");
                    return true;
                }
                else
                {
                    MessageBox.Show("Puede que no se haya registrado correctamente");
                    return false;
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return false;

            }
        }


        //Metodo para indicar que se quiere prestar servicio
        public bool prestarServicio()
        {
            SqlCommand consulta = new SqlCommand();
            consulta.Connection = usersConnect;
            consulta.Parameters.Add("@documento", SqlDbType.VarChar).Value = clsSesion.DocumentoSesion;
            consulta.CommandText = "UPDATE tblConductores SET activo='1' where numDocumentoIdentidad=@documento" ;
            try
            {
                if (consulta.ExecuteNonQuery() >= 1)
                {
                    MessageBox.Show("Te has puesto en servicio");
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

        //Metodo para dejar de prestar servicio
        public bool dejarServicio()
        {
            SqlCommand consulta = new SqlCommand();
            consulta.Connection = usersConnect;
            consulta.Parameters.Add("@documento", SqlDbType.VarChar).Value = clsSesion.DocumentoSesion;
            consulta.CommandText = "UPDATE tblConductores SET activo='0', solicitudActual=null where numDocumentoIdentidad=@documento";
            try
            {
                if (consulta.ExecuteNonQuery() >= 1)
                {
                    MessageBox.Show("Has dejado de estar en servicio");
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

        //Metodo para mostrar los conductores activos
        public DataTable infoConductor()
        {
            SqlCommand consulta = new SqlCommand();
            consulta.Connection = usersConnect;
            consulta.Parameters.Add("@idConductor", SqlDbType.Int).Value = idConductor;
            consulta.Parameters.Add("@solActual", SqlDbType.Int).Value = SolicitudActual;
            consulta.CommandText = "select * from tblConductores where solicitudActual=@solActual and idConductor=@idConductor";

            SqlDataReader listaConductoresActivos = consulta.ExecuteReader();
            DataTable infoConductoresActivos = new DataTable();
            infoConductoresActivos.Load(listaConductoresActivos);

            return infoConductoresActivos;
        }

        //Metodo para establecer si un conductor está o no en una solicitud
        public bool cambiarSolicitudConductor()
        {
            SqlCommand consulta = new SqlCommand();
            consulta.Connection = usersConnect;
            consulta.Parameters.Add("@idSol", SqlDbType.Int).Value = SolicitudActual;
            consulta.Parameters.Add("@documento", SqlDbType.VarChar).Value = clsSesion.DocumentoSesion;
            consulta.CommandText = "EXECUTE aceptarSolicitudUsuario @idSol,@documento";

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

        public DataTable conductoresSolicitud()
        {
            SqlCommand consulta = new SqlCommand();
            consulta.Connection = usersConnect;
            consulta.Parameters.Add("@solId", SqlDbType.Int).Value = SolicitudActual;
            consulta.CommandText = "select * from conductorSolicitud where solicitudActual=@solId order by calificacionPromedio DESC";

            SqlDataReader listaConductores = consulta.ExecuteReader();
            DataTable infoConductores = new DataTable();
            infoConductores.Load(listaConductores);

            return infoConductores;
        }
    }
}
