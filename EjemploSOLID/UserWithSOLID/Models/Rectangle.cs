
/// <summary>
/// the class Rectangle implements a IShape interface
/// </summary>
public class Rectangle : IShape
{
    /// <summary>
    /// implements IShape's interface variables
    /// </summary>
    public double Width { get; set; }
    public double Height { get; set; }
    public double ValueInput { get; set; }
    public double Area { get; set; }
    /// <summary>
    /// overwrite the method for to calculate the rectangle's area
    /// </summary>
    /// <returns>the rectangle's area</returns>
    public double CalculateArea()
    {
        //define the Height value using DataInput method
        Height = DataInput();
        //define the Height value using DataInput method
        Width = DataInput();
        //calculate the Rectangle's area and define two decimals
        Area = Math.Round(Height * Width, 2);
        //show the area value
        Console.WriteLine($"El valor del area del rectangulo es: {Area}");
        //returns the Area value
        return Area;
    }
    /// <summary>
    /// overwrite the DataInput method for to obtain the Height and Width values
    /// </summary>
    /// <returns>the data input from keyboard</returns>
    public double DataInput()
    {
        //obtain the keyboard entries from user
        Console.WriteLine("Ingrese el valor: ");
        ValueInput = Double.Parse(Console.ReadLine()!);
        //returns the data input using the ValueInput variable
        return ValueInput;
    }
}