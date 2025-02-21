
public class Rectangle : IShape
{
    /// <summary>
    /// implements IShape interface
    /// </summary>
    public double Width { get; set; }
    public double Height { get; set; }
    public double ValueInput { get; set; }
    public double Area { get; set; }
    /// <summary>
    /// method for to calculate the rectangle's area
    /// </summary>
    /// <returns>the rectangle's area</returns>
    public double CalculateArea()
    {
        Height = DataInput();
        Width = DataInput();
        Area = Math.Round(Height * Width, 2);
        Console.WriteLine($"El valor del area del rectangulo es: {Area}");
        return Area;
    }
    public double DataInput()
    {
        Console.WriteLine("Ingrese el valor: ");
        ValueInput = Double.Parse(Console.ReadLine());
        return ValueInput;
    }
}