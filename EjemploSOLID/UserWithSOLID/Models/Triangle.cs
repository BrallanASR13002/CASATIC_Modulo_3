/// <summary>
/// ths Triangle class implements IShape's interface
/// </summary>
public class Triangle : IShape
{
    /// <summary>
    /// implements Height, Width, Area and ValueInput of the interface
    /// </summary>
    public double Width { get; set; }
    public double Height { get; set; }
    public double Area { get; set; }
    public double ValueInput { get; set; }
    /// <summary>
    /// overwrite the CalculateArea method for triangle are
    /// </summary>
    /// <returns>the triangle area</returns>
    public double CalculateArea()
    {
        //assign the keyboard entries at Height variable
        Height = DataInput();
        //assign the keyboard entries at With variable
        Width = DataInput();
        //calculate the Triangle area and assign at area var his value
        Area = Math.Round(0.5 * Height * Width, 2);
        //print in terminal the triangle area's value
        Console.WriteLine($"El valor del area del cuadrado es: {Area}");
        //returns triangle area
        return Area;
    }
/// <summary>
/// overwrite the DataInput method for keyboard entries
/// </summary>
/// <returns>keyboard entries</returns>
    public double DataInput()
    {
        //request keyboard input
        Console.WriteLine("Ingrese el valor: ");
        //assign the keyboard entries at ValueInput var
        ValueInput = Double.Parse(Console.ReadLine()!);
        //returns ValueInput
        return ValueInput;
    }
}