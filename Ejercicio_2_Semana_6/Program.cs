class Program
{
    static void Main(string[] args)
    {
        ListaEnlazada lista = new ListaEnlazada();

        lista.añadir(10);
        lista.añadir(20);
        lista.añadir(20);
        lista.añadir(25);
        lista.añadir(3);
        lista.añadir(16);

        System.Console.WriteLine($"El número de veces que aparece el valor es {lista.contarvalor(5)}");
    }
}
