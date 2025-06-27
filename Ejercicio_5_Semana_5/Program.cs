class Program
{
    static void Main(string[] args)
    {
        List<string> asignaturas = ["Matemáticas", "Física", "Química", "Historia", "Lengua"];
        List<string> notas = [];

        for (int i = 0; i < asignaturas.Count; i++)
        {
            System.Console.WriteLine($"Ingrese la nota de la materia de {asignaturas[i]}: ");
            string nota = Console.ReadLine();
            notas.Add(nota);
        }

        for (int i = 0; i < notas.Count; i++)
        {
            float num;
            num = float.Parse(notas[i]);
            System.Console.WriteLine(num);
        }

        //for (int i = 0; i < notas.Count; i++)
        //{
        //    if (notas[i] is string)
        //    {
                notas.Remove(notas[i]);
        //    }
        //}

        //for (int i = 0; i < asignaturas.Count; i++)
        //    {
        //       if (notas[i] >= 7)
        //        {
        //            asignaturas.Remove(asignaturas[i]);
        //        }
        //    }

        

        System.Console.WriteLine("");
        System.Console.WriteLine("Materias Reprobadas");
        System.Console.WriteLine("");

        foreach (var materia in asignaturas)
        {
            System.Console.WriteLine(materia);
        }
    }
}
