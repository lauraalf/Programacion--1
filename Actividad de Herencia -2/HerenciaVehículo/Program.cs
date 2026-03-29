using System;

public class Vehiculo
{
    public string Marca { get; set; } = "";
    public Vehiculo(string marca)
    {
        Marca = marca;
    }
}

public class Automovil : Vehiculo
{
    public int Puertas { get; set; }
    public Automovil(string marca, int puertas) : base(marca)
    {
        Puertas = puertas;
    }
}

public class CocheDeportivo : Automovil
{
    public bool TieneTurbo { get; set; }
    public CocheDeportivo(string marca, int puertas, bool tieneTurbo) : base(marca, puertas)
    {
        TieneTurbo = tieneTurbo;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Al crear el coche deportivo, le pasamos la marca, las puertas y si tiene turbo
        CocheDeportivo miFerrari = new CocheDeportivo("Ferrari", 2, true);

        Console.WriteLine($"Marca del vehículo: {miFerrari.Marca}");
        Console.WriteLine($"Cantidad de puertas: {miFerrari.Puertas}");
        Console.WriteLine($"¿Tiene turbo?: {miFerrari.TieneTurbo}");

        Console.ReadLine();
    }
}