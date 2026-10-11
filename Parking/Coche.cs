namespace Parking;

public class Coche : Vehiculo
{
    public int Potencia;

    public Coche (string matricula, string marca, int potencia) : base (matricula, marca)
    {
        Potencia = potencia;
    }

    public override string MostrarDetalles()
    {
        return $"El coche con matricula {Matricula} y marca {Marca} tiene {Potencia}CV";
    }
}
