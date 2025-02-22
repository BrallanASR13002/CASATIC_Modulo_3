/// <summary>
/// ShapeService implements IShapeInputService interface
/// </summary>
public class ShapeService : IShapeInputService
{
    /// <summary>
    /// using and implements the IShapeInputService's vars
    /// </summary>
    public int SelectionArgument { get; set; }
    public double AreaValue { get; set; }
    public int dataInput { get; set; }
    /// <summary>
    /// The method GetArgument it's for manage the area calculate type as:
    /// Circle, Rectangle, Square and Triangle shape
    /// </summary>
    /// <returns>The Area value according to Shape type</returns>
    public double GetArgument()
    {
        //using the InputDataShape method
        dataInput = InputDataShape();
        SelectionArgument = dataInput;
        //define the multiple selection with control structure
        switch (SelectionArgument)
        {
            //if the shape is a circle
            case 1:
                //message for the user
                Console.WriteLine("Calculo del Area de un Circulo: ");
                //create a Circle object and initializing
                Circle circle = new Circle();
                //returns AreaValue from CalculateAre method
                return AreaValue = circle.CalculateArea();
            //if the shape is a Square  
            case 2:
                //message for the user
                Console.WriteLine("Calculo del Area de un Cuadrado");
                //create a Square object and initializing
                Square square = new Square();
                //returns AreaValue from CalculateAre method
                return AreaValue = square.CalculateArea();
            case 3:
                //message for the user
                Console.WriteLine("Calculo del Area de un Rectangulo");
                //create a Circle object and initializing
                Rectangle rectangle = new Rectangle();
                //returns AreaValue from CalculateAre method
                return AreaValue = rectangle.CalculateArea();
            //message for the user
            case 4:
                //create a Triangle object and initializing
                Console.WriteLine("Calculo del Area de un Triangulo");
                Triangle triangle = new Triangle();
                //returns AreaValue from CalculateAre method
                return AreaValue = triangle.CalculateArea();
            //is the default case, it will occur whenever the other conditions are not met
            default:
                //message for the user
                Console.WriteLine("La operación no existe");
                //endpoint
                break;
        }
        //returns AreaValues var
        return AreaValue;
    }
    //local method for define the operation type according to shape type
    public int InputDataShape()
    {
        //output message for application's terminal
        Console.WriteLine("Ingrese una opción: ");
        Console.WriteLine("1) Calculo del Area de un Circulo: ");
        Console.WriteLine("2) Calculo del Area de un Cuadrado: ");
        Console.WriteLine("3) Calculo del Area de un Rectangulo: ");
        Console.WriteLine("4) Calculo del Area de un Triangulo: ");
        //assign the data entries at SelectionArgument var
        SelectionArgument = int.Parse(Console.ReadLine()!);
        //show the SelectionArgument in user's terminal
        Console.WriteLine($"Operación a realizar: {SelectionArgument}");
        //returns the SelectionArgument var
        return SelectionArgument;
    }
}