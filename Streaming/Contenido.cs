namespace Streaming;

public abstract class Contenido
{
    public string Titulo;
    public int duracion;

    public abstract string ObtenerDescripcion();
}