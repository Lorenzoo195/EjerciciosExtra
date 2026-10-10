using Videojuego;
using Streaming;

public class MenuExtra
{
    private const int OpcionSalir = 0;

    private List<Contenido> GenerarCatalogoPrueba()
    {
        return new List<Contenido>
    {
        new Pelicula("El Padrino", 175, "Francis Ford Coppola"),
        new Pelicula("Interstellar", 169, "Christopher Nolan"),
        new Serie("Breaking Bad", 47, 5),
        new Serie("Stranger Things", 50, 4),
        new Documental("Planeta Tierra", 60, "Naturaleza")
    };
    }

    public void Iniciar()
    {
        int opcion = 0;

        do
        {
            Console.WriteLine("\n========================");
            Console.WriteLine("    EJERCICIOS EXTRA    ");
            Console.WriteLine("========================");
            Console.WriteLine("1. Videojuego (Ejercicio 1)");
            Console.WriteLine("2. Streaming (Ejercicio 2)");
            Console.WriteLine("0. Salir");
            Console.WriteLine("Selecciona una opción:");

            if (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 0 || opcion > 2)
            {
                Console.WriteLine("Error: selecciona una opción válida (0-2).");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    EjecutarEjercicio1();
                    break;
                case 2:
                    EjecutarEjercicio2();
                    break;
                case 3:
                    EjecutarEjercicio3();
                    break;
                case 4:
                    EjecutarEjercicio4();
                    break;
                case OpcionSalir:
                    Console.WriteLine("¡Hasta pronto!");
                    break;
            }

        } while (opcion != OpcionSalir);
    }

    private void EjecutarEjercicio1()
    {
        Console.WriteLine("\n--- EJERCICIO 1: VIDEOJUEGO ---");
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

    private void EjecutarEjercicio2()
    {
        Console.WriteLine("\n--- EJERCICIO 2: STREAMING ---");

        List<Contenido> catalogo = GenerarCatalogoPrueba();
        foreach (Contenido c in catalogo)
        {
            Console.WriteLine(c.ObtenerDescripcion());
        }
    }

    private void EjecutarEjercicio3()
    {
        Console.WriteLine("Titulo a buscar: ");

        List<Contenido> catalogo = GenerarCatalogoPrueba();


        string textoBusqueda = Console.ReadLine().ToLower();
        bool encontrado = false;

        foreach (Contenido c in catalogo)
        {
            if (c.Titulo.ToLower().Contains(textoBusqueda))
            {
                Console.WriteLine("\nContenido encontrado:");
                Console.WriteLine($"{c.Titulo} - {c.Duracion} minutos");
                encontrado = true;
            }
        }
        if (!encontrado)
        {
            Console.WriteLine("\nNo se ha encontrado ningún contenido con ese título.");
        }
    }

    private void EjecutarEjercicio4()
    {
        Console.WriteLine("Buscar las peliculas del catalogo: ");

        List<Contenido> catalogo = GenerarCatalogoPrueba();

        foreach (Contenido c in catalogo)
        {
            if (c is Pelicula)
            {
                Console.WriteLine(c.ObtenerDescripcion());
            }
        }
    }
}