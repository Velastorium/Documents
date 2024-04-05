using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3POO
{
    internal class Camion : Vehiculo
    {
        private Remolque remolque;

        public Camion(string matricula, double velocidad) : base(matricula, velocidad)
        {
            this.matricula = matricula;
            this.velocidad = 0.0;
        }

        public override void Acelerar(double incremento)
        {
            if (remolque != null && velocidad + incremento > 100.0)
            {
                throw new DemasiadoRapidoException("El camión con remolque no puede acelerar tanto");
            }
            velocidad += incremento;
        }

        public void PonerRemolque(Remolque remolque)
        {
            this.remolque = remolque;
        }

        public void QuitarRemolque()
        {
            remolque = null;
        }
    }
}
