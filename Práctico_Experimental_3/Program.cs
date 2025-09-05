//Diccionario vacia para registrar jugadores con un id unico
Dictionary<string, string> jugadores = new Dictionary<string, string> { };
//Conjunto de equipos que evita que existan dos equipos iguales
HashSet<string> equipos = new HashSet<string>();
//Diccionario vacío que almacenara cada equipo con sus respectos jugadores en una lista
Dictionary<string, List<string>> equiposyjugadores = new Dictionary<string, List<string>> { };

//Función para registrar jugadores
void registrarjugadores()
{
    System.Console.WriteLine("Ingrese el ID del jugador:");
    string id = Console.ReadLine();

    //Verifica que el ID no Exista
    if (jugadores.ContainsKey(id))
    {
        System.Console.WriteLine("El ID ingresado ya está registrado.");
        System.Console.WriteLine("");
    }
    //Si el ID no existe, añade al jugador
    else
    {
        System.Console.WriteLine("Ingrese el nombre del jugador:");
        string nombrejugador = Console.ReadLine();
        jugadores.Add(id, nombrejugador);
        System.Console.WriteLine("El jugador fue registrado correctamente.");
        System.Console.WriteLine("");
    }
}

//Función para ver los jugadores registrados
void verjugadoresregistrados()
{
    //Verifica que haya elementos para imnprimir
    if (jugadores.Count != 0)
    {
        foreach (KeyValuePair<string, string> jugador in jugadores)
        {
            System.Console.WriteLine($"Jugador {jugador.Value}, con ID {jugador.Key}");
        }
    }
    else
    {
        System.Console.WriteLine("No hay jugadores registrados.");
    }
    
}

//Función para registrar un equipo y para que se añade como clave al diccionario equiposyjugadores, con una lista como valor
void registrarEquipo()
{
    System.Console.WriteLine("Ingrese el nombre del equipo:");
    string nombreequipo = Console.ReadLine().ToLower();
    equipos.Add(nombreequipo);
    //Bucle para que los equipos se registren en el diccionario como clave única
    foreach (string e in equipos)
    {
        //Evita que se repitan las claves en cada bucle
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


//Función para ver los equipos registrados
void verequiposregistrados()
{
    //Verifica si existen elementos 
    if (equipos.Count != 0)
    {
        foreach (string e in equipos)
        {
            System.Console.WriteLine(e);
        }
    }
    else
    {
        System.Console.WriteLine("No hay equipos registrados.");
    }
    
}

//Función para añadir un jugador a un equipo
void añadiraequipo()
{

    System.Console.WriteLine("Ingrese el nombre del equipo:");
    string nequipo = Console.ReadLine().ToLower();
    //Verifica que exista el equipo
    if (equiposyjugadores.ContainsKey(nequipo))
    {
        System.Console.WriteLine("Escriba el ID del jugador que desea añadir:");
        string idjugador = Console.ReadLine();
        //Verifica que exista el ID del jugador, si existe lo añade al equipo
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

//Función para ver los equipos con sus jugadores
void jugadoresxEquipo()
{
    //Verifica que existan elementos para visualizar
    if (equiposyjugadores.Count != 0)
    {
        // Bucle para recorrer los elementos del diccionario
        foreach (KeyValuePair<string, List<string>> jugadores in equiposyjugadores)
        {
            //Verifica que la lista de jugadores de los equipos esten con elementos
            if (jugadores.Value.Count != 0)
            {
                foreach (string jugador in jugadores.Value)
                {
                    System.Console.WriteLine($"Equipo: {jugadores.Key}. Jugador: {jugador}");
                }
            }
            else
            {
                System.Console.WriteLine($"El equipo {jugadores.Key} no tiene jugadores.");
            }

        }
    }
    else
    {
        System.Console.WriteLine("No equipos registrados.");
    }
    
}


//Menú para escribir las opciones 
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
    else
    {
        System.Console.WriteLine("Opción Incorrecta, intente de nuevo.");
    }
}