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
            if (valorBuscado == actual.Valor)
            {
                contador++;
            }
            actual = actual.nodosiguiente;
        }
        if (contador == 0)
        {
            System.Console.WriteLine("El valor no existe en la lista.");
        }
        return contador;
    }
}