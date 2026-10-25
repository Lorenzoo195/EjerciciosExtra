using System.Text.Json.Serialization;

namespace Gimnasio;

[JsonPolymorphic(TypeDiscriminatorPropertyName = "$tipo")]
[JsonDerivedType(typeof(Spinning), "spinning")]
[JsonDerivedType(typeof(Yoga), "yoga")]
[JsonDerivedType(typeof(CrossTraining), "crossTraining")]

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

    public Actividad() {}

    public abstract string MostrarDetalles();

}