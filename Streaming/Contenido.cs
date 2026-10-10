namespace Streaming;

public abstract class Contenido
{
    public string Titulo { get; set; }
    public int Duracion { get; set; }

    public Contenido(string titulo, int duracion)
    {
        Titulo = titulo;
        Duracion = duracion;
    }

    public abstract string ObtenerDescripcion();
}