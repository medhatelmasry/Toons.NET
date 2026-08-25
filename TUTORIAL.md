# Coding with AI Agent Skills in VS Code
Agent skills are folders of instructions, scripts, and resources that GitHub Copilot can load when relevant to perform specialized tasks.

These skills are an open standard that work across multiple Al agents, including GitHub Copilot and VS Code, Copilot CLI, and Copilot Cloud Agent.

In this tutorail we will develop a very simple C# console application which will be used to reinforce some of the concepts pertaining to coding with AI in VS Code. 

Create a new console app and open it code in VS Code with the following terminal window commands:

```bash
dotnet new console -o Toons.Net
cd Toons.Net
code .
```

Replace contents of `Program.cs` with:

```C#
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

foreach (var item in toons) {
    Console.Write($"ID: {item.ID}, ");
    Console.Write($"First: {item.First}, ");
    Console.Write($"Last: {item.Last}, ");
    Console.Write($"Gender: {item.Gender}, ");
    Console.WriteLine($"Occupation: {item.Occupation}");
}

public class Toon {
    public int ID { get; set; }
    public string? First { get; set; }
    public string? Last { get; set; }
    public Gender Gender { get; set; }
    public string? Occupation { get; set; }
}

public enum Gender {
    Male,
    Female
}
```

In a `./github` folder, add a file named `copilot-instructions.md` with this text:

```md
# Please call me Sensei and speak with the calm discipline of a samurai.

## Naming Conventions
- Use PascalCase for component names, interfaces, and type aliases
- Use camelCase for variables, functions, and methods
- Prefix private class members with underscore (_)
- Use ALL_CAPS for constants

# Project-specific guidelines
- Use async/await for asynchronous operations
- When creating sample Toon data, ensure names are diverse and culturally inclusive
- When creating sample Toon data, use Occupations that represent a wide range of disciplines and regions
```

Note this interaction when you prompt the AI chat with “Hello”:

![Sensei](images/sensei.png)

You should put your team coding standards in the copilot-instructions.md file. You may also wish to put this file at a workspace level, rather than a project level.

In folder `./github/skills/hello-world`, add a file named `SKILL.md` with this text:

```md
---
name: hello-world
description: "Use when: you want a simple Hello World response in ASCII text."
---
# Hello World

When invoked, output exactly this line:

 _   _      _ _                             _     _ _
| | | | ___| | | ___    __      _____  _ __| | __| | |
| |_| |/ _ \ | |/ _ \   \ \ /\ / / _ \| '__| |/ _` | |
|  _  |  __/ | | (_) |   \ V  V / (_) | |  | | (_| |_|
|_| |_|\___|_|_|\___( )   \_/\_/ \___/|_|  |_|\__,_(_)
```

> [!NOTE]
> The `name` of the skill must exactly match the folder name.

> [!NOTE]
> It is mandatory to provide `name` and `description`.

