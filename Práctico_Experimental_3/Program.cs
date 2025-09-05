Dictionary<string, string> jugadores = new Dictionary<string, string> { };
HashSet<string> equipos = new HashSet<string>();
Dictionary<string, List<string>> equiposyjugadores = new Dictionary<string, List<string>> { };

void registrarjugadores()
{
    System.Console.WriteLine("Ingrese el ID del jugador:");
    string id = ConsoleReadLine();
    System.Console.WriteLine("Ingrese el nombre del jugador:");
    string nombrejugador = ConsoleReadLine();

    if (jugadores.ContainsKey(id))
    {
        System.Console.WriteLine("El ID ingresado ya está registrado.");
    }
    else
    {
        jugadores.Add(id, nombrejugador);
        System.Console.WriteLine("El jugador fue registrado correctamente.");
    }
}


while (true)
{
    System.Console.WriteLine("==========================Menú==========================");
    System.Console.WriteLine("");
    System.Console.WriteLine("1. Registrar jugador en la base de datos");
    System.Console.WriteLine("2. Salir");
    System.Console.WriteLine("");

    System.Console.WriteLine("Elija una opción:");
    string opcion = ConsoleReadLine();

    if (opcion == "1")
    {
        registrarjugadores();
    }
    else if (opcion == "2")
    {
        break;
    }
}