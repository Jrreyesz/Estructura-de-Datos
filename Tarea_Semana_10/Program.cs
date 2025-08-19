
HashSet<string> TotalCiudadanos = new HashSet<string> { };
HashSet<string> CiudadanosPfizer = new HashSet<string> { };
HashSet<string> CiudadanosAstraZeneca = new HashSet<string> { };

for (int i = 0; i < 500; i++)
{
    if (i < 75)
    {
        CiudadanosPfizer.Add($"Ciudadano {i + 1}");
    }
}

System.Console.WriteLine(CiudadanosPfizer);