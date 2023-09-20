namespace ShapesExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double width1 = 10;
            double height1 = 10;
            string color1 = "Blue";

            Rectangle rect1;
            rect1 = new Rectangle(width1, height1, color1);

            double perimeter1 = rect1.CalcPerimeter();
            double area1 = rect1.CalcArea();

            Console.WriteLine("rect1 perimeter = " + perimeter1);
            Console.WriteLine("rect1 area = " + area1);

            Console.WriteLine("Created rect1");

            double width2 = 2;
            double height2 = 8;
            string color2 = "Green";

            Rectangle rect2;
            rect2  = new Rectangle(width2, height2, color2);

            Console.WriteLine("Created rect2");

            Console.WriteLine("rect2 perimeter = " + rect2.CalcPerimeter());
            Console.WriteLine("rect2 area = " + rect2.CalcArea());

            Square square1 = new Square(15, "Blue");

            double squareArea1 = square1.CalcArea();
            Console.WriteLine("square1 area = " + squareArea1);
        }
    }
}