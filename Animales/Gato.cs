using Animales;
namespace Animales;

public class Gato : Animal
{
    public string Raza { get; set; }

    public Gato (string nombre, string raza) : base(nombre)
    {
        Raza = raza;
    }
    public override string HacerSonido()
    {
        return "Miau";
    }
}