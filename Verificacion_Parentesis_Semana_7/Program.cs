string ecuacion = "{2 + 3(8/3) + (2/3) / [(2*3)/2]}";

Stack<string> cantSignosAgrupacion = new Stack<string>();

foreach (var e in ecuacion)
{
    System.Console.WriteLine(e);
}