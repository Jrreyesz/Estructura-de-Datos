// Asignación de 30 asientos en orden de llegada, una vez que todos los asientos son vendidos

//Creamos dos variables una para entradas vendidas 
int entradasVendidas = 0;
int entradasTotales = 30;

//Creamos una cola para simular la fila
Queue<int> colaEntrada = new Queue<int>();


//Creamos un bucle for para vender todas las entradas y las añadimos a la cola
for (int entrada = 0; entrada < entradasTotales; entrada++)
{
    colaEntrada.Enqueue(entrada + 1);
    entradasVendidas++;
}

System.Console.WriteLine("FILA: ");
//Simulamos la fila
foreach (int entrada in colaEntrada)
{
    if (entrada < entradasTotales)
    {
        System.Console.Write(entrada + ", ");
    }
    else
    {
        System.Console.Write(entrada + "\n");
    }
}

System.Console.WriteLine("ENTRAR: ");

//Aseguramos que cada persona entre en orden y lo eliminamos de la cola segun entre
for (int entrada = 0; entrada < entradasTotales; entrada++)
{
    System.Console.Write(colaEntrada.Dequeue() + ", ");
}

//Creamos un menu 
System.Console.WriteLine("\nMenu: ");
System.Console.WriteLine("1. Consultar entradas disponibles");
System.Console.WriteLine("2. Verificar si están todos dentro de la atracción");
System.Console.WriteLine("3. Salir");
System.Console.WriteLine("Elija una opción: ");
string opcion = Console.ReadLine();

//Creamos un switch para completar el menu y consultar distintos aspectos
switch (opcion)
{
    case "1":
        if (entradasVendidas == 30)
        {
            System.Console.WriteLine("Todas las entradas han sido vendidas");
        }
        else
        {
            System.Console.WriteLine($"Aun quedan {entradasVendidas - entradasTotales} entradas por vender.");
        }
        break;
    case "2":
        if (colaEntrada.Count == 0)
        {
            System.Console.WriteLine("Todos han entrada a la atracción.");
        }
        else
        {
            System.Console.WriteLine("Aun no han ingresado todos a la atracción.");
        }
        break;
    case "3":
        break;

}