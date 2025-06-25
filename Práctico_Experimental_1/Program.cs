class Program
{
    public static void Main(string[] args)
    {
        //Creamos citas para la agenda asignándo todos sus atributos
        Cita cita1 = new Cita();
        DateTime Cita1Fecha = new DateTime(2025, 6, 19, 8, 30, 0);
        cita1.crearCita("Jinsonp", "Reyes Zambrano", Cita1Fecha);

        Cita cita2 = new Cita();
        DateTime Cita2Fecha = new DateTime(2025, 8, 26, 9, 45, 0);
        cita2.crearCita("Bryan", "Reyes León", Cita2Fecha);

        Cita cita3 = new Cita();
        DateTime Cita3Fecha = new DateTime(2025, 12, 30, 19, 0, 0);
        cita3.crearCita("Henry", "Marin Ávila", Cita3Fecha);

        //Creamos un array con todas las citas de la agenda
        Cita[] agendamientos = new Cita[] { cita1, cita2, cita3 };

        //Visualizamos las citas de la agenda
        for (int i = 0; i < agendamientos.Length; i++)
        {
            Console.WriteLine(agendamientos[i]);
        }

        //Buscamos una cita en el agendamiento
        for (int i = 0; i < agendamientos.Length; i++)
        {
            if ("Reyes Zambrano" == agendamientos[i].apellidos)
            {
                Console.WriteLine($"El paciente {agendamientos[i].apellidos} tiene su cita el {agendamientos[i].fechahora}");
            }
        }

        
    }
}
