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
        return $"La furgoneta con matricula {Matricula} y marca {Marca} pesa {Peso}Kg";
    }
}
