namespace Biblioteca;

public class Libro : Publicacion 
{
    public string Autor{get; set;}

    public Libro (string titulo, int year, string autor) : base(titulo, year)
    {
        Autor = autor;
    }

    public override string ObtenerDescripcion()
    {
        return $"La publicacion es un libro llamado {Titulo} del año {Year} del autor {Autor}";
    }
}