namespace Menus;

using Parking;

public class MenuExtra2
{
    public void Iniciar()
    {
        List<Vehiculo> parking = GenerarVehiculosPrueba();
        int opcion = 0;

        do
        {
            Console.WriteLine("\n=== PARKING ===");
            Console.WriteLine("1. Ver vehículos");
            Console.WriteLine("2. Buscar por matrícula");
            Console.WriteLine("3. Mostrar coches");
            Console.WriteLine("0. Salir");
            Console.WriteLine("Selecciona una opción:");

            if (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 0 || opcion > 3)
            {
                Console.WriteLine("Error: selecciona una opción válida (0-3).");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    VerVehiculos(parking);
                    break;
                case 2:
                    BuscarPorMatricula(parking);
                    break;
                case 3:
                    MostrarCoches(parking);
                    break;
                case 0:
                    Console.WriteLine("Saliendo del parking...");
                    break;
            }

        } while (opcion != 0);
    }

    private List<Vehiculo> GenerarVehiculosPrueba()
    {
        return new List<Vehiculo>
        {
            new Coche("1234-BBB", "Seat", 110),
            new Coche("5678-CCC", "Audi", 150),
            new Moto("9999-XYZ", "Yamaha", 2),
            new Furgoneta("4321-FFF", "Renault", 2200)
        };
    }

    private void VerVehiculos(List<Vehiculo> vehiculos)
    {
        Console.WriteLine("\n--- VEHÍCULOS EN EL PARKING ---");
        foreach (Vehiculo v in vehiculos)
        {
            Console.WriteLine(v.MostrarDetalles());
        }
    }

    private void BuscarPorMatricula(List<Vehiculo> vehiculos)
    {
        Console.Write("\nIntroduce la matrícula a buscar: ");
        string matriculaBuscada = Console.ReadLine();
        bool encontrado = false;

        foreach (Vehiculo v in vehiculos)
        {
            if (v.Matricula.ToLower() == matriculaBuscada.ToLower())
            {
                Console.WriteLine("\nVehículo encontrado:");
                Console.WriteLine(v.MostrarDetalles());
                encontrado = true;
                break;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("No existe ningún vehículo con esa matrícula.");
        }
    }

    private void MostrarCoches(List<Vehiculo> vehiculos)
    {
        Console.WriteLine("\n--- COCHES EN EL PARKING ---");
        foreach (Vehiculo v in vehiculos)
        {
            if (v is Coche)
            {
                Console.WriteLine(v.MostrarDetalles());
            }
        }
    }
}