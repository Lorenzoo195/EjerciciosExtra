namespace Empresa;

public class Diseñadores : Empleado
{
    public string ColorCorporativo;

    public Diseñadores (string nombre, int salario, string colorcorporativo) :base(nombre, salario)
    {
        ColorCorporativo = colorcorporativo;
    }

    public override string MostrarInformacion()
    {
        return $"El diseñador {Nombre} cobra un salario de {Salario} y tienen como color corporativo: {ColorCorporativo}";
    }
}