using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Punto2POO
{
    internal class Empleado
    {
        private string Nombre {  get; set; }
        private string Apellidos { get; set; }
        private string DNI { get; set; }
        private string Direccion { get; set; }
        private int AniosAntiguedad { get; set; }
        private string Telefono { get; set; }
        public double Salario { get; set; }
        private Empleado Supervisor { get; set; }

        public Empleado(string nombre, string apellidos, string dNI, string direccion, int aniosAntiguedad, string telefono, double salario, Empleado supervisor)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            DNI = dNI;
            Direccion = direccion;
            AniosAntiguedad = aniosAntiguedad;
            Telefono = telefono;
            Salario = salario;
            Supervisor = supervisor;
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre} {Apellidos}\n" +
                   $"DNI: {DNI}\n" +
                   $"Dirección: {Direccion}\n" +
                   $"Teléfono: {Telefono}\n" +
                   $"Salario: {Salario}\n" +
                   $"Supervisor: {(Supervisor != null ? Supervisor.Nombre : "Ninguno")}";
        }

        public void CambiarSupervisor(Empleado nuevoSupervisor)
        {
            Supervisor = nuevoSupervisor;
        }

        public void IncrementarSalario(double aumento)
        {
            Salario += aumento;
        }
    }
}

/*Clase básica que describe a un empleado. Incluye sus datos personales
(nombre, apellidos, DNI, dirección) y algunos datos tales como los años de antigüedad,
teléfono de contacto y su salario. Incluye también información de quién es el empleado
que lo supervisa (Empleado *). Tendrá, al menos, las siguientes funciones miembro:
• Constructores para definir correctamente un empleado, a partir de su nombre,
apellidos, DNI, dirección, teléfono y salario.

• Imprimir (A través de los operadores de E/S redefinidos)
• Cambiar supervisor
• Incrementar salario*/