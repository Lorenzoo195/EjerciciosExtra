namespace Menus;

public class MenuCajero
{
    private decimal Saldo = 1000;

    public void Iniciar()
    {
        int opcion = 0;

        do
        {
            Console.WriteLine("\n=== CAJERO ===");
            Console.WriteLine("1. Consultar saldo ");
            Console.WriteLine("2. Ingresar dinero");
            Console.WriteLine("3. Retirar dinero");
            Console.WriteLine("0. Salir");



            if (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 0 || opcion > 3)
            {
                Console.WriteLine("Error: selecciona una opción válida (0-3).");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    ConsultarSaldo();
                    break;
                case 2:
                    IngresarDinero();
                    break;
                case 3:
                    RetirarDinero();
                    break;
                case 0:
                    Console.WriteLine("¡Hasta pronto!");
                    break;
            }
        } while (opcion != 0);
    }

    public void ConsultarSaldo()
    {
        Console.WriteLine($"\nSu saldo es de {Saldo:C}");
    }

    public void IngresarDinero()
    {
        Console.WriteLine("Dinero que se quiere ingresar");
        if(decimal.TryParse(Console.ReadLine(), out decimal cantidad) && cantidad > 0)
        {
            Saldo += cantidad;
            Console.WriteLine($"Ingreso correcto. Tu saldo actual es de {Saldo:C}");
        }
        else
        {
            Console.WriteLine("Cantidad invalida");
        }
    }

    public void RetirarDinero()
    {
        Console.WriteLine("Dinero que se quiere retirar");
        if(decimal.TryParse(Console.ReadLine(), out decimal retiro) && retiro >0 && retiro <= Saldo)
        {
            Saldo -= retiro;
        } else
        {
            Console.WriteLine("Retiro invalido");
        }
    }
}