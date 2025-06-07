public class Rectangulo //Creamos la clase
{
    private double labase; //Encapsulamos el atributo 
    private double laaltura; //Encapsulamos el atributo

    public double Labase { get => labase; set => labase = value; } //Creamos un set y get para el atirbuto 
    public double Laaltura { get => laaltura; set => laaltura = value; } //Creamos un set y get para el atirbuto 

    public string AreaRectangulo() //Creamos el método que va a calcular el área del rectángulo 
    {
        double resultadoAreaRectangulo = Labase * Laaltura;
        return $"El área del rectángulo es: {resultadoAreaRectangulo}";
    }

    public string PerimetroRectangulo() //Creamos el método que va a calcular el perímetro del rectángulo 
    {
        double resultadoPerimetroRectangulo = (2 * Labase) + (2 * Laaltura);
        return $"El perímetro del rectángulo es de {resultadoPerimetroRectangulo}"; 
    }

}