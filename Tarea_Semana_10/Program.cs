
HashSet<string> CiudadanosNoVacunados = new HashSet<string> { };
HashSet<string> CiudadanosPfizer = new HashSet<string> { };
HashSet<string> CiudadanosAstraZeneca = new HashSet<string> { };

for (int i = 0; i < 500; i++)
{
    if (i < 75)
    {
        CiudadanosPfizer.Add($"Ciudadano {i + 1}");
    }
    if (i >= 30 && i < 150)
    {
        CiudadanosAstraZeneca.Add($"Ciudadano {i + 1}");
    }
    if (i > 150)
    {
        CiudadanosNoVacunados.Add($"Ciudadano {i + 1}");
    }


}

foreach (var i in CiudadanosNoVacunados)
{
    System.Console.Write(i, );
}

foreach (var i in CiudadanosPfizer)
{
    System.Console.Write(i, );
}

foreach (var i in CiudadanosAstraZeneca)
{
    System.Console.Write(i, );
}