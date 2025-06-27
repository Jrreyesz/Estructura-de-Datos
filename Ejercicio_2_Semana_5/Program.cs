class Program
{
    static void Main(string[] args)
    {
        List<string> materias = ["Matemática", "Física", "Química", "Historia", "Lengua"];
        List<string> notas = [];

        for (int i = 0; i < materias.Count; i++)
        {
            System.Console.WriteLine($"Ingrese su nota en la materia de {materias[i]}: ");
            string nota = Console.ReadLine();
            notas.Add(nota);
        }

        for (int i = 0; i < materias.Count; i++)
        {
            System.Console.WriteLine($"En {materias[i]} has sacado {notas[i]}");
        }

    }
}