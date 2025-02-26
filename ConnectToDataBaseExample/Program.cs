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
            //define the Users table and display the user ID and user name
            foreach (var user in users)
            {
                Console.WriteLine($"User ID: {user.UserID} || User Name: {user.UserName}");
            }
        } 
        
        Console.WriteLine("____________________________________________________________");

    }
}
