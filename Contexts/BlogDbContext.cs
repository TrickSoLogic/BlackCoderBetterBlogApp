using System.Reflection;
using BlackCoderBlogMaster.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlackCoderBlogMaster.Contexts;

public class BlackCoderBlogMasterDbContext : DbContext
{
    public BlackCoderBlogMasterDbContext(DbContextOptions<BlackCoderBlogMasterDbContext> options) : base(options)
    {
        
    }

    DbSet<Article> Articles => Set<Article>();
    DbSet<Author> Authors => Set<Author>();
    DbSet<Category> Categories => Set<Category>();
    DbSet<Comment> Comments => Set<Comment>();
    DbSet<Photo> Photos => Set<Photo>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}