namespace Gimnasio;

public abstract class Actividad
{
    public string Nombre { get; set; }

    public int Duracion { get; set; }

    public int MaxParticipantes { get; set; }

    public Actividad(string nombre, int duracion, int maxparticipantes)
    {
        Nombre = nombre;
        Duracion = duracion;
        MaxParticipantes = maxparticipantes;
    }

    public abstract string MostrarDetalles();

}