public struct Cita
{
    private string Nombre;
    private string Apellidos;
    private DateTime FechaHora;

    public string nombre { get => Nombre; set => Nombre = value; }
    public string apellidos { get => Apellidos; set => Apellidos = value; }
    public DateTime fechahora { get => FechaHora; set => FechaHora = value; }

    public void crearCita(string _Nombre, string _Apellidos, DateTime _FechaHora)
    {
        this.Nombre = _Nombre;
        this.Apellidos = _Apellidos;
        this.FechaHora = _FechaHora;
    }

    public override string ToString()
    {
        return $"Cita con {Nombre} {Apellidos} el {FechaHora}";
    }

}