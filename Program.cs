Console.WriteLine("""
 _   _      _ _                             _     _ _
| | | | ___| | | ___    __      _____  _ __| | __| | |
| |_| |/ _ \ | |/ _ \   \ \ /\ / / _ \| '__| |/ _` | |
|  _  |  __/ | | (_) |   \ V  V / (_) | |  | | (_| |_|
|_| |_|\___|_|_|\___( )   \_/\_/ \___/|_|  |_|\__,_(_)
""");

Toon[] toons = {
    new() {
        ID = 1,
        First = "Barney",
        Last = "Rubble",
        Gender = Gender.Male,
        Occupation = "Mining Assistant"
    },
    new() {
        ID = 2,
        First = "Betty",
        Last = "Rubble",
        Gender = Gender.Female,
        Occupation = "Nurse" },
    new() {
        ID = 3,
        First = "Fred",
        Last = "Flintstone",
        Gender = Gender.Male,
        Occupation = "Mining Manager" },
    new() {
        ID = 4,
        First = "Wilma",
        Last = "Flintstone",
        Gender = Gender.Female,
        Occupation = "Teacher" },
    new() {
        ID = 5,
        First = "Pebbles",
        Last = "Flintstone",
        Gender = Gender.Female,
        Occupation = "Toddler" },
};

Console.WriteLine("\nSort toons by:");
Console.WriteLine("1. ID");
Console.WriteLine("2. First name");
Console.WriteLine("3. Last name");
Console.WriteLine("4. Gender");
Console.WriteLine("5. Occupation");

var sortBy = ReadSortOption();
var sortedToons = sortBy switch
{
    "1" => toons.OrderBy(toon => toon.ID),
    "2" => toons.OrderBy(toon => toon.First).ThenBy(toon => toon.ID),
    "3" => toons.OrderBy(toon => toon.Last).ThenBy(toon => toon.ID),
    "4" => toons.OrderBy(toon => toon.Gender).ThenBy(toon => toon.ID),
    "5" => toons.OrderBy(toon => toon.Occupation).ThenBy(toon => toon.ID),
    _ => toons.OrderBy(toon => toon.ID)
};

foreach (var item in sortedToons)
{
    Console.Write($"ID: {item.ID}, ");
    Console.Write($"First: {item.First}, ");
    Console.Write($"Last: {item.Last}, ");
    Console.Write($"Gender: {item.Gender}, ");
    Console.WriteLine($"Occupation: {item.Occupation}");
}

static string ReadSortOption()
{
    while (true)
    {
        Console.Write("Choose an option (1-5): ");
        var option = Console.ReadLine()?.Trim();
        if (option is "1" or "2" or "3" or "4" or "5")
        {
            return option;
        }

        Console.WriteLine("Please choose an option from 1 to 5.");
    }
}

/// <summary>
/// Represents a character in the sample toon collection.
/// </summary>
public class Toon
{
    /// <summary>
    /// Gets the unique identifier for the toon.
    /// </summary>
    public int ID { get; init; }

    /// <summary>
    /// Gets the toon&apos;s first name.
    /// </summary>
    public required string First { get; init; }

    /// <summary>
    /// Gets the toon&apos;s last name.
    /// </summary>
    public required string Last { get; init; }

    /// <summary>
    /// Gets the toon&apos;s gender classification.
    /// </summary>
    public required Gender Gender { get; init; }

    /// <summary>
    /// Gets the toon&apos;s occupation.
    /// </summary>
    public required string Occupation { get; init; }
}

/// <summary>
/// Defines the gender classifications used by the sample data.
/// </summary>
public enum Gender
{
    /// <summary>
    /// Identifies a male toon.
    /// </summary>
    Male,

    /// <summary>
    /// Identifies a female toon.
    /// </summary>
    Female
}
