public struct Cita //Creamos una estructura para las Citas médicas
{
    //Asignamos sus atributos y los encapsulamos
    private string Nombre; 
    private string Apellidos;
    private DateTime FechaHora;

    //Creamos un get  y set para cada atributo
    public string nombre { get => Nombre; set => Nombre = value; }
    public string apellidos { get => Apellidos; set => Apellidos = value; }
    public DateTime fechahora { get => FechaHora; set => FechaHora = value; }

    //Creamos el método para crear el objeto
    public void crearCita(string _Nombre, string _Apellidos, DateTime _FechaHora)
    {
        this.Nombre = _Nombre;
        this.Apellidos = _Apellidos;
        this.FechaHora = _FechaHora;
    }

    //Método para obtener los objetos en String
    public override string ToString()
    {
        return $"Cita con {Nombre} {Apellidos} el {FechaHora}";
    }

}