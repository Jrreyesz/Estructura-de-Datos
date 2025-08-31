//Creamos el diccionario con las palabras en inglés
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

//Creamos un método para traducir la frase que desee el usuario
void traducirFrase()
{
    //Pedimos la frase al usuario
    System.Console.WriteLine("Escriba la frase que desea traducir:");
    //Almacenamos la frase en una variable
    string frase = Console.ReadLine();
    //Creamos una nueva variable para la frase traducida que inicie con la frase original
    string frasetraducida = frase.ToLower();

    //Creamos un bucle para recorrer las claves y valores del diccionario
    foreach (KeyValuePair<string, string> palabra in palabrasIngles)
    {
        frasetraducida = frasetraducida.Replace(palabra.Value, palabra.Key);
    }
    //Imprime la frase traducida
    System.Console.WriteLine($"La frase traducida es: {frasetraducida}");
}

//Creamos una función para agregar una palabra
void agregarPalabra()
{
    List<string> claves = palabrasIngles.Keys.ToList();
    //Pedimos al usuario la palabra que desea agregar en inglés y la almacenamos en una variable
    System.Console.WriteLine("Escriba la palabra que desea agregar en inglés:");
    string palabraClave = Console.ReadLine();

    if (claves.Contains(palabraClave.ToLower()))
    {
        System.Console.WriteLine("La palabra ya existe.");
    }
    else
    {
        //Pedimos el significado de la palabra al usuario y la almacenamos en una variable
        System.Console.WriteLine("Escriba la palabra en español:");
        string palabraValor = Console.ReadLine();
        //Con el método Add agregamos el nuevo par clave - valor al diccionario
        palabrasIngles.Add(palabraClave.ToLower(), palabraValor.ToLower());
        System.Console.WriteLine("Palabra agregada con éxito.");
    }

}

//Creamos una función para consultar una palabra, esto nos servirá para asegurarnos de que las palabras nuevas se añadan
void consultarPalabra()
{
    //Pedimos al usuario la palabra que desea buscar en inglés y la almacenamos en una variable
    System.Console.WriteLine("Ingrese la palabra que desea buscar en inglés: ");
    string palaraBuscada = Console.ReadLine();
    //Con ContainsKey verificamos si clave existe en el diccionario
    if (palabrasIngles.ContainsKey(palaraBuscada.ToLower()))
    {
        //Imprime el valor de la palabra buscada
        System.Console.WriteLine($"La palabra existe, su traducción es: {palabrasIngles[palaraBuscada]}");
    }
    else
    {
        //Se imprime si no se encuentra la palabra
        System.Console.WriteLine("Palabra no encontrada");
    }
}

//Creamos el menú
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