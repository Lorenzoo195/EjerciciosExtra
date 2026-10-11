namespace Parking;

public class Moto : Vehiculo
{
    public int Ruedas;

    public Moto (string matricula, string marca, int ruedas): base(matricula, marca)
    {
        Ruedas = ruedas;
    }

    public override string MostrarDetalles()
    {
        return $"La moto con matricula {Matricula} y marca {Marca} tiene {Ruedas} ruedas";
    }
}