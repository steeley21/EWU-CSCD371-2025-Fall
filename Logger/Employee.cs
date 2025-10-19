namespace Logger;

public record Employee : Person
{
    public required string Position { get; set; }

    public Employee(FullName fullName, string position) : base(fullName)
    {
        Position = position;
    }

    public override string Name
    {
        // Implicit implementation because Name getter should be publically available via Employee Instance
        get
        {
            return $"{PersonDisplayName}, {Position}";
        }
    }

    public virtual bool Equals(Employee? obj)
    {
        if (obj is not Employee otherEmployee)
        {
            return false;
        }

        return this.Position == otherEmployee.Position && this.FullName.Equals(otherEmployee.FullName);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(FullName, Position);
    }
}