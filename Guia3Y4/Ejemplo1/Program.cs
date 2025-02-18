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
        Console.WriteLine(areaCircle.ShapeArea());

    }
}