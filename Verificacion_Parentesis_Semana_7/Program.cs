string ecuacion = "{2 + 3(8/3) + (2/3) / [(2*3)/2]}";

Stack<string> cantSignosAgrupacion = new Stack<string>();

foreach (var e in ecuacion)
{
    if (e == "(" || e == ")" || e == "[" || e == "]" || e == "{" || e == "}")
    {
        string elementoCast = e.ToString();
        cantSignosAgrupacion.Push(elementoCast);
    }
}

int contadorParentsisA = 0;
int contadorParentsisC = 0;
int contadorCorchetesA = 0;
int contadorCorchetesC = 0;
int contadorLlavesA = 0;
int contadorLlavesC = 0;

for (int i = 0; i < cantSignosAgrupacion.Count(); i++)
{
    if (cantSignosAgrupacion[i] == "(")
    {
        contadorParentsisA++;
    }
    else if (cantSignosAgrupacion[i] == ")")
    {
        contadorParentsisC++;
    }
    else if (cantSignosAgrupacion[i] == "[")
    {
        contadorCorchetesA++;
    }
    else if (cantSignosAgrupacion[i] == "]")
    {
        contadorCorchetesC++;
    }
    else if (cantSignosAgrupacion[i] == "{")
    {
        contadorLlavesA++;
    }
    else if (cantSignosAgrupacion[i] == "}")
    {
        contadorLlavesC++;
    }

}

if (contadorParentsisA == contadorParentsisC && contadorCorchetesA == contadorCorchetesC && contadorLlavesA == contadorLlavesC)
{
    System.Console.WriteLine("Fórmula balanceada.");
}