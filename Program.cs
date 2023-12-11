// principio Open/Close
//abierto para extender cerrado para modificar 
class Program{

    static void Main(){
        
        // Crear instancias de formas geométricas
        Circulo circulo = new Circulo(5);
        Rectangulo rectangulo = new Rectangulo(4, 6);
        Triangulo triangulo = new Triangulo(3,4);


        // Calcular el área de cada forma geométrica por separado
        Console.WriteLine("El área del círculo es: "+circulo.CalcularArea()+"cm²");
        Console.WriteLine("El área del rectángulo es: "+rectangulo.CalcularArea()+"cm²");
        Console.WriteLine("El área del Triangulo es: "+triangulo.CalcularArea()+"cm²");
      

    }
}
