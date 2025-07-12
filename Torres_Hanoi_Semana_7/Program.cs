int numDiscos = 4;

Stack<int> origen = new Stack<int>();
Stack<int> auxiliar = new Stack<int>();
Stack<int> destino = new Stack<int>();

for (int i = 0; i < numDiscos; i++)
{
    origen.Push(i);
}

solucion(numDiscos, origen, destino, auxiliar, "Origen", "Destino", "Auxiliar");

static void solucion(int n, Stack<int> origen, Stack<int> destino, Stack<int> auxiliar, string nombreOrigen, string nombreDestino, string nombreAuxiliar)
{
    if (n == 1)
    {
        Mover(origen, destino, nombreOrigen, nombreDestino);
        return;
    }
    solucion(n - 1, origen, auxiliar, destino, nombreOrigen, nombreAuxiliar, nombreDestino);
    Mover(origen, destino, nombreOrigen, nombreDestino);
    solucion(n - 1, auxiliar, destino, origen, nombreAuxiliar, nombreDestino, nombreOrigen);
}

static void Mover(Stack<int> desde, Stack<int> hacia, string nombreDesde, string nombreHacia)
{
    int disco = desde.Pop();
    hacia.Push(disco);
    System.Console.WriteLine($"Mover el disco {disco} de {nombreDesde} a {nombreHacia}");
}