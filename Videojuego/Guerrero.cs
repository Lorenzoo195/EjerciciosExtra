namespace Videojuego;

public class Guerrero : Personaje
{
    public int Fuerza {get; set;}

    public Guerrero(string nombre, int vida, int fuerza) : base(nombre, vida)
    {
        Fuerza = fuerza;
    }

    public override string ObtenerDescripcion()
    {
        return $" El guerrero tiene esta fuerza {Fuerza}.";
    }
}