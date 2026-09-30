namespace Videojuego;
public abstract class Personaje
{
    public string Nombre {get; set;}
    public int Vida {get; set;}

    public Personaje (string nombre, int vida){
        Nombre = nombre;
        Vida = vida;
    }
    public abstract string ObtenerDescripcion();
}