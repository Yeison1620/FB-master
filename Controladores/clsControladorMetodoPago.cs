using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using FB.Modelo;

namespace FB.Controladores
{
    class clsControladorMetodoPago
    {
        clsMetodoPago metodoPago;
        public clsControladorMetodoPago(string numDocumentoIdentidad, string numeroTarjeta, string vencimiento, string tipoTarjeta,string concepto, string codigoSeguridad, string codigoPostal)
        {
            metodoPago = new clsMetodoPago(numDocumentoIdentidad,numeroTarjeta,vencimiento,tipoTarjeta,concepto,codigoSeguridad,codigoPostal);
        }

        public clsControladorMetodoPago(int idMetodoPago, string numeroTarjeta, string vencimiento, string tipoTarjeta,string concepto, string codigoSeguridad, string codigoPostal)
        {
            metodoPago = new clsMetodoPago(idMetodoPago, numeroTarjeta, vencimiento,tipoTarjeta ,concepto, codigoSeguridad, codigoPostal);

        }
        public clsControladorMetodoPago(string numDocumentoIdentidad)
        {
            metodoPago = new clsMetodoPago(numDocumentoIdentidad);
        }

        public DataTable ejecutarConsultarMetodosPago()
        {
            return metodoPago.consultarMetodosUsuario();
        }

        public bool ejecutarAgregarMetodoPago()
        {
            if (metodoPago.agregarMetodoPago())
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
