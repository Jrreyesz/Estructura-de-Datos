// Creamos una lista con las revistas iniciales
List<string> revistas = new List<string>{"full deportes", "todo moda", "auto deporte", "vanguardia", "tic relevance", "ciencia simplificada", "historia curiosa", "vestigios del pasado", "psicología de la vida", "mascota amigable"};

//Creamos un método para ingresar una revista
void ingresarRevista()
{
    System.Console.WriteLine("Ingrese el nombre de la revista: ");
    string nombreRevista = Console.ReadLine().ToLower();

    //Verificamos si la revista existe
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

//Creamos el método para ingresar la búsqueda y que inicie el algoritmo de recursividad con un indice que sirve como apuntador
void ingresarBusqueda()
{
    System.Console.WriteLine("Ingrese el nombre de la revista que desea buscar:");
    string nombreRevista = Console.ReadLine().ToLower();
    //Llamamos a la función recursiva
    buscarRevista(0, nombreRevista);
}

//Creamos el algoritmo recursivo para encontrar si la revista se encuentra en la lista
void buscarRevista(int indice, string nRevista)
{
    //Nos aseguramos que no se repita más allá del número de elementos de la lista
    if (indice < revistas.Count())
    {
        //Con el índice verificamos si el elemento de la lista es igual a la revista que buscamos
        if (revistas[indice] == nRevista)
        {
            System.Console.WriteLine($"La revista {nRevista} fue encontrada.");
        }
        //Si no es igual, llama de nuevo a la función pero incrementando el indice en uno
        else
        {
            buscarRevista(indice + 1, nRevista);
        }
    }
    //Si no se encontró el elemento, imprime un mensaje de notificación
    else
    {
        System.Console.WriteLine($"Revista {nRevista} no fue encontrada.");
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
        ingresarBusqueda();
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