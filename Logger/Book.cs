namespace Logger;

public record Book(string title, Person author) : Entity
{
    public required string Title { get; init; }
    public required Person Author { get; init; }

    public override string Name
    {
        get
        {
            return $"{Title} by {Author.Name}";
        }
    }
}