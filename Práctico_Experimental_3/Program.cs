Dictionary<string, string> jugadores = new Dictionary<string, string> { };
HashSet<string> equipos = new HashSet<string>();
Dictionary<string, List<string>> equiposyjugadores = new Dictionary<string, List<string>> { };

void registrarjugadores()
{
    System.Console.WriteLine("Ingrese el ID del jugador:");
    string id = Console.ReadLine();

    if (jugadores.ContainsKey(id))
    {
        System.Console.WriteLine("El ID ingresado ya está registrado.");
        System.Console.WriteLine("");
    }
    else
    {
        System.Console.WriteLine("Ingrese el nombre del jugador:");
        string nombrejugador = Console.ReadLine();
        jugadores.Add(id, nombrejugador);
        System.Console.WriteLine("El jugador fue registrado correctamente.");
        System.Console.WriteLine("");
    }
}

void verjugadoresregistrados()
{
    foreach (KeyValuePair<string, string> jugador in jugadores)
    {
        System.Console.WriteLine($"Jugador {jugador.Value}, con ID {jugador.Key}");
    }
}

void registrarEquipo()
{
    System.Console.WriteLine("Ingrese el nombre del equipo:");
    string nombreequipo = Console.ReadLine().ToLower();
    equipos.Add(nombreequipo);
    foreach (string e in equipos)
    {
        if (!equiposyjugadores.ContainsKey(e))
        {
            equiposyjugadores.Add(e, new List<string>());
        }
        else
        {
            continue;
        }
    }
}

void verequiposregistrados()
{
    foreach (string e in equipos)
    {
        System.Console.WriteLine(e);
    }
}

void añadiraequipo()
{
    System.Console.WriteLine("Ingrese el nombre del equipo:");
    string nequipo = Console.ReadLine().ToLower();
    if (equiposyjugadores.ContainsKey(nequipo))
    {
        System.Console.WriteLine("Escriba el ID del jugador que desea añadir:");
        string idjugador = Console.ReadLine();
        if (jugadores.ContainsKey(idjugador))
        {
            equiposyjugadores[nequipo].Add(jugadores[idjugador]);
        }
        else
        {
            System.Console.WriteLine("El ID del jugador no existe.");
        }
    }
    else
    {
        System.Console.WriteLine("El nombre del equipo no existe.");
    }
}

void jugadoresxEquipo()
{
    foreach (KeyValuePair<string, List<string>> jugadores in equiposyjugadores)
    {
        foreach (string jugador in jugadores.Value)
        {
            System.Console.WriteLine($"Equipo: {jugadores.Key}. Jugador: {jugador}");
        }
    }
}

while (true)
{
    System.Console.WriteLine("==========================Menú==========================");
    System.Console.WriteLine("");
    System.Console.WriteLine("1. Registrar jugador en la base de datos");
    System.Console.WriteLine("2. Ver jugadores registrados en la base de datos");
    System.Console.WriteLine("3. Registrar equipo");
    System.Console.WriteLine("4. Ver equipos registrados");
    System.Console.WriteLine("5. Añadir un jugador a un equipo");
    System.Console.WriteLine("6. Consultar equipos y sus jugadores");
    System.Console.WriteLine("7. Salir");
    System.Console.WriteLine("");

    System.Console.WriteLine("Elija una opción:");
    string opcion = Console.ReadLine();

    if (opcion == "1")
    {
        registrarjugadores();
    }
    else if (opcion == "2")
    {
        verjugadoresregistrados();
    }
    else if (opcion == "3")
    {
        registrarEquipo();
    }
    else if (opcion == "4")
    {
        verequiposregistrados();
    }
    else if (opcion == "5")
    {
        añadiraequipo();
    }
    else if (opcion == "6")
    {
        jugadoresxEquipo();
    }
    else if (opcion == "7")
    {
        break;
    }
}