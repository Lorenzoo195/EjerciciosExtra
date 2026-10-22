using Gimnasio;

namespace Menus;

public class MenuGimnasio
{
    public void Iniciar()
    {
        int opcion = 0;
        List<Actividad> gimnasio = GenerarClasesPrueba();
        do
        {
            Console.WriteLine("\n=== GIMNASIO ===");
            Console.WriteLine("1. Ver actividades");
            Console.WriteLine("2. Buscar actividad");
            Console.WriteLine("3. Ver actividades por duración máxima");
            Console.WriteLine("4. Ver actividades por tipo");
            Console.WriteLine("0. Salir");

            if (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 0 || opcion > 4)
            {
                Console.WriteLine("Error: selecciona una opción válida (0-4).");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    VerActividades(gimnasio);
                    break;

                case 2:
                    BuscarActividad(gimnasio);
                    break;

                case 3:
                    ActividadPorDuracionMax(gimnasio);
                    break;

                case 4:
                    VerActividadesPorTipo(gimnasio);
                    break;

                case 0:
                    Console.WriteLine("Saliendo del gimnasio...");
                    break;
            }

        } while (opcion != 0);
    }

    private List<Actividad> GenerarClasesPrueba()
    {
        return new List<Actividad>
        {
            new Spinning("Spinning Matutino", 45, 20, "BH Fitness"),
            new Spinning("Power Spinning", 50, 15, "Technogym"),
            new Yoga("Hatha Yoga", 60, 12, "Laura"),
            new Yoga("Yoga Suave", 40, 10, "Marcos"),
            new CrossTraining("WOD Fuerza", 60, 16, "Box Exterior")
        };
    }

    private void VerActividades(List<Actividad> gimnasio)
    {
        Console.WriteLine("\n--- TODAS LAS ACTIVIDADES ---");
        foreach (Actividad a in gimnasio)
        {
            Console.WriteLine(a.MostrarDetalles());
        }
    }

    private void BuscarActividad(List<Actividad> gimnasio)
    {
        Console.Write("\nNombre de la actividad a buscar: ");
        string texto = Console.ReadLine();
        bool encontrado = false;

        foreach (Actividad a in gimnasio)
        {
            if (a.Nombre.ToLower().Contains(texto.ToLower()))
            {
                Console.WriteLine(a.MostrarDetalles());
                encontrado = true;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("No se ha encontrado ninguna actividad con ese nombre.");
        }
    }

    private void ActividadPorDuracionMax(List<Actividad> gimnasio)
    {
        Console.Write("\nIntroduce la duración máxima (minutos): ");
        if (int.TryParse(Console.ReadLine(), out int maxMinutos) && maxMinutos > 0)
        {
            bool encontrado = false;
            foreach (Actividad a in gimnasio)
            {
                if (a.Duracion <= maxMinutos)
                {
                    Console.WriteLine(a.MostrarDetalles());
                    encontrado = true;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("No se encontraron actividades con esa duración o menor.");
            }
        }
        else
        {
            Console.WriteLine("Error: introduce un número válido mayor que 0.");
        }
    }

    private void VerActividadesPorTipo(List<Actividad> gimnasio)
    {
        Console.WriteLine("\n¿Qué tipo de actividad deseas ver?");
        Console.WriteLine("1. Spinning");
        Console.WriteLine("2. Yoga");
        Console.WriteLine("3. CrossTraining");
        Console.Write("Selecciona una opción: ");

        if (int.TryParse(Console.ReadLine(), out int tipo))
        {
            bool encontrado = false;
            foreach (Actividad a in gimnasio)
            {
                if (tipo == 1 && a is Spinning)
                {
                    Console.WriteLine(a.MostrarDetalles());
                    encontrado = true;
                }
                else if (tipo == 2 && a is Yoga)
                {
                    Console.WriteLine(a.MostrarDetalles());
                    encontrado = true;
                }
                else if (tipo == 3 && a is CrossTraining)
                {
                    Console.WriteLine(a.MostrarDetalles());
                    encontrado = true;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("No se encontraron actividades de ese tipo o la opción no es válida.");
            }
        }
        else
        {
            Console.WriteLine("Error: opción no válida.");
        }
    }
}
