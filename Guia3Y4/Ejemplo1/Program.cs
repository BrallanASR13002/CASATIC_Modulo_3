/* This C# program calculates the area of a circle based on user input for the radius. */
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Calculo del area");
        Console.WriteLine("Area de un circulo:");
        /* The line `Circle areaCircle = new Circle();` is creating a new instance of the `Circle` class and
        assigning it to the variable `areaCircle`. This allows you to work with the properties and methods
        of the `Circle` class using the `areaCircle` object. In this specific context, it is used to
        calculate the area of a circle based on user input for the radius. */
        Circle areaCircle = new Circle();
        Console.WriteLine("Ingrese el valor del radio del circulo: ");
        /* The line `areaCircle.Radius = Double.Parse(Console.ReadLine());` is taking user input from the
        console, converting it to a double data type using `Double.Parse()`, and then assigning that value
        to the `Radius` property of the `areaCircle` object. This allows the user to input the radius of the
        circle, which is then used in the calculation of the circle's area. */
        areaCircle.Radius = Double.Parse(Console.ReadLine());
        /* The line `Console.WriteLine(areaCircle.ShapeArea());` is calling the `ShapeArea()` method of the
        `areaCircle` object and then printing the result to the console. */
        Console.WriteLine($"El area del circulo es: {areaCircle.ShapeArea()}");
        Console.WriteLine("Area de un cuadrado");
        /* The line `Square areaSquare = new Square();` is creating a new instance of the `Square` class and
        assigning it to the variable `areaSquare`. This allows you to work with the properties and methods
        of the `Square` class using the `areaSquare` object. In this specific context, it is used to
        calculate the area of a square based on user input for the lengths of its sides. */
        Square areaSquare = new Square();
        /* The code snippet you provided is responsible for taking user input for the lengths of the sides of a
        square. Here's a breakdown of what each line is doing: */
        Console.WriteLine("Ingrese el valor del primer lado del cuadrado: ");
        areaSquare.Slide1 = Double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el valor del segundo lado del cuadrado: ");
        areaSquare.Slide2 = Double.Parse(Console.ReadLine());
        /* The line `Console.WriteLine($"El area de un cuadrado es: "+
        "{areaSquare.ShapeArea2(areaSquare.Slide1, areaSquare.Slide2)}");` is attempting to print the
        calculated area of a square to the console. However, there seems to be a syntax error in the way the
        string interpolation is being used. */
        Console.WriteLine($"El area de un cuadrado es: " +
        $"{areaSquare.ShapeArea2(areaSquare.Slide1, areaSquare.Slide2)}");
        /* This portion of the C# program is responsible for calculating the area of a triangle based
        on user input for the height and base of the triangle. Here's a breakdown of what each line
        is doing: */
        Console.WriteLine("Area de un triangulo");
        Triangle areaTriangle = new Triangle();
        Console.WriteLine("Ingrese el valor de la altura del triangulo: ");
        areaTriangle.Heigth = Double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el valor de la base del triangulo: ");
        areaTriangle.With = Double.Parse(Console.ReadLine());
        Console.WriteLine($"El area de un triangulo es: {areaTriangle.Area()}");
    }
}