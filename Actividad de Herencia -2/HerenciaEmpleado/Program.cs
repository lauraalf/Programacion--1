using System;

public class Empleado
{
    public string Nombre { get; set; } = "";
    public double SalarioBase { get; set; }

    public virtual double CalcularBono()
    {
        return SalarioBase * 0.10;
    }
}

public class Gerente : Empleado
{
    public override double CalcularBono()
    {
        return SalarioBase * 0.30;
    }
}

public class Programador : Empleado
{
    public override double CalcularBono()
    {
        return SalarioBase * 0.15;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Gerente jefa = new Gerente();
        jefa.Nombre = "Laura";
        jefa.SalarioBase = 2000;

        Programador dev = new Programador();
        dev.Nombre = "Pedro";
        dev.SalarioBase = 1000;

        Console.WriteLine($"{jefa.Nombre} (Gerente) tiene un bono de: ${jefa.CalcularBono()}");
        Console.WriteLine($"{dev.Nombre} (Programador) tiene un bono de: ${dev.CalcularBono()}");

        Console.ReadLine();
    }
}