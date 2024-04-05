using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3POO
{
    internal class DemasiadoRapidoException : Exception
    {
        public DemasiadoRapidoException(string mensaje) : base(mensaje)
        {
        }
    }
}
