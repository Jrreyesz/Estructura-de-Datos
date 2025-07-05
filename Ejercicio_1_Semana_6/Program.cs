class Program
{
    static void Main(string[] args)
    {
        ListaEnlazada lista = new ListaEnlazada();
        int contador = 0;

        lista.añadir("Manzanas");
        lista.añadir("Limones");
        lista.añadir("Duraznos");
        lista.añadir("Uvas");
        lista.añadir("Moras");
        lista.añadir("Piñas");

        foreach (var item in lista)
        {
            contador += 1;
        }

        System.Console.WriteLine($"El número de elementos de lista es: {contador}");

    }
}
