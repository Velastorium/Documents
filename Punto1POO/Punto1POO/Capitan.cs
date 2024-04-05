using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1POO
{
    internal class Capitan : Tripulante
    {
        private int HorasDeExperiencia { get; set; }
        private const float Sueldoo = 4500000;
        private float SueldoTotal { get; set; }
        private float Bono { get; set; }

        public Capitan(int horasDeExperiencia,int numeroCarnet, int edad, int tiempoEnEmpresa, string nombre, string telefono, char sexo, Barco barco) : base(numeroCarnet, edad, tiempoEnEmpresa, nombre, telefono, sexo, barco)
        {
            HorasDeExperiencia = horasDeExperiencia;
        }

        public float CalcularBono()
        {
            if (HorasDeExperiencia >= 5000 && HorasDeExperiencia < 150000)
                Bono = Sueldoo * 0.2f;
            else if (HorasDeExperiencia >= 150000 && HorasDeExperiencia < 300000)
                Bono = Sueldoo * 0.4f;
            else if (HorasDeExperiencia >= 300000)
                Bono = Sueldoo * 0.75f;
            else
                Bono = 0;
            return Bono;
        }

        public override float Sueldo()
        {
            SueldoTotal = Sueldoo + CalcularBono();
            return SueldoTotal;
        }

        public override void MostrarDatos()
        {
            Console.WriteLine("\nInformacíon del Capitán");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Número de Carnet: {NumeroCarnet}");
            Console.WriteLine($"Barco: {Barco}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"Tiempo en la empresa: {TiempoEnEmpresa} años");
            Console.WriteLine($"Teléfono: {Telefono}");
            Console.WriteLine($"Sexo: {Sexo}");
            Console.WriteLine($"Horas de experiencia: {HorasDeExperiencia}");
            Console.WriteLine($"Bono: {CalcularBono()}");
            Console.WriteLine($"Sueldo Total: {Sueldo()}");
        }

    }
}
/* Atributos horas de experticia tipo int, constante sueldo de 4.500.000, sueldo total y bono
tipo float.
 Método propio para calcular el bono de la siguiente manera:
▪ Si las horas de experticia es mayor igual a 5000 y menor a 150000 tendrá un bono del
20%.
▪ Si las horas de experticia es mayor igual a 150000 y menor a 300000 tendrá un bono del
40%. Y si es mayor a 300000 será un 75% de bono
▪ Su sueldo total se calculará: sueldo más bono.
 */