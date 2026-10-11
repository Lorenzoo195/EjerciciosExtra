using Menus;


int opcion = -1;
do
{
    Console.WriteLine("\n=== PANEL PRINCIPAL DE EJERCICIOS ===");
    Console.WriteLine("1. Bloque 1 (Ejercicios 1 al 6)");
    Console.WriteLine("2. Bloque 2 (Ejercicios 7 al 20)");
    Console.WriteLine("0. Salir de la aplicación");
    Console.Write("Selecciona qué bloque quieres abrir: ");

    if (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 0 || opcion > 2)
    {
        Console.WriteLine("Error: selecciona una opción válida (0-2).");
        continue;
    }
    switch (opcion)
    {
        case 1:
            MenuExtra menu1 = new MenuExtra();
            menu1.Iniciar();
            break;
        case 2:
            MenuExtra2 menu2 = new MenuExtra2();
            menu2.Iniciar();
            break;
        case 0:
            Console.WriteLine("Cerrando la aplicación...");
            break;
    }
}while (opcion != 0);
