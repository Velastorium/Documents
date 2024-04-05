using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1POO
{
    internal abstract class Tripulante
    {
        public int NumeroCarnet {  get; set; }
        public int Edad { get; set; }
        public int TiempoEnEmpresa { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public char Sexo { get; set; }
        public Barco Barco { get; set; }

        public Tripulante(int numeroCarnet, int edad, int tiempoEnEmpresa, string nombre, string telefono, char sexo, Barco barco)
        {
            NumeroCarnet = numeroCarnet;
            Edad = edad;
            TiempoEnEmpresa = tiempoEnEmpresa;
            Nombre = nombre;
            Telefono = telefono;
            Sexo = sexo;
            Barco = barco;
        }

        public abstract float Sueldo();
        public abstract void MostrarDatos();
    }
}
/*El mismo debe tener los siguientes atributos: número carnet, edad, tiempo en la empresa
de tipos int; nombre y teléfono tipo String, sexo tipo char, barco de tipo barco
 Métodos abstractos sueldo y mostrar datos
 El método sueldo se calculará según el rango de cada tripulante en el barco
 El método mostrar dato deberá mostrar todos los datos (atributos) según la clase
derivada.*/