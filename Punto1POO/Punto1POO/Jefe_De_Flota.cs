using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1POO
{
    internal class Jefe_De_Flota : Tripulante
    {
        private int PesoPescado {  get; set; }
        private int PesoMariscos { get; set; }
        private const float Sueldoo = 350000000;
        private float SueldoTotal { get; set; }
        private float BonoPescado { get; set; }
        private float BonoMariscos { get; set; }

        public Jefe_De_Flota(int pesoPescado, int pesoMariscos, int numeroCarnet, int edad, int tiempoEnEmpresa, string nombre, string telefono, char sexo, Barco barco) : base(numeroCarnet, edad, tiempoEnEmpresa, nombre, telefono, sexo, barco)
        {
            PesoPescado = pesoPescado;
            PesoMariscos = pesoMariscos;
        }

        public float CalcularBonos()
        {
            BonoPescado = PesoPescado * 1;
            BonoMariscos = PesoMariscos * 2;
            return BonoMariscos + BonoPescado;
            
        }


        public override float Sueldo()
        {
            SueldoTotal = Sueldoo + CalcularBonos();
            return SueldoTotal;
        }

        public override void MostrarDatos()
        {
            Console.WriteLine("\nInformacíon del Jefe de flota");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Número de Carnet: {NumeroCarnet}");
            Console.WriteLine($"Barco: {Barco}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"Tiempo en la empresa: {TiempoEnEmpresa} años");
            Console.WriteLine($"Teléfono: {Telefono}");
            Console.WriteLine($"Sexo: {Sexo}");
            Console.WriteLine($"Valor total en bonos: {CalcularBonos()}");
            Console.WriteLine($"Sueldo Total: {Sueldo()}");
        }
    }
}
/*Atributos peso Pescado y peso mariscos tipo int, constante sueldo de 350.000.000, sueldo
total y bono pescado y bono mariscos tipo float.
 Método propio para calcular los bonos de la siguiente manera:
▪ Si son pescados, se multiplicará la cantidad 1 y si son mariscos por 2.
▪ Su sueldo total se calculará: sueldo más bonos.
 */