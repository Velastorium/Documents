using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1POO
{
    internal class Barco
    {
        private String Nombre { get; set; }
        private String Tipo { get; set; }
        private int Capacidad_Pasajero { get; set; }
        private int Capacidad_Carga { get; set; }

        public Barco(string nombre, string tipo, int capacidad_Pasajero, int capacidad_Carga)
        {
            Nombre = nombre;
            Tipo = tipo;
            Capacidad_Pasajero = capacidad_Pasajero;
            Capacidad_Carga = capacidad_Carga;
        }

        public void MostrarDatos()
        {
            Console.WriteLine("\nDatos del barco:");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Tipo: {Tipo}");
            Console.WriteLine($"Capacidad de pasajeros: {Capacidad_Pasajero}");
            Console.WriteLine($"Capacidad de carga: {Capacidad_Carga}");
        }
    }
}
/*
 * Con los atributos: Nombre y tipo de tipo String, Capacidad de pasajero y capacidad de carga tipo int.
 * Método para mostrar todos los datos del barco
 */