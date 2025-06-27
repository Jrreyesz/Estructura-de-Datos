class Program
{
    static void Main(string[] args)
    {
        List<string> asignaturas = ["Matemáticas", "Física", "Química", "Historia", "Lengua"];
        List<double> notas = [];

        for (int i = 0; i < asignaturas.Count; i++)
        {
            System.Console.WriteLine($"Ingrese la nota de la materia de {asignaturas[i]}: ");
            string nota = Console.ReadLine();
            double nota;

            // Validar que la entrada sea un número
            while (!double.TryParse(entrada, out nota))
            {
                Console.WriteLine("Entrada inválida. Ingrese un número válido:");
                entrada = Console.ReadLine();
            }

            notas.Add(nota);
        }

        for (int i = 0; i < asignaturas.Count; i++)
            {
               if (notas[i] >= 7)
                {
                    asignaturas.Remove(asignaturas[i]);
                }
            }

        System.Console.WriteLine("");
        System.Console.WriteLine("Materias Reprobadas");
        System.Console.WriteLine("");

        foreach (var materia in asignaturas)
        {
            System.Console.WriteLine(materia);
        }
    }
}
