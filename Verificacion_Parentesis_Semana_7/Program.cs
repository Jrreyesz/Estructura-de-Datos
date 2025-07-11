string ecuacion = "{2 + 3(8/3) + (2/3) / [(2*3)/2]}";

Stack<char> cantSignosAgrupacion = new Stack<char>();

foreach (var e in ecuacion)
{
    if (e == "(" || e == ")" || e == "[" || e == "]" || e == "{" || e == "}")
    {
        cantSignosAgrupacion.Push(e);
    }
}

int contadorParentsisA = 0;
int contadorParentsisC = 0;
int contadorCorchetesA = 0;
int contadorCorchetesC = 0;
int contadorLlavesA = 0;
int contadorLlavesC = 0;

foreach (var signo in cantSignosAgrupacion)
{
    if (signo == "(")
    {
        contadorParentsisA++;
    }
    else if (signo == ")")
    {
        contadorParentsisC++;
    }
    else if (signo == "[")
    {
        contadorCorchetesA++;
    }
    else if (signo == "]")
    {
        contadorCorchetesC++;
    }
    else if (signo == "{")
    {
        contadorLlavesA++;
    }
    else if (signo == "}")
    {
        contadorLlavesC++;
    }

}

if (contadorParentsisA == contadorParentsisC && contadorCorchetesA == contadorCorchetesC && contadorLlavesA == contadorLlavesC)
{
    System.Console.WriteLine("Fórmula balanceada.");
}