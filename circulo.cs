//clase circulo
public class Circulo : FormaGeometrica{

    //se crea el atributo
    public double Radio;

    public Circulo(double radio){

        //se le da valor a el atributo
        Random rand=new Random();
        Radio=rand.Next(1, 9);
    }
    //se sobre escribe el metodo de calcular area
    public override double CalcularArea(){
        
        return 3.14*Radio*Radio;
    }
}

