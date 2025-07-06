class Program
{
    static void Main(string[] args)
    {
        //Crear la lista enlazada
        ListaEnlazada lista = new ListaEnlazada();

        //Añadir elementos a la lista
        lista.añadir(10);
        lista.añadir(20);
        lista.añadir(20);
        lista.añadir(25);
        lista.añadir(3);
        lista.añadir(16);

        //Ejecutar el método contarvalor
        System.Console.WriteLine($"El número de veces que aparece el valor es {lista.contarvalor(5)}");
    }
}
