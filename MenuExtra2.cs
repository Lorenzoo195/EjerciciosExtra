namespace Menus;

using Parking;
using Producto;

public class MenuExtra2
{
    public void Iniciar()
    {
        List<Vehiculo> parking = GenerarVehiculosPrueba();
        List<Articulo> revista = GenerarArticulosPrueba();
        int opcion = 0;

        do
        {
            Console.WriteLine("\n=== PARKING ===");
            Console.WriteLine("1. Ver vehículos");
            Console.WriteLine("2. Buscar por matrícula");
            Console.WriteLine("3. Mostrar coches");
            Console.WriteLine("4. Mostrar los articulos con el precio mas bajo");
            Console.WriteLine("5. Mostrar el precio medio de los articulos");
            Console.WriteLine("0. Salir");
            Console.WriteLine("Selecciona una opción:");

            if (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 0 || opcion > 5)
            {
                Console.WriteLine("Error: selecciona una opción válida (0-5).");
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
                case 4:
                    BuscarArticuloMasBarato(revista);
                    break;
                case 5:
                    PrecioMedio(revista);
                    break;
                case 0:
                    Console.WriteLine("¡Hasta pronto!");
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

    private List<Articulo> GenerarArticulosPrueba()
    {
        return new List<Articulo>
        {
            new Articulo("Ratón", 15.99m),
            new Articulo("Cable USB", 4.50m),
            new Articulo("Teclado", 29.95m)
        };
    }

    private void BuscarArticuloMasBarato(List<Articulo> articulos)
    {
        Articulo masBarato = articulos[0];

        foreach (Articulo a in articulos)
        {
            if (a.Precio < masBarato.Precio)
            {
                masBarato = a;
            }
        }
        Console.WriteLine($"El artículo más barato es: {masBarato.Nombre} - {masBarato.Precio:C} ");
    }

    private void PrecioMedio(List<Articulo> articulos)
    {
        decimal suma = 0;
        int cont = 0;
        foreach (Articulo a in articulos)
        {
            suma += a.Precio;
            cont++;

        }
        decimal media = suma / cont;
        Console.WriteLine($"La media es: {media:C}");
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