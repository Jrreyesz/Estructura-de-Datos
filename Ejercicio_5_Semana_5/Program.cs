using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<string> asignaturas = ["Matemáticas", "Física", "Química", "Historia", "Lengua"]; //Lista de asignaturas
        List<double> notas = []; //Lista de notas

        //Bucle para ingresar las notas de cada materia
        for (int i = 0; i < asignaturas.Count; i++)
        {
            Console.WriteLine($"Ingrese la nota de la materia de {asignaturas[i]}: ");
            string entrada = Console.ReadLine();
            double nota;

            // Validar que la entrada sea un número para convertirlo a float
            while (!double.TryParse(entrada, NumberStyles.Any, CultureInfo.InvariantCulture, out nota))
            {
                Console.WriteLine("Entrada inválida. Ingrese un número válido:");
                entrada = Console.ReadLine();
            }

            //Añadimos la nota ya en float a la lista de notas
            notas.Add(nota);
        }

        //Creamos una lista de materias reprobadas
        List<string> reprobadas = [];

        //Bucle para evaluar que materias se reprobaron para añadirlas a la lista de reprobadas
        for (int i = 0; i < asignaturas.Count; i++)
        {
            if (notas[i] < 7)
            {
                reprobadas.Add(asignaturas[i]);
            }
        }

        System.Console.WriteLine("");
        System.Console.WriteLine("Materias Reprobadas");
        System.Console.WriteLine("");

        //Bucle que imprime las materias reprobadas
        foreach (var materia in reprobadas)
        {
            System.Console.WriteLine(materia);
        }
        
    }
}
