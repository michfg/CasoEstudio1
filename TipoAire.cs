using System;
using System.Collections.Generic;
using System.Text;

namespace CasoEstudio1
{
    class TipoAire:ProductoCongelado
    {
        protected double PorcentajeNitrogeno { get; set; }
        protected double PorcentajeOxigeno { get; set; }
        protected double PorcentajeDioxido { get; set; }
        protected double PorcentajeVapor { get; set; }
    }
}
