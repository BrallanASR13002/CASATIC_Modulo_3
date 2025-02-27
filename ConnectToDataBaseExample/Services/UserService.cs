/// <summary>
/// UserService class, it is used to list all users and their orders, implements IUserService
/// </summary>
public class UserService : IUserService
{
    /// <summary>
    /// OutputService object, it is used to style the output
    /// </summary>
    OutputService output = new OutputService();
    /// <summary>
    /// ListUsers method, it is used to list all users and their orders
    /// </summary>
    public void ListUsers()
    {
        // Style the output
        output.StyleOutput();
        // List of users message
        Console.WriteLine("List of users:");
        // Get all users from the database
        using (var db = new AppDbContext())
        {   //declare a list of users
            var users = db.Users.ToList();
            //define a  list of orders
            var orders = db.Orders.ToList();
            //list all users and their orders
            foreach (var order in orders)
            {
                output.StyleOutput();
                //print the order's date from the database
                Console.WriteLine($"Date: {order.OrderDate}");
                //print the user's name
                Console.WriteLine($"User: {order.User?.UserName}");
            }
        }
    }
}
