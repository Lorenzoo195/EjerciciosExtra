namespace Parking;

public abstract class Vehiculo
{
    public string Matricula;
    public string Marca;

    public Vehiculo (string matricula, string marca)
    {
        Matricula = matricula;
        Marca = marca;
    }

    public abstract string MostrarDetalles();
}