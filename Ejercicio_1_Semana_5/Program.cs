class Program
{
    static void Main(string[] args)
    {
        List<string> asignaturas = ["Matemática", "Física", "Química", "Historia", "Lengua"];

        foreach (var asignatura in asignaturas)
        {
            System.Console.WriteLine($"Materia: {asignatura}");
        }
    }
}