public class ListaEnlazada
{
    private Nodo head;
    public ListaEnlazada()
    {
        head = null;
    }
    //Método para añadir elementos a la lista
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

    //Método para contar un valor específico en la lista
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