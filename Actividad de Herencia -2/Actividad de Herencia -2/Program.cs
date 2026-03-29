using System;

// 1. Clase Base (El molde principal)
public class Persona
{
    // Le ponemos = "" al final para evitar el error de que el Nombre esté nulo
    public string Nombre { get; set; } = "";

    public void Saludar()
    {
        Console.WriteLine($"Hola, mi nombre es {Nombre}");
    }
}

// 2. Clase Derivada (Hereda de Persona)
public class Estudiante : Persona
{
    public string Matricula { get; set; } = "";

    public void Estudiar()
    {
        Console.WriteLine($"El estudiante {Nombre} con matrícula {Matricula} está estudiando.");
    }
}

// 3. Programa principal
class Program
{
    static void Main(string[] args)
    {
        // Creamos un nuevo estudiante en la memoria
        Estudiante miEstudiante = new Estudiante();

        // Le asignamos el Nombre y la Matrícula
        miEstudiante.Nombre = "Carlos";
        miEstudiante.Matricula = "25-0001";

        // Usamos el método que heredó de Persona
        miEstudiante.Saludar();

        // Usamos su propio método de Estudiante
        miEstudiante.Estudiar();

        // Pausamos la consola para poder ver el resultado
        Console.ReadLine();
    }
}