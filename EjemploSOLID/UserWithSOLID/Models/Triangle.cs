public class Triangle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }
    public double CalculateArea()
    {
        return 0.5*Height*Width;
    }
}