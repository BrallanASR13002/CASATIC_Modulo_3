internal class Program
{
    private static void Main(string[] args)
    {
        OrderService orderService = new OrderService();
        orderService.CanContinue();
    }
}