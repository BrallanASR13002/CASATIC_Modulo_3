public class UserService
{
    public void SaveDataUser(User user)
    {
        EmailSender emailSender = new EmailSender();
        emailSender.SendEmail("Enviando correo", user.Email);
    }
}