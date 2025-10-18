namespace Logger;

public abstract record Entity : IEntity
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public abstract string Name { get; }

}