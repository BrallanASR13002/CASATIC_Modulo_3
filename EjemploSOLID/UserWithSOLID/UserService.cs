class UserService
{
    public void SaveToDatabase(User user)
    {
        EmailSender emailSender = new EmailSender();
        emailSender.SendEmail("Enviando correo", user.Email);
    }
}