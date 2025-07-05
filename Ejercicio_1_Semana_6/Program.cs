class Program
{
    static void Main(string[] args)
    {
        // Creamos la lista enlazada
        ListaEnlazada lista = new ListaEnlazada();

        //Añadimos elementos a la lista
        lista.añadir("Manzanas");
        lista.añadir("Limones");
        lista.añadir("Duraznos");
        lista.añadir("Uvas");
        lista.añadir("Moras");
        lista.añadir("Piñas");

        //Imprime en pantalla el número de elementos
        System.Console.WriteLine($"El número de elementos de la lista es: {lista.contar()}");

    }
}
