using Videojuego;

public class MenuExtra
{
    private const int OpcionSalir = 0;

    public void Iniciar()
    {
        int opcion = -1;

        do
        {
            Console.WriteLine("\n========================");
            Console.WriteLine("    EJERCICIOS EXTRA    ");
            Console.WriteLine("========================");
            Console.WriteLine("1. Videojuego (Ejercicio 1)");
            Console.WriteLine("0. Salir");
            Console.WriteLine("Selecciona una opción:");

            if (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 0 || opcion > 1)
            {
                Console.WriteLine("Error: selecciona una opción válida (0-1).");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    EjecutarEjercicio1();
                    break;
                case OpcionSalir:
                    Console.WriteLine("¡Hasta pronto!");
                    break;
            }

        } while (opcion != OpcionSalir);
    }

    private void EjecutarEjercicio1()
    {
        Console.WriteLine("\n--- EJERCICIO 1 ---");
        List<Personaje> equipo = new List<Personaje>
        {
            new Guerrero("Conan", 100, 85),
            new Mago("Gandalf", 80, 200),
            new Arquero("Legolas", 90, 50)
        };

        foreach (Personaje p in equipo)
        {
            Console.WriteLine(p.ObtenerDescripcion());
        }
    }
}