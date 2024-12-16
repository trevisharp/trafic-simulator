using System;
using System.Drawing;
using System.Collections.Generic;

namespace Domain.Entities;

public class Building
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public ICollection<Person> Residents { get; init; } = [];
    public required Point Position { get; init; }
}