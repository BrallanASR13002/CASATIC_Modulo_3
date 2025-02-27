// Purpose: Display the users table from the database
class Program
{
    static void Main()
    {   // Display the users table
        Console.WriteLine("Users Table:");
        Console.WriteLine("____________________________________________________________");
        // using the AppDbContext class, for the connection to the database
        using (var context = new AppDbContext())
        {
            // get the users table from the database
            var users = context.Users.ToList();
            var orders = context.Orders.ToList();
            //define the Users table and display the user ID and user name
            foreach (var order in orders)
            {
                Console.WriteLine($"Order ID: {order.OrderID}");
                Console.WriteLine($"User ID: {order.UserID}");
                Console.WriteLine($"User Name: {order.User?.UserName}");
                Console.WriteLine($"User Email: {order.User?.UserEmail}");
                Console.WriteLine($"Order Date: {order.OrderDate}");
                Console.WriteLine("____________________________________________________________");
            }

        }

        Console.WriteLine("____________________________________________________________");

    }
}
