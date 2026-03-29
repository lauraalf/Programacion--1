using System;

public abstract class Figura
{
    public string Color { get; set; } = "";
    public abstract double CalcularArea();
}

public class Circulo : Figura
{
    public double Radio { get; set; }

    public override double CalcularArea()
    {
        return Math.PI * (Radio * Radio);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Circulo miCirculo = new Circulo();
        miCirculo.Color = "Rojo";
        miCirculo.Radio = 5.5;

        // Usamos :F2 para redondear el resultado a 2 decimales
        Console.WriteLine($"El círculo de color {miCirculo.Color} tiene un área de: {miCirculo.CalcularArea():F2}");

        Console.ReadLine();
    }
}