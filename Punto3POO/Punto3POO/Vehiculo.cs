using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3POO
{
    internal class Vehiculo
    {
        public string matricula;
        public double velocidad;

        public Vehiculo(string matricula, double velocidad)
        {
            matricula = matricula;
            velocidad = 0.0;
        }

        public virtual void Acelerar(double incremento)
        {
            velocidad += incremento;
        }

        public override string ToString()
        {
            return $"Matricula: {matricula} \nVelocidad: {velocidad}";
        }
    }
}
