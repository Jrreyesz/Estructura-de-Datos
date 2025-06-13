public class Estudiante //Creamos la clase Estudiante
{
    //Definimos los atributos de la clase Estudiante encapsulados
    private int idUnico;
    private string Nombres;
    private string Apellidos;
    private string Direccion;
    private int[] Telefonos = new int[3];
    //Creamos un get y set para los atributos encapsulados 
    public int IdUnico { get => idUnico; set => idUnico = value; }
    public string nombres { get => Nombres; set => Nombres = value; }
    public string apellidos { get => Apellidos; set => Apellidos = value; }
    public string direccion { get => Direccion; set => Direccion = value; }
    public int[] telefonos { get => Telefonos; set => Telefonos = value; }

    //Establecemos el método para crear el objeto estudiante
    public void crearEstudiante(int _idUnico, string _Nombres, string _Apellidos, string _Direccion, int[] _Telefonos)
    {
        this.idUnico = _idUnico;
        this.Nombres = _Nombres;
        this.Apellidos = _Apellidos;
        this.Direccion = _Direccion;
        this.Telefonos = _Telefonos;
    }


}