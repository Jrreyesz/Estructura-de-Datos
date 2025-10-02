public class ArbolBinario
{
    private Nodo raiz;
    public Nodo Raiz { get => raiz; set => raiz = value; }

    public ArbolBinario()
    {
        Raiz = null;
    }

    public void Insertar(int valor)
    {
        Raiz = InsertRecursivo(Raiz, valor);
    }

    private Nodo InsertRecursivo(Nodo nodoActual, int valor)
    {
        if (nodoActual == null)
        {
            return new Nodo(valor);
        }
        if (valor < nodoActual.Valor)
        {
            nodoActual.Izquierdo = InsertRecursivo(nodoActual.Izquierdo, valor);
        }
        else if (valor > nodoActual.Valor)
        {
            nodoActual.Derecho = InsertRecursivo(nodoActual.Derecho, valor);
        }
        return nodoActual;
    }

    public string menorPrecio()
    {
        Nodo nodoActual = Raiz;

        while (nodoActual.Izquierdo != null)
        {
            nodoActual = nodoActual.Izquierdo;
        }

        return nodoActual.Valor;
    }
}

