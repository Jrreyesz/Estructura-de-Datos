class Programa
{
    static void Main(string[] args)
    {
        
        Circulo objCirculo = new Circulo(); //Creamos el objeto Circulo de la clase circulo
        objCirculo.Radio = 4.6; //Le damos un valor a su atributo radio
        Console.WriteLine(objCirculo.calcular_area()); //Llamamos al método calcular_area para que se ejecute
        Console.WriteLine(objCirculo.calcular_perimetro()); //Llamamos al método calcular_perimetro para que se ejecute

        Console.WriteLine("======================================"); 

        Rectangulo objRectangulo = new Rectangulo(); //Creamos el objeto Rectángulo de la clase Rectangulo
        objRectangulo.Laaltura = 2.3; //Le damos un valor al atributo altura
        objRectangulo.Labase = 5; //Le damos un valor al atributo base
        Console.WriteLine(objRectangulo.AreaRectangulo()); //Llamamos al método AreaRectangulo para que se ejecute
        Console.WriteLine(objRectangulo.PerimetroRectangulo()); //Lllamamos al método PerimetroRectangulo y se ejecuta

    }


}