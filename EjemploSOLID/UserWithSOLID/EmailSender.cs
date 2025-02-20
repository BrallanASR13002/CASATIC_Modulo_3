public class EmailSender
{
    public static string SendEmail(string? message, string? Email)
    {
        return $"email enviado {Email}: {message}";
    }
}