using Bogus;

namespace AI_TestDataGenerator.Builders;

public static class TitlesFakerBuilder
{
    private static string[] AgeCertifications = { "G", "PG", "PG-13", "R", "NC-17", "U", "U/A", "A", "S", "AL", "6", "9", "12", "12A", "15", "18", "18R", "R18", "R21", "M", "MA15+", "R16", "R18+", "X18", "T", "E", "E10+", "EC", "C", "CA", "GP", "M/PG", "TV-Y", "TV-Y7", "TV-G", "TV-PG", "TV-14", "TV-MA" };
    
    public static Faker<Title> Build() =>
        new Faker<Title>()
            .RuleFor(t => t.Id, f => f.UniqueIndex + 1)
            .RuleFor(t => t.Name, f => f.Lorem.Word())
            .RuleFor(t => t.Description, f => f.Lorem.Sentence())
            .RuleFor(t => t.ReleaseYear, f => f.Random.Int(1900, DateTime.Now.Year))
            .RuleFor(t => t.AgeCertification, f => f.PickRandom(AgeCertifications))
            .RuleFor(t => t.Runtime, f => f.Random.Int(30, 240))
            .RuleFor(t => t.Genres, f => string.Join(", ", f.Lorem.Words(f.Random.Int(1, 5))))
            .RuleFor(t => t.ProductionCountry, f => f.Address.CountryCode())
            .RuleFor(t => t.Seasons, f => f.Random.Int(1, 20));
}