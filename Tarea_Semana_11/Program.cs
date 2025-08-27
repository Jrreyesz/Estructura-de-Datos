
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

foreach (var v in palabrasIngles.Values())
{
    System.Console.WriteLine(v);
}