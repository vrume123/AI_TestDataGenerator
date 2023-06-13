using Bogus;

namespace AI_TestDataGenerator.Builders;

public static class CreditsFakerBuilder
{
    private static string[] Roles = { "Director", "Producer", "Screenwriter", "Actor", "Actress", "Cinematographer", "Film Editor", "Production Designer", "Costume Designer", "Music Composer" };
    
    public static Faker<Credit> Build() =>
        new Faker<Credit>()
            .RuleFor(c => c.Id, f => f.UniqueIndex + 1)
            .RuleFor(c => c.TitleId, f => f.Random.Int(1, 200)) // assuming that the IDs of titles start at 0 and go up to 99
            .RuleFor(c => c.RealName, f => f.Name.FullName())
            .RuleFor(c => c.CharacterName, f => f.Name.FullName())
            .RuleFor(c => c.Role, f => f.PickRandom(Roles));
}