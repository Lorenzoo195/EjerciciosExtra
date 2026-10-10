namespace Biblioteca;

public class Revista : Publicacion
{
    public int Numero;

    public Revista (string titulo, int year, int numero) :base (titulo, year)
    {
        Numero = numero;
    }
    public override string ObtenerDescripcion()
    {
        return $"La publicacion es una revista llamada {Titulo} del año {Year} con numero {Numero}";
    }
}