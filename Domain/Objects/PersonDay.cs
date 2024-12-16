using System.Drawing;

namespace Domain.Objects;

using Entities;

public class PersonDay
{
    public required Person Person { get; init; }
    public required LocomotionMethod Locomotion { get; init; }
    
    public required Point Position { get; set; }
}