string ecuacion = "{2 + 3(8/3) + (2/3) / [(2*3)/2]}";

Stack<string> cantSignosAgrupacion = new Stack<string>();

foreach (var e in ecuacion)
{
    string e = e.ToString();
    if (e == "(" || e == ")" || e == "[" || e == "]" || e== "{" || e == "}")
    {
        System.Console.WriteLine(e.GetType());
    }
}

int contadorParentsisA = 0;
int contadorParentsisC = 0;
int contadorCorchetesA = 0;
int contadorCorchetesC = 0;
int contadorLlavesA = 0;
int contadorLlavesC = 0;

//foreach (var signo in cantSignosAgrupacion)
//{
//    if (signo == "(")
//    {
//        contadorParentsisA++;
//    }
//    else if (signo == ")")
//    {
//        contadorParentsisC++;
//    }
//    else if (signo == "[")
//    {
//        contadorCorchetesA++;
//   }
//    else if (signo == "]")
//    {
//        contadorCorchetesC++;
//    }
//    else if (signo == "{")
//    {
//        contadorLlavesA++;
//    }
//    else if (signo == "}")
//    {
//        contadorLlavesC++;
//    }

//}

//if (contadorParentsisA == contadorParentsisC && contadorCorchetesA == contadorCorchetesC && contadorLlavesA == contadorLlavesC)
//{
//    System.Console.WriteLine("Fórmula balanceada.");
//}