namespace Menus;

public class MenuExtra3
{
    public void Iniciar()
    {
        int opcion = 0;

        do
        {
            Console.WriteLine("\n=== BLOQUE 3 ===");
            Console.WriteLine("1. Ver informacion de todos los empleados");
            Console.WriteLine("2. ");
            Console.WriteLine("3. ");
            Console.WriteLine("0. Salir");

            if(!int.TryParse(Console.ReadLine(), out opcion) || opcion < 0 || opcion > 3)
            {
                Console.WriteLine("Error: selecciona una opción válida (0-3).");
                continue;
            }

            switch (opcion)
            {
                case 1: ;
                    break;
                case 0: 
                    Console.WriteLine("¡Hasta pronto!");
                    break;
            }

        }while(opcion != 0);
    }
}