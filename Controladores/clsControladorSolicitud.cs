using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FB.Modelo;
using System.Data;


namespace FB.Controladores
{
    class clsControladorSolicitud
    {
        private clsSolicitud solicitud;

        public clsControladorSolicitud(decimal precioSolicitado, string recogida, string destino)
        {
            solicitud = new clsSolicitud(precioSolicitado, recogida, destino);
        }

        public clsControladorSolicitud()
        {
            solicitud = new clsSolicitud(clsSesion.FechaUltimaSolicitud);
        }
        public clsControladorSolicitud(int idSol, int idConductor)
        {
            solicitud = new clsSolicitud(idSol, idConductor);
        }
        public clsControladorSolicitud(int idSol)
        {
            solicitud = new clsSolicitud(idSol);
        }

        public bool ejecutarCrearSolicitud()
        {
            if (solicitud.crearSolicitud())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ejecutarCancelarSolicitud()
        {
            if (solicitud.cancelarSolicitud())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ejecutarInterrumpirSolicitud()
        {
            if (solicitud.interrumpirSoliciutd())
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        public bool ejecutarAceptarConductorSolicitud()
        {
            if (solicitud.aceptarConductorSolicitud())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable ejecutarConsultarSolicitud()
        {
            return solicitud.consultarSolicitud();
        }
       
        public bool ejecutarClienteRecogido()
        {
            if (solicitud.clienteRecogido())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ejecutarConfirmarRecogida()
        {
            if (solicitud.confirmarRecogida())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ejecutarLlegarDestino()
        {
            if (solicitud.llegarDestino())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ejecutarConfirmarLlegarDestino()
        {
            if (solicitud.confirmarLlegarDestino())
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
