namespace lab1_2
{
    public class Rectangle
    {
        private double side1;
        private double side2;

        public Rectangle(double sideA, double sideB)
        {
            side1 = sideA;
            side2 = sideB;
        }

        private double CalculateArea()
        {
            return side1 * side2;
        }

        private double CalculatePerimeter()
        {
            return 2 * (side1 + side2);
        }

        public double Area
        {
            get { return CalculateArea(); }
        }

        public double Perimeter
        {
            get { return CalculatePerimeter(); }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the first side of the rectangle: ");
            double sideA = double.Parse(Console.ReadLine());

            Console.Write("Enter the length of the second side of the rectangle: ");
            double sideB = double.Parse(Console.ReadLine());

            Rectangle rectangle = new Rectangle(sideA, sideB);

            Console.WriteLine($"The perimeter of the rectangle is: {rectangle.Perimeter}");
            Console.WriteLine($"The area of the rectangle is: {rectangle.Area}");
        }
    }
}
