public class Program
{
    public static void Main()
    {
        // Create a new instance of the UserService class
        IUserService userService = new UserService();
        // Call the ListUsers method
        userService.ListUsers();
    }
}