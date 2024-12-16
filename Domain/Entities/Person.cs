using System;

namespace Domain.Entities;

using Objects;

public class Person
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public required int BornYear { get; init; }
    public int? DeathYear { get; set; } = null;
    public required Building Home { get; init; }
    public required Building Work { get; init; }
    public required float SocialIndex { get; set; }
    public bool HasCar { get; set; } = false;
    public bool HasMotorcycle { get; set; } = false;
    public bool HasBicycle { get; set; } = false;

    public PersonDay StartDay()
    {
        var locomotion = LocomotionMethod.Unknown;

        return new PersonDay {
            Person = this,
            Locomotion = locomotion,
            Position = Home.Position
        };
    }
}