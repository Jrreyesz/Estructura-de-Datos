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
}