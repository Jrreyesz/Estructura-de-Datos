public class ListaEnlazada
{
    private Nodo head;
    public ListaEnlazada()
    {
        head = null;
    }

    public void añadir(int valor)
    {
        Nodo nuevo = new Nodo(valor);
        if (head == null)
        {
            head = nuevo;
        }
        else
        {
            Nodo actual = head;
            while (actual.nodosiguiente != null)
            {
                actual = actual.nodosiguiente;
            }
            actual.nodosiguiente = nuevo;
        }
    }

    public int contarvalor(int valorBuscado)
    {
        int contador = 0;
        Nodo actual = head;
        while (actual != null)
        {
            if (valorBuscado == actual)
            {
                contador++;
            }
            actual = actual.nodosiguiente;
        }
        return contador;
    }
}