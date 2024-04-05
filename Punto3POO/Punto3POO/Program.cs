namespace Punto3POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear instancias de objetos
            JefeZona jefe = new JefeZona("Juan", 5000, 101);
            Secretario secretario = new Secretario("Ana", 2500);
            Coche coche = new Coche("ABC123", "Toyota", 2022, 4, 0);
            Vendedor vendedor1 = new Vendedor("Pedro", 2000);
            Vendedor vendedor2 = new Vendedor("Maria", 2000);

            // Cambiar secretario y coche del jefe de zona
            jefe.CambiarSecretario(secretario);
            jefe.CambiarCoche(coche);

            // Dar de alta vendedores
            jefe.DarAltaVendedor(vendedor1);
            jefe.DarAltaVendedor(vendedor2);

            // Incrementar salario del jefe de zona
            jefe.IncrementarSalario(10); // Supongamos que el jefe recibe un aumento del 10%

            // Imprimir datos del jefe de zona
            Console.WriteLine("Datos del Jefe de Zona:");
            jefe.ImprimirDatos();

            // Imprimir datos del secretario
            Console.WriteLine("\nDatos del Secretario:");
            secretario.ImprimirDatos();

            // Imprimir datos del coche
            Console.WriteLine("\nDatos del Coche:");
            Console.WriteLine(coche.ToString());

            // Imprimir datos de los vendedores
            Console.WriteLine("\nDatos de los Vendedores:");
            vendedor1.ImprimirDatos();
            vendedor2.ImprimirDatos();

            // Ejemplo de manejo de excepción
            try
            {
                // Intentar acelerar un camión con remolque más de lo permitido
                Camion camion = new Camion("XYZ789", 0);
                Remolque remolque = new Remolque(500);
                camion.PonerRemolque(remolque);
                camion.Acelerar(110); // Esto debería lanzar una excepción
            }
            catch (DemasiadoRapidoException e)
            {
                Console.WriteLine("\n¡Error! " + e.Message);
            }
        }
    }
}
