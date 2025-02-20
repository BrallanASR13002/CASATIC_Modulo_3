public class Triangle : IShape
{
    public double Width { get; set; }
    public double Heigth { get; set; }

    public double CalculateArea()
    {
        return 0.5*Heigth*Width;
    }
}