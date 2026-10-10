namespace Videojuego;

public class Mago : Personaje
{
    int Mana {get; set;} 

    public Mago (string nombre, int vida, int mana) :base ( nombre, vida)
    {
        Mana = mana;
    }
    public override void ObtenerDescripcion()
    {
        Console.WriteLine($"El mago tiene este mana {Mana}");
    }
}