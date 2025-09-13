List<string> revistas = new List<string>{"Full Deportes", "Todo Moda", "Auto Deporte", "Vanguardia", "TIC Relevance", "Ciencia Simplificada", "Historia Curiosa", "Vestigios del Pasado", "Psicología de la Vida", "Mascota Amigable"};

void ingresarRevista()
{
    System.Console.WriteLine("Ingrese el nombre de la revista: ");
    string nombreRevista = Console.ReadLine().ToTitleCase();

    if (!revistas.Contains(nombreRevista))
    {
        revistas.Add(nombreRevista);
        System.Console.WriteLine($"La revista {nombreRevista} fue añadida exitosamente.");
    }
    else
    {
        System.Console.WriteLine("La revista ya existe.");
    }
}

int indice = 0;

string buscarRevista()
{
    System.Console.WriteLine("Ingrese el nombre de la revista que desea buscar:");
    string nombreRevista = Console.ReadLine().ToTitleCase();


    if (indice < revistas.Count())
    {
        if (revistas[indice] == nombreRevista)
        {
            return $"La revista {nombreRevista} fue encontrada.";
        }
        else
        {
            indice += 1;
            buscarRevista();
        }
    }
    else
    {
        return $"Revista {nombreRevista} no fue encontrada.";
    }
}

while (true)
{
    System.Console.WriteLine("");
    System.Console.WriteLine("========================MENÚ========================\n");
    System.Console.WriteLine("1. Ingresar una nueva revista");
    System.Console.WriteLine("2. Buscar una revista");
    System.Console.WriteLine("3. Salir\n");
    System.Console.WriteLine("Elija una opción: ");
    string opcion = Console.ReadLine();

    if (opcion == "1")
    {
        ingresarRevista();
    }
    else if (opcion == "2")
    {
        buscarRevista();
    }
    else if (opcion == "3")
    {
        break;
    }
    else
    {
        System.Console.WriteLine("Opción incorrecta, eliga otra vez.");
    }

}