class Program
{
    static void Main(string[] args)
    {
        List<int> numeros = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

        numeros.Reverse();
        
        string listaDeNumeros = string.Join(", ", numeros);
        System.Console.WriteLine(listaDeNumeros);

    }
}