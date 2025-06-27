class Program
{
    static void Main(string[] args)
    {   
        //Creamos una lista de numero del 1 al 10
        List<int> numeros = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

        //Utilizamos el método reverse para revertir la lista
        numeros.Reverse();
        
        //Imprimimos los números separados por coma en una sola linea
        string listaDeNumeros = string.Join(", ", numeros);
        System.Console.WriteLine(listaDeNumeros);

    }
}