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
    
    //Creamos en método para encontrar el menor precio o valor dentro del arbol binario
    public int menorPrecio()
    {
        //Ubicamos el nodo actual en la raiz
        Nodo nodoActual = Raiz;

        //mientras el nodo actual izquiero no sea nulo, no debe parar el bucle
        while (nodoActual.Izquierdo != null)
        {
            //Avanzamos sucesivamente por cada nodo hasta el último
            nodoActual = nodoActual.Izquierdo;
        }

        //Al ir por el camino de la izquiera nos aseguramos que es el menor valor de todos el ultimo nodo
        return nodoActual.Valor;
    }
}

