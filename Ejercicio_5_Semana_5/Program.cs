using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<string> asignaturas = ["Matemáticas", "Física", "Química", "Historia", "Lengua"];
        List<double> notas = [];

        for (int i = 0; i < asignaturas.Count; i++)
        {
            Console.WriteLine($"Ingrese la nota de la materia de {asignaturas[i]}: ");
            string entrada = Console.ReadLine();
            double nota;

            // Validar que la entrada sea un número
            while (!double.TryParse(entrada, NumberStyles.Any, CultureInfo.InvariantCulture, out nota))
            {
                Console.WriteLine("Entrada inválida. Ingrese un número válido:");
                entrada = Console.ReadLine();
            }

            notas.Add(nota);
        }

        for (int i = 0; i < notas.Count; i++)
        {
            Console.WriteLine($"{asignaturas[i]}: {notas[i]}");
        }
        //List<string> reprobadas = [];

        //for (int i = 0; i < asignaturas.Count; i++)
        //{
        //    if (notas[i] < 7)
        //    {
        //        reprobadas.Add(asignaturas[i]);
        //    }
        //}

        //System.Console.WriteLine("");
        //System.Console.WriteLine("Materias Reprobadas");
        //System.Console.WriteLine("");

        //foreach (var materia in reprobadas)
        //{
        //    System.Console.WriteLine(materia);
        //}
        //
    }
}
