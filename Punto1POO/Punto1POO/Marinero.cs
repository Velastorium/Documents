using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Punto1POO
{
    internal class Marinero : Tripulante
    {
        private int PesoTotalPescado {  get; set; }
        private const float Sueldoo = 90000;
        private float SueldoTotal {  get; set; }
        private float Bono{ get; set; }

        public Marinero(int pesoTotalPescado, int numeroCarnet, int edad, int tiempoEnEmpresa, string nombre, string telefono, char sexo, Barco barco) : base(numeroCarnet, edad, tiempoEnEmpresa, nombre, telefono, sexo, barco)
        {
            PesoTotalPescado = pesoTotalPescado;
        }

        public float CalcularBono()
        {
            if (PesoTotalPescado >= 1)
            {
                Bono = Sueldoo * 0.25f;
            }
            else
            {
                Bono = 0;
            }
            return Bono;
        }

        public override float Sueldo()
        {
            SueldoTotal = Sueldoo + CalcularBono();
            return SueldoTotal;
        }

        public override void MostrarDatos()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Número de Carnet: {NumeroCarnet}");
            Console.WriteLine($"Barco: {Barco}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"Tiempo en la empresa: {TiempoEnEmpresa} años");
            Console.WriteLine($"Teléfono: {Telefono}");
            Console.WriteLine($"Sexo: {Sexo}");
            Console.WriteLine($"Peso total del pescado: {PesoTotalPescado}");
            Console.WriteLine($"Sueldo Total: {Sueldo()}");
        }
    }
}
/*Atributos peso total pescado tipo int, constante sueldo de 90.000, sueldo total y bono tipo
float.
 Método propio para calcular el bono de la siguiente manera:
▪ Si la cantidad pescada es mayor o igual a 1 se multiplicará por 0.25
▪ Su sueldo total se calculará: sueldo más bonos.*/