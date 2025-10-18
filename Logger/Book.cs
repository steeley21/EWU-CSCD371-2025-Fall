namespace Logger;

public class Book : Entity
{
    public string Title { get; init; }
    public Person Author { get; init; } //change type to person.

    public override string Name
    {
        get
        {
            return $"{Title} by {Author.Name}";
        }
    }

    public Book(string title, Person author)
    {
        Title = title;
        Author = author;
    }
}