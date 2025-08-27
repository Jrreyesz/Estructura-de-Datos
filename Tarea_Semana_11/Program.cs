Dictionary<string, string> palabrasIngles = new Dictionary<string, string>
{
    {"time", "tiempo"},
    {"person", "persona"},
    {"year", "año"},
    {"way", "forma"},
    {"day", "día"},
    {"thing", "cosa"},
    {"man", "hombre"},
    {"world", "mundo"},
    {"life", "vida"},
    {"part", "parte"},
    {"child", "niño"},
    {"eye", "ojo"},
    {"place", "lugar"},
    {"work", "trabajo"},
    {"week", "semana"}
};

void traducirFrase()
{
    System.Console.WriteLine("Escriba la frase que desea traducir:");
    string frase = Console.ReadLine();

    foreach (KeyValuePair<string, string> palabra in palabrasIngles)
    {
        frase.Replace(palabra.Value, palabra.Key);
    }

    System.Console.WriteLine($"La frase traducida es: {frase}");
}

void agregarPalabra()
{
    System.Console.WriteLine("Escriba la palabra que desea agregar en inglés:");
    string palabraClave = Console.ReadLine();
    System.Console.WriteLine("Escriba la palabra en español:");
    string palabraValor = Console.ReadLine();
    palabrasIngles.Add(palabraClave, palabraValor);
}

void consultarPalabra()
{
    System.Console.WriteLine("Ingrese la palabra que desea buscar en inglés: ");
    string palaraBuscada = Console.ReadLine();
    if (palabrasIngles.ContainsKey(palaraBuscada.ToLower()))
    {
        System.Console.WriteLine($"La palabra existe, su traducción es: {palabrasIngles[palaraBuscada]}");
    }
    else
    {
        System.Console.WriteLine("Palabra no encontrada");
    }
}


while (true)
{
    System.Console.WriteLine("=========================Menú=========================");
    System.Console.WriteLine("1. Traducir una frase");
    System.Console.WriteLine("2. Agregar palabras al diccionario");
    System.Console.WriteLine("3. Buscar una palabra");
    System.Console.WriteLine("4. Salir");

    string opcion = Console.ReadLine();

    if (opcion == "1")
    {
        traducirFrase();
    }
    else if (opcion == "2")
    {
        agregarPalabra();
    }
    else if (opcion == "3")
    {
        consultarPalabra();
    }
    else if (opcion == "4")
    {
        break;
    }
    else
    {
        System.Console.WriteLine("Opción Incorrecta, elija una opción correcta.");
    }

}