namespace Parking;

public abstract class Parking
{
    public string Matricula;
    public string Marca;

    public Parking (string matricula, string marca)
    {
        Matricula = matricula;
        Marca = marca;
    }

    public abstract string MostrarDetalles();
}