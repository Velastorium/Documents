using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3POO
{
    internal class JefeZona : Empleado
    {
        private int despacho;
        private Secretario secretario;
        private List<Vendedor> vendedores;
        private Coche coche;

        public JefeZona(string nombre, double salario, int despacho) : base(nombre, salario)
        {
            vendedores = new List<Vendedor>();
        }

        public void CambiarSecretario(Secretario nuevoSecretario)
        {
            secretario = nuevoSecretario;
        }

        public void CambiarCoche(Coche nuevoCoche)
        {
            coche = nuevoCoche;
        }

        public void DarAltaVendedor(Vendedor nuevoVendedor)
        {
            vendedores.Add(nuevoVendedor);
        }

        public void DarBajaVendedor(Vendedor vendedor)
        {
            vendedores.Remove(vendedor);
        }

        public override void IncrementarSalario(double porcentaje)
        {
            base.IncrementarSalario(0.20);
        }
    }
}
