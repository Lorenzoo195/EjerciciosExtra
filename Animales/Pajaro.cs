using Animales;
namespace Animales;

public class Pajaro : Animal
{
    public int Velocidad { get; set; }

    public Pajaro (string nombre, int velocidad) : base (nombre)
    {
        Velocidad = velocidad;
    }

    public override string HacerSonido()
    {
        return "Pio Pio";
    }
}