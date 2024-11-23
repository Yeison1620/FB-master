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
    class clsMoto
    {
        private SqlConnection usersConnect = clsConexion.dbConnect();

        private string numeroMatricula;
        private string placaMoto;
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

        private string numDocumento;
        private string primerNombre;
        private string segundoNombre;
        private string primerApellido;
        private string segundoApellido;
        private string celular;

        public string NumeroMatricula { get => numeroMatricula; set => numeroMatricula = value; }
        public string PlacaMoto { get => placaMoto; set => placaMoto = value; }
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
        public string NumDocumento { get => numDocumento; set => numDocumento = value; }
        public string PrimerNombre { get => primerNombre; set => primerNombre = value; }
        public string SegundoNombre { get => segundoNombre; set => segundoNombre = value; }
        public string PrimerApellido { get => primerApellido; set => primerApellido = value; }
        public string SegundoApellido { get => segundoApellido; set => segundoApellido = value; }
        public string Celular { get => celular; set => celular = value; }

        public clsMoto(string numeroMatricula, bool motoPropia, DateTime inicioSOAT, DateTime finSOAT, DateTime inicioTecnomecanica, DateTime finTecnomecanica)
        {
            NumeroMatricula = numeroMatricula;
            MotoPropia = motoPropia;
            InicioSOAT = inicioSOAT;
            FinSOAT = finSOAT;
            InicioTecnomecanica = inicioTecnomecanica;
            FinTecnomecanica = finTecnomecanica;
        }

        public clsMoto(string placa, string marcaMoto, string modeloMoto, string lineaMoto, string color, int cilindraje, string numChasis, string numMotor)
        {
            PlacaMoto = placa;
            MarcaMoto = marcaMoto;
            ModeloMoto = modeloMoto;
            LineaMoto = lineaMoto;
            Color = color;
            Cilindraje = cilindraje;
            NumChasis = numChasis;
            NumMotor = numMotor;
        }
        public clsMoto(string numDocumento, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, string celular)
        {
            NumDocumento = numDocumento;
            PrimerNombre = primerNombre;
            SegundoNombre = segundoNombre;
            PrimerApellido = primerApellido;
            SegundoApellido = segundoApellido;
            Celular = celular;
        }

        public bool registrarDetallesMoto()
        {
            SqlCommand consulta = new SqlCommand();
            consulta.Connection = usersConnect;
            consulta.CommandText = "insert into tblDetallesMoto values (@placa, @marca, @modelo, " +
                "@linea, @color, @cilindraje, @numChasis, @numMotor)";
            consulta.Parameters.Add("@placa", SqlDbType.VarChar).Value = PlacaMoto;
            consulta.Parameters.Add("@marca", SqlDbType.VarChar).Value = MarcaMoto;
            consulta.Parameters.Add("@modelo", SqlDbType.VarChar).Value = ModeloMoto;
            consulta.Parameters.Add("@linea", SqlDbType.VarChar).Value = LineaMoto;
            consulta.Parameters.Add("@color", SqlDbType.VarChar).Value = Color;
            consulta.Parameters.Add("@cilindraje", SqlDbType.Int).Value = Cilindraje;
            consulta.Parameters.Add("@numChasis", SqlDbType.VarChar).Value = NumChasis;
            consulta.Parameters.Add("@numMotor", SqlDbType.VarChar).Value = NumMotor;
            try
            {
                if (consulta.ExecuteNonQuery() == 1)
                {
                    clsSesion.PlacaMoto = PlacaMoto;
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
        public bool registrarPapelesMoto()
        {
            SqlCommand consulta = new SqlCommand();
            consulta.Connection = usersConnect;
            consulta.CommandText = "insert into tblPapelesMoto values (@numMatricula, @placa, @propio," +
                "@inicioSOAT, @finSOAT, @inicioTecno, @finTecno)";
            consulta.Parameters.Add("@numMatricula", SqlDbType.VarChar).Value = NumeroMatricula;
            consulta.Parameters.Add("@placa", SqlDbType.VarChar).Value = clsSesion.PlacaMoto;
            consulta.Parameters.Add("@propio", SqlDbType.Bit).Value = MotoPropia;
            consulta.Parameters.Add("@inicioSOAT", SqlDbType.Date).Value = InicioSOAT;
            consulta.Parameters.Add("@finSOAT", SqlDbType.Date).Value = FinSOAT;
            consulta.Parameters.Add("@inicioTecno", SqlDbType.Date).Value = InicioTecnomecanica;
            consulta.Parameters.Add("@finTecno", SqlDbType.Date).Value = FinTecnomecanica;
            
            try
            {
                if (consulta.ExecuteNonQuery() == 1)
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

      
    }
}
