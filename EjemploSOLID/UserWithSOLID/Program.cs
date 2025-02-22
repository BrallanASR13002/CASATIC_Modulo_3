/// <summary>
/// principal class of the project
/// </summary>
internal class Program
{
    /// <summary>
    /// Principal method of the program
    /// </summary>
    /// <param name="args">It's the entry point of the application, where program control starts and ends</param>
    private static void Main(string[] args)
    {
        //create and initializing the shapeService object
        ShapeService shapeService = new ShapeService();
        //using the GetArgument method to calculate the area of ​​a shape
        shapeService.GetArgument();
    }
}