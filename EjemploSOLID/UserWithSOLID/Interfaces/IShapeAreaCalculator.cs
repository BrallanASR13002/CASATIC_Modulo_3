/// <summary>
/// IShapeAreaCalculator's interface implements a DataInput's interface
/// </summary>
interface IShapeAreaCalculator:IDataInput
{
    /// <summary>
    /// define a output data type
    /// </summary>
    double Area { get; set; }
}