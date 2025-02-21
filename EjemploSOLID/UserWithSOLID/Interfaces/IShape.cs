/// <summary>
/// IShape's interface implements a IShapeAreaCalculator's interface
/// </summary>
interface IShape : IShapeAreaCalculator
{
    /// <summary>
    /// defines two input variables for the Shape interface
    /// </summary>
    double Width { get; set; }
    double Height { get; set; }
}