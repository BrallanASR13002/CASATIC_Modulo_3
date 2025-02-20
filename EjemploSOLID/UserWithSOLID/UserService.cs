public class UserService
{
    public void SaveDataUser(User user)
    {
        _ = new EmailSender();
        _ = EmailSender.SendEmail("Enviando correo", user.Email);
    }
}