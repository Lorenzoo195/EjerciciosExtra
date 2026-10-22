namespace Gimnasio;

public class Spinning : Actividad
{
    public string MarcaBici {get;set;}



    public Spinning (string nombre, int duracion, int maxparticipantes, string marcabici) :base(nombre, duracion, maxparticipantes)
    {
        MarcaBici = marcabici;
    }
    public override string MostrarDetalles()
    {
        return  $" Tiene de nombre {Nombre} y dura {Duracion} minutos y la clase tiene como maximo {MaxParticipantes} y la marca de la bicicleta {MarcaBici}";
    }
}