public class Program
{
    public static void Main(string[] args)
    {
        //Creamos el abrol binario de búsqueda
        var arbol = new ArbolBinario();

        //Creamos un diccionario para almacenar los valores de los vuelos
        Dictionary<string, int> vuelos = new Dictionary<string, int>
        {
            {"Iberia", 950},
            {"Brittish Airways", 150},
            {"Air France", 120},
            {"Lufthansa", 135},
            {"KLM", 115},
            {"American Airlines", 1100},
            {"United Airlines", 1050},
            {"Delta", 1080},
            {"Air Canada", 990},
            {"Alitalia", 105},
            {"Swiss", 160},
            {"Turkish Airlines", 480},
            {"SAS", 190},
            {"Aer Lingus", 185},
            {"TAP Air Portugal", 95},
            {"Aeroflot", 550},
            {"Austrian Airlines", 145},
            {"LATAM", 1150},
            {"Aeroméxico", 890},
            {"Avianca", 980}
        };

        //Con la ayuda de un bucle recorremos los precios de 
        foreach (int precio in vuelos.Values)
        {
            arbol.Insertar(precio);
        }

        int menorValor = arbol.menorPrecio();

        foreach (string aerolinea in vuelos.Keys)
        {
            if (aerolinea.Value == menorValor)
            {
                System.Console.WriteLine($"La aerolínea con el vuelo más económico es {aerolinea} con un valor de {menorValor}.");
            }
        }
    }
}


