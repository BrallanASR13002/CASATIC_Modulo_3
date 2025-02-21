/// <summary>
/// circle class implements a IShapeAreaCalculator's Interface
/// </summary>
public class Circle : IShapeAreaCalculator
{
    /// <summary>
    /// circle class implements the area, value input of IShapeAreaCalculator
    /// radius it's the local input variable for to capture the input value.
    /// </summary>
    public double Radius { get; set; }
    public double Area { get; set; }
    public double ValueInput { get; set; }
    /// <summary>
    /// overwrite the CalculateArea's method for to calculate the Circle's area
    /// </summary>
    /// <returns>Circle's Area</returns>
    public double CalculateArea()
    {
        //capture the data input in Radius variable
        Radius = DataInput();
        //using two significative decimals for  circle area's value
        Area = Math.Round(Math.PI * Math.Pow(Radius, 2), 2);
        //show the area value
        Console.WriteLine($"El valor del area del circulo es: {Area}");
        return Area;
    }
    /// <summary>
    /// overwrite the data input method of IShapeAreaCalculator's interface
    /// </summary>
    /// <returns>the input data argument for CalculateArea's method</returns>
    public double DataInput()
    {
        //obtain the data input from keyboard 
        Console.WriteLine("Ingrese el valor del radio: ");
        //assign the input value to ValueInput variable
        ValueInput = Double.Parse(Console.ReadLine()!);
        //return the ValueInput variable
        return ValueInput;
    }
}