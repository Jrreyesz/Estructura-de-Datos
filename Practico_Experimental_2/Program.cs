// Asignación de 30 asientos en orden de llegada, una vez que todos los asientos son vendidos

int entradasDisponibles = 30;

Queue<int> colaEntrada = new Queue<int>();

for (int entrada = 0; entrada < entradasDisponibles; entrada++)
{
    colaEntrada.Enqueue(entrada+1);
}

System.Console.WriteLine("FILA: ");

foreach (int entrada in colaEntrada)
{
    if (entrada < entradasDisponibles)
    {
        System.Console.Write(entrada + ", ");
    }
    else
    {
        System.Console.Write(entrada + "\n");
    }
}

System.Console.WriteLine("ENTRAR: ");

for (int entrada = 0; entrada < entradasDisponibles; entrada++)
{
    System.Console.Write(colaEntrada.Dequeue() + ", ");
}