using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using FB.Modelo;

namespace FB.Controladores
{
    class clsControladorConductores
    {
        private clsConductor conductor;
        public clsControladorConductores(string numDoc, DateTime inicioLicencia, DateTime finLicencia)
        {
            conductor = new clsConductor(numDoc, inicioLicencia, finLicencia);
        }
        public clsControladorConductores()
        {
            conductor = new clsConductor();
        }
        public clsControladorConductores(int idConductor, int idSol)
        {
            conductor = new clsConductor(idConductor,idSol);
        }
        public clsControladorConductores(int idSol)
        {
            conductor = new clsConductor(idSol);
        }
        public clsControladorConductores(string placaMoto, string numDocumentoIdentidad, DateTime licenciaDesde, DateTime licenciaHasta, string numeroMatricula, bool motoPropia, DateTime inicioSOAT, DateTime finSOAT, DateTime inicioTecnomecanica, DateTime finTecnomecanica, string marcaMoto, string modeloMoto, string lineaMoto, string color, int cilindraje, string numChasis, string numMotor, string numDocumento, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, string celular)
        {
            conductor = new clsConductor(placaMoto, numDocumentoIdentidad, licenciaDesde, licenciaHasta, numeroMatricula, motoPropia, inicioSOAT, finSOAT, inicioTecnomecanica, finTecnomecanica, marcaMoto, modeloMoto, lineaMoto, color, cilindraje, numChasis, numMotor, numDocumento, primerNombre, segundoNombre, primerApellido, segundoApellido, celular);
        
        }

        public bool ejecutarRegistrarComoConductor()
        {
            if (conductor.registrarComoConductor())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        
        
        public bool ejecutarPrestarServicio()
        {
            if (conductor.prestarServicio())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ejecutarDejarServicio()
        {
            if (conductor.dejarServicio())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable ejecutarInfoConductor()
        {
            return conductor.infoConductor();
        }
        public bool ejecutarCambiarSolicitudConductor()
        {
            if(conductor.cambiarSolicitudConductor())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable ejecutarConductoresSolicitud()
        {
            return conductor.conductoresSolicitud();
        }
    }
}
