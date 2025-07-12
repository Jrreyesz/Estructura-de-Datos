//Establecemos el número de discos 
int numDiscos = 4;

//Creamos las pilas para cada "Poste"
Stack<int> origen = new Stack<int>();
Stack<int> auxiliar = new Stack<int>();
Stack<int> destino = new Stack<int>();

//Añadimos la cantidad de discos a la pila de origen
for (int i = 0; i < numDiscos; i++)
{
    origen.Push(i + 1);
}

//Llamamos a la función solucion
solucion(numDiscos, origen, destino, auxiliar, "Origen", "Destino", "Auxiliar");


//Creamos la función para solucionar el problema de las Torres de Hanoi
static void solucion(int n, Stack<int> origen, Stack<int> destino, Stack<int> auxiliar, string nombreOrigen, string nombreDestino, string nombreAuxiliar)
{
    //Si el número de discos es uno, solo es necesario un movimiento
    if (n == 1)
    {
        Mover(origen, destino, nombreOrigen, nombreDestino);
        return;
    }
    //Realizamos los movivmientos necesarios
    solucion(n - 1, origen, auxiliar, destino, nombreOrigen, nombreAuxiliar, nombreDestino);
    Mover(origen, destino, nombreOrigen, nombreDestino);
    solucion(n - 1, auxiliar, destino, origen, nombreAuxiliar, nombreDestino, nombreOrigen);
}

//Creamos un método para mover los discos entre las pilas
static void Mover(Stack<int> desde, Stack<int> hacia, string nombreDesde, string nombreHacia)
{
    int disco = desde.Pop();
    hacia.Push(disco);
    System.Console.WriteLine($"Mover el disco {disco} de {nombreDesde} a {nombreHacia}");
}

//Verificamos que la pila de destino este correcta
foreach (int i in destino)
{
    System.Console.WriteLine(i);
}