namespace Gimnasio;

public class DiaGimnasio
{
    public List<Actividad> Actividades {get; set;} = new();

    public DateTime FechaHoy {get; set;}

    public DiaGimnasio()
    {
        FechaHoy = DateTime.Now;
    }

    public void AnadirActividad (Actividad actividad)
    {
        Actividades.Add(actividad);
    }

}