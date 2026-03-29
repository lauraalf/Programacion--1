using System;

public interface IVolador
{
    void Volar();
}

public interface INadador
{
    void Nadar();
}

public class Animal
{
    public string Nombre { get; set; } = "";
}

public class Pato : Animal, IVolador, INadador
{
    public void Volar()
    {
        Console.WriteLine($"{Nombre} está volando por el cielo.");
    }

    public void Nadar()
    {
        Console.WriteLine($"{Nombre} está nadando en el lago.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Pato lucas = new Pato();
        lucas.Nombre = "Pato Lucas";

        // Ejecutamos las acciones que provienen de las interfaces
        lucas.Volar();
        lucas.Nadar();

        Console.ReadLine();
    }
}