public interface IShapeInputService : IShapeSelection
{

    public int SelectionArgument { get; set; }
    double AreaValue { get; set; }

    int InputDataShape();

}