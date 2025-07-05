public class ListaEnlazada
{
    private Nodo head;
    public ListaEnlazada()
    {
        cabeza = null;
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
}