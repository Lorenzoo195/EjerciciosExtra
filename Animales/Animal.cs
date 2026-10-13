namespace Animales;

public abstract class Animal
{
    public string Nombre;

    public Animal(string nombre)
    {
        Nombre = nombre;
    }

    public abstract string HacerSonido();
}