namespace Gimnasio;

public class CrossTraining : Actividad
{
    public string LugarClase {get;set;}
    public CrossTraining (string nombre, int duracion, int maxparticipantes, string lugarclase ) :base(nombre, duracion, maxparticipantes)
    {
        LugarClase = lugarclase;
    }
        
    
    public override string MostrarDetalles()
    {
        return $" Tiene de nombre {Nombre} y dura {Duracion} minutos y la clase tiene como maximo {MaxParticipantes} y la ubicacion de la clase es: {LugarClase}";
    }
}