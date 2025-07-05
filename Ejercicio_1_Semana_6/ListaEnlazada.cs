public class ListaEnlazada
{
    private Nodo head;
    public ListaEnlazada()
    {
        head = null;
    }
    
    //Crea un método para añadir elementos 
    public void añadir(string valor)
    {
        Nodo nuevo = new Nodo(valor);
        if (head == null)
        {
            head = nuevo;
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

    //Crea un método para contar los elementos
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