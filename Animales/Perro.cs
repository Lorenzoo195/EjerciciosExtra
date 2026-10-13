using Animales;
namespace Animales;

public class Perro : Animal
{
    public int Patas { get; set; }
    public Perro(string nombre, int patas) : base(nombre)
    {
        Patas = patas;
    }
    public override string HacerSonido()
    {
        return "Guau";
    }
}