namespace Logger;

public record Book(string title, Person author) : Entity
{
    public required string Title { get; init; }
    public required Person Author { get; init; }

    public override string Name
    {
        // Implicit implementation because Name getter should be publically available via Book Instance
        get
        {
            return $"{Title} by {Author.Name}";
        }
    }
}