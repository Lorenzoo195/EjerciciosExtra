namespace Biblioteca;

public class Comic : Publicacion
{
    public string Dibujante {get; set;}
    public Comic(string titulo, int year, string dibujante ) : base(titulo, year)
    {
        Dibujante = dibujante;
    }

    public override string ObtenerDescripcion()
    {
        return $"La publicacion es un comic llamado {Titulo} del año {Year} del dibujante {Dibujante}";
    }
}