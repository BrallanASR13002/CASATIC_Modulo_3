
using System.ComponentModel.DataAnnotations;

/// <summary>
/// Orders model class, it has a foreign key to User model and a primary keys
/// </summary> 
public class Order
{ 
    /// <summary>
    /// Order ID, can be used as primary key and auto incremented
    /// </summary> 
    [Key]
    public int OrderID { get; set; }
    /// <summary>
    /// User ID, can be used as foreign key
    /// </summary>
    public int? UserID {get; set;} 
    public User? User { get; set; }
    /// <summary>
    /// Order Date, it is a DateTime type, can be null
    /// </summary>
    public DateTime OrderDate { get; set; }
}