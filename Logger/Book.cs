namespace Logger;

public record Book : Entity
{
    public required string Title { get; init; }

    public override string Name
    {
        // Implicit implementation because Name getter should be publically available via Book Instance
        get
        {
            return $"{Title}";
        }
    }

    public virtual bool Equals(Book? obj)
    {
        if (obj is not Book otherBook)
        {
            return false;
        }

        return this.Title == otherBook.Title;
    }

    public override int GetHashCode()
    {
        return Title.GetHashCode();
    }
}