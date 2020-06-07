using System;
using System.Collections.Generic;
using System.Text;

namespace CasoEstudio1
{
    class TipoNitrogeno:ProductoCongelado
    {
        protected string MtdoCongelacion { set; get; }
        protected double TiempoExpoNitrogeno { get; set; }
    }
}
