using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace BlackCoderBlogMaster.Contexts;

public class BlackCoderBlogMasterDbContextFactory : IDesignTimeDbContextFactory<BlackCoderBlogMasterDbContext>
{
    public BlackCoderBlogMasterDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<BlackCoderBlogMasterDbContext>();
        optionsBuilder.UseSqlServer("Server=.;Database=BlackCoderBlackCoderBlogMasterDb;Trusted_Connection=True;");

        return new BlackCoderBlogMasterDbContext(optionsBuilder.Options);
    }
}