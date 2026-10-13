namespace Empresa;

public class Programadores : Empleado
{
    public string EditorDeCodigo;

    public Programadores (string nombre, int salario, string editordecodigo) :base(nombre, salario)
    {
        EditorDeCodigo = editordecodigo;
    }
    public override string MostrarInformacion()
    {
        return $"El programador con nombre {Nombre}, cobra un salario de {Salario} y su programa para editar codigo es {EditorDeCodigo}";
    }
}