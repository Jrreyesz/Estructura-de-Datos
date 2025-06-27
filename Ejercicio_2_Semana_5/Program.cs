class Program
{
    static void Main(string[] args)
    {
        //Creamos una lista con las materias
        List<string> materias = ["Matemática", "Física", "Química", "Historia", "Lengua"];
        //Creamos una lista vacia de notas
        List<string> notas = [];

        //Bucle para pedir las notas de cada materia
        for (int i = 0; i < materias.Count; i++)
        {
            System.Console.WriteLine($"Ingrese su nota en la materia de {materias[i]}: ");
            string nota = Console.ReadLine();
            //Añadimos cada nota a la lista de notas
            notas.Add(nota);
        }

        //Con un bucle for imprimimos todos los elementos de ambas listas
        for (int i = 0; i < materias.Count; i++)
        {
            System.Console.WriteLine($"En {materias[i]} has sacado {notas[i]}");
        }

    }
}