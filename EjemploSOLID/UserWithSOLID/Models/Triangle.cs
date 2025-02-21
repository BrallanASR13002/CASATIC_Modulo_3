public class Triangle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }
    public double Area { get; set; }
    public double ValueInput { get; set; }

    public double CalculateArea()
    {
        Height = DataInput();
        Width = DataInput();
        Area = Math.Round(0.5 * Height * Width, 2);
        Console.WriteLine($"El valor del area del cuadrado es: {Area}");
        return Area;
    }

    public double DataInput()
    {
        Console.WriteLine("Ingrese el valor: ");
        ValueInput = Double.Parse(Console.ReadLine());
        return ValueInput;
    }
}