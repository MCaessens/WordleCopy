using WordleCopy.Core.Interfaces;

namespace WordleCopy.Core.Entities;

public class Word : IEntity
{

    public Guid Id { get; set; }
    public string Name { get; set; } = "";
    public Word(string name)
    {
        Name = name;
    }
    public Word () { }
    
}