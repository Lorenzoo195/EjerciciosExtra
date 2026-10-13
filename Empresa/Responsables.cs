namespace Empresa;

public class Responsables : Empleado
{
    public int NumEmpleadosEquipo;

    public Responsables (string nombre, int salario, int numempleadosequipo) :base(nombre, salario)
    {
        NumEmpleadosEquipo = numempleadosequipo;
    }
    public override string MostrarInformacion()
    {
        return $"El responsable con nombre {Nombre} cobra {Salario} y tiene {NumEmpleadosEquipo} de personal en su equipo";
    }
}