using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Punto2POO
{
    internal class Secretario : Empleado
    {
        private string Despacho {  get; set; }
        private string NumFax { get; set; }

        public Secretario(string despacho, string numFax, string nombre, string apellidos, string dNI, string direccion, int aniosAntiguedad, string telefono, double salario, Empleado supervisor) : base(nombre, apellidos, dNI, direccion, aniosAntiguedad, telefono, salario, supervisor)
        {
            Despacho = despacho;
            NumFax = numFax;
        }
        public override string ToString()
        {
            return base.ToString() + $"\nDespacho: {Despacho}\nNúmero de Fax: {NumFax}\nPuesto: Secretario";
        }
        public void IncrementarSalarioAnual()
        {
            double aumento = Salario * 0.05;
            IncrementarSalario(aumento);
        }
    }
}
/*Tiene despacho, número de fax e incrementa su salario un 5% anual. Tendrá,
al menos, las siguientes funciones miembro:
• Constructores (debe rellenar la información personal y los datos principales)
• Imprimir (debe imprimir sus datos personales y su puesto en la empresa).*/