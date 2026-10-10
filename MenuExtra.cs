using Videojuego;
using Streaming;
using Biblioteca;

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

    private List<Publicacion> GenerarPublicacionesPrueba()
    {
        return new List<Publicacion>
        {
             new Libro("Don Quijote de la Mancha", 1605, "Miguel de Cervantes"),
            new Libro("Cien Años de Soledad", 1967, "Gabriel García Márquez"),
            new Revista("National Geographic", 2026, 125),
            new Revista("Muy Interesante", 2025, 450),
            new Comic("Spiderman", 1962, "Steve Ditko")
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
            Console.WriteLine("3. Buscar por titulo (Ejercicio 3)");
            Console.WriteLine("4. Buscar peliculas (Ejercicio 4)");
            Console.WriteLine("5. Mostrar todas la publicaciones (Ejercicio 5)");
            Console.WriteLine("6. Mostrar publicaciones posteriores al año: (Ejercicio 6)");
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
                case 5:
                    EjecutarEjercicio5();
                    break;
                case 6:
                    EjecutarEjercicio6();
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
        Console.WriteLine("\n--- EJERCICIO 3:Titulo a buscar: ---");

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
        Console.WriteLine("\n--- EJERCICIO 4:Buscar las peliculas del catalogo: ---");

        List<Contenido> catalogo = GenerarCatalogoPrueba();

        foreach (Contenido c in catalogo)
        {
            if (c is Pelicula)
            {
                Console.WriteLine(c.ObtenerDescripcion());
            }
        }
    }

    private void EjecutarEjercicio5()
    {
        Console.WriteLine("\n--- EJERCICIO 5:Mostrar todas las publicaciones ---");

        List<Publicacion> publicacions = GenerarPublicacionesPrueba();

        foreach (Publicacion p in publicacions)
        {
            Console.WriteLine(p.ObtenerDescripcion());
        }

    }

    private void EjecutarEjercicio6()
    {
        Console.WriteLine("Dame un año y te dare las publicaciones posteriores");
        if (int.TryParse(Console.ReadLine(), out int dato))
        {
            List<Publicacion> publicacions = GenerarPublicacionesPrueba();
            foreach (Publicacion p in publicacions)
            {
                if (p.Year > dato)
                {
                    Console.WriteLine(p.ObtenerDescripcion());
                }

            }
        } else
        {
            Console.WriteLine("Error: no es un valor valido");
        }
    }

}