using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2POO
{
    internal class Vendedor : Empleado
    {
        private string NumMatricula {  get; set; }
        private string Marca { get; set; }
        private string Modelo { get; set; }
        private string TelMovil { get; set; }
        private string AreaVenta { get; set; }
        private List<string> Clientes;
        public double PorcentajeComision { get; set; }

        public Vendedor(string numMatricula, string marca, string modelo, string telMovil, string areaVenta, double porcentajeComision, string nombre, string apellidos, string dNI, string direccion, int aniosAntiguedad, string telefono, double salario, Empleado supervisor) : base(nombre, apellidos, dNI, direccion, aniosAntiguedad, telefono, salario, supervisor)
        {
            NumMatricula = numMatricula;
            Marca = marca;
            Modelo = modelo;
            TelMovil = telMovil;
            AreaVenta = areaVenta;
            Clientes = new List<string>();
            PorcentajeComision = porcentajeComision;
        }
        public override string ToString()
        {
            return base.ToString() + $"\nCoche de la empresa: {Marca} {Modelo}, Matrícula: {NumMatricula}\nTeléfono Móvil: {TelMovil}\nÁrea de Venta: {AreaVenta}\nPorcentaje de Comisión: {PorcentajeComision}%\nPuesto: Vendedor";
        }

        public void AltaCliente(string clientes) 
        {
            Clientes.Add(clientes);
        }
        public void DeBajaCliente(string clientes)
        {
            Clientes.Remove(clientes);
        }
        public void CambiarCoche(string nuevaMatricula, string nuevaMarca, string nuevoModelo)
        {
            NumMatricula = nuevaMatricula;
            Marca = nuevaMarca;
            Modelo = nuevoModelo;
        }

        public void IncrementarSalarioAnual()
        {
            double aumento = Salario * 0.10;
            IncrementarSalario(aumento);
        }
    }
}
/*Vendedor. Tiene coche de la empresa (identificado por la matricula, marca y modelo),
teléfono móvil, área de venta, lista de clientes y porcentaje que se lleva de las ventas en
concepto de comisiones. Incrementa su salario un 10% anual. Tendrá, al menos, las
siguientes funciones miembro:
• Constructores (debe rellenar la información personal y los datos principales)
• Imprimir (debe imprimir sus datos personales y su puesto en la empresa).
• Dar de alta un nuevo cliente.
• Dar de baja un cliente.
• Cambiar de coche.*/