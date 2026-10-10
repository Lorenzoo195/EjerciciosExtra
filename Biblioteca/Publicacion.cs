namespace Biblioteca;

public abstract class Publicacion
{
    public string Titulo {get; set;}
    public int Year{get; set;}

    public Publicacion(string titulo, int year)
    {
        Titulo = titulo;
        Year = year;
    }

    public abstract string ObtenerDescripcion();
}