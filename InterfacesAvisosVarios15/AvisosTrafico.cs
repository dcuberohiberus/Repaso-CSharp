using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAvisosVarios15
{
    internal class AvisosTrafico : IAvisos
    {
        private string remitente, mensaje, fecha;

        public AvisosTrafico()
        {
            this.remitente = "DGT";
            this.mensaje = "Sanción cometida. Pague antes de 3 ´días y se beneficiará de una reducción en la sanción";
            this.fecha = "";
        }

        public AvisosTrafico(string remitente, string mensaje, string fecha)
        {
            this.remitente = remitente;
            this.mensaje = mensaje;
            this.fecha = fecha;
        }

        public string getFecha()
        {
            return fecha;
        }

        public void mostrarAviso()
        {
            Console.WriteLine("Mensaje {0} ha sido enviado por {1} el día {2}", mensaje, remitente, fecha);
        }



    }
}
