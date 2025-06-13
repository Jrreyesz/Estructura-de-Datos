class Program
{
    static void Main(string[] args)
    {
        Estudiante objEstudiante = new Estudiante(); //Creamos el objeto estudiante
        int[] telefonos = new int[] { 997449973, 992241405, 998609762 }; //Asignamos los valores al array
        //otorgamos los atributos al objeto
        objEstudiante.crearEstudiante(001, "Jinsonp Romario", "Reyes Zambrano", "Av. Kennedy", telefonos); 
        //Imprimimos en pantalla los datos del estudiante
        System.Console.WriteLine("ID Único: " + objEstudiante.IdUnico + " Nombres: " + objEstudiante.nombres + " Apellidos: " + objEstudiante.apellidos + " Dirección: " + objEstudiante.direccion + " Telefonos: " + string.Join(", ", objEstudiante.telefonos));
    }
}
