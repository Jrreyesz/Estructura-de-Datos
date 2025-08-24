//Creamos tres conjuntos, uno para no vacunados, otro para pfizer y otro para AstraZeneca
HashSet<string> CiudadanosNoVacunados = new HashSet<string> { };
HashSet<string> CiudadanosPfizer = new HashSet<string> { };
HashSet<string> CiudadanosAstraZeneca = new HashSet<string> { };

//Con un bucle for agregaremos los ciudadanos a sus conjuntos, 500 en total
for (int i = 0; i <= 500; i++)
{
    //75 ciudadanos para pfizer
    if (i < 75)
    {
        CiudadanosPfizer.Add($"Ciudadano {i + 1}");
    }
    //75 ciudadanos para AstraZeneca, de los cuales 45 tambien tienen pfizer
    if (i >= 30 && i < 105)
    {
        CiudadanosAstraZeneca.Add($"Ciudadano {i + 1}");
    }
    //ciudadanos no vacunados
    if (i > 105)
    {
        CiudadanosNoVacunados.Add($"Ciudadano {i}");
    }


}

//Creamos un conjunto con los elementos de la interesección entre los conjuntos de pfizer y astrazeneca
HashSet<string> AmbasDosis = new HashSet<string>(CiudadanosPfizer);
AmbasDosis.IntersectWith(CiudadanosAstraZeneca);

//Creamos un conjunto con los elementos de la diferencia entre los conjuntos de pfizer y astrazeneca
HashSet<string> SoloPfizer = new HashSet<string>(CiudadanosPfizer);
SoloPfizer.ExceptWith(CiudadanosAstraZeneca);

//Creamos un conjunto con los elementos de la diferencia entre los conjuntos de astrazeneca y pfizer
HashSet<string> SoloAstraZeneca = new HashSet<string>(CiudadanosAstraZeneca);
SoloAstraZeneca.ExceptWith(CiudadanosPfizer);

//Imprimir en pantalla las listas correspondientes
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
foreach (var c in SoloPfizer)
{
    System.Console.WriteLine(c);
}
System.Console.WriteLine("");

System.Console.WriteLine("==========================Ciudadanos con AstraZeneca=========================");
System.Console.WriteLine("");
foreach (var c in SoloAstraZeneca)
{
    System.Console.WriteLine(c);
}