class Program
{
    static void Main(string[] args)
    {
        //Creamos una lista para los numeros ganadores
        List<string> numsGanadores = [];
        
        //Creamos un bucle para ingresar seis números
        for (int i = 0; i < 6; i++)
        {
            //Pedimos al usuario que ingrese cada numero
            System.Console.WriteLine($"Ingrese el número {i + 1} ganador de la loteria: ");
            string numGanador = Console.ReadLine();
            //Añadimos cada numero ingresado a la lista de numeros ganadores
            numsGanadores.Add(numGanador);
        }

        System.Console.WriteLine("");
        System.Console.WriteLine("============================================================");
        System.Console.WriteLine("=============Números ordenados de menor a mayor=============");
        System.Console.WriteLine("============================================================");
        System.Console.WriteLine("");
        
        //Utilizamos el método sort para ordenalos de menor a mayor
        numsGanadores.Sort();

        //Bucle para imprimir todos los números en orden
        foreach (var numero in numsGanadores)
        {
            System.Console.WriteLine(numero);
        }
    }
}
