namespace Logger;

public record Employee(FullName fullName, string position) : Person(fullName)
{
    public required string Position { get; init; }

    public override string Name
    {
        // Implicit implementation because Name getter should be publically available via Employee Instance
        get
        {
            return $"{PersonDisplayName}, {Position}";
        }
    }
}