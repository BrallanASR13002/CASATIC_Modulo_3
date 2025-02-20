//
public class Rectangle : IShape
{
/// <summary>
/// implements IShape interface
/// </summary>
    public double Width { get; set; }
    public double Height { get; set; }
/// <summary>
/// method for to calculate the rectangle's area
/// </summary>
/// <returns>the rectangle's area</returns>
    public double CalculateArea()
    {
        return Height * Width;
    }
}