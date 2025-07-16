// Asignación de 30 asientos en orden de llegada, una vez que todos los asientos son vendidos

int entradasDisponibles = 30;

Queue<int> colaEntrada = new Queue<int>();

for (int entrada = 0; entrada < entradasDisponibles; entrada++)
{
    colaEntrada.Enqueue(entrada+1);
}

foreach (int entrada in colaEntrada)
{
    if (entrada < entradasDisponibles - 1)
    {
        System.Console.Write(entrada + ", ");
    }
    else
    {
        System.Console.Write(entrada);
    }
    
    
}