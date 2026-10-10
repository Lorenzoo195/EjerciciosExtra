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
       return $"Soy {Nombre}, un Mago con {Vida} puntos de vida y mi maná es {Mana}.";
    }
}