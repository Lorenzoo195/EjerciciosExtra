namespace Streaming;

public class Pelicula : Contenido
{
    public string Director { get; set; }

    public Pelicula(string titulo, int duracion, string director) : base(titulo, duracion)
    {
        Director = director;
    }

    public override string ObtenerDescripcion()
    {
        return $"Película: '{Titulo}' dirigida por {Director} ({Duracion} min).";
    }
}
