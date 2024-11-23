using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FB.Modelo
{
    class clsConexion
    {
        private static SqlConnection dbConnection;

        private static string host = "desarrollo-kevin.database.windows.net";
        private static string database = "dboFastBike";
        private static string security = "integrated security=false";
        private static string user = "Dylan";
        private static string password = "#Cavesandcliffspart2";

        public static SqlConnection dbConnect()
        {
            if(dbConnection == null)
            {
                dbConnection = new SqlConnection($"server={host};database={database};{security};user={user};password={password}");
                try
                {
                    dbConnection.Open();
                    return dbConnection;
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                    return null;
                }
            }
            else
            {
                return dbConnection;
            }
             
        }
    }
}
