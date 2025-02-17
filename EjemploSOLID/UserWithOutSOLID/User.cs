class User
{
    public string name;
    public string email;
    public User(string name, string email)
    {
        this.name = name;
        this.email = email;
    }
    public string saveToDatabase(string name)
    {
        return name;
    }
    public string sendEmail(string email)
    {
        return email;
    }
}