namespace Streaming;

public class Serie : Contenido
{
    public int NumeroTemporadas { get; set; }

    public Serie(string titulo, int duracion, int temporadas) : base(titulo, duracion)
    {
        NumeroTemporadas = temporadas;
    }

    public override string ObtenerDescripcion()
    {
        return $"Serie: '{Titulo}' con {NumeroTemporadas} temporadas ({Duracion} min por capítulo).";
    }
}
