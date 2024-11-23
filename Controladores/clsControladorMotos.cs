using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using FB.Modelo;
using System.Windows.Forms;

namespace FB.Controladores
{
    class clsControladorMotos
    {
        private clsMoto moto;

        public clsControladorMotos(string placa, string marcaMoto, string modeloMoto, string lineaMoto, string color, int cilindraje, string numChasis, string numMotor)
        {
            moto = new clsMoto(placa, marcaMoto, modeloMoto, lineaMoto, color, cilindraje, numChasis, numMotor);
        }
        public clsControladorMotos(string numeroMatricula, bool motoPropia, DateTime inicioSOAT, DateTime finSOAT, DateTime inicioTecnomecanica, DateTime finTecnomecanica)
        {
            moto = new clsMoto(numeroMatricula, motoPropia, inicioSOAT, finSOAT, inicioTecnomecanica, finTecnomecanica);
        }

        public clsControladorMotos(string numDocumento, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, string celular)
        {
            moto = new clsMoto(numDocumento, primerNombre, segundoNombre, primerApellido, segundoApellido, celular);
        }

        public bool ejecutarIngresarDetallesMoto()
        {
           if(moto.registrarDetallesMoto())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ejecutarRegistrarPapeles()
        {
            if (moto.registrarPapelesMoto())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        
    }
}
