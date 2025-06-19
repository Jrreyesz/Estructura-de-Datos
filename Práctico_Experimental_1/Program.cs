class Program
{
    public static void Main(string[] args)
    {
        Cita cita1 = new Cita();
        DateTime Cita1Fecha = new DateTime(2025, 6, 19, 8, 30, 0);
        cita1.crearCita("Jinsonp", "Reyes Zambrano", Cita1Fecha);

        Cita cita2 = new Cita();
        DateTime Cita2Fecha = new DateTime(2025, 8, 26, 9, 45, 0);
        cita2.crearCita("Bryan", "Reyes Zambrano", Cita2Fecha);

        Cita cita3 = new Cita();
        DateTime Cita3Fecha = new DateTime(2025, 12, 30, 19, 0, 0);
        cita3.crearCita("Henry", "Marin Ávila", Cita3Fecha);

        Cita[] agendamientos = new Cita[] { cita1, cita2, cita3 };

        for (int i = 0; i < agendamientos.Length; i++)
        {
            Console.WriteLine(agendamientos[i]);
        }

        
    }
}
