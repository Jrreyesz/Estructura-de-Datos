
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
        CiudadanosNoVacunados.Add($"Ciudadano {i}");
    }


}

HashSet<string> AmbasDosis = new HashSet<string>(CiudadanosPfizer);
AmbasDosis.IntersectWith(CiudadanosAstraZeneca);


System.Console.WriteLine("==========================Ciudadanos No Vacunados==========================");
System.Console.WriteLine("");
foreach (var c in CiudadanosNoVacunados)
{
    System.Console.WriteLine(c);
}
System.Console.WriteLine("");

System.Console.WriteLine("==========================Ciudadanos con Ambas Dosis==========================");
System.Console.WriteLine("");
foreach (var c in AmbasDosis)
{
    System.Console.WriteLine(c);
}
System.Console.WriteLine("");

System.Console.WriteLine("==========================Ciudadanos con Pfizer==========================");
System.Console.WriteLine("");
foreach (var c in CiudadanosPfizer)
{
    System.Console.WriteLine(c);
}
System.Console.WriteLine("");

System.Console.WriteLine("==========================Ciudadanos con AstraZeneca=========================");
System.Console.WriteLine("");
foreach (var c in CiudadanosAstraZeneca)
{
    System.Console.WriteLine(c);
}