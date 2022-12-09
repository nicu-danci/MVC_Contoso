using ContosoUniversity.Data;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

public class SchoolDbContextFactory : IDesignTimeDbContextFactory<SchoolContext>
{
    public SchoolContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<SchoolContext>();
        optionsBuilder.UseSqlServer("Server=YourServer; Database=YourDb; Integrated Security=true; MultipleActiveResultSets=true; Trusted_Connection=True");

        return new SchoolContext(optionsBuilder.Options);
    }
}