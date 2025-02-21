internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        ShapeService shapeService = new ShapeService();
        shapeService.GetArgument();
    }
}