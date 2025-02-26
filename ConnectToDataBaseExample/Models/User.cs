 /// <summary>
 /// User model class
 /// </summary>
 public class User
{
    /// <summary>
    /// User ID, can be used as primary key and auto incremented
    /// </summary>
    public int UserID { get; set; }
    /// <summary>
    /// User Name,  it is a string type and can be null
    /// </summary>
    public string? UserName { get; set; }
    /// <summary>
    /// User Email, it is a string type and can be null
    /// </summary>
    public string? UserEmail { get; set; }
}