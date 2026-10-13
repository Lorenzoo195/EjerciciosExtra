namespace Menus;

using Empresa;

public class MenuExtra3
{
    public void Iniciar()
    {
        int opcion = 0;
        List<Empleado> equipo = GenerarEmpleadosPrueba();
        do
        {
            Console.WriteLine("\n=== BLOQUE 3 ===");
            Console.WriteLine("1. Ver informacion de todos los empleados");
            Console.WriteLine("2. Ver informacion de la plantilla");
            Console.WriteLine("3. ");
            Console.WriteLine("0. Salir");

            if(!int.TryParse(Console.ReadLine(), out opcion) || opcion < 0 || opcion > 3)
            {
                Console.WriteLine("Error: selecciona una opción válida (0-3).");
                continue;
            }

            switch (opcion)
            {
                case 1: 
                    VerEmpleados(equipo);
                    break;
                case 0: 
                    Console.WriteLine("¡Hasta pronto!");
                    break;
            }

        }while(opcion != 0);
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

    private void VerEmpleados(List<Empleado> equipo)
    {
        Console.WriteLine("\n--- EMPLEADOS DE LA EMPRESA ---");
        foreach (Empleado v in equipo)
        {
            Console.WriteLine(v.MostrarInformacion());
        }
    }
}