using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FB.Modelo
{
    static class clsSesion
    {
        //private static string emailSesion;
        private static string documentoSesion;
        private static string primerNombre;
        private static string primerApellido;
        private static string segundoNombre;
        private static string segundoApellido;
        private static string celular;

        private static string pais;
        private static string estado;
        private static string ciudad;
        private static bool ofreciendoServicio;
        private static string placaMoto;
        private static string direccionRecogida;
        private static string direccionDestino;
        private static DateTime fechaUltimaSolicitud;

        private static int solicitudActual;
        private static int idConductor;

        public static string DocumentoSesion { get => documentoSesion; set => documentoSesion = value; }
        public static string PrimerNombre { get => primerNombre; set => primerNombre = value; }
        public static string PrimerApellido { get => primerApellido; set => primerApellido = value; }
        public static string Pais { get => pais; set => pais = value; }
        public static string Estado { get => estado; set => estado = value; }
        public static string Ciudad { get => ciudad; set => ciudad = value; }
        public static bool OfreciendoServicio { get => ofreciendoServicio; set => ofreciendoServicio = value; }
        public static string PlacaMoto { get => placaMoto; set => placaMoto = value; }
        public static string SegundoNombre { get => segundoNombre; set => segundoNombre = value; }
        public static string SegundoApellido { get => segundoApellido; set => segundoApellido = value; }
        public static string Celular { get => celular; set => celular = value; }
        public static string DireccionRecogida { get => direccionRecogida; set => direccionRecogida = value; }
        public static string DireccionDestino { get => direccionDestino; set => direccionDestino = value; }
        public static DateTime FechaUltimaSolicitud { get => fechaUltimaSolicitud; set => fechaUltimaSolicitud = value; }
        public static int SolicitudActual { get => solicitudActual; set => solicitudActual = value; }
        public static int IdConductor { get => idConductor; set => idConductor = value; }
    }

   
}
