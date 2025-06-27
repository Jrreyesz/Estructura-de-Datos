class Program
{
    static void Main(string[] args)
    {
        //Creamos una lista de materias
        List<string> asignaturas = ["Matemática", "Física", "Química", "Historia", "Lengua"];

        //Con un bucle for imprimimos cada asignatura
        foreach (var asignatura in asignaturas)
        {
            System.Console.WriteLine($"Materia: {asignatura}");
        }
    }
}