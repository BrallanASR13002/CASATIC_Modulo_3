public class UserService : IUserService
{
    Output output = new Output();
    public void ListUsers()
    {
        output.StyleOutput();
        Console.WriteLine("List of users:");
        using (var db = new AppDbContext())
        {
            var users = db.Users.ToList();
            var orders = db.Orders.ToList();
            foreach (var order in orders)
            {
                output.StyleOutput();
                Console.WriteLine($"Date: {order.OrderDate}");
                Console.WriteLine($"User: {order.User?.UserName}");
            }
        }
    }
}
