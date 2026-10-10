namespace Videojuego;

public class Arquero : Personaje
{
    public int NumeroFlechas {get; set;}

    public Arquero (string nombre, int vida, int numflechas) : base(nombre, vida)
    {
        NumeroFlechas = numflechas;
    }

    public override string ObtenerDescripcion()
    {
       return $"El arquero tiene estas flechas {NumeroFlechas}";
    }
}