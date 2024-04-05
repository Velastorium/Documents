namespace Punto2POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Empleado
            Empleado supervisor = new Empleado("Ariana", "Smith", "12345678A", "Calle #123", 5, "123456789", 3000, null);

            //Secretario
            Secretario secretario = new Secretario("Despacho 1", "987654321", "Alec", "Herondale", "87654321B", "Calle #456", 3, "987654321", 2000, supervisor);
            Console.WriteLine("Datos del Secretario:");
            Console.WriteLine(secretario.ToString());

            // Incrementar salario del secretario
            secretario.IncrementarSalarioAnual();
            Console.WriteLine("\nSalario - Aumento anual:");
            Console.WriteLine(secretario.ToString());

            //Vendedor
            Vendedor vendedor = new Vendedor("1234ABC", "Toyota", "Corolla", "654321987", "Zona Norte", 5, "Dylan", "Riddle", "7654321C", "Calle #789", 2, "654321987", 1500, supervisor);
            Console.WriteLine("\nDatos del Vendedor:");
            Console.WriteLine(vendedor.ToString());

            // Dar de alta un nuevo cliente al vendedor
            vendedor.AltaCliente("Sabrina");

            // Cambiar coche del vendedor
            vendedor.CambiarCoche("5678DEF", "Honda", "Civic");
            vendedor.IncrementarSalarioAnual();
            Console.WriteLine("\nDatos del Vendedor después de cambios:");
            Console.WriteLine(vendedor.ToString());

        }
    }
}
