namespace Videojuego;

public class Mago : Personaje
{
    public int Mana {get; set;} 

    public Mago (string nombre, int vida, int mana) :base ( nombre, vida)
    {
        Mana = mana;
    }
    public override string ObtenerDescripcion()
    {
       return  $"El mago tiene este mana {Mana}";
    }
}