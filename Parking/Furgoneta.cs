namespace Parking;

public class Furgoneta : Vehiculo
{
    public int Peso;

    public Furgoneta (string matricula, string marca, int peso) : base (matricula, marca)
    {
        Peso = peso;
    }

    public override string MostrarDetalles()
    {
        return $"El coche con matricula {Matricula} y marca {Marca} pesa {Peso}Kg";
    }
}
