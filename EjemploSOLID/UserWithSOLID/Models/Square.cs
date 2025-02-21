/// <summary>
/// the Square class implements a IShape interface
/// </summary>
public class Square : IShape
{
    /// <summary>
    /// Implements the IShape interface's variables
    /// </summary>
    public double Width { get; set; }
    public double Height { get; set; }
    public double Area { get; set; }
    public double ValueInput { get; set; }
    /// <summary>
    /// overwrite the CalculateArea method of the IShape interface
    /// </summary>
    /// <returns> the Square area</returns>
    public double CalculateArea()
    {
        //define the Height value using DataInput method
        Height = DataInput();
        //define the Width value using DataInput method
        Width = DataInput();
        //calculate the Square area and assigns the value in Area variable
        Area = Math.Round(Height * Width, 2);
        //show the area value
        Console.WriteLine($"El valor del area del cuadrado es: {Area}");
        return Area;
    }
    /// <summary>
    /// overwrite the DataInput method of the IShape interface
    /// </summary>
    /// <returns> keyboard data entries</returns>
    public double DataInput()
    {
        //obtains the keyboards entries
        Console.WriteLine("Ingrese el valor: ");
        //assigns keyboard entries and convert to double type at the ValueInput variable
        ValueInput = Double.Parse(Console.ReadLine()!);
        //returns ValueInput variable
        return ValueInput;
    }
}