// Asignación de 30 asientos en orden de llegada, una vez que todos los asientos son vendidos
int entradasVendidas = 1;
int entradasDisponibles = 30;

Queue<int> colaEntrada = new Queue<int>();

for (int entrada = 0; entrada < entradasDisponibles; entrada++)
{
    colaEntrada.Enqueue(entrada + 1);
    entradasVendidas++;
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

System.Console.WriteLine("Menu: ");
System.Console.WriteLine("1. Consultar entradas disponibles");
System.Console.WriteLine("2. Verificar si están todos dentro de la atracción");
System.Console.WriteLine("3. Salir");
System.Console.WriteLine("Elija una opción: ");
string opcion = Console.ReadLine();

switch (opcion)
{
    case 1:
        if (entradasVendidas == 30)
        {
            System.Console.WriteLine("Todas las entradas han sido vendidas");
        }
        else
        {
            System.Console.WriteLine($"Aun quedan {entradasVendidas - entradasDisponibles} entradas por vender.");
        }
        break;
    case 2:
        if (colaEntrada.Count == 0)
        {
            System.Console.WriteLine("Todos han entrada a la atracción.");
        }
        else
        {
            System.Console.WriteLine("Aun no han ingresado todos a la atracción.");
        }
        break;
    case 3:
        break;
    
}