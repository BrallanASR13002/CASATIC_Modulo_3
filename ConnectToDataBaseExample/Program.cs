public class Program
{
    public static void Main()
    {
        IUserService userService = new UserService();
        userService.ListUsers();
    }
}