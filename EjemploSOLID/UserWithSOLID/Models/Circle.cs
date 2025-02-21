public class Circle : IShapeAreaCalculator
{
    public double Radius { get; set; }
    public double Area { get; set; }
    public double ValueInput { get; set; }

    public double CalculateArea()
    {
        Radius=DataInput();
        Area=Math.Round(Math.PI * Math.Pow(Radius, 2),2);
        Console.WriteLine($"El valor del area del circulo es: {Area}");
        return Area;
    }

    public double DataInput()
    {
        Console.WriteLine("Ingrese el valor del radio: ");
        ValueInput = Double.Parse(Console.ReadLine()!);
        return ValueInput;
    }
}