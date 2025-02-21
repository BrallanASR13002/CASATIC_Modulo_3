public class ShapeService : IShapeInputService
{
    public int SelectionArgument { get; set; }
    public double AreaValue { get; set; }
    public int dataInput { get; set; }

    public double GetArgument()
    {

        dataInput=InputDataShape();
        SelectionArgument=dataInput;
        switch (SelectionArgument)
        {
            case 1:
                Console.WriteLine("Calculo del Area de un Circulo: ");
                Circle circle = new Circle();
                return AreaValue=circle.CalculateArea();
            case 2:
                Console.WriteLine("Calculo del Area de un Cuadrado");
                Square square = new Square();
                return AreaValue=square.CalculateArea();
            case 3:
                Console.WriteLine("Calculo del Area de un Rectangulo");
                Rectangle rectangle = new Rectangle();
                return AreaValue=rectangle.CalculateArea();
            case 4:
                Console.WriteLine("Calculo del Area de un Triangulo");
                Triangle triangle = new Triangle();
                return AreaValue=triangle.CalculateArea();
            default:
                Console.WriteLine("La operación no existe");
                break;
        }
        return AreaValue;
    }

    public int InputDataShape()
    {
        Console.WriteLine("Ingrese una opción: ");
        Console.WriteLine("1) Calculo del Area de un Circulo: ");
        Console.WriteLine("2) Calculo del Area de un Cuadrado: ");
        Console.WriteLine("3) Calculo del Area de un Rectangulo: ");
        Console.WriteLine("4) Calculo del Area de un Triangulo: ");
        SelectionArgument = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"Operación a realizar: {SelectionArgument}");
        return SelectionArgument;
    }
}