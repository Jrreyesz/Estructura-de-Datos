int numDiscos = 4;

Stack<int> origen = new Stack<int>();
Stack<int> auxiliar = new Stack<int>();
Stack<int> destino = new Stack<int>();

for (int i = 0; i < numDiscos; i++)
{
    origen.Push(i);
}

static void solucion()
{
    
}

static void Mover(Stack<int> desde, Stack<int> hacia, string nombreDesde, string nombreHacia)
{
    int disco = desde.Pop();
    hacia.Push(disco);
    System.Console.WriteLine($"Mover el disco {disco} de {nombreDesde} a {nombreHacia}");
}