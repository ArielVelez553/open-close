//clase rectangulo
public class Rectangulo : FormaGeometrica{

    //se crean los atributos    
    public double Altura; 
    public double Base;

    public Rectangulo(double altura,double basee){

        //se les da valor a los atributos
        Random rand=new Random();

        Altura=rand.Next(3,12);
        Base=rand.Next(9,16);

    }
    //se sobre escribe el metodo de calcular area
    public override double CalcularArea(){

        return Altura*Base;
    }
}
