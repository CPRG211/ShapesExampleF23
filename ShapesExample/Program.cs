namespace ShapesExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double width1 = 10;
            double height1 = 8;
            string color1 = "Blue";

            Rectangle rect1;
            rect1 = new Rectangle(width1, height1, color1);

            Console.WriteLine("Created rect1");

            double width2 = 2;
            double height2 = 8;
            string color2 = "Green";

            Rectangle rect2;
            rect2  = new Rectangle(width2, height2, color2);

            Console.WriteLine("Created rect2");
        }
    }
}