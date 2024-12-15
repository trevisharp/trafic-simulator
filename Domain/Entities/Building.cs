using System;

namespace Domain.Entities;

public class Building
{
    public Guid Id { get; init; } = Guid.NewGuid();
}