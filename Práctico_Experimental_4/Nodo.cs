public class Nodo
{
    private int valor;
    public int Valor { get => valor; set => valor = value; }

    private Nodo izquierdo;
    public Nodo Izquierdo { get => izquierdo; set => izquierdo = value; }

    private Nodo derecho;
    public Nodo Derecho { get => derecho; set => derecho = value; }

    public Nodo(int valor)
    {
        Valor = valor;
        Izquierdo = null;
        Derecho = null;
    }
}

