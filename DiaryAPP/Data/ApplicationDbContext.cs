using DiaryAPP.Models;
using Microsoft.EntityFrameworkCore;
namespace DiaryAPP.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    //Add a DbSet that is used to interact with the DiaryEntry model
    public DbSet<DiaryEntry> DiaryEntries { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // Seed initial data for the DiaryEntry table
        modelBuilder.Entity<DiaryEntry>().HasData(
          new DiaryEntry
          {
              Id = 1,
              Title = "Went Hiking",
              Content = "Went hiking with Joe!",
              Created = new DateTime(2024, 6, 17)
          },

          new DiaryEntry
          {
              Id = 2,
              Title = "Went to the Beach",
              Content = "Went to the beach with Joe!",
              Created = new DateTime(2023, 6, 17)
          },

          new DiaryEntry
          {
              Id = 3,
              Title = "Went to the Movies",
              Content = "Went to the movies with Joe!",
              Created = new DateTime(2022, 6, 17)
          }



            );

    }
}
