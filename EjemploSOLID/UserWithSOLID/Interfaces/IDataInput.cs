/// <summary>
/// Interface for to capture data input using a input value
/// </summary>
public interface IDataInput
{
    /// <summary>
    /// its a input parameter
    /// </summary>
    double ValueInput { get; set; }
    /// <summary>
    /// method for to capture data entrance
    /// </summary>
    /// <returns>input value data</returns>
    double DataInput();

}