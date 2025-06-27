class Program
{
    static void Main(string[] args)
    {

        List<string> numsGanadores = [];

        for (int i = 0; i < 6; i++)
        {
            System.Console.WriteLine($"Ingrese el número {i} ganador de la loteria: ");
            string numGanador = Console.ReadLine;
            numsGanadores.Add(numGanador);
        }

        numsGanadores.Sort();

        foreach (var numero in numsGanadores)
        {
            System.Console.WriteLine(numero);
        }
    }
}
