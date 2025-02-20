public class ShapeService: IShapeSelection
{
    public int SelectionArgument { get; set; }
    public int SelectionArgument2 { get; set; }


    public void GetArgument(int SelectionArgument)
    {
        Console.WriteLine("Ingrese una opción");
        if (SelectionArgument==1)
        {
            
        }else if (SelectionArgument==2)
        {
            
        }
    }
}