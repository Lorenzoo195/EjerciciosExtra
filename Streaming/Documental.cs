namespace Streaming;

public class Documental : Contenido
{
    public string Tematica { get; set; }

    public Documental(string titulo, int duracion, string tematica) : base(titulo, duracion)
    {
        Tematica = tematica;
    }

    public override string ObtenerDescripcion()
    {
        return $"Documental de {Tematica}: '{Titulo}' ({Duracion} min).";
    }
}
