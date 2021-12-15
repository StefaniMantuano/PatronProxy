using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StefaniaMantuano_PatronProxy
{
    class ProxyServidor:Servidor
    {
        MiServidor miServidor;
        private int puerto;
        private String host;

        public ProxyServidor(int p,String h)
        {
            puerto = p;
            host = h;
            miServidor = null;
        }
        public override string descargar(String url)
        {
            string resultado = String.Empty;
            if (restringido(url))
            {
                if (miServidor == null)
                    miServidor = new MiServidor( puerto, host);

                resultado= miServidor.descargar(url);
            }
            else
                resultado= "Desde esta ubicación no puedes descargar.";


            return resultado;
        }


        public Boolean restringido(string ruta)
        {
            Boolean descargaPermitida = false;
            if (ruta == "Descarga Permitida")
                descargaPermitida = true;   
            return descargaPermitida;
        }
    }
}
