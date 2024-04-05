namespace Punto1POO
{
    internal class Principal
    {
        static void Main(string[] args)
        {
            Barco barco = new Barco("Rigel", "Exclusivo", 500, 1000);
            GPS gps = new GPS(453,231,"04.04.2024. 22.59",7);
            Capitan capitan = new Capitan(8000, 01234, 38, 8, "Simone Engrovic", "1234567890", 'M', barco);
            Jefe_De_Flota jefeDeFlota = new Jefe_De_Flota(893,18,2134,26,6,"Arthur Gendrovich","98765432",'M',barco);

            //Mostrar informacíon
            barco.MostrarDatos();
            capitan.MostrarDatos();
            jefeDeFlota.MostrarDatos();

            Marinero[] marineros = new Marinero[7];
            marineros[0] = new Marinero(20, 01, 23, 1, "Sasha Norman", "123456789", 'F', barco);
            marineros[1] = new Marinero(6, 02, 28, 6, "Enzo Varel", "234567891", 'M', barco);
            marineros[2] = new Marinero(4, 03, 34, 8, "Marco Diaz", "345678912", 'M', barco);
            marineros[3] = new Marinero(42, 04, 56, 15, "Keren Smith", "456789123", 'F', barco);
            marineros[4] = new Marinero(15, 05, 34, 3, "Lia Black", "567891234", 'F', barco);
            marineros[5] = new Marinero(30, 06, 32, 5, "Calum Riddle", "678912345", 'M', barco);
            marineros[6] = new Marinero(7, 07, 47, 13, "Remus Stewar", "789123456", 'F', barco);

            Console.WriteLine("\nInformación de los Marineros: ");
            int i = 1;
            foreach (var marinero in marineros)
            {
                Console.WriteLine($"\nMarinero N°{i}: ");
                marinero.MostrarDatos();
                i++;
            }
            Console.ReadLine();
        }
    }
}
