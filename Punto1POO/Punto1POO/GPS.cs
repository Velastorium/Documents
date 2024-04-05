using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1POO
{
    internal class GPS
    {
        private int CordenadaX {  get; set; }
        private int CordenadaY { get; set;}
        private string FechaHora { get; set; }
        private int DiasTripulado  { get; set; }

        public GPS(int cordenadaX, int cordenadaY, string fechaHora, int diasTripulado)
        {
            CordenadaX = cordenadaX;
            CordenadaY = cordenadaY;
            FechaHora = fechaHora;
            DiasTripulado = diasTripulado;
        }
    }
}
/*Con los atributos: coordenadas en X, coordenada Y, fecha y hora de tipo String, días
tripulado tipo int.*/