namespace lab1_3
{
    public class Point
    {
        private int x;
        private int y;

        //свойства для доступа к полям
        public int X
        {
            get { return x; }
        }

        public int Y
        {
            get { return y; }
        }

        //инициализация полей
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public class Figure
    {
        //массив точек для хранения вершин фигуры
        private Point[] points;
        Point p1;
        Point p2;
        Point p3;
        Point p4;
        Point p5;
        //автосвойство для хранения названия фигуры
        public string Name { get; set; }


        public Figure(Point p1, Point p2, Point p3)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            Name = "Triangle";
        }

        public Figure(Point p1, Point p2, Point p3, Point p4) : this([p1, p2, p3]) 
        { 
            this.p4 = p4;
            Name = "Square";
        }

        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5) : this([p1, p2, p3, p4])
        {
            this.p5 = p5;
            Name = "Pentagon";
        }

        //приватный конструктор для инициализации массива точек
        private Figure(Point[] points)
        {
            this.points = points;
        }

        //вычисление длины стороны
        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
        }

        //вычисление периметра многоугольника
        public double PerimeterCalculator()
        {
            double perimeter = 0;
            for (int i = 0; i < points.Length; i++)
            {
                Point current = points[i];
                Point next = points[(i + 1) % points.Length];
                perimeter += LengthSide(current, next);
            }
            return perimeter;
        }
    }

    class Program
    {
        static void Main()
        {
            Point p1 = new Point(0, 0);
            Point p2 = new Point(4, 0);
            Point p3 = new Point(4, 3);
            Point p4 = new Point(0, 3);

            Figure rectangle = new(p1, p2, p3, p4);
           

            Console.WriteLine($"Figure Name: {rectangle.Name}");
            Console.WriteLine($"Perimeter: {rectangle.PerimeterCalculator()}");
        }
    }
}
