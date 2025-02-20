/// <summary>
/// user service, for to save
/// user data and send emails
/// </summary>
public class UserService
{
    /// <summary>
    /// save user data and send emails
    /// </summary>
    /// <param name="user">send a email from user</param>
    public void SaveDataUser(User user)
    {
        _ = new EmailSender();
        _ = EmailSender.SendEmail("Sending email", user.Email);
    }
}