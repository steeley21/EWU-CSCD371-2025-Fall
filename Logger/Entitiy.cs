namespace Logger;

public abstract class Entitiy : IEntity
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public required string Name { get; init; }

}