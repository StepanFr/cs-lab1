using lab1_3;

namespace test_lab_1_3
{
    [TestFixture]
    public class FigureTests
    {
        [Test]
        public void TestLengthSide()
        {
            Point p1 = new Point(0, 0);
            Point p2 = new Point(3, 4);
            Point p3 = new Point(4, 3);
            Figure figure = new Figure(p1, p2, p3);

            double length = figure.LengthSide(p1, p2);
            Assert.That(length, Is.EqualTo(5.0).Within(0.001));
        }

        [Test]
        public void TestPerimeterCalculator()
        {
            Point p1 = new Point(0, 0);
            Point p2 = new Point(4, 0);
            Point p3 = new Point(4, 3);
            Point p4 = new Point(0, 3);
            Figure figure = new Figure(p1, p2, p3, p4)
            {
                Name = "Rectangle"
            };

            double perimeter = figure.PerimeterCalculator();
            Assert.That(perimeter, Is.EqualTo(14.0).Within(0.001));
        }
    }
}