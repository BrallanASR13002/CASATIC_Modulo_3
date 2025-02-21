public class ShapeService : IShapeSelection
{

    public int SelectionArgument { get; set; }
    public void GetArgument(int SelectionArgument)
    {
        Console.WriteLine("Ingrese una opción");
        SelectionArgument = int.Parse(Console.ReadLine());
        switch (SelectionArgument)
        {
            case 1:
                Console.WriteLine("Calculo del Area de un Circulo: ");
                break;
            case 2:
                Console.WriteLine("Calculo del Area de un Cuadrado");
                break;
            case 3:
                Console.WriteLine("Calculo del Area de un Rectangulo");
                break;
            case 4:
                Console.WriteLine("Calculo del Area de un Triangulo");
                break;
            default:
                Console.WriteLine("La operación no existe");
                break;
        }
    }
}