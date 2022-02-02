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
        var words = new Word[]
        {
            new Word
            {
                Id = Guid.NewGuid(),
                Name = "Torso",
            },
            new Word
            {
                Id = Guid.NewGuid(),
                Name = "Whizz",
            },
            new Word
            {
                Id = Guid.NewGuid(),
                Name = "Muzzy",
            },
            new Word
            {
                Id = Guid.NewGuid(),
                Name = "Frizz",
            },
            new Word
            {
                Id = Guid.NewGuid(),
                Name = "Bizzy",
            },
            new Word
            {
                Id = Guid.NewGuid(),
                Name = "Jumbo",
            },
            new Word
            {
                Id = Guid.NewGuid(),
                Name = "Jumps",
            }
        };
        modelBuilder.Entity<Word>().HasData(words);
    }
}