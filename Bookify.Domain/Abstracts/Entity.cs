﻿namespace Bookify.Domain.Abstracts;

public abstract class Entity
{
    private readonly List<IDomainEvent> _domainEvents = new();
    protected Entity(Guid id)
    {
        Id = id;
    }
    public Guid Id { get; init; }

    public IReadOnlyList<IDomainEvent> GetDomainEvents => _domainEvents.ToList();
    public void ClearDomainEvents() => _domainEvents.Clear();
    protected void RaiseDomainEvent(IDomainEvent domainEvent) => _domainEvents.Add(domainEvent);
}
