using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3POO
{
    internal class Coche : Vehiculo
    {
        public string marca { get; set; }
        public int modelo { get; set; }
        int numeroPuertas { get; set; }

        public Coche(string matricula, string marca, int modelo, int numeroPuertas, double velocidad) : base(matricula, velocidad) 
        {
            this.matricula = matricula;
            this.marca = marca;
            this.modelo = modelo;
            this.numeroPuertas = numeroPuertas;
            this.velocidad = 0.0;
        }

        public override string ToString()
        {
            return $"Matricula: {matricula} \nMarca: {marca} \nModelo: {modelo} \nVelocidad: {velocidad}";
        }
    }
}
