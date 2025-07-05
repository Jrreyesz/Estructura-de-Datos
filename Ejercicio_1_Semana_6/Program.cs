class Program
{
    static void Main(string[] args)
    {
        ListaEnlazada lista = new ListaEnlazada();

        lista.añadir("Manzanas");
        lista.añadir("Limones");
        lista.añadir("Duraznos");
        lista.añadir("Uvas");
        lista.añadir("Moras");
        lista.añadir("Piñas");

        lista.contar();

    }
}
