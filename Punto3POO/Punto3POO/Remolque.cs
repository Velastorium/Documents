using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3POO
{
    internal class Remolque
    {
        private int peso;

        public Remolque(int peso)
        {
            this.peso = peso;
        }

        public override string ToString()
        {
            return $"Remolque - Peso: {peso} kg";
        }
    }
}
