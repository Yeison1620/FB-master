using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FB.Modelo;

namespace FB.Controladores
{
    class clsControladorReportes
    {
        private clsReporte reporte;
        public clsControladorReportes(string docReportante, string docReportado, string descripcion)
        {
            reporte = new clsReporte(docReportante, docReportado, descripcion);
        }

        public bool ejecutarNuevoReporte()
        {
            if (reporte.crearReporte())
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
