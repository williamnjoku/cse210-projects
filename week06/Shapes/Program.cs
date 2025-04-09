using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Black", 5);
        square.SetColor("Blue");
        

        Rectangle rectangle = new Rectangle("Blue", 4, 4);
        rectangle.SetColor("Green");
        

        Circle circle = new Circle("Grey", 10);
        circle.SetColor("Brown");
        

        List<Shape> shapes = new List<Shape>()
        {
            square, rectangle, circle
        };
       

        foreach (Shape s in shapes)
        {
            Console.WriteLine(s.GetColor());
            Console.WriteLine(s.GetArea());

        }
        
    }
}