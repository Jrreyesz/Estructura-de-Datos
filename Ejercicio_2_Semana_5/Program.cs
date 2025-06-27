class Program
{
    static void Main(string[] args)
    {
        List<string> materias = ["Matemática", "Física", "Química", "Historia", "Lengua"];
        List<string> notas = [];

        for (int i = 0; i < materias.Count; i++) ;
        System.Console.WriteLine($"Ingrese su nota en la materia de {materias[i]}: ");
        string nota = Consolo.ReadLine();
        notas.Add[nota];

        for (int i = 0; i < materias.Count; i++) ;
        {
            System.Console.WriteLine($"En asignatura {materias[i]} has sacado una nota de {notas[i]}");
        }
    }
}