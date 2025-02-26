/// <summary>
/// AppDbContext class, it is a DbContext class that inherits from DbContext
/// </summary>
using Microsoft.EntityFrameworkCore;
/// <summary>
/// AppDbContext class, it is a DbContext class that inherits from DbContext
/// </summary>
public class AppDbContext : DbContext
{
    /// <summary>
    /// DbSet of Orders, it is a table that will be created in the database
    /// </summary>
    public DbSet<User> Users { get; set; }
    /// <summary>
    /// DbSet of Orders, it is a table that will be created in the database
    /// </summary>
    /// <param name="optionsBuilder">using for configure the DbContext objet </param>
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // using Npgsql provider and the connection string
        optionsBuilder.UseNpgsql(
            "Host=localhost;"
            + "Port=5432;"
            + "Database=DBProducts;"
            + "Username=postgres;"
            + "Password=B@sanchez93");
    }
    /// <summary>
    /// OnModelCreating method, it is used to configure the model that was defined in the DbContext class
    /// </summary>
    /// <param name="modelBuilder"></param>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().ToTable("Users", schema: "public");
    }

}
