public class Circle : Shape
{
    public int Radius { get; set; }
    public double CircleArea { get; set; }
    Circle circle = new Circle();
    Radius = 3;
    CircleArea = Circle.ShapeArea(Radius);
    public double ShapeArea(int Radius)
    {
        return Math.PI * Radius * Radius;
    }
}