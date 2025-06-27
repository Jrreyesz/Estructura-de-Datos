class Program
{
    static void Main(string[] args)
    {
        List<string> asignaturas = ["Matemática", "Física", "Química", "Historia", "Lengua"];

        System.Console.WriteLine($"Lista de materias: {asignaturas}");

        foreach (var asignatura in asignaturas)
        {
            System.Console.WriteLine($"Materia: {asignatura}");
        }
    }
}