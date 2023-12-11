//clase triangulo
public class Triangulo : FormaGeometrica{

    //se crean los atributos
    public double Base;
    public double Altura;
    
    public Triangulo(double basetriangulo, double alturatriangulo){

        //se les da valor a los atributos
        Random rand = new Random();

        Base=rand.Next(3,4);
        Altura=rand.Next(2,6);

    }
    //se sobre escribe el metodo de calcular area
    public override double CalcularArea(){

        return (Base*Altura)/2;
    }
}