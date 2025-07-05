public class Nodo
{
    public string Dato;
    public Nodo siguientenodo;

    public Nodo(string valor)
    {
        Valor = valor;
        siguientenodo = null;
    }
}