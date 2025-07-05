public class Nodo
{
    public string Valor;
    public Nodo siguientenodo;

    public Nodo(string valor)
    {
        Valor = valor;
        siguientenodo = null;
    }
}