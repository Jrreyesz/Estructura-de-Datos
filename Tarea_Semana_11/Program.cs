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

void agregarPalabra()
{
    System.Console.WriteLine("Escriba la palabra que desea agregar en inglés:");
    string palabraClave = Console.ReadLine();
    System.Console.WriteLine("Escriba la palabra en español:");
    string palabraValor = Console.ReadLine();
    palabrasIngles.Add(palabraClave, palabraValor);
}

