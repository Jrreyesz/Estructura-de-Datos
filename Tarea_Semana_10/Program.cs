
HashSet<string> CiudadanosNoVacunados = new HashSet<string> { };
HashSet<string> CiudadanosPfizer = new HashSet<string> { };
HashSet<string> CiudadanosAstraZeneca = new HashSet<string> { };

for (int i = 0; i < 500; i++)
{
    if (i < 75)
    {
        CiudadanosPfizer.Add($"Ciudadano {i + 1}");
    }
}

foreach (var i in CiudadanosPfizer)
{
    System.Console.WriteLine(i);
}