using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Users Table:");
        Console.WriteLine("____________________________________________________________");
        using (var context = new AppDbContext())
        {
            var users = context.users.ToList();

            foreach (var user in users)
            {
                Console.WriteLine($"User ID: {user.ID} || User Name: {user.UserName}");
            }
        }
        Console.WriteLine("____________________________________________________________");

    }
}
