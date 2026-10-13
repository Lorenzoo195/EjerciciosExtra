namespace Empresa;

public abstract class Empleado
{
    public string Nombre;

    public int Salario;

    public Empleado (string nombre, int salario)
    {
        Nombre = nombre;
        Salario = salario;
    }

    public abstract string MostrarInformacion();
}