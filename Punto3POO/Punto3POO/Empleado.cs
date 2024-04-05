using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3POO
{
    internal class Empleado
    {
        private string nombre;
        private double salario;

        public Empleado(string nombre, double salario)
        {
            this.Nombre = nombre;
            this.Salario = salario;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public double Salario { get => salario; set => salario = value; }

        public virtual void IncrementarSalario(double porcentaje)
        {
            Salario *= (1 + porcentaje / 100);
        }

        public void ImprimirDatos()
        {
            Console.WriteLine($"Nombre: {Nombre} \nSalario: {Salario}");
        }
    }
}
