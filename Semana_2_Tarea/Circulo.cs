using System.Formats.Asn1;

public class Circulo //Creamos la clase círculo
{
    private double radio; //Creamos el atributo radio

    public double Radio { get => radio; set => radio = value; } //Creamos un get y set para el atributo

    public string calcular_area() //Método para calcular el área del circulo
    {
        double resultadoArea = Math.PI * Radio * Radio;
        return "El área del círculo es: " + resultadoArea;

    }

    public string calcular_perimetro() //Método para calcular el perímetro del círculo
    {
        double resultadoPerimetro = 2 * Math.PI * Radio;
        return "El perímetro del círculo es: " + resultadoPerimetro;
    }

}