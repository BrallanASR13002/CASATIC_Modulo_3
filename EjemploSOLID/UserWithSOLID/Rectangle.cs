public class Rectangle : IShape
{
    public double Width { get; set; }
    public double Heigth { get; set; }

    public double CalculateArea()
    {
        return Heigth * Width;
    }
}