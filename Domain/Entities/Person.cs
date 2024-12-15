using System;

namespace Domain.Entities;

public class Person
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public required int BornYear { get; init; }
    public int? DeathYear { get; set; } = null;
    public required Building Home { get; init; }
}