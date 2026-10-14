namespace Menus;

using Empresa;
using Animales;

public class MenuExtra3
{
    public void Iniciar()
    {
        int opcion = 0;
        List<Empleado> equipo = GenerarEmpleadosPrueba();
        List<Animal> zoo = GenerarAnimalesPrueba();
        do
        {
            Console.WriteLine("\n=== BLOQUE 3 ===");
            Console.WriteLine("1. Ver informacion de todos los empleados");
            Console.WriteLine("2. Ver informacion de los animales");
            Console.WriteLine("3. Cajero Automatico");
            Console.WriteLine("4. Adivina el numero secreto");
            Console.WriteLine("0. Salir");

            if (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 0 || opcion > 4)
            {
                Console.WriteLine("Error: selecciona una opción válida (0-4).");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    VerEmpleados(equipo);
                    break;
                case 2:
                    VerAnimales(zoo);
                    break;
                case 3:
                    MenuCajero cajero = new MenuCajero();
                    cajero.Iniciar();
                    break;
                case 4:
                    AdivinaElNumero();
                    break;
                case 0:
                    Console.WriteLine("¡Hasta pronto!");
                    break;
            }

        } while (opcion != 0);
    }

    private List<Empleado> GenerarEmpleadosPrueba()
    {
        return new List<Empleado>
        {
            new Programadores("Carlos", 2800, "Visual Studio Code"),
            new Programadores("Lucía", 3200, "Rider"),
            new Diseñadores("Marta", 2500, "Azul marino"),
            new Diseñadores("Álvaro", 2400, "Verde lima"),
            new Responsables("Elena", 4200, 8)
        };
    }

    private List<Animal> GenerarAnimalesPrueba()
    {
        return new List<Animal>
        {
             new Perro("Toby", 4),
            new Perro("Rex", 4),
            new Gato("Luna", "Siamés"),
            new Gato("Misi", "Persa"),
            new Pajaro("Piolín", 25)
        };
    }

    private void VerEmpleados(List<Empleado> equipo)
    {
        Console.WriteLine("\n--- EMPLEADOS DE LA EMPRESA ---");
        foreach (Empleado v in equipo)
        {
            Console.WriteLine(v.MostrarInformacion());
        }
    }

    private void VerAnimales(List<Animal> zoo)
    {
        Console.WriteLine("\n--- Comportamiento de los animales del zoo ---");
        foreach (Animal a in zoo)
        {
            Console.WriteLine($"{a.Nombre}: {a.HacerSonido()}");
        }
    }
    public void AdivinaElNumero()
    {
        Random random = new Random();
        int numSecreto = random.Next(1, 101); //int numSecreto = Random.Shared.Next(1, 101);
        int contIntentos = 0;
        int intento = 0;
        do
        {
            Console.Write("Adivina el número (1-100): ");
            if (int.TryParse(Console.ReadLine(), out  intento))
            {
                contIntentos++;
                if (intento < numSecreto)
                {
                    Console.WriteLine("El número es mayor.");
                }
                else if (intento > numSecreto)
                {
                    Console.WriteLine("El número es menor.");
                }
                else
                {
                    Console.WriteLine($"Correcto. Has necesitado {contIntentos} intentos.");
                }
            }
            else
            {
                Console.WriteLine("Error: introduce un número válido.");
            }
        } while (intento != numSecreto);
    }
}