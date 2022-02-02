using Microsoft.EntityFrameworkCore;
using WordleCopy.Core;
using WordleCopy.Core.Entities;

namespace WordleCopy.Infrastructure.Data;

public class WordleDbContext : DbContext
{
    public DbSet<Word> Words { get; set; }
    public DbSet<SelectedWord> SelectedWords { get; set; }
    public WordleDbContext(DbContextOptions<WordleDbContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}