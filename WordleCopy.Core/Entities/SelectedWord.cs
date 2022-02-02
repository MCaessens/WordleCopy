using WordleCopy.Core.Interfaces;

namespace WordleCopy.Core.Entities;

public class SelectedWord : IEntity
{
    public Guid Id { get; set; }
    public Word Word { get; set; }
    public Guid WordId { get; set; }
    public DateTime? SelectionDate { get; set; }

    public SelectedWord(Guid id, Word word, Guid wordId, DateTime? selectionDate)
    {
        Id = id;
        Word = word;
        WordId = wordId;
        SelectionDate = selectionDate;
    }

    public SelectedWord()
    {
    }
}