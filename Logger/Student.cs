namespace Logger;

public record Student(FullName fullName, string studenId) : Person(fullName)
{
    public required string StudentId { get; init; }
    public override string Name
    {
        // Implicit implementation because Name getter should be publically available via Student Instance
        get
        {
            return $"{PersonDisplayName} (ID: {StudentId})";
        }
    }
}