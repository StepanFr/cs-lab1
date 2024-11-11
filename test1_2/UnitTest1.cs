using lab1_2;
using NUnit.Framework;

[TestFixture]
public class RectangleTests
{
    [Test]
    public void TestCalculateArea()
    {
        // Arrange
        Rectangle rectangle = new Rectangle(5, 3);

        // Act
        double area = rectangle.Area;

        // Assert
        Assert.That(area, Is.EqualTo(15));
    }

    [Test]
    public void TestCalculatePerimeter()
    {
        // Arrange
        Rectangle rectangle = new Rectangle(5, 3);

        // Act
        double perimeter = rectangle.Perimeter;

        // Assert
        Assert.That(perimeter, Is.EqualTo(16));
    }
}
