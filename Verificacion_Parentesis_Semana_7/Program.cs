//Establecemos la ecuación de entrada
string ecuacion = "{2 + 3(8/3) + (2/3) / [(2*3)/2}";

//Creamos una pilas para almacenar los signos de agrupación
Stack<string> cantSignosAgrupacion = new Stack<string>();

//Recorremos la ecuación y cada signo de agrupación se añade a la pila
foreach (var e in ecuacion)
{
    char elemento = e;
    string elementoCast = elemento.ToString();
    if (elementoCast == "(" || elementoCast == ")" || elementoCast == "[" || elementoCast == "]" || elementoCast == "{" || elementoCast == "}")
    {
        cantSignosAgrupacion.Push(elementoCast);
    }
}

//Creamos contadores para cada signo de agrupación
int contadorParentsisA = 0;
int contadorParentsisC = 0;
int contadorCorchetesA = 0;
int contadorCorchetesC = 0;
int contadorLlavesA = 0;
int contadorLlavesC = 0;

//Contamos cuantos signos hay de cada uno de ellos
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

//Condición para determinar si la función está balanceada
if (contadorParentsisA == contadorParentsisC && contadorCorchetesA == contadorCorchetesC && contadorLlavesA == contadorLlavesC)
{
    System.Console.WriteLine("Fórmula balanceada.");
}
else
{
    System.Console.WriteLine("La fórmula no está balanceada.");
}