namespace Gimnasio;

public class Yoga : Actividad
{
    public string NombreProfesor {get; set;}

    public Yoga ( string nombre, int duracion, int maxparticipantes, string nombreprofesor) :base(nombre, duracion, maxparticipantes)
    {
        NombreProfesor = nombreprofesor;
    }
    public override string MostrarDetalles()
    {
        return $" Tiene de nombre {Nombre} y dura {Duracion} minutos y la clase tiene como maximo {MaxParticipantes} y la nombre del profesor es {NombreProfesor}";;
    }
}