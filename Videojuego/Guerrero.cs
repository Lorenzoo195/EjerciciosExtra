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
        return $"Soy {Nombre}, un Guerrero con {Vida} puntos de vida y mi fuerza es {Fuerza}.";
    }
}