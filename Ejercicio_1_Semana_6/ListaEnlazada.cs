public class ListaEnlazada
{
    private Nodo head;
    public ListaEnlazada()
    {
        head = null;
    }

    public void añadir(string valor)
    {
        Nodo nuevo = new Nodo(valor);
        if (head == null)
        {
            head == nuevo;
        }
        else
        {
            Nodo actual = head;
            while (actual.siguientenodo != null)
            {
                actual = actual.siguientenodo;
            }
            actual.siguientenodo = nuevo;
        }
    }

    public int contar()
    {
        int contador = 0;
        Nodo actual = head;
        while (actual != null)
        {
            contador += 1;
            actual = actual.siguientenodo;
        }
        return contador;
    }
}