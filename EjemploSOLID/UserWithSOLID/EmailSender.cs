/// <summary>
/// EmailSender class for send emails by the user
/// </summary>
public class EmailSender
{
/// <summary>
/// method for send emails
/// </summary>
/// <param name="message">user message</param>
/// <param name="Email">user email</param>
/// <returns>message of the email was sended</returns>
    public static string SendEmail(string? message, string? Email)
    {
        return $"email enviado {Email}: {message}";
    }
}