/// <summary>
/// IShapeInputService's interface implements a IShapeSelection's interface
/// </summary>
public interface IShapeInputService : IShapeSelection
{
    /// <summary>
    /// data output variable for to obtain area's value
    /// </summary>
    double AreaValue { get; set; }
    /// <summary>
    /// method for to obtain the input parameter for to calculate the shape's area.
    /// </summary>
    /// <returns>data input for shape's area calculate</returns>
    int InputDataShape();

}